using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyakonenkoValuta
{
    public partial class Form1 : Form
    {
        //selected fromX button
        bool selected1_rub;
        bool selected1_usd;
        bool selected1_eur;
        bool selected1_gbp;
        //selected toX button
        bool selected2_rub;
        bool selected2_usd;
        bool selected2_eur;
        bool selected2_gbp;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x1;
            double y1;

            x1 = Convert.ToInt32(textBox1.Text);

            if (selected1_rub)
            {
                if (selected2_rub)
                {
                    y1 = x1;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_usd)
                {
                    y1 = x1 / 74;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_eur)
                {
                    y1 = x1 / 83;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_gbp)
                {
                    y1 = x1 / 99;
                    textBox2.Text = y1.ToString();
                }
            }
            if (selected1_eur)
            {
                if (selected2_rub)
                {
                    y1 = x1 / 0.012;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_eur)
                {
                    y1 = x1;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_usd)
                {
                    y1 = x1 / 0.89;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_gbp)
                {
                    y1 = x1 / 1.19;
                    textBox2.Text = y1.ToString();
                }
            }
            if (selected1_usd)
            {
                if (selected2_rub)
                {
                    y1 = x1 / 0.013;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_eur)
                {
                    y1 = x1 / 1.13;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_usd)
                {
                    y1 = x1;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_gbp)
                {
                    y1 = x1 / 1.34;
                    textBox2.Text = y1.ToString();
                }
            }
            if (selected1_gbp)
            {
                if (selected2_rub)
                {
                    y1 = x1 / 0.010;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_eur)
                {
                    y1 = x1 / 0.84;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_usd)
                {
                    y1 = x1 / 0.75;
                    textBox2.Text = y1.ToString();
                }
                if (selected2_gbp)
                {
                    y1 = x1;
                    textBox2.Text = y1.ToString();
                }
            }
        }

        private void fromRUB_MouseEnter(object sender, EventArgs e)
        {
            fromRUB.BackColor = Color.LightGreen;
        }

        private void fromRUB_MouseLeave(object sender, EventArgs e)
        {
            fromRUB.BackColor = Color.White;
            if (selected1_rub)
            {
                fromRUB.BackColor = Color.LightGreen;
            }
        }

        private void fromUSD_MouseEnter(object sender, EventArgs e)
        {
            fromUSD.BackColor = Color.LightGreen;
        }

        private void fromUSD_MouseLeave(object sender, EventArgs e)
        {
            fromUSD.BackColor = Color.White;
            if (selected1_usd)
            {
                fromUSD.BackColor = Color.LightGreen;
            }
        }

        private void fromEUR_MouseEnter(object sender, EventArgs e)
        {
            fromEUR.BackColor = Color.LightGreen;
        }

        private void fromEUR_MouseLeave(object sender, EventArgs e)
        {
            fromEUR.BackColor = Color.White;
            if (selected1_eur)
            {
                fromEUR.BackColor = Color.LightGreen;
            }
        }

        private void fromGBP_MouseEnter(object sender, EventArgs e)
        {
            fromGBP.BackColor = Color.LightGreen;
        }

        private void fromGBP_MouseLeave(object sender, EventArgs e)
        {
            fromGBP.BackColor = Color.White;
            if (selected1_gbp)
            {
                fromGBP.BackColor = Color.LightGreen;
            }
        }

        private void toRUB_MouseEnter(object sender, EventArgs e)
        {
            toRUB.BackColor = Color.LightGreen;
        }

        private void toRUB_MouseLeave(object sender, EventArgs e)
        {
            toRUB.BackColor = Color.White;
            if (selected2_rub)
            {
                toRUB.BackColor = Color.LightGreen;
            }
        }

        private void toUSD_MouseEnter(object sender, EventArgs e)
        {
            toUSD.BackColor = Color.LightGreen;
        }

        private void toUSD_MouseLeave(object sender, EventArgs e)
        {
            toUSD.BackColor = Color.White;
            if (selected2_usd)
            {
                toUSD.BackColor = Color.LightGreen;
            }
        }

        private void toEUR_MouseEnter(object sender, EventArgs e)
        {
            toEUR.BackColor = Color.LightGreen;
        }

        private void toEUR_MouseLeave(object sender, EventArgs e)
        {
            toEUR.BackColor = Color.White;
            if (selected2_eur)
            {
                toEUR.BackColor = Color.LightGreen;
            }
        }

        private void toGBP_MouseEnter(object sender, EventArgs e)
        {
            toGBP.BackColor = Color.LightGreen;
        }

        private void toGBP_MouseLeave(object sender, EventArgs e)
        {
            toGBP.BackColor = Color.White;
            if (selected2_gbp)
            {
                toGBP.BackColor = Color.LightGreen;
            }
        }

        private void fromRUB_MouseClick(object sender, MouseEventArgs e)
        {
            selected1_rub = true;
            selected1_eur = false;
            selected1_gbp = false;
            selected1_usd = false;

            fromEUR.BackColor = Color.White;
            fromGBP.BackColor = Color.White;
            fromUSD.BackColor = Color.White;
        }

        private void fromUSD_Click(object sender, EventArgs e)
        {
            selected1_rub = false;
            selected1_eur = false;
            selected1_gbp = false;
            selected1_usd = true;

            fromEUR.BackColor = Color.White;
            fromGBP.BackColor = Color.White;
            fromRUB.BackColor = Color.White;
        }

        private void fromEUR_Click(object sender, EventArgs e)
        {
            selected1_rub = false;
            selected1_eur = true;
            selected1_gbp = false;
            selected1_usd = false;

            fromRUB.BackColor = Color.White;
            fromGBP.BackColor = Color.White;
            fromUSD.BackColor = Color.White;
        }

        private void fromGBP_Click(object sender, EventArgs e)
        {
            selected1_rub = false;
            selected1_eur = false;
            selected1_gbp = true;
            selected1_usd = false;

            fromEUR.BackColor = Color.White;
            fromRUB.BackColor = Color.White;
            fromUSD.BackColor = Color.White;
        }

        private void toRUB_MouseClick(object sender, MouseEventArgs e)
        {
            selected2_rub = true;
            selected2_eur = false;
            selected2_gbp = false;
            selected2_usd = false;

            toEUR.BackColor = Color.White;
            toGBP.BackColor = Color.White;
            toUSD.BackColor = Color.White;
        }

        private void toUSD_Click(object sender, EventArgs e)
        {
            selected2_rub = false;
            selected2_eur = false;
            selected2_gbp = false;
            selected2_usd = true;

            toEUR.BackColor = Color.White;
            toRUB.BackColor = Color.White;
            toGBP.BackColor = Color.White;
        }

        private void toEUR_Click(object sender, EventArgs e)
        {
            selected2_rub = false;
            selected2_eur = true;
            selected2_gbp = false;
            selected2_usd = false;

            toGBP.BackColor = Color.White;
            toRUB.BackColor = Color.White;
            toUSD.BackColor = Color.White;
        }

        private void toGBP_Click(object sender, EventArgs e)
        {
            selected2_rub = false;
            selected2_eur = false;
            selected2_gbp = true;
            selected2_usd = false;

            toEUR.BackColor = Color.White;
            toRUB.BackColor = Color.White;
            toUSD.BackColor = Color.White;
        }
    }
}
