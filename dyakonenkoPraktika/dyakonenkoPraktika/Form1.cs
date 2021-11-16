using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dyakonenkoPraktika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p1 = textBox1.Text;
            String p2 = textBox2.Text;
            String p3 = textBox3.Text;
            String p4 = textBox4.Text;
            String p5 = textBox5.Text;
            String p6 = textBox6.Text;
            String p7 = textBox7.Text;
            String p8 = textBox8.Text;
            String p9 = textBox9.Text;
            Form2 f2 = new Form2(p1, p2, p3, p4, p5, p6, p7, p8, p9);

            f2.Show();
        }
    }
}
