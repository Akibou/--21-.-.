using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class CruiseLiner : Ship
    //добавить отличия, кот нет у судна
    {
        private bool BorderLine;
        private bool TopLine;
        private bool RoundLine;
        private Color dopColor;

        public CruiseLiner(int maxSpeed,
                           int maxCountPassenget,
                           double weight,
                           Color color,
                           bool BorderLine,
                           bool TopLine,
                           bool RoundLine,
                           Color dopColor) : base(maxSpeed, maxCountPassenget, weight, color)

        {

            this.BorderLine = BorderLine;
            this.TopLine = TopLine;
            this.RoundLine = RoundLine;
            this.dopColor = dopColor;

        }

        protected override void drawLiner(Graphics g)
        {

            base.drawLiner(g);
            Brush dop_color = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Black);

            if (BorderLine)
            {
                //Боковая линия
                PointF[] border_line = {
                    new PointF(startPosX + 5 , startPosY +75),
                    new PointF(startPosX + 85 , startPosY + 75),
                    new PointF(startPosX + 80 , startPosY + 90),
                    new PointF(startPosX + 7 , startPosY + 90)
                };

                g.FillPolygon(dop_color, border_line);
                g.DrawPolygon(pen, border_line);

            }
            if (TopLine)
            {
                //Линия на трубе
                PointF[] top_line = {
                    new PointF(startPosX + 20 , startPosY + 17),
                    new PointF(startPosX + 20 , startPosY + 23),
                    new PointF(startPosX + 30 , startPosY + 23),
                    new PointF(startPosX + 30 , startPosY + 17)
                };

                g.FillPolygon(dop_color, top_line);
                g.DrawPolygon(pen, top_line);
            }
            if (RoundLine)
            {
                g.FillEllipse(dop_color, startPosX + 20, startPosY + 70, 15, -15);
                g.DrawEllipse(pen, startPosX + 20, startPosY + 70, 15, -15);
            }



        }

    }
}