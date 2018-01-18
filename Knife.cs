using System;
using System.Data;


class Knife
{
    public void Clean(Lemon l)
    {
        if (l.Have_skin)
        {
            l.Have_skin = false;
        }
    }
    public void Slice(Lemon l)
    {
        if (l.sliced == false)
        {
            l.sliced = true;
        }
    }
}
