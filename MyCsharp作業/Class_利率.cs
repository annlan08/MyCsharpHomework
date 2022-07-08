using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp作業
{
    class Class_利率
    {
        public int Bank(string M, string Y, string R, string H)
        {
            double Money = Convert.ToDouble(M);
            double Head = Convert.ToInt32(H);
            double rate = Convert.ToDouble(R) / 100;

            /*計算變數*/

            int month = Convert.ToInt32(Y) * 12;
            double m_rate = rate / 12;
            double First_money = Money - Head;
            double ATemp = 1;

            /*計算*/

            for (int i = 0; i < month; i++)
            {
                ATemp = (1 + m_rate) * ATemp;
            }

            int per_month = Convert.ToInt32(First_money * ((ATemp * m_rate) / (ATemp - 1)));
            return per_month;
        }
    }
}
