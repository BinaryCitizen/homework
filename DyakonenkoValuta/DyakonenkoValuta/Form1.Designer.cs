
namespace DyakonenkoValuta
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromRUB = new System.Windows.Forms.Button();
            this.fromUSD = new System.Windows.Forms.Button();
            this.fromGBP = new System.Windows.Forms.Button();
            this.fromEUR = new System.Windows.Forms.Button();
            this.toGBP = new System.Windows.Forms.Button();
            this.toEUR = new System.Windows.Forms.Button();
            this.toUSD = new System.Windows.Forms.Button();
            this.toRUB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "У меня есть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(506, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Хочу приобрести";
            // 
            // fromRUB
            // 
            this.fromRUB.BackColor = System.Drawing.Color.White;
            this.fromRUB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromRUB.Location = new System.Drawing.Point(12, 51);
            this.fromRUB.Name = "fromRUB";
            this.fromRUB.Size = new System.Drawing.Size(80, 36);
            this.fromRUB.TabIndex = 2;
            this.fromRUB.Text = "RUB";
            this.fromRUB.UseVisualStyleBackColor = false;
            this.fromRUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fromRUB_MouseClick);
            this.fromRUB.MouseEnter += new System.EventHandler(this.fromRUB_MouseEnter);
            this.fromRUB.MouseLeave += new System.EventHandler(this.fromRUB_MouseLeave);
            // 
            // fromUSD
            // 
            this.fromUSD.BackColor = System.Drawing.Color.White;
            this.fromUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromUSD.Location = new System.Drawing.Point(118, 51);
            this.fromUSD.Name = "fromUSD";
            this.fromUSD.Size = new System.Drawing.Size(80, 36);
            this.fromUSD.TabIndex = 3;
            this.fromUSD.Text = "USD";
            this.fromUSD.UseVisualStyleBackColor = false;
            this.fromUSD.Click += new System.EventHandler(this.fromUSD_Click);
            this.fromUSD.MouseEnter += new System.EventHandler(this.fromUSD_MouseEnter);
            this.fromUSD.MouseLeave += new System.EventHandler(this.fromUSD_MouseLeave);
            // 
            // fromGBP
            // 
            this.fromGBP.BackColor = System.Drawing.Color.White;
            this.fromGBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromGBP.Location = new System.Drawing.Point(328, 51);
            this.fromGBP.Name = "fromGBP";
            this.fromGBP.Size = new System.Drawing.Size(80, 36);
            this.fromGBP.TabIndex = 5;
            this.fromGBP.Text = "GBP";
            this.fromGBP.UseVisualStyleBackColor = false;
            this.fromGBP.Click += new System.EventHandler(this.fromGBP_Click);
            this.fromGBP.MouseEnter += new System.EventHandler(this.fromGBP_MouseEnter);
            this.fromGBP.MouseLeave += new System.EventHandler(this.fromGBP_MouseLeave);
            // 
            // fromEUR
            // 
            this.fromEUR.BackColor = System.Drawing.Color.White;
            this.fromEUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromEUR.Location = new System.Drawing.Point(227, 51);
            this.fromEUR.Name = "fromEUR";
            this.fromEUR.Size = new System.Drawing.Size(80, 36);
            this.fromEUR.TabIndex = 4;
            this.fromEUR.Text = "EUR";
            this.fromEUR.UseVisualStyleBackColor = false;
            this.fromEUR.Click += new System.EventHandler(this.fromEUR_Click);
            this.fromEUR.MouseEnter += new System.EventHandler(this.fromEUR_MouseEnter);
            this.fromEUR.MouseLeave += new System.EventHandler(this.fromEUR_MouseLeave);
            // 
            // toGBP
            // 
            this.toGBP.BackColor = System.Drawing.Color.White;
            this.toGBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toGBP.Location = new System.Drawing.Point(826, 51);
            this.toGBP.Name = "toGBP";
            this.toGBP.Size = new System.Drawing.Size(80, 36);
            this.toGBP.TabIndex = 10;
            this.toGBP.Text = "GBP";
            this.toGBP.UseVisualStyleBackColor = false;
            this.toGBP.Click += new System.EventHandler(this.toGBP_Click);
            this.toGBP.MouseEnter += new System.EventHandler(this.toGBP_MouseEnter);
            this.toGBP.MouseLeave += new System.EventHandler(this.toGBP_MouseLeave);
            // 
            // toEUR
            // 
            this.toEUR.BackColor = System.Drawing.Color.White;
            this.toEUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toEUR.Location = new System.Drawing.Point(724, 51);
            this.toEUR.Name = "toEUR";
            this.toEUR.Size = new System.Drawing.Size(80, 36);
            this.toEUR.TabIndex = 9;
            this.toEUR.Text = "EUR";
            this.toEUR.UseVisualStyleBackColor = false;
            this.toEUR.Click += new System.EventHandler(this.toEUR_Click);
            this.toEUR.MouseEnter += new System.EventHandler(this.toEUR_MouseEnter);
            this.toEUR.MouseLeave += new System.EventHandler(this.toEUR_MouseLeave);
            // 
            // toUSD
            // 
            this.toUSD.BackColor = System.Drawing.Color.White;
            this.toUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toUSD.Location = new System.Drawing.Point(619, 51);
            this.toUSD.Name = "toUSD";
            this.toUSD.Size = new System.Drawing.Size(80, 36);
            this.toUSD.TabIndex = 8;
            this.toUSD.Text = "USD";
            this.toUSD.UseVisualStyleBackColor = false;
            this.toUSD.Click += new System.EventHandler(this.toUSD_Click);
            this.toUSD.MouseEnter += new System.EventHandler(this.toUSD_MouseEnter);
            this.toUSD.MouseLeave += new System.EventHandler(this.toUSD_MouseLeave);
            // 
            // toRUB
            // 
            this.toRUB.BackColor = System.Drawing.Color.White;
            this.toRUB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toRUB.Location = new System.Drawing.Point(510, 51);
            this.toRUB.Name = "toRUB";
            this.toRUB.Size = new System.Drawing.Size(80, 36);
            this.toRUB.TabIndex = 7;
            this.toRUB.Text = "RUB";
            this.toRUB.UseVisualStyleBackColor = false;
            this.toRUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toRUB_MouseClick);
            this.toRUB.MouseEnter += new System.EventHandler(this.toRUB_MouseEnter);
            this.toRUB.MouseLeave += new System.EventHandler(this.toRUB_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 192);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = " \r\n \r\n \r\n ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(510, 93);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 192);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = " \r\n \r\n \r\n ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://cdn4.iconfinder.com/data/icons/social-messaging-productivity-5/128/transf" +
    "er-arrows-512.png";
            this.pictureBox1.Location = new System.Drawing.Point(414, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toGBP);
            this.Controls.Add(this.toEUR);
            this.Controls.Add(this.toUSD);
            this.Controls.Add(this.toRUB);
            this.Controls.Add(this.fromGBP);
            this.Controls.Add(this.fromEUR);
            this.Controls.Add(this.fromUSD);
            this.Controls.Add(this.fromRUB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Обмен валюты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fromRUB;
        private System.Windows.Forms.Button fromUSD;
        private System.Windows.Forms.Button fromGBP;
        private System.Windows.Forms.Button fromEUR;
        private System.Windows.Forms.Button toGBP;
        private System.Windows.Forms.Button toEUR;
        private System.Windows.Forms.Button toUSD;
        private System.Windows.Forms.Button toRUB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

