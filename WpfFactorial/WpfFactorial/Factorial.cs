using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFactorial
{
    public class Factorial
    {
        public int DoCalc(int number)
        {
            var fact = 1;
            if (number == 0)
                return fact;
            for(var i = number; i>0;i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
