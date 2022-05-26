using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project1
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\airline.mdf;Integrated Security=True;Connect Timeout=30");
       
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(textBox1.Text))&&(!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox3.Text)))
            {
                if(textBox2.Text==textBox3.Text)
                {
                    if(textBox2.TextLength <4)
                    {
                        MessageBox.Show("password cannot be less than 4 characters");
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into register(username, password) values ('"+ textBox1.Text+"','"+textBox2.Text+"')";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("data added succesfully");

                        }    
                         catch(Exception ex)
                        {
                            MessageBox.Show("error");
                        }

                    }
                }

            }
            else
            {
                
                MessageBox.Show("enter all the necessary details");
            }
        }
    }
}
