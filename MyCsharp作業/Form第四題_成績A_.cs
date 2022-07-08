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
    public partial class Form第四題_成績A_ : Form
    {
        public Form第四題_成績A_()
        {
            InitializeComponent();
        }

        string[] arr_名稱 = new string[4] { "姓名", "國文", "英文", "數學" };
        string[] arr_成績 = new string[4] { "0", "0", "0", "0" };

        private void button_儲存_Click(object sender, EventArgs e)
        {
            arr_成績[0] = textBox_姓名.Text;
            arr_成績[1] = textBox_國文.Text;
            arr_成績[2] = textBox_英文.Text;
            arr_成績[3] = textBox_數學.Text;
        }

        private void button_顯示儲存_Click(object sender, EventArgs e)
        {
            label_show.Text = string.Empty;         //清空表單
            for (int i = 0; i < 4; i++)
            {
                label_show.Text += (arr_名稱[i] + " " + arr_成績[i] + " \n");
            }
        }

        private void button_MAXMIN_Click(object sender, EventArgs e)
        {
            int[] arr_num = new int[3] { 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                arr_num[i] = Convert.ToInt32(arr_成績[i + 1]);
            }

            int num_MAX, num_min;
            string text_MAX, text_min;
            num_min = num_MAX = arr_num[0];
            text_MAX = text_min = arr_名稱[1];

            for (int i = 0; i < 3; i++)
            {
                if (arr_num[i] > num_MAX)
                {
                    num_MAX = arr_num[i];
                    text_MAX = arr_名稱[i + 1];
                }

                if (arr_num[i] < num_min)
                {
                    num_min = arr_num[i];
                    text_min = arr_名稱[i + 1];
                }
            }

            label_maxmin.Text = "最大值 : " + text_MAX + "為 : " + num_MAX + "分" + "\n"
                              + "最小值 : " + text_min + "為 : " + num_min + "分";

        }

        private void Form第四題_成績A__Load(object sender, EventArgs e)
        {
            textBox_姓名.Text = "0";
            textBox_國文.Text = "0";
            textBox_英文.Text = "0";
            textBox_數學.Text = "0";
        }
    }
}
