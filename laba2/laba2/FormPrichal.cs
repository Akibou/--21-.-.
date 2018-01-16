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
        
             public FormPrichal()
             {
                 InitializeComponent();
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
        
             }
        private void AddShip(ITransport ship)
        {
            if (ship != null)
            {
                int place = prichal.PutShipInPrichal(ship);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Не удалось причалить");
                }
            }
          
            }


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
                         MessageBox.Show("Ваше место: " + place);
                     }
                 }

             }

        private void TakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    ITransport ship = prichal.GetShipInPrichal(Convert.ToInt32(maskedTextBox1.Text));
                    if (ship != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.setPosition(5, 5);
                        ship.drawShip(gr);
                        pictureBoxShip.Image = bmp;
                        Draw();
                    }
                    else { MessageBox.Show("На этом месте нет корабля"); }
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            prichal.LevelDown();
            listBoxLevels.SelectedIndex = prichal.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            prichal.LevelUp();
            listBoxLevels.SelectedIndex = prichal.getCurrentLevel;
            Draw();
        }
    }
}
