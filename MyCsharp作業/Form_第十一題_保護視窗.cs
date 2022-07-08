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
    public partial class Form_第十一題_保護視窗 : Form
    {
        public Form_第十一題_保護視窗()
        {
            InitializeComponent();
        }

        int flag_start = 0;
        int flag_方向;
        int x;
        int y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag_start == 0)
            {
                flag_start = 1;
                Random ran = new Random();
                /*------------------初始直---------------------*/
                this.label_圖片.Top = ran.Next(50, 200);
                this.label_圖片.Left = ran.Next(50, 200);
                flag_方向 = ran.Next(1, 5);

                this.Cursor = new Cursor(Cursor.Current.Handle);
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
                /*---------------------------------------------*/
            }

            if (this.label_圖片.Left <= 0 || this.label_圖片.Left >= this.Width - this.label_圖片.Width ||
                this.label_圖片.Top <= 0 || this.label_圖片.Top >= this.Height - this.label_圖片.Height)      // 彈到邊框，轉變方向
            {
                if (flag_方向 == 1)
                {
                    flag_方向 = 4;
                }
                else
                {
                    flag_方向--;
                }
            }

            switch (flag_方向)
            {
                case 1:
                    function_1_右下();
                    break;
                case 2:
                    function_2_右上();
                    break;
                case 3:
                    function_3_左上();
                    break;
                case 4:
                    function_4_左下();
                    break;
            }

            MoveCursor();

        }

        private void Form_第十一題_保護視窗_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        void function_1_右下()
        {
            this.label_圖片.Left++;
            this.label_圖片.Top++;
        }

        void function_2_右上()
        {
            this.label_圖片.Left++;
            this.label_圖片.Top--;
        }

        void function_3_左上()
        {
            this.label_圖片.Left--;
            this.label_圖片.Top--;
        }

        void function_4_左下()
        {
            this.label_圖片.Left--;
            this.label_圖片.Top++;
        }

         void MoveCursor()
        {
            if(Cursor.Position.X-x>50 || Cursor.Position.Y-y>50)
            this.Close();
        }
    }
}
