using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp作業
{
    class Class_Grade_B
    {
        public string function_顯示(string[] arr,       /*-----輸入資料,科目數-----*/
                            int T, decimal A,
                            int MAX_N, string MAX_S,
                            int min_N, string min_S)
        {
            string showText = string.Empty;
            /*-------------------------顯示輸入資料-----------------------------*/
            const int W = 6;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    showText += $"{arr[i],W}";
                }
                else if (i == 0)
                {
                    showText += $"{arr[i],-4}";
                }
            }
            showText += $"{T,W}";
            showText += $"{A,W}";
            showText += $"{(MAX_S + MAX_N),W}";
            showText += $"{(min_S + min_N),W}";
            showText += "\n";
            return showText;
        }
        public int function_總和(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }
        public decimal function_平均(int T, int C)
        {
            return Convert.ToDecimal(T) / Convert.ToDecimal(C);
        }
        public int[] function_最大(int[] arr)
        {
            int MAX_num = arr[0];
            int MAX_class = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= MAX_num)
                {
                    MAX_num = arr[i];
                    MAX_class = i;
                }
            }
            int[] arr_MAX = new int[2] { MAX_num, MAX_class };
            return arr_MAX;
        }
        public int[] function_最小(int[] arr)
        {
            int min_num = arr[0];
            int min_class = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= min_num)
                {
                    min_num = arr[i];
                    min_class = i;
                }
            }
            int[] arr_min = new int[2] { min_num, min_class };
            return arr_min;
        }
    }
}
