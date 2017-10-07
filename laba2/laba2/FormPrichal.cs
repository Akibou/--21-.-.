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
        public FormPrichal()
        {
            InitializeComponent();
            prichal = new Prichal();
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPrichal.Width, pictureBoxPrichal.Height);
            Graphics gr = Graphics.FromImage(bmp);
            prichal.Draw(gr, pictureBoxPrichal.Width, pictureBoxPrichal.Height);
            pictureBoxPrichal.Image = bmp;
        }

        private void SetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var ship = new Ship(100, 4, 1000, dialog.Color);
                int place = prichal.PutShipInPrichal(ship);
                Draw();
                MessageBox.Show("Ваше место: " + place);
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
            if (maskedTextBox1.Text != "")
            {
                var car = prichal.GetShipInPrichal(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(5, 5);
                car.drawShip(gr);
                pictureBoxTakeShip.Image = bmp;
                Draw();
            }

        }
    }
}
