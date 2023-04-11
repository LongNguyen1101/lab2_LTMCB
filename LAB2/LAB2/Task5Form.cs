using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB2
{
    public partial class Task5Form : Form
    {
        public Task5Form()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName)) return;

            FileInfo file = new FileInfo(ofd.FileName);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.gz)|*.gz";
            sfd.ShowDialog();
            if (string.IsNullOrEmpty(sfd.FileName)) return;

            try
            {
                using (FileStream sourceStream = File.Open(ofd.FileName, FileMode.Open))
                using (FileStream compressStream = File.Create(sfd.FileName))
                {
                    using (GZipStream gzipStream = new GZipStream(compressStream, CompressionMode.Compress))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        long totalBytesRead = 0;
                        long fileSize = sourceStream.Length;
                        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            gzipStream.Write(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;
                            int progressPercentage = (int)((double)totalBytesRead / fileSize * 100);
                            progressBar.Value = progressPercentage;
                        }
                        gzipStream.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to compress file {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Compress successfully!", "Success", MessageBoxButtons.OK);
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName)) return;

            FileInfo file = new FileInfo(ofd.FileName);

            if (!isGzFile(file))
            {
                MessageBox.Show("Please select a .gz file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            if (string.IsNullOrEmpty(sfd.FileName)) return;

            try
            {
                using (FileStream compressStream = File.Open(ofd.FileName, FileMode.Open))
                using (FileStream decompressStream = File.Create(sfd.FileName))
                {
                    using (GZipStream gzipStream = new GZipStream(compressStream, CompressionMode.Decompress))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        long totalBytesRead = 0;
                        long fileSize = compressStream.Length;
                        while ((bytesRead = gzipStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            decompressStream.Write(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;
                            int progressPercentage = (int)((double)totalBytesRead / fileSize * 100);
                            if (progressPercentage <= 100)
                            {
                                progressBar.Value = progressPercentage;
                            }
                            else
                            {
                                progressBar.Value = 100;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to decompress file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Decompress successfully!", "Success", MessageBoxButtons.OK);
        }

        private bool isGzFile(FileInfo file)
        {
            return file.Extension == ".gz";
        }
    }
}
