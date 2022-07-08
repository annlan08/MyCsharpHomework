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
    public partial class Form_GUESS_MAIN : Form
    {
        public Form_GUESS_MAIN()
        {
            InitializeComponent();
        }

        internal int Num_ans;
        internal int Num_MAX;
        internal int Num_min;

        public void text_show(int min, int MAX)
        {
            label_show.Text = $"Between{min}~{MAX}!";
        }

        private void Form_GUESS_MAIN_Load(object sender, EventArgs e)
        {
            Random myObject = new Random();
            Num_ans = myObject.Next(0, 100);
            Num_MAX = 100;
            Num_min = 0;
        }

        private void button_guess_Click(object sender, EventArgs e)
        {
            Form_GUESS_2 F2 = new Form_GUESS_2();
            F2.Owner = this;
            F2.ShowDialog();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ANSWER : {Num_ans}");
        }
    }
}
