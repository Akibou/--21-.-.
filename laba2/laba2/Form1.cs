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
  
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountPass;
        int weight;
        float maxWaterLine;
        private ITransport inter;

        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Blue;
            maxSpeed = 100;
            maxCountPass = 50;
            weight = 100;
            buttonSelectColor.BackColor = color;
            buttonDopColor.BackColor = dopColor;
            
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private void buttonDopColor_click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonDopColor.BackColor = dopColor;
            }
        }

        private void Weight_Click(object sender, EventArgs e)
        {

        }

        private void LinerPic_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(LinerPic.Width, LinerPic.Height);
            Graphics gr = Graphics.FromImage(bmp);
            LinerPic.Image = bmp;

        }
        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out weight))
            {
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void WaterLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inter = new CruiseLiner(150, 4, 1000, color, BorderLine.Checked, TopLine.Checked, RoundLine.Checked, dopColor, Rest.Checked,Bass.Checked);
            Bitmap bmp = new Bitmap(LinerPic.Width, LinerPic.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawShip(gr);
            LinerPic.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(LinerPic.Width, LinerPic.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveShip(gr);
                LinerPic.Image = bmp;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BorderLine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TopLine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RoundLine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Ship(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(LinerPic.Width, LinerPic.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawShip(gr);
                LinerPic.Image = bmp;
            }

        }

        private void Rest_CheckedChanged(object sender, EventArgs e)
        {
            if (Rest.Checked)
            {
                button3.Enabled = false;
            }
            else button3.Enabled = true;
                
        }

        private void Bass_CheckedChanged(object sender, EventArgs e)
        {
            if (Bass.Checked)
            {
                button3.Enabled = false;
            }
            else button3.Enabled = true;
            
        }
    }
}
