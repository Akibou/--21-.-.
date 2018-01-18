namespace laba2
{
    partial class FormPrichal
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
            this.pictureBoxPrichal = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.SetShip = new System.Windows.Forms.Button();
            this.SetLiner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TakeShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrichal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPrichal
            // 
            this.pictureBoxPrichal.Location = new System.Drawing.Point(10, 13);
            this.pictureBoxPrichal.Name = "pictureBoxPrichal";
            this.pictureBoxPrichal.Size = new System.Drawing.Size(561, 328);
            this.pictureBoxPrichal.TabIndex = 0;
            this.pictureBoxPrichal.TabStop = false;
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(577, 96);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(130, 119);
            this.pictureBoxTakeShip.TabIndex = 1;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // SetShip
            // 
            this.SetShip.Location = new System.Drawing.Point(577, 18);
            this.SetShip.Name = "SetShip";
            this.SetShip.Size = new System.Drawing.Size(129, 33);
            this.SetShip.TabIndex = 2;
            this.SetShip.Text = "Оставить корабль";
            this.SetShip.UseVisualStyleBackColor = true;
            this.SetShip.Click += new System.EventHandler(this.SetShip_Click);
            // 
            // SetLiner
            // 
            this.SetLiner.Location = new System.Drawing.Point(577, 57);
            this.SetLiner.Name = "SetLiner";
            this.SetLiner.Size = new System.Drawing.Size(130, 33);
            this.SetLiner.TabIndex = 3;
            this.SetLiner.Text = "Оставить лайнер";
            this.SetLiner.UseVisualStyleBackColor = true;
            this.SetLiner.Click += new System.EventHandler(this.SetLiner_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TakeShip);
            this.groupBox1.Location = new System.Drawing.Point(577, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор корабля";
            // 
            // TakeShip
            // 
            this.TakeShip.Location = new System.Drawing.Point(6, 76);
            this.TakeShip.Name = "TakeShip";
            this.TakeShip.Size = new System.Drawing.Size(116, 32);
            this.TakeShip.TabIndex = 0;
            this.TakeShip.Text = "Отчалить";
            this.TakeShip.UseVisualStyleBackColor = true;
            this.TakeShip.Click += new System.EventHandler(this.TakeShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(69, 41);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(31, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // FormPrichal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SetLiner);
            this.Controls.Add(this.SetShip);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.pictureBoxPrichal);
            this.Name = "FormPrichal";
            this.Text = "FormPrichal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrichal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPrichal;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.Button SetShip;
        private System.Windows.Forms.Button SetLiner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TakeShip;
    }
}