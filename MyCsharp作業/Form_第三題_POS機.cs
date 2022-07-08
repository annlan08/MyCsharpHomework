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
    public partial class Form_第三題_POS機 : Form
    {
        public Form_第三題_POS機()
        {
            InitializeComponent();
        }
        /*--------------------------------*/
        int total_price = 0;
        int count_A = 0;
        int count_B = 0;
        int count_C = 0;
        int count_D = 0;
        int price_A = 120;
        int price_B = 180;
        int price_C = 350;
        int price_D = 320;
        string List_A = string.Empty;
        string List_B = string.Empty;
        string List_C = string.Empty;
        string List_D = string.Empty;

        private void button_A_Click(object sender, EventArgs e)
        {
            total_price += price_A;
            Lab_totalmoney.Text = $"{total_price:c0}";
            count_A++;
            List_A = "啤酒 *" + count_A + " 共NT$" + price_A * count_A + "元" + "\n";
            label_表單.Text = List_A + List_B + List_C + List_D;
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            total_price += price_B;
            Lab_totalmoney.Text = "NT$" + total_price.ToString();
            count_B++;
            List_B = "龍舌蘭 *" + count_B + " 共NT$" + price_B * count_B + "元" + "\n";
            label_表單.Text = List_A + List_B + List_C + List_D;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            total_price += price_C;
            Lab_totalmoney.Text = "NT$" + total_price.ToString();
            count_C++;
            List_C = "威士忌 *" + count_C + " 共NT$" + price_C * count_C + "元" + "\n";
            label_表單.Text = List_A + List_B + List_C + List_D;
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            total_price += price_D;
            Lab_totalmoney.Text = $"{total_price:c0}";
            count_D++;
            List_D = $"紅酒 *{count_D}共{price_D * count_D:c0}元\n";
            label_表單.Text = List_A + List_B + List_C + List_D;
        }

        private void pay_money_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額 : " + total_price);
        }

        private void pay_card_Click(object sender, EventArgs e)
        {
            double off_price_double = total_price * 0.9;
            MessageBox.Show("總金額 : " + total_price + "\n折扣後 : " + Convert.ToInt32(off_price_double));

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            total_price = 0;
            count_A = 0;
            count_B = 0;
            count_C = 0;
            count_D = 0;
            List_A = List_B = List_C = List_D = string.Empty;
            Lab_totalmoney.Text = $"{total_price:c0}";
            label_表單.Text = "尚未點餐";
        }

        private void Form_第三題_POS機_Load(object sender, EventArgs e)
        {
            total_price = 0;
            Lab_totalmoney.Text = $"{total_price:c0}";
        }
        /*--------------------------------*/


    }
}
