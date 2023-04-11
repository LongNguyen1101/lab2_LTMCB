using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();

            rtxtShow.ReadOnly = true;
            txtFileName.ReadOnly = true;
            txtSize.ReadOnly = true;
            txtURL.ReadOnly = true;
            txtLineCount.ReadOnly = true;
            txtWordsCount.ReadOnly = true;
            txtCharacterCount.ReadOnly = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName)) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            char[] characters;

            try
            {
                rtxtShow.Text = sr.ReadToEnd();
                characters = rtxtShow.Text.ToCharArray();
            }
            catch
            {
                MessageBox.Show("Failed to read a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            int lineCount = 0, wordCount = 0, characterCount = characters.Length;
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
                lineCount++;
            }

            show(ofd.SafeFileName, fs.Length.ToString(), fs.Name.ToString(), lineCount.ToString(), wordCount.ToString(), characterCount.ToString());

            fs.Close();
        }

        private void show(string FileName, string size, string URL, string lineCount, string wordCount, string characterCount) 
        {
            txtFileName.Text = FileName;
            txtSize.Text = size + " bytes";
            txtURL.Text = URL;
            txtLineCount.Text = lineCount;
            txtWordsCount.Text = wordCount;
            txtCharacterCount.Text = characterCount;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
