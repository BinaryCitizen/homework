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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean c1 = false;
        Boolean c2 = false;

        Form f2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "31-КС")
            {
                textBox3.Text = "Компьютерные сети.";
                textBox1.Text = "3 - eго";
                c1 = true;
                c2 = false;
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "21-КС")
                {
                    textBox3.Text = "Компьютерные сети 2.0.";
                    textBox1.Text = "2 - ого";
                    c2 = true;
                    c1 = false;
                }
            }

            if (c1 = true)
            {
                this.Hide();
                f2.Show();
            } 
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
