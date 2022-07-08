
namespace MyCsharp作業
{
    partial class Form_GUESS_2
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
            this.textBox_GUESS = new System.Windows.Forms.TextBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_GUESS
            // 
            this.textBox_GUESS.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_GUESS.Location = new System.Drawing.Point(36, 113);
            this.textBox_GUESS.Name = "textBox_GUESS";
            this.textBox_GUESS.Size = new System.Drawing.Size(215, 46);
            this.textBox_GUESS.TabIndex = 5;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(289, 117);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(99, 51);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "CLOSE";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(289, 44);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(99, 51);
            this.button_Enter.TabIndex = 3;
            this.button_Enter.Text = "ENTER";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // Form_GUESS_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 224);
            this.Controls.Add(this.textBox_GUESS);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_GUESS_2";
            this.ShowIcon = false;
            this.Text = "Form_GUESS_2";
            this.Load += new System.EventHandler(this.Form_GUESS_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_GUESS;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Enter;
    }
}