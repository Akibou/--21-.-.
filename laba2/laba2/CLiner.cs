using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class CLiner : Ship//переделать на шип
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

                    base.MaxCountPassengers = 4;
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
        public CLiner(int maxSpeed, int maxCountPassenger, double weight, Color color)
        {

            this.MaxSpeed = maxSpeed;

            this.MaxCountPassengers = maxCountPassenger;

            this.ColorBody = color;

            this.Weight = weight;

            this.countPassengers = 0;

            Random rand = new Random();

            startPosX = rand.Next(10, 200);

            startPosY = rand.Next(10, 200);
        }
        public override void moveLiner(Graphics g)
        {

            startPosX += (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
            drawLiner(g);

        }

        public override void drawLiner(Graphics g)
        {

            drawShip(g);
        }
        protected virtual void drawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawEllipse(pen, startPosX, startPosY, 20, 20);
            g.DrawEllipse(pen, startPosX, startPosY + 30, 20, 20);
            g.DrawEllipse(pen, startPosX + 70, startPosY, 20, 20);
            g.DrawEllipse(pen, startPosX + 70, startPosY + 30, 20, 20);
            g.DrawRectangle(pen, startPosX - 1, startPosY + 10, 10, 30);
            g.DrawRectangle(pen, startPosX + 80, startPosY + 10, 10, 30);
            g.DrawRectangle(pen, startPosX + 10, startPosY - 1, 70, 52);

            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, startPosX, startPosY, 20, 20);
            g.FillEllipse(brRed, startPosX, startPosY + 30, 20, 20);
            
        }
}

    }
