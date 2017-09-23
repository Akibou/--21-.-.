namespace laba1
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
            this.RedVineCount = new System.Windows.Forms.NumericUpDown();
            this.SugarCount = new System.Windows.Forms.NumericUpDown();
            this.Cinnamon = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ingr = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Spec = new System.Windows.Forms.GroupBox();
            this.Cpecii = new System.Windows.Forms.CheckedListBox();
            this.Fire = new System.Windows.Forms.GroupBox();
            this.PanOfFire = new System.Windows.Forms.Button();
            this.WarmUp = new System.Windows.Forms.Button();
            this.PanOnFire = new System.Windows.Forms.Button();
            this.CheckFire = new System.Windows.Forms.CheckBox();
            this.Knife = new System.Windows.Forms.GroupBox();
            this.SliceLemon = new System.Windows.Forms.Button();
            this.GetCedra = new System.Windows.Forms.Button();
            this.Pan = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.SetSugar = new System.Windows.Forms.Button();
            this.SetSpec = new System.Windows.Forms.Button();
            this.SetVine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedVineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cinnamon)).BeginInit();
            this.Ingr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Spec.SuspendLayout();
            this.Fire.SuspendLayout();
            this.Knife.SuspendLayout();
            this.Pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedVineCount
            // 
            this.RedVineCount.Location = new System.Drawing.Point(9, 25);
            this.RedVineCount.Name = "RedVineCount";
            this.RedVineCount.Size = new System.Drawing.Size(41, 20);
            this.RedVineCount.TabIndex = 0;
            this.RedVineCount.ValueChanged += new System.EventHandler(this.RedVineCount_ValueChanged);
            // 
            // SugarCount
            // 
            this.SugarCount.Location = new System.Drawing.Point(9, 51);
            this.SugarCount.Name = "SugarCount";
            this.SugarCount.Size = new System.Drawing.Size(41, 20);
            this.SugarCount.TabIndex = 1;
            this.SugarCount.ValueChanged += new System.EventHandler(this.Sugar_ValueChanged);
            // 
            // Cinnamon
            // 
            this.Cinnamon.Location = new System.Drawing.Point(9, 77);
            this.Cinnamon.Name = "Cinnamon";
            this.Cinnamon.Size = new System.Drawing.Size(41, 20);
            this.Cinnamon.TabIndex = 2;
            this.Cinnamon.ValueChanged += new System.EventHandler(this.Cinnamon_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Красное вино";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сахар (в ч.л.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Корица (в ч.л.)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Ingr
            // 
            this.Ingr.Controls.Add(this.label4);
            this.Ingr.Controls.Add(this.numericUpDown1);
            this.Ingr.Controls.Add(this.label3);
            this.Ingr.Controls.Add(this.label2);
            this.Ingr.Controls.Add(this.label1);
            this.Ingr.Controls.Add(this.Cinnamon);
            this.Ingr.Controls.Add(this.SugarCount);
            this.Ingr.Controls.Add(this.RedVineCount);
            this.Ingr.Location = new System.Drawing.Point(10, 10);
            this.Ingr.Name = "Ingr";
            this.Ingr.Size = new System.Drawing.Size(161, 163);
            this.Ingr.TabIndex = 6;
            this.Ingr.TabStop = false;
            this.Ingr.Text = "Ингридиенты";
            this.Ingr.Enter += new System.EventHandler(this.Ingr_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Лимон (шт)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Spec
            // 
            this.Spec.Controls.Add(this.Cpecii);
            this.Spec.Location = new System.Drawing.Point(192, 10);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(210, 216);
            this.Spec.TabIndex = 7;
            this.Spec.TabStop = false;
            this.Spec.Text = "Специи";
            this.Spec.Enter += new System.EventHandler(this.Spec_Enter);
            // 
            // Cpecii
            // 
            this.Cpecii.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cpecii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cpecii.FormattingEnabled = true;
            this.Cpecii.Items.AddRange(new object[] {
            "Корица измельченная",
            "Корень имбиря нарезанный",
            "Звездочки бадьяна",
            "Зерна кардамона",
            "Гвоздика",
            "Душистый перец",
            "Мускатный орех",
            "Лимон"});
            this.Cpecii.Location = new System.Drawing.Point(6, 25);
            this.Cpecii.Name = "Cpecii";
            this.Cpecii.Size = new System.Drawing.Size(198, 165);
            this.Cpecii.TabIndex = 11;
            this.Cpecii.SelectedIndexChanged += new System.EventHandler(this.Cpecii_SelectedIndexChanged);
            // 
            // Fire
            // 
            this.Fire.Controls.Add(this.PanOfFire);
            this.Fire.Controls.Add(this.WarmUp);
            this.Fire.Controls.Add(this.PanOnFire);
            this.Fire.Controls.Add(this.CheckFire);
            this.Fire.Location = new System.Drawing.Point(408, 17);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(171, 209);
            this.Fire.TabIndex = 8;
            this.Fire.TabStop = false;
            this.Fire.Text = "Плита";
            this.Fire.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // PanOfFire
            // 
            this.PanOfFire.Enabled = false;
            this.PanOfFire.Location = new System.Drawing.Point(20, 133);
            this.PanOfFire.Name = "PanOfFire";
            this.PanOfFire.Size = new System.Drawing.Size(128, 39);
            this.PanOfFire.TabIndex = 3;
            this.PanOfFire.Text = "Убрать кастрюлю";
            this.PanOfFire.UseVisualStyleBackColor = true;
            this.PanOfFire.Click += new System.EventHandler(this.PanOfFire_Click);
            // 
            // WarmUp
            // 
            this.WarmUp.Enabled = false;
            this.WarmUp.Location = new System.Drawing.Point(20, 91);
            this.WarmUp.Name = "WarmUp";
            this.WarmUp.Size = new System.Drawing.Size(126, 36);
            this.WarmUp.TabIndex = 2;
            this.WarmUp.Text = "Нагреть вино со специями";
            this.WarmUp.UseVisualStyleBackColor = true;
            this.WarmUp.Click += new System.EventHandler(this.WarmUp_Click);
            // 
            // PanOnFire
            // 
            this.PanOnFire.Enabled = false;
            this.PanOnFire.Location = new System.Drawing.Point(20, 52);
            this.PanOnFire.Name = "PanOnFire";
            this.PanOnFire.Size = new System.Drawing.Size(128, 35);
            this.PanOnFire.TabIndex = 1;
            this.PanOnFire.Text = "Поставить кастрюлю";
            this.PanOnFire.UseVisualStyleBackColor = true;
            this.PanOnFire.Click += new System.EventHandler(this.PanOnFire_Click);
            // 
            // CheckFire
            // 
            this.CheckFire.AutoSize = true;
            this.CheckFire.Location = new System.Drawing.Point(61, 19);
            this.CheckFire.Name = "CheckFire";
            this.CheckFire.Size = new System.Drawing.Size(45, 17);
            this.CheckFire.TabIndex = 0;
            this.CheckFire.Text = "Вкл";
            this.CheckFire.UseVisualStyleBackColor = true;
            this.CheckFire.CheckedChanged += new System.EventHandler(this.CheckFire_CheckedChanged);
            // 
            // Knife
            // 
            this.Knife.Controls.Add(this.SliceLemon);
            this.Knife.Controls.Add(this.GetCedra);
            this.Knife.Location = new System.Drawing.Point(604, 17);
            this.Knife.Name = "Knife";
            this.Knife.Size = new System.Drawing.Size(184, 209);
            this.Knife.TabIndex = 9;
            this.Knife.TabStop = false;
            this.Knife.Text = "Нож";
            this.Knife.Enter += new System.EventHandler(this.Knife_Enter);
            // 
            // SliceLemon
            // 
            this.SliceLemon.Enabled = false;
            this.SliceLemon.Location = new System.Drawing.Point(35, 113);
            this.SliceLemon.Name = "SliceLemon";
            this.SliceLemon.Size = new System.Drawing.Size(117, 51);
            this.SliceLemon.TabIndex = 1;
            this.SliceLemon.Text = "Порезать мякоть лимона кружочками";
            this.SliceLemon.UseVisualStyleBackColor = true;
            // 
            // GetCedra
            // 
            this.GetCedra.Enabled = false;
            this.GetCedra.Location = new System.Drawing.Point(31, 31);
            this.GetCedra.Name = "GetCedra";
            this.GetCedra.Size = new System.Drawing.Size(121, 50);
            this.GetCedra.TabIndex = 0;
            this.GetCedra.Text = "Отделить цедру лимона";
            this.GetCedra.UseVisualStyleBackColor = true;
            this.GetCedra.Click += new System.EventHandler(this.GetCedra_Click);
            // 
            // Pan
            // 
            this.Pan.Controls.Add(this.button9);
            this.Pan.Controls.Add(this.SetSugar);
            this.Pan.Controls.Add(this.SetSpec);
            this.Pan.Controls.Add(this.SetVine);
            this.Pan.Location = new System.Drawing.Point(12, 179);
            this.Pan.Name = "Pan";
            this.Pan.Size = new System.Drawing.Size(161, 191);
            this.Pan.TabIndex = 10;
            this.Pan.TabStop = false;
            this.Pan.Text = "Кастрюля";
            this.Pan.Enter += new System.EventHandler(this.Pan_Enter);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(10, 140);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 30);
            this.button9.TabIndex = 11;
            this.button9.Text = "Процедить глинтвейн";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SetSugar
            // 
            this.SetSugar.Enabled = false;
            this.SetSugar.Location = new System.Drawing.Point(10, 64);
            this.SetSugar.Name = "SetSugar";
            this.SetSugar.Size = new System.Drawing.Size(134, 32);
            this.SetSugar.TabIndex = 2;
            this.SetSugar.Text = "Добавить сахар";
            this.SetSugar.UseVisualStyleBackColor = true;
            this.SetSugar.Click += new System.EventHandler(this.SetSugar_Click);
            // 
            // SetSpec
            // 
            this.SetSpec.Enabled = false;
            this.SetSpec.Location = new System.Drawing.Point(10, 102);
            this.SetSpec.Name = "SetSpec";
            this.SetSpec.Size = new System.Drawing.Size(134, 32);
            this.SetSpec.TabIndex = 1;
            this.SetSpec.Text = "Добавить специи";
            this.SetSpec.UseVisualStyleBackColor = true;
            // 
            // SetVine
            // 
            this.SetVine.Enabled = false;
            this.SetVine.Location = new System.Drawing.Point(10, 26);
            this.SetVine.Name = "SetVine";
            this.SetVine.Size = new System.Drawing.Size(134, 32);
            this.SetVine.TabIndex = 0;
            this.SetVine.Text = "Залить вино";
            this.SetVine.UseVisualStyleBackColor = true;
            this.SetVine.Click += new System.EventHandler(this.SetVine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 371);
            this.Controls.Add(this.Pan);
            this.Controls.Add(this.Knife);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.Ingr);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Глинтвейн";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedVineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cinnamon)).EndInit();
            this.Ingr.ResumeLayout(false);
            this.Ingr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Spec.ResumeLayout(false);
            this.Fire.ResumeLayout(false);
            this.Fire.PerformLayout();
            this.Knife.ResumeLayout(false);
            this.Pan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown RedVineCount;
        private System.Windows.Forms.NumericUpDown SugarCount;
        private System.Windows.Forms.NumericUpDown Cinnamon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Ingr;
        private System.Windows.Forms.GroupBox Spec;
        private System.Windows.Forms.GroupBox Fire;
        private System.Windows.Forms.GroupBox Knife;
        private System.Windows.Forms.CheckBox CheckFire;
        private System.Windows.Forms.Button GetCedra;
        private System.Windows.Forms.Button SliceLemon;
        private System.Windows.Forms.Button PanOfFire;
        private System.Windows.Forms.Button WarmUp;
        private System.Windows.Forms.Button PanOnFire;
        private System.Windows.Forms.GroupBox Pan;
        private System.Windows.Forms.Button SetSugar;
        private System.Windows.Forms.Button SetSpec;
        private System.Windows.Forms.Button SetVine;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckedListBox Cpecii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

