using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp作業
{
    class Class_FoDoWhile
    {
        public string function_聖誕樹(string T)
        {
            string s_1 = "";
            int point = 1;
            int row = Convert.ToInt32(T);

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < point; j++)
                {
                    s_1 += "*";
                }
                s_1 += "\n";
                point++;
            }

            return s_1;
        }

        public string function_九九乘法()
        {
            string T = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j < 9; j++)
                {
                    T += $"{j,5}*{i,2} ={j * i,3} |";
                }
                T += "\n";
            }

            return T;
        }

        public string function_奇偶數(int a)
        {
            return (a % 2 == 0 ? "偶數" : "奇數");
        }

        public string SHOW_2D_ARR_中心是0()
        {
            string show = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 9 == 0 || j % 9 == 0)
                    {
                        show += $" 1 ";
                    }
                    else
                    {
                        show += $" 0 ";
                    }
                }
                show += "\n";
            }

            return show;
        }

        public string SHOW_2D_ARR_中心是1()
        {
            string show = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 9 == 0 || j % 9 == 0)
                    {
                        show += $" 0 ";
                    }
                    else
                    {
                        show += $" 1 ";
                    }
                }
                show += "\n";
            }

            return show;
        }

        public string SHOW_2D_ARR_1010()
        {
            string show = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        show += $" 1 ";
                    }
                    else
                    {
                        show += $" 0 ";
                    }
                }
                show += "\n";
            }

            return show;
        }

        public int function_找字元(string T, char a)
        {
            char A = char.ToUpper(a);
            string[] e = T.Split(new char[2] { a, A });
            return (e.Length - 1);
        }

        public string function_最長字串(List<string> A)
        {
            string Max = A[0];
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i].Length >= Max.Length)
                {
                    Max = A[i];
                }
            }
            return Max;
        }

        public void function_swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public void function_arr_計算(List<int> arr, out int sum, out int Max, out int min)
        {
            sum = 0;
            Max = arr[0];
            min = arr[0];
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
                if (arr[i] > Max) { Max = arr[i]; }
                if (arr[i] < min) { min = arr[i]; }
            }
        }

        public int[] function_樂透(int n)  //------->你需要幾個數字
        {
            Random ran = new Random();

            int[] arr = new int[50];
            for (int i = 0; i < n;)
            {
                if (arr[ran.Next(0, 50)] != -1)
                {
                    arr[ran.Next(0, 50)] = -1;
                    i++;
                }
            }
            return arr;
        }

        public string function_二進位(int n)
        {
            List<int> M = new List<int>();
            for (; n != 0; n /= 2)
            {
                M.Add(n % 2 == 1 ? 1 : 0);
            }
            string s = string.Empty;
            for (int i = M.Count - 1; i >= 0; i--)
            {
                s += $"{M[i]} ";
            }
            return s;
        }

        public string CLEAR()
        {
            return string.Empty;
        }
    }
}
