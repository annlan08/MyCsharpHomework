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
    public partial class Form_第八題_計算機 : Form
    {
        public Form_第八題_計算機()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MATH_CLASS MC = new MATH_CLASS();
            double answer = MC.simble(1, textBox1.Text, textBox2.Text);
            ANS.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MATH_CLASS MC = new MATH_CLASS();
            double answer = MC.simble(2, textBox1.Text, textBox2.Text);
            ANS.Text = answer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MATH_CLASS MC = new MATH_CLASS();
            double answer = MC.simble(3, textBox1.Text, textBox2.Text);
            ANS.Text = answer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MATH_CLASS MC = new MATH_CLASS();
            double answer = Math.Round(MC.simble(4, textBox1.Text, textBox2.Text), 4);
            ANS.Text = answer.ToString();
        }
    }
}
