using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class PrichalOverflowException : Exception
    {
        public PrichalOverflowException() : base("Нет свободных доков") { }
    }
    class PrichalIndexOutOfRangeException : Exception
    {
        public PrichalIndexOutOfRangeException() : base("Этот док не занят") { }
    }

    class DataErrorException : Exception
    {
        public DataErrorException() : base("Не те данные") { }
    }
    class PrichalAlreadyHaveException : Exception
    {
        public PrichalAlreadyHaveException() : base("Такой корабль уже есть") { }
    }
}
