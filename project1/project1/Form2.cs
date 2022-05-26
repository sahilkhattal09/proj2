using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
            if (progressBar1.Value == 100)
                MessageBox.Show("System loaded succesfully");
            Form1 x = new Form1();
            x.Show();



        }
    }
}
