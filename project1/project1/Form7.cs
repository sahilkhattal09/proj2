using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace project1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)) && (comboBox1.SelectedText == null) && (comboBox2.SelectedText == null) && (comboBox1.SelectedText == comboBox2.SelectedText))
            {

                if (!(Regex.IsMatch(textBox3.Text, @"^\d{4}-\d{2}-\d{2}$")))
                {

                }
                else
                {
                    MessageBox.Show("Enter valid data formet");
                }
                
            }
            else
            {
                MessageBox.Show("Enter all the necessary details");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
