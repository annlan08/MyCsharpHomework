
namespace MyCsharp作業
{
    partial class Form第四題_成績A_
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
            this.label_maxmin = new System.Windows.Forms.Label();
            this.label_show = new System.Windows.Forms.Label();
            this.button_MAXMIN = new System.Windows.Forms.Button();
            this.button_顯示儲存 = new System.Windows.Forms.Button();
            this.button_儲存 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_數學 = new System.Windows.Forms.TextBox();
            this.textBox_英文 = new System.Windows.Forms.TextBox();
            this.textBox_國文 = new System.Windows.Forms.TextBox();
            this.textBox_姓名 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_maxmin);
            this.groupBox1.Controls.Add(this.label_show);
            this.groupBox1.Location = new System.Drawing.Point(375, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 353);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績顯示";
            // 
            // label_maxmin
            // 
            this.label_maxmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_maxmin.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_maxmin.Location = new System.Drawing.Point(6, 246);
            this.label_maxmin.Name = "label_maxmin";
            this.label_maxmin.Size = new System.Drawing.Size(234, 104);
            this.label_maxmin.TabIndex = 11;
            // 
            // label_show
            // 
            this.label_show.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_show.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_show.Location = new System.Drawing.Point(6, 14);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(236, 222);
            this.label_show.TabIndex = 10;
            // 
            // button_MAXMIN
            // 
            this.button_MAXMIN.Location = new System.Drawing.Point(444, 383);
            this.button_MAXMIN.Name = "button_MAXMIN";
            this.button_MAXMIN.Size = new System.Drawing.Size(161, 48);
            this.button_MAXMIN.TabIndex = 24;
            this.button_MAXMIN.Text = "最高 最低";
            this.button_MAXMIN.UseVisualStyleBackColor = true;
            this.button_MAXMIN.Click += new System.EventHandler(this.button_MAXMIN_Click);
            // 
            // button_顯示儲存
            // 
            this.button_顯示儲存.Location = new System.Drawing.Point(175, 277);
            this.button_顯示儲存.Name = "button_顯示儲存";
            this.button_顯示儲存.Size = new System.Drawing.Size(107, 64);
            this.button_顯示儲存.TabIndex = 23;
            this.button_顯示儲存.Text = "顯示儲存";
            this.button_顯示儲存.UseVisualStyleBackColor = true;
            this.button_顯示儲存.Click += new System.EventHandler(this.button_顯示儲存_Click);
            // 
            // button_儲存
            // 
            this.button_儲存.Location = new System.Drawing.Point(26, 277);
            this.button_儲存.Name = "button_儲存";
            this.button_儲存.Size = new System.Drawing.Size(107, 64);
            this.button_儲存.TabIndex = 22;
            this.button_儲存.Text = "儲存";
            this.button_儲存.UseVisualStyleBackColor = true;
            this.button_儲存.Click += new System.EventHandler(this.button_儲存_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "數學";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "英文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "國文";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "姓名";
            // 
            // textBox_數學
            // 
            this.textBox_數學.Location = new System.Drawing.Point(117, 164);
            this.textBox_數學.Name = "textBox_數學";
            this.textBox_數學.Size = new System.Drawing.Size(145, 22);
            this.textBox_數學.TabIndex = 17;
            // 
            // textBox_英文
            // 
            this.textBox_英文.Location = new System.Drawing.Point(117, 119);
            this.textBox_英文.Name = "textBox_英文";
            this.textBox_英文.Size = new System.Drawing.Size(145, 22);
            this.textBox_英文.TabIndex = 16;
            // 
            // textBox_國文
            // 
            this.textBox_國文.Location = new System.Drawing.Point(117, 72);
            this.textBox_國文.Name = "textBox_國文";
            this.textBox_國文.Size = new System.Drawing.Size(145, 22);
            this.textBox_國文.TabIndex = 15;
            // 
            // textBox_姓名
            // 
            this.textBox_姓名.Location = new System.Drawing.Point(117, 31);
            this.textBox_姓名.Name = "textBox_姓名";
            this.textBox_姓名.Size = new System.Drawing.Size(145, 22);
            this.textBox_姓名.TabIndex = 14;
            // 
            // Form第四題_成績A_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_MAXMIN);
            this.Controls.Add(this.button_顯示儲存);
            this.Controls.Add(this.button_儲存);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_數學);
            this.Controls.Add(this.textBox_英文);
            this.Controls.Add(this.textBox_國文);
            this.Controls.Add(this.textBox_姓名);
            this.Name = "Form第四題_成績A_";
            this.Text = "Form第四題_成績A_";
            this.Load += new System.EventHandler(this.Form第四題_成績A__Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_maxmin;
        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.Button button_MAXMIN;
        private System.Windows.Forms.Button button_顯示儲存;
        private System.Windows.Forms.Button button_儲存;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_數學;
        private System.Windows.Forms.TextBox textBox_英文;
        private System.Windows.Forms.TextBox textBox_國文;
        private System.Windows.Forms.TextBox textBox_姓名;
    }
}