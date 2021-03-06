﻿//3
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public abstract class WaterTrans : ITransport

    {
        protected float startPosX;
        protected float startPosY;

        protected int countPassengers;


        public virtual int MaxCountPassengers
        {
            protected set; get;
        }
        public virtual float MaxWaterLine
        {
            protected set; get;
        }
        public virtual int MaxSpeed
        {
            protected set; get;
        }

        public Color ColorBody
        {
            protected set; get;
        }

        public virtual double Weight
        {
            protected set; get;
        }

       

        public abstract void moveShip(Graphics g);
        
        public abstract void drawShip(Graphics g);


        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void loadPassenger(int count)
        {

            if (countPassengers + count < MaxCountPassengers)
            {

                countPassengers += count;

            }
        }

        public int getPassenger()
        {

            int count = countPassengers;
            countPassengers = 0;
            return count;

        }

        public virtual void SetMainColor(Color color)
        {
            ColorBody = color;
        }
        public virtual void setDopColor(Color dopColor)
        {
            ColorBody = dopColor;
        }
        public virtual string GetInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name;
        }

    }
}
