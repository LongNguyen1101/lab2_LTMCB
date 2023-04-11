using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName)) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                rtxtShow.Text = sr.ReadToEnd();
            }
            catch 
            {
                MessageBox.Show("Failed to read a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fs.Close();

            MessageBox.Show("Read Succesfully!", "Successful", MessageBoxButtons.OK);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtShow.Text))
            {
                MessageBox.Show("Please read a file or write some text before writing it!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt";
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName)) return;
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                sw.Write(rtxtShow.Text.ToUpper());
            }
            catch
            {
                MessageBox.Show("Failed to write to a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sw.Close();

            MessageBox.Show("Write Succesfully!", "Successful", MessageBoxButtons.OK);
        }

        private void btnClear_Click(object sender, EventArgs e) { rtxtShow.Clear(); }

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
