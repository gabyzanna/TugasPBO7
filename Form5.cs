using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGASPBO7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
             label6.Text = Class2.uname1;
            int a = 250, b = 10 , z = 10;
            label7.Text = Convert.ToString(a+b);
            label5.Text = Convert.ToString(z);
        }
    }
}
