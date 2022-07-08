using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp作業
{
    class MATH_CLASS
    {
        public double simble(int F, string T_A, string T_B)
        {
            double sum = 0;
            double a = double.Parse(T_A);
            double b = double.Parse(T_B);
            switch (F)
            {
                case 1:
                    sum = a + b;
                    break;
                case 2:
                    sum = a - b;
                    break;
                case 3:
                    sum = a * b;
                    break;
                case 4:
                    sum = a / b;
                    break;

            }
            return sum;
        }
    }
}
