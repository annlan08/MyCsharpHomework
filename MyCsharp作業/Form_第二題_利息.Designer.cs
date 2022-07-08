
namespace MyCsharp作業
{
    partial class Form_第二題_利息
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
            this.button_回報 = new System.Windows.Forms.Button();
            this.price_total = new System.Windows.Forms.Button();
            this.price_month = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_head = new System.Windows.Forms.TextBox();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_回報
            // 
            this.button_回報.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_回報.Location = new System.Drawing.Point(282, 308);
            this.button_回報.Name = "button_回報";
            this.button_回報.Size = new System.Drawing.Size(119, 40);
            this.button_回報.TabIndex = 21;
            this.button_回報.Text = "回報";
            this.button_回報.UseVisualStyleBackColor = true;
            this.button_回報.Click += new System.EventHandler(this.button_回報_Click);
            // 
            // price_total
            // 
            this.price_total.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price_total.Location = new System.Drawing.Point(157, 308);
            this.price_total.Name = "price_total";
            this.price_total.Size = new System.Drawing.Size(119, 40);
            this.price_total.TabIndex = 20;
            this.price_total.Text = "總金額";
            this.price_total.UseVisualStyleBackColor = true;
            this.price_total.Click += new System.EventHandler(this.price_total_Click);
            // 
            // price_month
            // 
            this.price_month.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price_month.Location = new System.Drawing.Point(32, 308);
            this.price_month.Name = "price_month";
            this.price_month.Size = new System.Drawing.Size(119, 40);
            this.price_month.TabIndex = 19;
            this.price_month.Text = "月繳";
            this.price_month.UseVisualStyleBackColor = true;
            this.price_month.Click += new System.EventHandler(this.price_month_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "頭期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "利率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "年期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "金額";
            // 
            // textBox_head
            // 
            this.textBox_head.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_head.Location = new System.Drawing.Point(146, 215);
            this.textBox_head.Name = "textBox_head";
            this.textBox_head.Size = new System.Drawing.Size(100, 33);
            this.textBox_head.TabIndex = 14;
            this.textBox_head.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_rate
            // 
            this.textBox_rate.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_rate.Location = new System.Drawing.Point(146, 154);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(100, 33);
            this.textBox_rate.TabIndex = 13;
            this.textBox_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_year
            // 
            this.textBox_year.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_year.Location = new System.Drawing.Point(146, 94);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(100, 33);
            this.textBox_year.TabIndex = 12;
            this.textBox_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_money
            // 
            this.textBox_money.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_money.Location = new System.Drawing.Point(146, 38);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(100, 33);
            this.textBox_money.TabIndex = 11;
            this.textBox_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_第二題_利息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_回報);
            this.Controls.Add(this.price_total);
            this.Controls.Add(this.price_month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_head);
            this.Controls.Add(this.textBox_rate);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_money);
            this.Name = "Form_第二題_利息";
            this.Text = "Form_第二題_利息";
            this.Load += new System.EventHandler(this.Form_第二題_利息_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_回報;
        private System.Windows.Forms.Button price_total;
        private System.Windows.Forms.Button price_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_head;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_money;
    }
}