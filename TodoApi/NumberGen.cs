using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksTextsSplit
{
    public interface INumberGen {
        int GetNumber();
    }
    public class NumberGen : INumberGen
    {
        public int GetNumber()
        {
            return new Random().Next();
        }
    }
}
