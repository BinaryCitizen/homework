using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyakonenkoBMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool selected_Man = false;
        bool selected_Woman = false;
        int bar;
        int standartY = 415;
        int standartX = 588;
        int maxX = 786;

        int standartYlabel = 388;
        int standartXlabel = 584;
        int maxXlabel = 781;

        double onePercent;
        double movingTo;
        double movingToLabel;
        int newX;
        int newXlabel;
        double disposal;
        double resultat;
        double mass1;
        double height1;

        private void button1_Click(object sender, EventArgs e)
        {
            selected_Man = true;
            selected_Woman = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selected_Woman = true;
            selected_Man = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (selected_Man || selected_Woman)
            {

                mass1 = Convert.ToDouble(mass.Text);
                height1 = Convert.ToDouble(height.Text) / 100;
                resultat = mass1 / (height1 * height1);
                trackBar1.Value = Convert.ToInt32(resultat);


                if (resultat < 18.5)
                {
                    bar = 10;
                    button3.Text = "Недостаточный";
                    if (selected_Man)
                    {
                        pictureBox5.ImageLocation = "https://cdn3.iconfinder.com/data/icons/destitution/500/destitution-famine-starving_6-512.png";
                    }
                    else if (selected_Woman)
                    {
                        pictureBox5.ImageLocation = "https://cdn0.iconfinder.com/data/icons/skinny-weak-man-life/227/guy-life-007-512.png";
                    }
                }
                else if ((resultat > 18.5) && (resultat < 24.9 ))
                {
                    bar = 30;
                    button3.Text = "Здоровый";
                    if (selected_Man)
                    {
                        pictureBox5.ImageLocation = "https://cdn3.iconfinder.com/data/icons/body-size-process/246/body-size-process-008-512.png";
                    }
                    else if (selected_Woman)
                    {
                        pictureBox5.ImageLocation = "https://cdn4.iconfinder.com/data/icons/aiga-symbol-signs/491/aiga_toilet_women-512.png";
                    }
                }
                else if ((resultat > 25) && (resultat < 29.9))
                {
                    bar = 70;
                    button3.Text = "Избыточный";
                    if (selected_Man)
                    {
                        pictureBox5.ImageLocation = "https://cdn0.iconfinder.com/data/icons/human-immune-system/198/normal-immune-vaccinated-003-512.png";
                    }
                    else if (selected_Woman)
                    {
                        pictureBox5.ImageLocation = "https://cdn2.iconfinder.com/data/icons/fat-man-woman-kid-obesity-overweight/238/fat-obesity-005-512.png";
                    }
                }
                else if (resultat > 30)
                {
                    bar = 90;
                    button3.Text = "Ожирение";
                    if (selected_Man)
                    {
                        pictureBox5.ImageLocation = "https://cdn2.iconfinder.com/data/icons/fat-man/271/fat-man-action-1002-512.png";
                    }else if (selected_Woman)
                    {
                        pictureBox5.ImageLocation = "https://cdn3.iconfinder.com/data/icons/slimming-center-treatment/219/obesity-woman-007-512.png";
                    }
                }

                onePercent = (maxX - standartX) / 100;
                movingTo = 2 * bar;
                disposal = movingTo + standartX;
                newX = Convert.ToInt32(disposal);
                newXlabel = Convert.ToInt32(movingTo + standartXlabel);

                progressBar1.Value = bar;
                pictureBox6.Location = new Point(newX, standartY);
                label8.Location = new Point(newXlabel, standartYlabel);

                label8.Text = Convert.ToString(resultat);
            }

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }
    }
}