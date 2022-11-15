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
using MySql.Data.MySqlClient;

namespace TUGASPBO7
{
    public partial class Form3 : Form
    {
        MySqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label37.Text = Class1.uname;

            MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Database=dataorg");
            string cmd = "SELECT nama,telp,pass,email,address,imagez FROM org WHERE username = '" + label37.Text + "'";
            MySqlCommand cmd2 = new MySqlCommand(cmd, conn);
            conn.Open();
            using (MySqlDataReader reader = cmd2.ExecuteReader())
            {
                reader.Read();
                if (reader.HasRows)
                {
                    label35.Text = reader[0].ToString();
                    label36.Text = reader[1].ToString();
                    label38.Text = reader[2].ToString();
                    label39.Text = reader[3].ToString();
                    label40.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[5]);
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("eror bang!");
                }
            }
        }
            private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
