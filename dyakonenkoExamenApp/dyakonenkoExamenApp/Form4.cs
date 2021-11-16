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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        double km;
        double sum;
        int with = 350;

        private void button1_Click(object sender, EventArgs e)
        {
            km = Convert.ToDouble(textBox1.Text);

            if (radioButton1.Checked)
            {
                sum = km * 1000 + with;
            }
            else
            {
                sum = km * 1000;
            }

            textBox2.Text = Convert.ToString(sum);
        }
    }
}
