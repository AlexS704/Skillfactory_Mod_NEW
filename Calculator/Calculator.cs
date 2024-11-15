using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator : ISummation
    {
        private double _x;
        private double _y;
        public Calculator(double x, double y)
        {
            SetX(x);
            SetY(y);            
        }

       
        
        double ISummation.ValueSumm(double x, double y) { return x + y; }
       
    }
}
