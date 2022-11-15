using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TUGASPBO7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string bella = "Server=localhost;Uid=root;database=dataorg";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(bella);
            con.ConnectionString = bella;
            try
            {
                con.Open();
                MessageBox.Show("Koneksi Berhasill!");

            }catch(Exception ex)
            {
                MessageBox.Show("gagal bro!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(bella);
            con.ConnectionString=bella;
            string ausername, apassword;
            ausername = textBox1_username.Text;
            apassword = textBox_password.Text;
            try
            {
                string query = "SELECT * FROM org WHERE username = '" + textBox1_username.Text + "'AND pass ='" + textBox_password.Text+"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, bella);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ausername = textBox1_username.Text;
                    apassword = textBox_password.Text;
                    Class1.uname = ausername;
                    Form2 a = new Form2();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error!!", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror ya!!"+ex);
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
