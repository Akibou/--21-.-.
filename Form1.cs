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
         private Spices spices;
         private Pan pan;
         private Stove stove;
         private Knife knife;
         private Lemon[] lemons;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //здесь инициализируем классы
            pan = new Pan();
            stove = new Stove();
            knife = new Knife();

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
            lemons = new Lemon[Convert.ToInt32(LemonsCount.Value)];
            for (int i = 0; i < lemons.Length; ++i)
            {
                lemons[i] = new Lemon();
            }

            if (lemons == null)
            {
                MessageBox.Show("Лимонов то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lemons.Length == 0)
            {
                MessageBox.Show("Лимонов то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < lemons.Length; ++i)
            {
                knife.Clean(lemons[i]);
            }
            SliceLemon.Enabled = true;
            MessageBox.Show("Лимоны почистили , можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            pan.GetVine();
            MessageBox.Show("Мы сделали это! Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void CheckFire_CheckedChanged(object sender, EventArgs e) {
            stove.State = CheckFire.Checked;
        }


        private void PanOnFire_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            WarmUp.Enabled = true;
            MessageBox.Show("Кастрюлька на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WarmUp_Click(object sender, EventArgs e)
        {
            if (!pan.ReadyToGO)
            {
                MessageBox.Show("У нас не все готово к варке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Варить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (stove.Pan.IsReady())
            {
                PanOfFire.Enabled = true;
                CheckFire.Checked = false;
                MessageBox.Show("Сварилась!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, картошка не сварилась", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void PanOfFire_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            MessageBox.Show("Убрали с плиты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                pan.Init(Convert.ToInt32(RedVineCount.Value), Convert.ToInt32(LemonsCount.Value));
                redVines = new RedVine[Convert.ToInt32(RedVineCount.Value)];
                for (int i = 0; i < redVines.Length; ++i)
                {
                    redVines[i] = new RedVine();
                    pan.AddVine(redVines[i]);
                }
                SetSugar.Enabled = true;
                SetSpec.Enabled = true;
                PanOnFire.Enabled = true;
                MessageBox.Show("Вино добавили, можно и на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SliceLemon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lemons.Length; ++i)
            {
                knife.Slice(lemons[i]);
            }
            AddLemons.Enabled = true;
            MessageBox.Show("Лимоны Нарезали , можно кидать в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LemonsCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddLemons_Click(object sender, EventArgs e)
        {
            if (lemons == null)
            {
                MessageBox.Show("Лимонов то нет.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lemons.Length == 0)
            {
                MessageBox.Show("Лимонов то нет.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < lemons.Length; ++i)
            {

                if (lemons[i].sliced!=true)
                {
                    MessageBox.Show("Лимоны не нарезаны", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lemons[i].Have_skin)
                {
                    MessageBox.Show("Нужно почистить лимоны!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (redVines!=null){
                bool gotov = true;
                for (int i = 0; i < redVines.Length; ++i)
                {
                    if (redVines[i].Has_ready < 10) {
                        gotov = false;
                    }
                }
                if (gotov == true) {
                    for (int i = 0; i < lemons.Length; ++i)
                    {
                        pan.AddLemon(lemons[i]);
                    }
                    MessageBox.Show("Лимоны положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вино еще не приготовилось. Нужно приготовить в кострюле вино!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Сначала нужно приготовить вино", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //buttonAddPan.Enabled = true;

        }

        private void SetSpec_Click(object sender, EventArgs e)
        {
            int spices_Count = 0;
            foreach (object itemChecked in Cpecii.CheckedItems)
            {
                spices_Count++;
            }

            spices = new Spices();
            spices.Count = Convert.ToInt32(spices_Count);
            if (spices.Count > 0)
            {
                if (spices.Count > 2)
                {
                    pan.AddSpice(spices);

                    MessageBox.Show("Специи добавили добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Маловато специй, нужно хотябы три", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            else
            {
                MessageBox.Show("Специи не выбраны, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

