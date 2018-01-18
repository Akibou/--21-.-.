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
    public partial class FormSelect : Form
    {
        ITransport ship = null;
        CruiseLiner liner = null;
        public ITransport getShip
        {
            get { return ship; }
        }
        private void DrawShip()
        {
            if (ship != null) { Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.setPosition(5, -15);
                ship.drawShip(gr);
                pictureBoxShip.Image = bmp;
            }
        }

        private event myDel eventAddShip;
        public void AddEvent (myDel ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new myDel(ev);
            } else
            {
                eventAddShip += ev;
            }
        }

        public FormSelect()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelCreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown; 
            panelYellow.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void lableShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy; else e.Effect = DragDropEffects.None;
        }

        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new Ship(100, 40, 55, Color.White);
                    break;
                case "Лайнер":
                    ship = new CruiseLiner(100, 100, 100, Color.Blue, true, true, true, Color.Black, true, true);
                    break;
            } DrawShip();
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }

        }
        

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is CruiseLiner) {
                    (ship as CruiseLiner).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (eventAddShip != null)
            {
                eventAddShip(ship);
            }Close();
        }

        private void labelLiner_MouseDown(object sender, MouseEventArgs e)
        {
            labelLiner.DoDragDrop(labelLiner.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelLiner_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelLiner_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }

        }
    }
}
