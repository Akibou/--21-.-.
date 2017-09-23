using System;

using System.Data;
class Pan
{
    private RedVine[] redVine;
    private Sugar sugar;

    public bool ReadyToGO
    {
        get { return Check(); }
    }
    public void Init(int CountVine)
    {
        redVine = new RedVine[CountVine];
        //линкануть со счетчиком
    }
    public void AddVine(RedVine v)
    {
        for (int i = 0; i < redVine.Length; ++i)
        {
            if (redVine[i] == null)
            {
                redVine[i] = v;
                return;
            }
        }
    }
    //для приправ и сахара добавить методы
    public void AddSugar(Sugar v)
    {
        sugar = v; 
    }
    private bool Check()
    {
        if (redVine.Length == 0)
        {
            return false;
        }
        if (redVine.Length == 0)
        {
            return false;
        }
        //для специй и сахара добавить счетчики

        for (int i = 0; i < redVine.Length; ++i)
        {
            if (redVine[i] == null)
            {
                return false;
            }
        }
        return true;
        //для сахара добавить цикл
    }

    public void GetHeat()
    {
        if (!Check()) { return; }
        if (redVine.Length > 0)
        {
            if (redVine[0].Has_ready < 10)
            {
                for (int i = 0; i < redVine.Length; i++)
                {
                    redVine[i].GetHeat();
                }
                bool flag = false;
                switch (redVine[0].Has_ready)
                {
                    case 10: flag = true; break;
                }

            }
        }
    }
    public bool IsReady()
    {
        for (int i = 0; i < redVine.Length; ++i)
        {
            if (redVine[i].Has_ready < 10)
            {
                return false;
            }
        }
        return true;
    }
    public RedVine[] Drain()
    {
        return redVine;
    }
}
