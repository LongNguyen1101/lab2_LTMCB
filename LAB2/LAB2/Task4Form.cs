using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Task4Form : Form
    {
        string[] students;
        public Task4Form()
        {
            InitializeComponent();
            rtxtShow.ReadOnly = true;
            txtNameShow.ReadOnly = txtIDShow.ReadOnly = 
            txtPhoneShow.ReadOnly = txtCourse1Show.ReadOnly = 
            txtCourse2Show.ReadOnly = txtCourse3Show.ReadOnly = 
            txtAverage.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtCourse1.Text) || string.IsNullOrEmpty(txtCourse2.Text) || string.IsNullOrEmpty(txtCourse3.Text))
            {
                MessageBox.Show("Please fill all the text box!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ID;
            if (txtID.Text.Length != 8 || !int.TryParse(txtID.Text, out ID))
            {
                MessageBox.Show("ID wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPhone.Text.Length != 10 || txtPhone.Text[0] != '0' || !int.TryParse(txtPhone.Text, out int phonrCheck))
            { 
                MessageBox.Show("Phone number wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float course1, course2, course3;
            if (!float.TryParse(txtCourse1.Text, out course1))
            {
                MessageBox.Show("Course 1 score wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(txtCourse2.Text, out course2))
            {
                MessageBox.Show("Course 2 score wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(txtCourse3.Text, out course3))
            {
                MessageBox.Show("Course 3 score wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (course1 < 0 || course1 > 10)
            {
                MessageBox.Show("Course 1 score is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (course2 < 0 || course2 > 10)
            {
                MessageBox.Show("Course 2 score is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (course3 < 0 || course3 > 10)
            {
                MessageBox.Show("Course 3 score is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            appendText(txtName.Text, txtID.Text, txtPhone.Text, txtCourse1.Text, txtCourse2.Text, txtCourse3.Text);

            txtName.Clear();
            txtID.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();
        }

        private void appendText(string name, string ID, string phone, string course1, string course2, string course3)
        {
            rtxtShow.Text += (name + Environment.NewLine);
            rtxtShow.Text += (ID + Environment.NewLine);
            rtxtShow.Text += (phone + Environment.NewLine);
            rtxtShow.Text += (course1 + Environment.NewLine);
            rtxtShow.Text += (course2 + Environment.NewLine);
            rtxtShow.Text += (course3 + Environment.NewLine);
            rtxtShow.Text += Environment.NewLine;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtShow.Text))
            {
                MessageBox.Show("Please add some student!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] studentsWrite = rtxtShow.Text.Split('\n');

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName)) return;
            FileStream fileName = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fileName, studentsWrite);

            fileName.Close();
            rtxtShow.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName)) return;

            FileStream fileName = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
           
            try
            {
                string[] contents = (string[])bf.Deserialize(fileName);
                fileName.Close();

                rtxtShow.Clear();
                foreach (string s in contents)
                    rtxtShow.Text += s + Environment.NewLine;

                students = rtxtShow.Text.Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.None);

                printInfo(students[0]);
            }
            catch
            {
                MessageBox.Show("Error to read file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtShow.Text))
            {
                MessageBox.Show("Please read a file contains students!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pageNumber = int.Parse(lbPageNumber.Text);
            pageNumber++;

            if (pageNumber - 1 == students.Length) return;
            if (string.IsNullOrEmpty(students[pageNumber - 1]) || students[pageNumber - 1] == "\n") return;
            printInfo(students[pageNumber - 1]);

            lbPageNumber.Text = pageNumber.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtShow.Text))
            {
                MessageBox.Show("Please read a file contains students!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pageNumber = int.Parse(lbPageNumber.Text);
            pageNumber--;

            if (pageNumber == 0) return;

            printInfo(students[pageNumber - 1]);
            lbPageNumber.Text = pageNumber.ToString();
        }

        private void printInfo(string student)
        {
            string[] info = student.Split('\n');
            txtNameShow.Text = info[0];
            txtIDShow.Text = info[1];
            txtPhoneShow.Text = info[2];
            txtCourse1Show.Text = info[3];
            txtCourse2Show.Text = info[4];
            txtCourse3Show.Text = info[5];
            txtAverage.Text = calculateAverage(double.Parse(info[3]), double.Parse(info[4]), double.Parse(info[5])).ToString();
        }
        
        private double calculateAverage(double course1, double course2, double course3)
        {
            return (course1 + course2 + course3) / 3.0;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtCourse1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtCourse2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtCourse3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
