using System;
using System.Data;

class Fire
{
    private Pan pan;
    public bool State
    {
        set; get;
    }
    public Pan Pan
    {
        set
        {
            pan = value;
        }
        get
        {
            return pan;
        }
    }
    public void Cook()
    {
        if (State)
        {
            while (!pan.IsReady())
            {
                pan.GetHeat;
            }
        }
    }
}
