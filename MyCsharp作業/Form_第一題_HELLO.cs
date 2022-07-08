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
    public partial class Form_第一題_HELLO : Form
    {
        public Form_第一題_HELLO()
        {
            InitializeComponent();
        }

        private void Form_第一題_HELLO_Load(object sender, EventArgs e)
        {
            Label_1.BackColor = Color.Transparent;  //讓背景消失
            Label_2.BackColor = Color.Transparent;
            Label_3.BackColor = Color.Transparent;
            Label_4.BackColor = Color.Transparent;
        }

        private void Hello_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,我是" + Text_Box_1.Text + "\n"
              + "英文名字是" + Text_Box_2.Text + "\n"
              + "性別是" + Text_Box_3.Text + "\n"
              + "星座是" + Text_Box_4.Text, "", MessageBoxButtons.OK);
        }

        private void Hi_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi,我是" + Text_Box_1.Text + "\n"
             + "英文名字是" + Text_Box_2.Text + "\n"
             + "性別是" + Text_Box_3.Text + "\n"
             + "星座是" + Text_Box_4.Text, "", MessageBoxButtons.OK);
        }
    }
}
