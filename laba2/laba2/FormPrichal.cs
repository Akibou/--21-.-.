using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class FormPrichal : Form
    {
        Prichal prichal;
        FormSelect form;
        private Logger log;
        
             public FormPrichal()
             {
                 InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
                 prichal = new Prichal(5);
            
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Причал " + i);
            }
            listBoxLevels.SelectedIndex = prichal.getCurrentLevel;
            Draw();
             }
             private void Draw()
             {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPrichal.Width, pictureBoxPrichal.Height);
                 Graphics gr = Graphics.FromImage(bmp);
                 prichal.Draw(gr);
                 pictureBoxPrichal.Image = bmp;
            }}

             private void SetShip_Click(object sender, EventArgs e)
             {
            form = new FormSelect();
            form.AddEvent(AddShip);
            form.Show();
            log.Info("Переход в formPrichal");

        }
        private void AddShip(ITransport ship)
        {
            if (ship != null)
            { try { 
                int place = prichal.PutShipInPrichal(ship);
                    Draw();
                    log.Info("Ваше место: " + place);
                } catch (PrichalOverflowException ex)

                {
                    log.Info("Ошибка - Переполнение");
                    MessageBox.Show(ex.Message,"Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    log.Info("Ошибка - Общая ошибка");
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }}}


             private void SetLiner_Click(object sender, EventArgs e)
             {
                 ColorDialog dialog = new ColorDialog();
                 if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 {
                     ColorDialog dialogDop = new ColorDialog();
                     if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                     {
                         var car = new CruiseLiner(10, 100, 1000, dialog.Color, true, true, true, dialogDop.Color,true,true);

                         int place = prichal.PutShipInPrichal(car);
                         Draw();
                    log.Info("Ваше место: " + place);
                     }
                 }

             }

        private void TakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            { 
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {try
                    {
                        ITransport ship = prichal.GetShipInPrichal(Convert.ToInt32(maskedTextBox1.Text));
                        
                            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            ship.setPosition(5, 5);
                            ship.drawShip(gr);
                            pictureBoxShip.Image = bmp;
                            Draw();
                        
                    } catch (PrichalIndexOutOfRangeException ex) {
                        log.Info("Ошибка - Неверный номер");
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    } catch (Exception ex)
                    {
                        log.Info("Ошибка - Общая ошибка");
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            prichal.LevelDown();
            listBoxLevels.SelectedIndex = prichal.getCurrentLevel;
            log.Info("Переход на уровень ниже, Текущий уровень: " + prichal.getCurrentLevel);
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            prichal.LevelUp();
            listBoxLevels.SelectedIndex = prichal.getCurrentLevel;
            log.Info("Переход на уровень выше, Текущий уровень: " + prichal.getCurrentLevel);
            Draw();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    prichal.SaveData(saveFileDialog1.FileName);
                    log.Info("Сохранение прошло успешно");
                    MessageBox.Show("Сохранение прошло успешно", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    log.Info("Ошибка при сохранении");
                    MessageBox.Show("Ошибка сохранения: " + ex.Message);
                }
            }

        }

        

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try {
                    prichal.LoadData(openFileDialog1.FileName);
                    log.Info("Загрузили файл");
                    MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                catch(Exception ex) {
                    log.Info(ex.Message + "Не загрузили файл");
                    MessageBox.Show("Загрузка не удалась: " + ex.Message);
                }
                Draw();
            }
        }
    }
}
