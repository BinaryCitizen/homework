using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyakonenkoMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start1_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Start 1";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = true;
            label1.Visible = true;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = false;
            label5.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 1";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = true;
            label1.Visible = true;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = false;
            label3.Visible = false;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 2";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = false;
            label1.Visible = false;
            pictureBox15.Visible = false;
            label2.Visible = false;
            pictureBox16.Visible = false;
            label3.Visible = false;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 3";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = false;
            label1.Visible = false;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = false;
            label3.Visible = false;
            pictureBox17.Visible = true;
            label4.Visible = true;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 4";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = false;
            label1.Visible = false;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 5";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = true;
            label1.Visible = true;
            pictureBox15.Visible = false;
            label2.Visible = false;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 6";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = false;
            label1.Visible = false;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = true;
            label4.Visible = true;
            pictureBox18.Visible = false;
            label5.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 7";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = true;
            label1.Visible = true;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Checkpoint 8";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = false;
            label1.Visible = false;
            pictureBox15.Visible = false;
            label2.Visible = false;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void s1_x_Click(object sender, EventArgs e)
        {
            s1_1.Visible = false;
            s1_2.Visible = false;
            s1_x.Visible = false;
            s1_p.Visible = false;
            pictureBox14.Visible = false;
            label1.Visible = false;
            pictureBox15.Visible = false;
            label2.Visible = false;
            pictureBox16.Visible = false;
            label3.Visible = false;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = false;
            label5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Start 2";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = true;
            label1.Visible = true;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = false;
            label4.Visible = false;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            s1_1.Visible = true;
            s1_1.Text = "Start 3";
            s1_2.Visible = true;
            s1_x.Visible = true;
            s1_p.Visible = true;
            pictureBox14.Visible = true;
            label1.Visible = true;
            pictureBox15.Visible = true;
            label2.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;
            pictureBox17.Visible = true;
            label4.Visible = true;
            pictureBox18.Visible = true;
            label5.Visible = true;
        }
    }
}
