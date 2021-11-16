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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int sum;
        int srok;
        int procent;
        int itog;

        private void button1_Click(object sender, EventArgs e)
        {
            sum = Convert.ToInt32(textBox1.Text);
            srok = Convert.ToInt32(textBox2.Text);
            procent = Convert.ToInt32(textBox3.Text);
            itog = sum + sum * procent * (srok/12 + 1) / 100;
            textBox4.Text = itog.ToString();
        }
    }
}
