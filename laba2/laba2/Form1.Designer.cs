namespace laba2
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
            this.LinerPic = new System.Windows.Forms.PictureBox();
            this.MaxSpeedL = new System.Windows.Forms.Label();
            this.MaxCountPassengers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSelectColor = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.ColorBody = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LinerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LinerPic
            // 
            this.LinerPic.Location = new System.Drawing.Point(19, 14);
            this.LinerPic.Name = "LinerPic";
            this.LinerPic.Size = new System.Drawing.Size(670, 282);
            this.LinerPic.TabIndex = 0;
            this.LinerPic.TabStop = false;
            this.LinerPic.Click += new System.EventHandler(this.LinerPic_Click);
            // 
            // MaxSpeedL
            // 
            this.MaxSpeedL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MaxSpeedL.AutoSize = true;
            this.MaxSpeedL.Location = new System.Drawing.Point(16, 312);
            this.MaxSpeedL.Name = "MaxSpeedL";
            this.MaxSpeedL.Size = new System.Drawing.Size(62, 13);
            this.MaxSpeedL.TabIndex = 1;
            this.MaxSpeedL.Text = "Max speed:";
            // 
            // MaxCountPassengers
            // 
            this.MaxCountPassengers.AutoSize = true;
            this.MaxCountPassengers.Location = new System.Drawing.Point(16, 335);
            this.MaxCountPassengers.Name = "MaxCountPassengers";
            this.MaxCountPassengers.Size = new System.Drawing.Size(117, 13);
            this.MaxCountPassengers.TabIndex = 2;
            this.MaxCountPassengers.Text = "Max count passengers:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 5;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(294, 332);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(47, 20);
            this.buttonSelectColor.TabIndex = 6;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(244, 312);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(44, 13);
            this.Weight.TabIndex = 9;
            this.Weight.Text = "Weight:";
            this.Weight.Click += new System.EventHandler(this.Weight_Click);
            // 
            // ColorBody
            // 
            this.ColorBody.AutoSize = true;
            this.ColorBody.Location = new System.Drawing.Point(244, 335);
            this.ColorBody.Name = "ColorBody";
            this.ColorBody.Size = new System.Drawing.Size(34, 13);
            this.ColorBody.TabIndex = 10;
            this.ColorBody.Text = "Color:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "Отправить лайнер";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 21);
            this.button2.TabIndex = 12;
            this.button2.Text = "Показать лайнер";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColorBody);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MaxCountPassengers);
            this.Controls.Add(this.MaxSpeedL);
            this.Controls.Add(this.LinerPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LinerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LinerPic;
        private System.Windows.Forms.Label MaxSpeedL;
        private System.Windows.Forms.Label MaxCountPassengers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox buttonSelectColor;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label ColorBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

