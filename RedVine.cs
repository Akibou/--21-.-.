using System;
using System.Data;

class RedVine
{
    public double Count;
    private int has_ready = 0;
    public int Has_ready
    {
        get { return has_ready; }
    }
    public void GetHeat()
    {
        if (has_ready < 10)
        {
            has_ready++;
        }
    }
}