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
    public partial class Form_第二題_分頁 : Form
    {
        public Form_第二題_分頁()
        {
            InitializeComponent();
        }

        public void Show_Text(string a, string b, string c, int d, int e)
        {
            label_貨款金額.Text = a;
            label_期數.Text = b;
            label_利率.Text = c;
            label_月付款.Text = Convert.ToString(d);
            label_總金額.Text = Convert.ToString(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email 已寄出");
            MessageBox.Show("騙你的，其實沒有","呵呵",MessageBoxButtons.OK);
            this.Close();

        }
    }
}
