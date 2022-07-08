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
    public partial class Form_GUESS_2 : Form
    {
        public Form_GUESS_2()
        {
            InitializeComponent();
        }
        private void Form_GUESS_2_Load(object sender, EventArgs e)
        {
            Form_GUESS_MAIN FM = (Form_GUESS_MAIN)this.Owner;
            FM.text_show(FM.Num_min, FM.Num_MAX);
        }
        private void button_Enter_Click(object sender, EventArgs e)
        {
            function_判斷(textBox_GUESS.Text);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void function_判斷(string txt)
        {
            Form_GUESS_MAIN FM = (Form_GUESS_MAIN)this.Owner;
            bool result = int.TryParse(txt, out int num_guess);
            if (!result || num_guess >= FM.Num_MAX || num_guess <= FM.Num_min)
            {
                MessageBox.Show($"請入{FM.Num_min}~{FM.Num_MAX}間的數字");
                textBox_GUESS.Clear();
            }
            else
            {
                if (num_guess > FM.Num_ans)
                {
                    FM.Num_MAX = num_guess;
                    /*---------------------*/
                    FM.text_show(FM.Num_min, FM.Num_MAX);
                }

                else if (num_guess < FM.Num_ans)
                {
                    FM.Num_min = num_guess;
                    /*---------------------*/
                    FM.text_show(FM.Num_min, FM.Num_MAX);
                }
                else
                {
                    MessageBox.Show("WIN");
                    function_清除();
                } //-----------勝利
            }
        }
        internal void function_清除()
        {
            Form_GUESS_MAIN FM = (Form_GUESS_MAIN)this.Owner;
            Random myObject = new Random();
            FM.Num_MAX = 100;
            FM.Num_min = 0;
            FM.text_show(FM.Num_min, FM.Num_MAX);
            FM.Num_ans = myObject.Next(0, 100);
            textBox_GUESS.Text = string.Empty;
        }


    }
}
