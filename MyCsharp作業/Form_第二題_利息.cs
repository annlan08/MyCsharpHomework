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
    public partial class Form_第二題_利息 : Form
    {
        public Form_第二題_利息()
        {
            InitializeComponent();
        }

        private int Pay_Month = 0;
        private int Pay_Total = 0;
        private int Count_Month = 0;

        private void price_month_Click(object sender, EventArgs e)
        {
            Class_利率 Cp = new Class_利率();
            Pay_Month = Cp.Bank(textBox_money.Text, textBox_year.Text, textBox_rate.Text, textBox_head.Text);
            MessageBox.Show($"月繳 : {Pay_Month}元");
        }

        private void price_total_Click(object sender, EventArgs e)
        {
            Class_利率 Cp = new Class_利率();
            Pay_Month = Cp.Bank(textBox_money.Text, textBox_year.Text, textBox_rate.Text, textBox_head.Text);
            Count_Month = Convert.ToInt32(textBox_year.Text) * 12;
            Pay_Total = Pay_Month * Count_Month;
            MessageBox.Show($"總金額 : {Pay_Total}元");
        }

        private void button_回報_Click(object sender, EventArgs e)
        {
            Class_利率 CP = new Class_利率();
            Pay_Month = CP.Bank(textBox_money.Text, textBox_year.Text, textBox_rate.Text, textBox_head.Text);
            Count_Month = Convert.ToInt32(textBox_year.Text) * 12;
            Pay_Total = Pay_Month * Count_Month;
            Form_第二題_分頁 f1 = new Form_第二題_分頁();
            f1.Show_Text(textBox_money.Text, textBox_year.Text, textBox_rate.Text, Pay_Month, Pay_Total);
            f1.Show(this);
        }

        private void Form_第二題_利息_Load(object sender, EventArgs e)
        {
            textBox_money.Text = "100000";
            textBox_year.Text = "2";
            textBox_rate.Text = "10";
            textBox_head.Text = "0";
            Class_利率 Cp = new Class_利率();
            Pay_Month = Cp.Bank(textBox_money.Text, textBox_year.Text, textBox_rate.Text, textBox_head.Text);
            Count_Month = Convert.ToInt32(textBox_year.Text) * 12;
            Pay_Total = Pay_Month * Count_Month;
        }
    }
}
