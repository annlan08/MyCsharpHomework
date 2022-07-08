
namespace MyCsharp作業
{
    partial class Form_GUESS_MAIN
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
            this.button_show = new System.Windows.Forms.Button();
            this.button_guess = new System.Windows.Forms.Button();
            this.label_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_show
            // 
            this.button_show.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_show.Location = new System.Drawing.Point(287, 181);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(233, 71);
            this.button_show.TabIndex = 5;
            this.button_show.Text = "SHOW ANS";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_guess
            // 
            this.button_guess.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_guess.Location = new System.Drawing.Point(49, 181);
            this.button_guess.Name = "button_guess";
            this.button_guess.Size = new System.Drawing.Size(141, 71);
            this.button_guess.TabIndex = 4;
            this.button_guess.Text = "GUESS";
            this.button_guess.UseVisualStyleBackColor = true;
            this.button_guess.Click += new System.EventHandler(this.button_guess_Click);
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_show.Location = new System.Drawing.Point(47, 72);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(171, 61);
            this.label_show.TabIndex = 3;
            this.label_show.Text = "猜數字";
            // 
            // Form_GUESS_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 353);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_guess);
            this.Controls.Add(this.label_show);
            this.Name = "Form_GUESS_MAIN";
            this.Text = "Form_GUESS_MAIN";
            this.Load += new System.EventHandler(this.Form_GUESS_MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_guess;
        private System.Windows.Forms.Label label_show;
    }
}