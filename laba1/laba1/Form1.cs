using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
         private RedVine[] redVines;
         private Sugar sugar;
         private Pan pan;
         private Fire fire;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //здесь инициализируем классы
            pan = new Pan();
            fire = new Fire();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            //плита
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ingr_Enter(object sender, EventArgs e)
        {

        }

        private void RedVineCount_ValueChanged(object sender, EventArgs e)
        {
            if (RedVineCount.Value > 0) {
                SetVine.Enabled = true;
            }
        }

        private void Sugar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cinnamon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GetCedra_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Spec_Enter(object sender, EventArgs e)
        {
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pan_Enter(object sender, EventArgs e)
        {

        }

        private void Knife_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void CheckFire_CheckedChanged(object sender, EventArgs e) { }


        private void PanOnFire_Click(object sender, EventArgs e)
        {

        }

        private void WarmUp_Click(object sender, EventArgs e)
        {

        }

        private void PanOfFire_Click(object sender, EventArgs e)
        {

        }

        private void Cpecii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetVine_Click(object sender, EventArgs e)
        {
            if (RedVineCount.Value < 7)
            {
                MessageBox.Show("Минимальное количество вина: 700мл! Добавьте вина!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                pan.Init(Convert.ToInt32(RedVineCount.Value));
                SetSugar.Enabled = true;
            }
        }

        private void SetSugar_Click(object sender, EventArgs e)
        {
            sugar = new Sugar();
            sugar.Count = Convert.ToInt32(SugarCount.Value);
            if (sugar.Count > 0)
            {
                pan.AddSugar(sugar);
                MessageBox.Show("Сахар добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сахара же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

