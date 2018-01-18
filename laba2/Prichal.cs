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
        ClassArray<ITransport> prichal;
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
        }
    }
}