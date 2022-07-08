
namespace MyCsharp作業
{
    partial class Form_第三題_POS機
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_B = new System.Windows.Forms.Button();
            this.button_A = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.label_表單 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.pay_card = new System.Windows.Forms.Button();
            this.pay_money = new System.Windows.Forms.Button();
            this.Lab_totalmoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_B);
            this.groupBox1.Controls.Add(this.button_A);
            this.groupBox1.Controls.Add(this.button_D);
            this.groupBox1.Controls.Add(this.button_C);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(11, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 345);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單";
            // 
            // button_B
            // 
            this.button_B.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_B.Location = new System.Drawing.Point(116, 35);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(75, 135);
            this.button_B.TabIndex = 1;
            this.button_B.Text = "TEQUILA 180";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // button_A
            // 
            this.button_A.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_A.Location = new System.Drawing.Point(20, 37);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(75, 133);
            this.button_A.TabIndex = 0;
            this.button_A.Text = "BEAR 120";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click);
            // 
            // button_D
            // 
            this.button_D.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_D.Location = new System.Drawing.Point(116, 185);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(75, 135);
            this.button_D.TabIndex = 3;
            this.button_D.Text = "WINE 320";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_C.Location = new System.Drawing.Point(20, 187);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 133);
            this.button_C.TabIndex = 2;
            this.button_C.Text = "WHISKY 350";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // label_表單
            // 
            this.label_表單.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_表單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_表單.Location = new System.Drawing.Point(553, 76);
            this.label_表單.Name = "label_表單";
            this.label_表單.Size = new System.Drawing.Size(236, 266);
            this.label_表單.TabIndex = 16;
            this.label_表單.Text = "尚未點餐";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_clear.Location = new System.Drawing.Point(597, 362);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(135, 47);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "清除";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // pay_card
            // 
            this.pay_card.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pay_card.Location = new System.Drawing.Point(404, 180);
            this.pay_card.Name = "pay_card";
            this.pay_card.Size = new System.Drawing.Size(119, 52);
            this.pay_card.TabIndex = 14;
            this.pay_card.Text = "信用卡";
            this.pay_card.UseVisualStyleBackColor = true;
            this.pay_card.Click += new System.EventHandler(this.pay_card_Click);
            // 
            // pay_money
            // 
            this.pay_money.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pay_money.Location = new System.Drawing.Point(270, 180);
            this.pay_money.Name = "pay_money";
            this.pay_money.Size = new System.Drawing.Size(119, 52);
            this.pay_money.TabIndex = 13;
            this.pay_money.Text = "現金";
            this.pay_money.UseVisualStyleBackColor = true;
            this.pay_money.Click += new System.EventHandler(this.pay_money_Click);
            // 
            // Lab_totalmoney
            // 
            this.Lab_totalmoney.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lab_totalmoney.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_totalmoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lab_totalmoney.Location = new System.Drawing.Point(304, 116);
            this.Lab_totalmoney.Name = "Lab_totalmoney";
            this.Lab_totalmoney.Size = new System.Drawing.Size(180, 41);
            this.Lab_totalmoney.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(385, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "信用卡享九折優惠";
            // 
            // Form_第三題_POS機
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_表單);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.pay_card);
            this.Controls.Add(this.pay_money);
            this.Controls.Add(this.Lab_totalmoney);
            this.Name = "Form_第三題_POS機";
            this.Text = "Form_第三題_POS機";
            this.Load += new System.EventHandler(this.Form_第三題_POS機_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Label label_表單;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button pay_card;
        private System.Windows.Forms.Button pay_money;
        private System.Windows.Forms.Label Lab_totalmoney;
        private System.Windows.Forms.Label label1;
    }
}