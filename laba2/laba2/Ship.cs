//5
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Ship : WaterTrans//переделать на шип
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {

                if (value > 0 && value < 300)
                {

                    base.MaxSpeed = value;
                }

                else
                {
                    base.MaxSpeed = 120;
                }

            }


        }
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }
            protected set
            {
                if (value > 0 && value < 50) //у меня маленький кораблик
                {

                    base.MaxCountPassengers = value;
                }

                else
                {

                    base.MaxCountPassengers = 40;
                }

            }

        }
        public override float MaxWaterLine
        {
            get
            {
                return base.MaxWaterLine;
            }

            protected set
            {
                if (value > 0 && value < 6) //у меня маленький кораблик
                {

                    base.MaxWaterLine = value;
                }

                else
                {

                    base.MaxWaterLine = 7;
                }
            }
        }
        

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {

                if (value > 50 && value < 100) //в тыс. тонн
                {

                    base.Weight = value;
                }

                else
                {

                    base.Weight = 80;

                }
            }
        }
        public Ship(int maxSpeed, int maxCountPassenger, double weight, Color color)
        {

            this.MaxSpeed = maxSpeed;

            this.MaxCountPassengers = maxCountPassenger;

            this.ColorBody = color;

            this.Weight = weight;

            this.countPassengers = 0;
            this.MaxWaterLine = 6;
            Random rand = new Random();

            startPosX = rand.Next(10, 200);

            startPosY = rand.Next(10, 200);
        }
        public Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
            }
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
      

        public override void moveShip(Graphics g)
        {

            startPosX += (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
            drawLiner(g);

        }

        public override void drawShip(Graphics g)
        {
            drawLiner(g);
        }
        protected virtual void drawLiner(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //g.DrawEllipse(pen, startPosX + 70, startPosY + 30, 20, 20);
            //корпус
            PointF[] corpus = {
                new PointF(startPosX + 10 , startPosY + 100),
                new PointF(startPosX + 5 , startPosY + 75),
                new PointF(startPosX + 85 , startPosY + 75),
                new PointF(startPosX + 75 , startPosY + 100)
            };
            Brush main_color = new SolidBrush(ColorBody);
            g.FillPolygon(main_color, corpus);
            g.DrawPolygon(pen, corpus);

            //кабина
            PointF[] cabin = {
                new PointF(startPosX + 15 , startPosY + 75),
                new PointF(startPosX + 15 , startPosY + 40),
                new PointF(startPosX + 55 , startPosY + 40),
                new PointF(startPosX + 70 , startPosY + 75)
            };
            g.DrawPolygon(pen, cabin);

            //труба
            PointF[] truba = {
                new PointF(startPosX + 20 , startPosY + 40),
                new PointF(startPosX + 20 , startPosY + 15),
                new PointF(startPosX + 30 , startPosY + 15),
                new PointF(startPosX + 30 , startPosY + 40)
            };

            g.DrawPolygon(pen, truba);

            Brush brRed = new SolidBrush(Color.Red);
           // g.FillEllipse(brRed, startPosX, startPosY, 20, 20);
           // g.FillEllipse(brRed, startPosX, startPosY + 30, 20, 20);
            
        }
        public override string GetInfo()
    {
        return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name;
    }
}
    

}
