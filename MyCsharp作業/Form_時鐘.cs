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
    public partial class Form_時鐘 : Form
    {
        public Form_時鐘()
        {
            InitializeComponent();
            button_關閉.Enabled = false;
            button_關閉.Visible = false;
            label_起.Visible = false;
            label_床.Visible = false;
        }

        bool flag = false;
        bool flag_鬧鐘到了 = false;
        int flag_color = 0;
        string[] time_存入時間 = { "00", "00", "00" };
        string time_鬧鈴時間 = string.Empty;
        string[] time_現在時間 = new string[3];

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
            time_現在時間 = label_time.Text.Split(' ');  //------->將時間拆成三個字串

            time_鬧鈴時間 = $"{time_存入時間[0]}:{time_存入時間[1]}:{time_存入時間[2]}";
            if (flag)
            {
                if (time_鬧鈴時間 == time_現在時間[2])
                {
                    button_關閉.Enabled = true;
                    button_關閉.Visible = true;
                    label_起.Visible = true;
                    label_床.Visible = true;
                    flag_鬧鐘到了 = true;
                }
            }
            if (flag_鬧鐘到了)
            {
                Random ran = new Random();
                flag_color = ran.Next(1, 6);
                switch (flag_color)
                {
                    case 1:
                        label_起.ForeColor = Color.Red;
                        label_床.ForeColor = Color.Green;
                        break;
                    case 2:
                        label_起.ForeColor = Color.Green;
                        label_床.ForeColor = Color.DarkSalmon;
                        break;
                    case 3:
                        label_起.ForeColor = Color.Yellow;
                        label_床.ForeColor = Color.LimeGreen;
                        break;
                    case 4:
                        label_起.ForeColor = Color.BurlyWood;
                        label_床.ForeColor = Color.Peru;
                        break;
                    case 5:
                        label_起.ForeColor = Color.DarkOrange;
                        label_床.ForeColor = Color.Red;
                        break;
                    default:
                        label_起.ForeColor = Color.AliceBlue;
                        break;
                }
            }
        }

        private void button_關閉_Click(object sender, EventArgs e)
        {
            button_關閉.Enabled = false;
            button_關閉.Visible = false;
            label_起.Visible = false;
            label_床.Visible = false;
            label_起.ForeColor = Color.Black;
            label_床.ForeColor = Color.Black;
            flag_鬧鐘到了 = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            flag = !flag;
        }

        private void comboBox_hr_SelectedIndexChanged(object sender, EventArgs e)
        {
            time_存入時間[0] = comboBox_hr.Text;
        }

        private void comboBox_min_SelectedIndexChanged(object sender, EventArgs e)
        {
            time_存入時間[1] = comboBox_min.Text;
        }

        private void comboBox_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            time_存入時間[2] = comboBox_sec.Text;
        }
    }
}
