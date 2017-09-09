using System;

using System.Data;
class Pan
{
    private RedVine[] redVine;
    private Sugar[] sugar;

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

    private bool Check()
    {
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
        //для сахара добавить цикл
    }

    public void GetHeat()
    {
        if (!Check()) { return; }
        if (redVine.Length > 0)
        {
            if (has_ready < 10)
            {
                for (int i = 0; i < redVine.Length; i++)
                {
                    redVine.GetHeat();
                }
                bool flag = false;
                switch (redVine.has_ready)
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
            if (redVine.had_ready < 10)
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
