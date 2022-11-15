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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
            string yyy;
            yyy = button1.Text;
            Class2.uname1 = yyy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
       
           string yyy;
            yyy = button1.Text;
            Class2.uname1 = yyy;

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
            this.Hide();
            string yyy;
            yyy = button3.Text;
            Class3.uname2 = yyy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.Show();
            this.Hide();
            string yyy;
            yyy = button4.Text;
            Class4.uname3 = yyy;
        }
    }
}
