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
    public partial class Form_第十題_圈圈叉叉 : Form
    {
        public Form_第十題_圈圈叉叉()
        {
            InitializeComponent();
        }

        private string s_符號;
        private int count_回合數 = 0;
        bool[] arr_bool_圈圈 = new bool[9];
        bool[] arr_bool_叉叉 = new bool[9];
        bool[] arr_bool_暫存器 = new bool[9];
        bool[,] arr_bool_勝利方式 = { { true,true,true,false,false,false,false,false,false },
                                      { false,false,false,true,true,true,false,false,false },
                                      { false,false,false,false,false,false,true,true,true },
                                      { true,false,false,true,false,false,true,false,false },
                                      { false,true,false,false,true,false,false,true,false },
                                      { false,false,true,false,false,true,false,false,true },
                                      { true,false,false,false,true,false,false,false,true },
                                      { false,false,true,false,true,false,true,false,false } };

        private void button1_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button1.Text = s_符號;
            button1.Enabled = false;
            function_按鈕執行(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button2.Text = s_符號;
            button2.Enabled = false;
            function_按鈕執行(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button3.Text = s_符號;
            button3.Enabled = false;
            function_按鈕執行(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button4.Text = s_符號;
            button4.Enabled = false;
            function_按鈕執行(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button5.Text = s_符號;
            button5.Enabled = false;
            function_按鈕執行(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button6.Text = s_符號;
            button6.Enabled = false;
            function_按鈕執行(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button7.Text = s_符號;
            button7.Enabled = false;
            function_按鈕執行(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button8.Text = s_符號;
            button8.Enabled = false;
            function_按鈕執行(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count_回合數++;
            s_符號 = function_按鈕顯示(count_回合數);
            button9.Text = s_符號;
            button9.Enabled = false;
            function_按鈕執行(9);
        }

        private void function_清除()
        {
            button1.Text = string.Empty;
            button1.Enabled = true;
            button2.Text = string.Empty;
            button2.Enabled = true;
            button3.Text = string.Empty;
            button3.Enabled = true;
            button4.Text = string.Empty;
            button4.Enabled = true;
            button5.Text = string.Empty;
            button5.Enabled = true;
            button6.Text = string.Empty;
            button6.Enabled = true;
            button7.Text = string.Empty;
            button7.Enabled = true;
            button8.Text = string.Empty;
            button8.Enabled = true;
            button9.Text = string.Empty;
            button9.Enabled = true;
            for (int i = 0; i < 9; i++)
            {
                arr_bool_叉叉[i] = false;
                arr_bool_圈圈[i] = false;
            }
            count_回合數 = 0;
        }

        private void function_按鈕執行(int n)
        {
            bool result = (count_回合數 % 2 == 1 ? true : false);
            if (result)
            {
                arr_bool_圈圈[n - 1] = true;
                if (function_檢查勝利(arr_bool_圈圈))
                {
                    MessageBox.Show("O是贏家");
                    function_清除();
                }
                else
                {
                    function_檢查平手();
                }
            }
            else
            {
                arr_bool_叉叉[n - 1] = true;
                if (function_檢查勝利(arr_bool_叉叉))
                {
                    MessageBox.Show("X是贏家");
                    function_清除();
                }
                else
                {
                    function_檢查平手();
                }
            }
        }

        private string function_按鈕顯示(int c)
        {
            string result = (c % 2 == 1 ? "O" : "X");
            return result;
        }

        void function_檢查平手()
        {
            if (count_回合數 == 9)
            {
                MessageBox.Show("平手");
                function_清除();
            }
        }

        bool function_檢查勝利(bool[] arr)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr_bool_暫存器[j] = (arr[j] && arr_bool_勝利方式[i, j]);
                    if (arr_bool_暫存器[j] == arr_bool_勝利方式[i, j])
                    {
                        if (j == 8)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return false;
        }

        private void button_RESET_Click(object sender, EventArgs e)
        {
            function_清除();
        }

        private void button_離開_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
