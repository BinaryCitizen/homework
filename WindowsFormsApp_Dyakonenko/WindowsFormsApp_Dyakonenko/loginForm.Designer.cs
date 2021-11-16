
namespace WindowsFormsApp_Dyakonenko
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.weakPass = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.kabenet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Vhod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp_Dyakonenko.Properties.Resources.megafon;
            this.pictureBox2.Location = new System.Drawing.Point(159, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(55, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 669);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.weakPass);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.kabenet);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Vhod);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(484, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход по паролю";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // weakPass
            // 
            this.weakPass.AutoSize = true;
            this.weakPass.ForeColor = System.Drawing.Color.IndianRed;
            this.weakPass.Location = new System.Drawing.Point(155, 250);
            this.weakPass.Name = "weakPass";
            this.weakPass.Size = new System.Drawing.Size(165, 23);
            this.weakPass.TabIndex = 10;
            this.weakPass.Text = "Пароль неверный";
            this.weakPass.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox1.Location = new System.Drawing.Point(91, 112);
            this.maskedTextBox1.Mask = "+7 (000) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(300, 32);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // kabenet
            // 
            this.kabenet.AutoSize = true;
            this.kabenet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.kabenet.Location = new System.Drawing.Point(155, 529);
            this.kabenet.Name = "kabenet";
            this.kabenet.Size = new System.Drawing.Size(185, 23);
            this.kabenet.TabIndex = 7;
            this.kabenet.Text = "О Личном кабинете";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(166, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Напомнить номер";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(180, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нужен пароль";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // Vhod
            // 
            this.Vhod.BackColor = System.Drawing.Color.YellowGreen;
            this.Vhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vhod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vhod.Location = new System.Drawing.Point(91, 288);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(301, 60);
            this.Vhod.TabIndex = 4;
            this.Vhod.Text = "Вход";
            this.Vhod.UseVisualStyleBackColor = false;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(300, 32);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер телефона";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 32);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.maskedTextBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 619);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Вход по коду ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(155, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "О Личном кабинете";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(166, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Напомнить номер";
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(91, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox2.Location = new System.Drawing.Point(91, 112);
            this.maskedTextBox2.Mask = "+7 (000) 000-00-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(300, 32);
            this.maskedTextBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Номер телефона";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Green;
            this.CloseButton.Location = new System.Drawing.Point(446, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 806);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label kabenet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Vhod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label weakPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}