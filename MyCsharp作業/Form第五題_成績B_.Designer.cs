
namespace MyCsharp作業
{
    partial class Form第五題_成績B_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_大表單 = new System.Windows.Forms.SplitContainer();
            this.label_表格 = new System.Windows.Forms.Label();
            this.label_統計表單 = new System.Windows.Forms.Label();
            this.button_隨機加入20筆 = new System.Windows.Forms.Button();
            this.button_重設所有資料 = new System.Windows.Forms.Button();
            this.button_各科統計 = new System.Windows.Forms.Button();
            this.button_隨機儲存資料 = new System.Windows.Forms.Button();
            this.button_加入學生資料 = new System.Windows.Forms.Button();
            this.textBox_數學 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_英文 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_國文 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_姓名 = new System.Windows.Forms.TextBox();
            this.label_姓名 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.label_大表單)).BeginInit();
            this.label_大表單.Panel1.SuspendLayout();
            this.label_大表單.Panel2.SuspendLayout();
            this.label_大表單.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_大表單
            // 
            this.label_大表單.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_大表單.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_大表單.Location = new System.Drawing.Point(285, 30);
            this.label_大表單.Name = "label_大表單";
            this.label_大表單.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // label_大表單.Panel1
            // 
            this.label_大表單.Panel1.AutoScroll = true;
            this.label_大表單.Panel1.Controls.Add(this.label_表格);
            // 
            // label_大表單.Panel2
            // 
            this.label_大表單.Panel2.Controls.Add(this.label_統計表單);
            this.label_大表單.Size = new System.Drawing.Size(458, 371);
            this.label_大表單.SplitterDistance = 253;
            this.label_大表單.TabIndex = 29;
            // 
            // label_表格
            // 
            this.label_表格.AutoSize = true;
            this.label_表格.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_表格.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_表格.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_表格.Location = new System.Drawing.Point(3, 3);
            this.label_表格.Name = "label_表格";
            this.label_表格.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_表格.Size = new System.Drawing.Size(0, 16);
            this.label_表格.TabIndex = 9;
            // 
            // label_統計表單
            // 
            this.label_統計表單.AutoSize = true;
            this.label_統計表單.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_統計表單.Location = new System.Drawing.Point(4, 7);
            this.label_統計表單.Name = "label_統計表單";
            this.label_統計表單.Size = new System.Drawing.Size(0, 16);
            this.label_統計表單.TabIndex = 0;
            // 
            // button_隨機加入20筆
            // 
            this.button_隨機加入20筆.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_隨機加入20筆.Location = new System.Drawing.Point(20, 365);
            this.button_隨機加入20筆.Name = "button_隨機加入20筆";
            this.button_隨機加入20筆.Size = new System.Drawing.Size(114, 28);
            this.button_隨機加入20筆.TabIndex = 28;
            this.button_隨機加入20筆.Text = "隨機加入20筆";
            this.button_隨機加入20筆.UseVisualStyleBackColor = true;
            this.button_隨機加入20筆.Click += new System.EventHandler(this.button_隨機加入20筆_Click);
            // 
            // button_重設所有資料
            // 
            this.button_重設所有資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_重設所有資料.Location = new System.Drawing.Point(20, 331);
            this.button_重設所有資料.Name = "button_重設所有資料";
            this.button_重設所有資料.Size = new System.Drawing.Size(114, 28);
            this.button_重設所有資料.TabIndex = 27;
            this.button_重設所有資料.Text = "重設所有資料";
            this.button_重設所有資料.UseVisualStyleBackColor = true;
            this.button_重設所有資料.Click += new System.EventHandler(this.button_重設所有資料_Click);
            // 
            // button_各科統計
            // 
            this.button_各科統計.Enabled = false;
            this.button_各科統計.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_各科統計.Location = new System.Drawing.Point(20, 281);
            this.button_各科統計.Name = "button_各科統計";
            this.button_各科統計.Size = new System.Drawing.Size(114, 28);
            this.button_各科統計.TabIndex = 26;
            this.button_各科統計.Text = "各科統計";
            this.button_各科統計.UseVisualStyleBackColor = true;
            this.button_各科統計.Click += new System.EventHandler(this.button_各科統計_Click);
            // 
            // button_隨機儲存資料
            // 
            this.button_隨機儲存資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_隨機儲存資料.Location = new System.Drawing.Point(20, 247);
            this.button_隨機儲存資料.Name = "button_隨機儲存資料";
            this.button_隨機儲存資料.Size = new System.Drawing.Size(114, 28);
            this.button_隨機儲存資料.TabIndex = 25;
            this.button_隨機儲存資料.Text = "隨機儲存資料";
            this.button_隨機儲存資料.UseVisualStyleBackColor = true;
            this.button_隨機儲存資料.Click += new System.EventHandler(this.button_隨機儲存資料_Click);
            // 
            // button_加入學生資料
            // 
            this.button_加入學生資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_加入學生資料.Location = new System.Drawing.Point(20, 213);
            this.button_加入學生資料.Name = "button_加入學生資料";
            this.button_加入學生資料.Size = new System.Drawing.Size(114, 28);
            this.button_加入學生資料.TabIndex = 24;
            this.button_加入學生資料.Text = "加入學生資料";
            this.button_加入學生資料.UseVisualStyleBackColor = true;
            this.button_加入學生資料.Click += new System.EventHandler(this.button_加入學生資料_Click);
            // 
            // textBox_數學
            // 
            this.textBox_數學.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_數學.Location = new System.Drawing.Point(82, 177);
            this.textBox_數學.Name = "textBox_數學";
            this.textBox_數學.Size = new System.Drawing.Size(96, 30);
            this.textBox_數學.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "數學";
            // 
            // textBox_英文
            // 
            this.textBox_英文.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_英文.Location = new System.Drawing.Point(82, 130);
            this.textBox_英文.Name = "textBox_英文";
            this.textBox_英文.Size = new System.Drawing.Size(96, 30);
            this.textBox_英文.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "英文";
            // 
            // textBox_國文
            // 
            this.textBox_國文.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_國文.Location = new System.Drawing.Point(82, 79);
            this.textBox_國文.Name = "textBox_國文";
            this.textBox_國文.Size = new System.Drawing.Size(96, 30);
            this.textBox_國文.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "國文";
            // 
            // textBox_姓名
            // 
            this.textBox_姓名.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_姓名.Location = new System.Drawing.Point(82, 30);
            this.textBox_姓名.Name = "textBox_姓名";
            this.textBox_姓名.Size = new System.Drawing.Size(96, 30);
            this.textBox_姓名.TabIndex = 17;
            // 
            // label_姓名
            // 
            this.label_姓名.AutoSize = true;
            this.label_姓名.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_姓名.Location = new System.Drawing.Point(14, 30);
            this.label_姓名.Name = "label_姓名";
            this.label_姓名.Size = new System.Drawing.Size(62, 31);
            this.label_姓名.TabIndex = 16;
            this.label_姓名.Text = "姓名";
            // 
            // Form第五題_成績B_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_大表單);
            this.Controls.Add(this.button_隨機加入20筆);
            this.Controls.Add(this.button_重設所有資料);
            this.Controls.Add(this.button_各科統計);
            this.Controls.Add(this.button_隨機儲存資料);
            this.Controls.Add(this.button_加入學生資料);
            this.Controls.Add(this.textBox_數學);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_英文);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_國文);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_姓名);
            this.Controls.Add(this.label_姓名);
            this.Name = "Form第五題_成績B_";
            this.Text = "Form第四題_成績B_";
            this.Load += new System.EventHandler(this.Form第五題_成績B__Load);
            this.label_大表單.Panel1.ResumeLayout(false);
            this.label_大表單.Panel1.PerformLayout();
            this.label_大表單.Panel2.ResumeLayout(false);
            this.label_大表單.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label_大表單)).EndInit();
            this.label_大表單.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer label_大表單;
        private System.Windows.Forms.Label label_表格;
        private System.Windows.Forms.Label label_統計表單;
        private System.Windows.Forms.Button button_隨機加入20筆;
        private System.Windows.Forms.Button button_重設所有資料;
        private System.Windows.Forms.Button button_各科統計;
        private System.Windows.Forms.Button button_隨機儲存資料;
        private System.Windows.Forms.Button button_加入學生資料;
        private System.Windows.Forms.TextBox textBox_數學;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_英文;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_國文;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_姓名;
        private System.Windows.Forms.Label label_姓名;
    }
}