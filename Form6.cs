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
    public partial class Form6 : Form
    {
        string konek = "Server=localhost;Uid=root;database=dataorg";
        public Form6()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
           MySqlConnection con = new MySqlConnection(konek);
            string query = "insert into org (nama,telp,username,pass,email,address,imagez)VALUES(@nama,@telp,@username,@pass,@email,@address,@imagez)";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@nama",MySqlDbType.VarChar,100);
            cmd.Parameters.Add("@telp", MySqlDbType.VarChar, 13);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 258);
            cmd.Parameters.Add("@address", MySqlDbType.VarChar, 258);
            cmd.Parameters.Add("@imagez", MySqlDbType.Blob);

            cmd.Parameters["@nama"].Value = namabox.Text;
            cmd.Parameters["@telp"].Value = telpbox.Text;
            cmd.Parameters["@username"].Value = userbox.Text;
            cmd.Parameters["@pass"].Value = passbox.Text;
            cmd.Parameters["@email"].Value = ebox.Text;
            cmd.Parameters["@address"].Value = addbox.Text;
            cmd.Parameters["@imagez"].Value = img;
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("berhasil@");
            }
            con.Clone();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose img (*jpg;.png;.gif)|*jpg;.png;.gif";
            if(opf.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(opf.FileName);
            }
        }

        private void addbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telpbox_TextChanged(object sender, EventArgs e)
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

        private void label29_Click(object sender, EventArgs e)
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

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
