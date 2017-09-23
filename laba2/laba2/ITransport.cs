using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITransport
{
    void moveLiner(Graphics g);

    void drawLiner(Graphics g);

    void setPosition(int x, int y);

    void loadPassenger(int count);

    int getPassenger();
}