using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyakonenkoBMRcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool man;
        bool woman;

        double rost;
        double ves;
        double age;
        double result;
        private void button1_Click(object sender, EventArgs e)
        {
            rost = Convert.ToDouble(textBox1.Text);
            ves = Convert.ToDouble(textBox2.Text);
            age = Convert.ToDouble(textBox3.Text);

            if (man)
            {
                result = 10 * ves + 6.25 * rost - 5 * age + 5;
                result = result / 1000;
            }
            if (woman)
            {
                result = 10 * ves + 6.25 * rost - 5 * age - 161;
                result = result / 1000;
            }
            BMR.Text = (result).ToString("##.###");
            none.Text = (result * 1.2).ToString("##.###");
            low.Text = (result * 1.375).ToString("##.###"); 
            medium.Text = (result * 1.55).ToString("##.###"); 
            big.Text = (result * 1.725).ToString("##.###"); 
            massive.Text = (result * 1.9).ToString("##.###"); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            man = true;
            woman = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            man = false;
            woman = true;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            hint.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            hint.Visible = false;
        }
    }
}
