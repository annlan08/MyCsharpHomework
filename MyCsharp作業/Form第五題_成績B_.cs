using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCsharp作業
{
    public partial class Form第五題_成績B_ : Form
    {
        public Form第五題_成績B_()
        {
            InitializeComponent();
        }
        int[] arr_所有成績 = new int[100];
        int num_總分;
        decimal num_平均;
        int count_已加入的次數 = 0;
        const int w = 4;
        string first = $"{"姓名",-3}" + $"{"國文",w}" + $"{"英文",w}" + $"{"數學",w}"
                     + $"{"總和",w}" + $"{"平均",w}" + $"{"最低",w}" + $"{"最高",w}" + "\n";
        string[] arr_輸入資料 = new string[4];
        int[] arr_只取成績數值 = new int[3] { 0, 0, 0 };
        int[] arr_單人最高分 = new int[2];
        int[] arr_單人最低分 = new int[2];
        string[] arr_科目名稱和姓名 = new string[4] { "姓名", "國文", "英文", "數學" };
        string[] arr_科目名稱 = new string[3] { "國文", "英文", "數學" };
        /*---------------------------------------------*/
        int total_總人數 = 0;
        int[] total_最大值 = new int[3] { 0, 0, 0 };
        int[] total_最小值 = new int[3] { 100, 100, 100 };
        int[] total_總分 = new int[3] { 0, 0, 0 };
        /*---------------------------------------------*/
        private void Form第五題_成績B__Load(object sender, EventArgs e)
        {
            label_表格.Text = first;
        }

        private void button_加入學生資料_Click(object sender, EventArgs e)
        {
            count_已加入的次數++;
            arr_輸入資料[0] = textBox_姓名.Text;
            arr_輸入資料[1] = textBox_國文.Text;
            arr_輸入資料[2] = textBox_英文.Text;
            arr_輸入資料[3] = textBox_數學.Text;

            bool[] isNum = new bool[4];
            int[] a = new int[3];
            if (arr_輸入資料[0] != "")
            {
                isNum[0] = true;
            }

            for (int i = 1; i < arr_輸入資料.Length; i++)
            {
                isNum[i] = int.TryParse(arr_輸入資料[i], out a[i - 1]);
            }
            /*----------------------------------------------*/
            if (isNum[0] && isNum[1] && isNum[2] && isNum[3])
            {
                label_表格.Text += function_計算(arr_輸入資料);
                button_各科統計.Enabled = true;
            }
            /*----------------------------------------------*/
            else
            {
                function_輸入錯誤(isNum);
            }
        }

        private void button_隨機儲存資料_Click(object sender, EventArgs e)
        {
            count_已加入的次數++;
            Random ran = new Random();
            arr_輸入資料[0] = count_已加入的次數.ToString();
            arr_輸入資料[1] = ran.Next(0, 101).ToString();
            arr_輸入資料[2] = ran.Next(0, 101).ToString();
            arr_輸入資料[3] = ran.Next(0, 101).ToString();
            /*--------------------------------------------------*/
            label_表格.Text += function_計算(arr_輸入資料);
            button_各科統計.Enabled = true;
            /*--------------------------------------------------*/
        }

        private void button_各科統計_Click(object sender, EventArgs e)
        {
            button_加入學生資料.Enabled = false;
            button_隨機儲存資料.Enabled = false;
            button_隨機加入20筆.Enabled = false;
            button_各科統計.Enabled = false;
            string Line1 = $"{"總分",-3}";
            string Line2 = $"{"平均",-3}";
            string Line3 = $"{"最高",-3}";
            string Line4 = $"{"最低",-3}";
            decimal D_N = Convert.ToDecimal(total_總人數);
            decimal D_T;
            decimal D_A;

            const int w2 = 6;
            for (int i = 0; i < 3; i++)
            {
                Line1 += $"{total_總分[i],w2}";
                D_T = Convert.ToDecimal(total_總分[i]);
                D_A = Math.Round(D_T / D_N, 1);
                Line2 += $"{D_A,w2}";
                Line3 += $"{total_最大值[i],w2}";
                Line4 += $"{total_最小值[i],w2}";
            }

            label_統計表單.Text = Line1 + "\n" + Line2 + "\n" + Line3 + "\n" + Line4 + "\n";

        }

        private void button_重設所有資料_Click(object sender, EventArgs e)
        {
            label_表格.Text = first;
            label_統計表單.Text = string.Empty;
            count_已加入的次數 = 0;
            total_總人數 = 0;
            total_最大值 = new int[] { 0, 0, 0 };
            total_最小值 = new int[] { 100, 100, 100 };
            total_總分 = new int[3] { 0, 0, 0 };
            button_加入學生資料.Enabled = true;
            button_隨機儲存資料.Enabled = true;
            button_隨機加入20筆.Enabled = true;
            button_各科統計.Enabled = false;
        }

        private void button_隨機加入20筆_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int j = 0; j < 20; j++)
            {
                count_已加入的次數++;
                arr_輸入資料[0] = count_已加入的次數.ToString();
                arr_輸入資料[1] = ran.Next(0, 101).ToString();
                arr_輸入資料[2] = ran.Next(0, 101).ToString();
                arr_輸入資料[3] = ran.Next(0, 101).ToString();
                label_表格.Text += function_計算(arr_輸入資料);
                button_各科統計.Enabled = true;
            }
        }
        private string function_計算(string[] arr_in)
        {
            int[] arr_value = new int[arr_in.Length - 1];

            for (int i = 0; i < (arr_value.Length); i++)
            {
                arr_value[i] = Convert.ToInt32(arr_in[i + 1]);

                total_總分[i] += arr_value[i];

                if (arr_value[i] > total_最大值[i])
                {
                    total_最大值[i] = arr_value[i];
                }

                if (arr_value[i] < total_最小值[i])
                {
                    total_最小值[i] = arr_value[i];
                }
            }

            Class_Grade_B CG = new Class_Grade_B();
            num_總分 = CG.function_總和(arr_value);
            num_平均 = Math.Round(CG.function_平均(num_總分, arr_value.Length), 1);

            arr_單人最高分 = CG.function_最大(arr_value);
            arr_單人最低分 = CG.function_最小(arr_value);

            button_各科統計.Enabled = true;
            total_總人數++;

            string Show_Text = CG.function_顯示(arr_輸入資料,
                   num_總分, num_平均,
                   arr_單人最低分[0], arr_科目名稱[arr_單人最低分[1]],
                   arr_單人最高分[0], arr_科目名稱[arr_單人最高分[1]]);

            return Show_Text;

        }
        void function_輸入錯誤(bool[] arr_bool)
        {
            int flag = 0;
            if (arr_輸入資料[0] == "")
            {
                MessageBox.Show($"請重新輸入{arr_輸入資料[0]}資料");
                textBox_姓名.Focus();
            }
            else
            {
                for (int i = 1; i < arr_輸入資料.Length; i++)
                {
                    if (arr_bool[i] == false)
                    {
                        flag = i;
                        i = arr_輸入資料.Length;
                    }
                }

                switch (flag)
                {
                    case 1:
                        MessageBox.Show($"請重新輸入{arr_科目名稱[0]}資料");
                        textBox_國文.Clear();
                        textBox_國文.Focus();
                        break;
                    case 2:
                        MessageBox.Show($"請重新輸入{arr_科目名稱[1]}資料");
                        textBox_英文.Clear();
                        textBox_英文.Focus();
                        break;
                    case 3:
                        MessageBox.Show($"請重新輸入{arr_科目名稱[2]}資料");
                        textBox_數學.Clear();
                        textBox_數學.Focus();
                        break;
                }
            }
        }
    }
}
