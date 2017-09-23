using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class OurLiner : CLiner
        //добавить отличия, кот нет у судна
    {
        private bool sideSpoiler;
        private Color dopColor;

        public OurLiner(int maxSpeed, int maxCountPassenget, double weight, Color color, bool sideSpoiler, Color dopColor) : base(maxSpeed, maxCountPassenget, weight, color)

        {

            this.sideSpoiler = sideSpoiler;
            this.dopColor = dopColor;

        }

        public override void drawLiner(Graphics g)
        {
            if (sideSpoiler)
            {

                Pen pen = new Pen(Color.Black);

                g.DrawRectangle(pen, startPosX + 25, startPosY - 6, 39, 10);
                g.DrawRectangle(pen, startPosX + 25, startPosY + 45, 39, 10);

                Brush spoiler = new SolidBrush(dopColor);

                g.FillRectangle(spoiler, startPosX + 25, startPosY - 5, 40, 10);
                g.FillRectangle(spoiler, startPosX + 25, startPosY + 45, 40, 10);

            }

            base.drawLiner(g);

            Brush br = new SolidBrush(dopColor);

            g.FillRectangle(br, startPosX + 65, startPosY + 15, 25, 5);
            g.FillRectangle(br, startPosX + 65, startPosY + 30, 25, 5);
            g.FillRectangle(br, startPosX + 25, startPosY + 15, 35, 5);


        }

    }
}