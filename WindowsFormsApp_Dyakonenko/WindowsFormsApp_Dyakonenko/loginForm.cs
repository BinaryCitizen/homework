using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp_Dyakonenko
{

    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "9999999999") && (textBox2.Text == "Password"))
            {
                tabControl1.Visible = false;
            }
            if (textBox2.TextLength <= 5)
            {
                weakPass.Visible = true;
            }
            else
            {
                weakPass.Visible = false;
            }
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Purple;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SteelBlue;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Purple;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.SteelBlue;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Purple;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.SteelBlue;
        }

        private void loginForm_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}