using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dyakonenkoExamenApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int kol;
        int sum;

        private void button1_Click(object sender, EventArgs e)
        {
            kol = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked)
            {
                sum = kol * 50;
                textBox2.Text = Convert.ToString(sum);
            }
            else if (radioButton2.Checked)
            {
                sum = kol * 100;
                textBox2.Text = Convert.ToString(sum);
            }
            else if (radioButton3.Checked)
            {
                sum = kol * 150;
                textBox2.Text = Convert.ToString(sum);
            }
        }
    }
}
