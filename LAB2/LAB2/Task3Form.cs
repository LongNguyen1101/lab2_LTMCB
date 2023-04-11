using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Task3Form : Form
    {
        public Task3Form()
        {
            InitializeComponent();
            rtxtShow.ReadOnly = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
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
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtShow.Text))
            {
                MessageBox.Show("Please read a file before writing it!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName)) return;
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                sw.Write(rtxtShow.Text);
            }
            catch
            {
                MessageBox.Show("Failed to write to a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sw.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtShow.Text))
            {
                MessageBox.Show("Please read a file before calculating it!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rtxtShow.Text.Contains("="))
            {
                MessageBox.Show("Error: Invalid character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] text = rtxtShow.Text.Split('\n');

            try
            {
                rtxtShow.Clear();
                for (int i = 0; i < text.Length; i++)
                {
                    if (!string.IsNullOrEmpty(text[i]))
                    {
                        text[i] = text[i].Replace(" ", "");
                        rtxtShow.Text += ($"{text[i]} = {getExpressionValue(text[i])}\n");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private int priority(char x)
        {
            if (x == '*' || x == '/') return 2;
            else if (x == '+' || x == '-') return 1;
            else if (x == '(') return 0;
            return -1;
        }

        List<string> changToPostFix (string s)
        {
            Stack<char> st = new Stack<char>();
            List<string> postFix = new List<string> ();

            int i = 0, n = s.Length;
            while (i < n)
            {
                if (s[i] == ' ') { i++; }
                else if (s[i] == '(')
                {
                    st.Push(s[i]);
                    i++;
                }
                else if (s[i] == ')')
                {
                    while (st.Peek() != '(')
                    {
                        postFix.Add(st.Peek().ToString());
                        st.Pop();
                    }
                    st.Pop();
                    i++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    string number = string.Empty;
                    while (i < n && s[i] >= '0' && s[i] <= '9')
                    {
                        number += s[i];
                        i++;
                    }
                    postFix.Add(number);
                }
                else if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
                {
                    while (st.Count != 0 && priority(st.Peek()) >= priority(s[i]))
                    {
                        postFix.Add(st.Peek().ToString());
                        st.Pop();
                    }
                    st.Push(s[i]);
                    i++;
                }
                else
                {
                    MessageBox.Show("Error: Invalid character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            while (st.Count != 0)
            {
                postFix.Add(st.Peek().ToString());
                st.Pop();
            }

            return postFix;
        }

        double getExpressionValue(string s)
        {
            List<string> postFix = changToPostFix(s);
            Stack<double> st = new Stack<double>();

            foreach (string e in postFix)
            {
                if (e == "+" || e == "-" || e == "*" || e == "/")
                {
                    double value1 = st.Peek();
                    st.Pop();
                    double value2 = st.Peek();
                    st.Pop();

                    if (e == "+") st.Push(value2 + value1);
                    else if (e == "-") st.Push(value2 - value1);
                    else if (e == "*") st.Push(value2 * value1);
                    else if (e == "/") st.Push(value2 / value1);
                    else
                    {
                        MessageBox.Show("Error: Invalid operator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                else
                {
                    st.Push(double.Parse(e));
                }
            }

            return st.Peek();
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
