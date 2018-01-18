using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{

    public interface ITransport
    {
        void moveLiner(Graphics g);

        void drawLiner(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        int getPassenger();
    }
}