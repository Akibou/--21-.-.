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

        private ITransport inter;

        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            maxSpeed = 100;
            maxCountPass = 50;
            weight = 100;

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
    }
}
