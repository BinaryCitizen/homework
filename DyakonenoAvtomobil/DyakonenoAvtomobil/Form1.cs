using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyakonenoAvtomobil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.ImageLocation = "https://www.avtovzglyad.ru/media/cache/carsmodel/Audi-A4/d8c499efb51947d164f5f77dc3b830c4.jpg";
                label1.Text = "Audi A4";
                label2.Text = "Цена: 2,97 миллиона ₽";
            }

            if (radioButton2.Checked)
            {
                pictureBox1.ImageLocation = "https://www.avtovzglyad.ru/media/cache/carsmodel/bmw-g01-x3-bilder-1920x1200-7/5204dc99d98cc2df2e85a949922524ab.jpg";
                label1.Text = "BMW X3";
                label2.Text = "Цена: 4,52 миллиона ₽";
            }

            if (radioButton3.Checked)
            {
                pictureBox1.ImageLocation = "https://www.avtovzglyad.ru/media/cache/carsmodel/parallax3/e20c2d35d0b0f319b7edc8ad90f2362c.jpg";
                label1.Text = "Hyundai Tucson";
                label2.Text = "Цена: 1,954 миллиона ₽";
            }

        }
    }
}
