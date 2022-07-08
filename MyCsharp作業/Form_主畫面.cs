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
    public partial class Form_主畫面 : Form
    {
        public Form_主畫面()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
 

            Form_第一題_HELLO F1 = new Form_第一題_HELLO();
            DialogResult result_1 = F1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_第二題_利息 F2 = new Form_第二題_利息();
            DialogResult result_2 = F2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_第三題_POS機 F3 = new Form_第三題_POS機();
            DialogResult result_3 = F3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form第四題_成績A_ F4 = new Form第四題_成績A_();
            DialogResult result_4 = F4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form第五題_成績B_ F5 = new Form第五題_成績B_();
            F5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_第七題_fordowhile F7 = new Form_第七題_fordowhile();
            F7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_第八題_計算機 F8 = new Form_第八題_計算機();
            DialogResult result_8 = F8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_GUESS_MAIN FG = new Form_GUESS_MAIN();
            FG.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_第十題_圈圈叉叉 F10 = new Form_第十題_圈圈叉叉();
            DialogResult result_10 = F10.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form_第十一題_保護視窗 F11 = new Form_第十一題_保護視窗();
            F11.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_時鐘 FT = new Form_時鐘();
            FT.ShowDialog();
        }
    }
}
