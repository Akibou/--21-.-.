using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Prichal
    {
        //код 4 лабораторной

        List<ClassArray<ITransport>> prichalStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 85;
        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }
        public Prichal(int countStages)
        {
            //как добавить эл-ты в список
            prichalStages = new List<ClassArray<ITransport>>();
            ClassArray<ITransport> ship;
            for (int i = 1; i<= countStages; i++)
            {
                ship = new ClassArray<ITransport>(countStages, null);
                prichalStages.Add(ship);
            }
            
        }

        public void LevelDown()
        {
            if (currentLevel + 1 < prichalStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelUp()
        {
            if (currentLevel >0)
            {
                currentLevel--;
            }
        }
        public int PutShipInPrichal(ITransport ship)
        {
            return prichalStages[currentLevel]+ship;
        }
        public ITransport GetShipInPrichal(int ticket)
        {
            return prichalStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {

            DrawMarking(g);

            for (int i = 0; i < countPlaces; i++)
            {

                var ship = prichalStages[currentLevel][i];
                if (ship != null)
                {

                    ship.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight - 15);
                    ship.drawShip(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {

            Pen pen = new Pen(Color.Black, 3);

            g.DrawString("L" + (currentLevel+1), new Font("Arial",30), new SolidBrush(Color.Blue),(countPlaces / 5)* placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);

            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {

                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                {
                    g.DrawString((i*5+j+1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue),i*placeSizeWidth+30,j*placeSizeHeight+20);
                }
                }
               
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }

        //код 3 лабораторой
        /*ClassArray<ITransport> prichal;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 85;
        public Prichal()
        {
            prichal = new ClassArray<ITransport>(countPlaces, null);
        }
        public int PutShipInPrichal(ITransport ship)
        {
            return prichal + ship;
        }
        public ITransport GetShipInPrichal(int ticket)
        {
            return prichal - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {

            DrawMarking(g);

            for (int i = 0; i < countPlaces; i++)
            {

                var ship = prichal.getObject(i);
                if (ship != null)
                {

                    ship.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight - 15);
                    ship.drawShip(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {

            Pen pen = new Pen(Color.Black, 3);

            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {

                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);

                }

                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 500);
            }
        }*/
    }
}