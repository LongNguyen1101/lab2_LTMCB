using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class LAB2Form : Form
    {
        public LAB2Form()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            Task1Form task1Form = new Task1Form();
            task1Form.ShowDialog();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            Task2Form task2Form = new Task2Form();
            task2Form.ShowDialog();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            Task3Form task3Form = new Task3Form();
            task3Form.ShowDialog();
        }
        private void btnTask4_Click(object sender, EventArgs e)
        {
            Task4Form task4Form = new Task4Form();
            task4Form.ShowDialog();
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            Task5Form task5Form = new Task5Form();
            task5Form.ShowDialog();
        }

        private void btnTask6_Click(object sender, EventArgs e)
        {
            Task6Form task6Form = new Task6Form();
            task6Form.ShowDialog();
        }
    }
}
