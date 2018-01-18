using System;

using System.Data;
class Pan
{
    private RedVine[] redVine;
    private Sugar sugar;
    private Spices spices;
    private Lemon[] lemons;

    public bool ReadyToGO
    {
        get { return Check(); }
    }
    public void Init(int CountVine, int CountLemons)
    {
        redVine = new RedVine[CountVine];
        lemons = new Lemon[CountLemons];
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
    public void AddLemon(Lemon l)
    {
        for (int i = 0; i < lemons.Length; ++i)
        {
            if (lemons[i] == null)
            {
                lemons[i] = l;
                return;
            }
        }
    }
    //для приправ и сахара добавить методы
    public void AddSugar(Sugar s)
    {
        sugar = s; 
    }
    public void AddSpice(Spices s)
    {
        spices = s;
    }
    private bool Check()
    {
        if (sugar == null) {
            return false;
        }
        if (spices == null)
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
                    case 1: flag = true; break;
                    case 2: flag = true; break;
                    case 3: flag = true; break;
                    case 4: flag = true; break;
                    case 5: flag = true; break;
                    case 6: flag = true; break;
                    case 7: flag = true; break;
                    case 8: flag = true; break;
                    case 9: flag = true; break;
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
    public RedVine[] GetVine()
    {
        return redVine;
    }
}
