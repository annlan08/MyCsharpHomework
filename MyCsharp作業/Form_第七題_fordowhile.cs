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
    public partial class Form_第七題_fordowhile : Form
    {
        public Form_第七題_fordowhile()
        {
            InitializeComponent();
        }

        Class_FoDoWhile CF = new Class_FoDoWhile();
        List<int> list_int = new List<int>();
        List<string> list_string = new List<string>();

        private void button_基數或偶數_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.function_奇偶數(Convert.ToInt32(textBox_基偶數.Text));
        }

        private void button_聖誕樹_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.function_聖誕樹(textBox_聖誕樹.Text);
        }

        private void button_九九乘法_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.function_九九乘法();
        }

        private void button_中心是1_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.SHOW_2D_ARR_中心是1();
        }

        private void button_中心是0_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.SHOW_2D_ARR_中心是0();
        }

        private void button_相鄰_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.SHOW_2D_ARR_1010();
        }

        private void button_加入數字_Click(object sender, EventArgs e)
        {
            list_int.Add(Convert.ToInt32(textBox_數字.Text));
            label_儲存數字.Text += $"[{list_int.Count - 1}] : {textBox_數字.Text} \n";
        }

        private void button_大小_Click(object sender, EventArgs e)
        {
            if (list_int.Count > 0)
            {
                CF.function_arr_計算(list_int, out int sum, out int Max, out int min);
                label_顯示.Text = $"array最大值 :{Max}\n"
                                + $"array最小值 :{min}";
            }
        }

        private void button_總和_Click(object sender, EventArgs e)
        {
            if (list_int.Count > 0)
            {
                CF.function_arr_計算(list_int, out int sum, out int Max, out int min);
                label_顯示.Text = $"array總和 :{sum}";
            }
        }

        private void button_刪除_數字_Click(object sender, EventArgs e)
        {
            list_int.Clear();
            label_儲存數字.Text = string.Empty;
        }

        private void button_加入字串_Click(object sender, EventArgs e)
        {
            list_string.Add(textBox_字串.Text);
            label_儲存字串.Text += $"[{list_string.Count - 1}] : {textBox_字串.Text}\n";
        }

        private void button_最長字串_Click(object sender, EventArgs e)
        {
            if (list_string.Count > 0)
            {
                label_顯示.Text = "最常字串 : " + CF.function_最長字串(list_string);
            }

        }

        private void button_尋找字元_Click(object sender, EventArgs e)
        {
            string T = "";
            for (int i = 0; i < list_string.Count; i++)
            {
                T += list_string[i];
            }

            if (T != "")
                label_顯示.Text = $"{Convert.ToChar(textBox_字元.Text)}字元不分大小寫共有" +
                                  $"{CF.function_找字元(T, Convert.ToChar(textBox_字元.Text))}";
        }

        private void button_刪除字串_Click(object sender, EventArgs e)
        {
            list_string.Clear();
            label_儲存字串.Text = string.Empty;
        }

        private void button_SWAP_Click(object sender, EventArgs e)
        {
            string a = textBox_SWAP_a.Text;
            string b = textBox_SWAP_b.Text;
            CF.function_swap(ref a, ref b);
            textBox_SWAP_a.Text = a;
            textBox_SWAP_b.Text = b;
        }

        private void button_樂透_Click(object sender, EventArgs e)
        {
            label_顯示.Text = string.Empty;
            int[] arr = CF.function_樂透(Convert.ToInt32(textBox_樂透.Text));
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                {
                    label_顯示.Text += $"{i + 1} ";
                }
            }
        }

        private void button_二進位_Click(object sender, EventArgs e)
        {
            label_顯示.Text = CF.function_二進位(Convert.ToInt32(textBox_二進位.Text));
        }

        private void button_清除_Click(object sender, EventArgs e)
        {
            label_顯示.Text = string.Empty;
        }
    }
}
