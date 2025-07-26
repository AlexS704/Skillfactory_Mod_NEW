using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ISummation
    {
        public double ValueSumm(double x, double y)
        {
            return x + y;
        }

    }
}
