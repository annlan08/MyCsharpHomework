
namespace MyCsharp作業
{
    partial class Form_時鐘
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
            this.components = new System.ComponentModel.Container();
            this.label_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_床 = new System.Windows.Forms.Label();
            this.label_起 = new System.Windows.Forms.Label();
            this.button_關閉 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_sec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_min = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_time.Location = new System.Drawing.Point(92, 39);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(171, 40);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "label_time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_床);
            this.groupBox1.Controls.Add(this.label_起);
            this.groupBox1.Controls.Add(this.button_關閉);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(105, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "時鐘";
            // 
            // label_床
            // 
            this.label_床.AutoSize = true;
            this.label_床.Font = new System.Drawing.Font("標楷體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_床.Location = new System.Drawing.Point(345, 77);
            this.label_床.Name = "label_床";
            this.label_床.Size = new System.Drawing.Size(137, 96);
            this.label_床.TabIndex = 4;
            this.label_床.Text = "床";
            // 
            // label_起
            // 
            this.label_起.AutoSize = true;
            this.label_起.Font = new System.Drawing.Font("標楷體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_起.Location = new System.Drawing.Point(21, 65);
            this.label_起.Name = "label_起";
            this.label_起.Size = new System.Drawing.Size(137, 96);
            this.label_起.TabIndex = 3;
            this.label_起.Text = "起";
            // 
            // button_關閉
            // 
            this.button_關閉.Location = new System.Drawing.Point(173, 90);
            this.button_關閉.Name = "button_關閉";
            this.button_關閉.Size = new System.Drawing.Size(133, 53);
            this.button_關閉.TabIndex = 2;
            this.button_關閉.Text = "關閉";
            this.button_關閉.UseVisualStyleBackColor = true;
            this.button_關閉.Click += new System.EventHandler(this.button_關閉_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(206, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox_sec);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_min);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_hr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(107, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 36);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_sec
            // 
            this.comboBox_sec.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_sec.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_sec.FormattingEnabled = true;
            this.comboBox_sec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_sec.IntegralHeight = false;
            this.comboBox_sec.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_sec.Location = new System.Drawing.Point(148, -2);
            this.comboBox_sec.Name = "comboBox_sec";
            this.comboBox_sec.Size = new System.Drawing.Size(50, 34);
            this.comboBox_sec.TabIndex = 5;
            this.comboBox_sec.SelectedIndexChanged += new System.EventHandler(this.comboBox_sec_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(199, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "秒";
            // 
            // comboBox_min
            // 
            this.comboBox_min.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_min.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_min.FormattingEnabled = true;
            this.comboBox_min.IntegralHeight = false;
            this.comboBox_min.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_min.Location = new System.Drawing.Point(80, -2);
            this.comboBox_min.Name = "comboBox_min";
            this.comboBox_min.Size = new System.Drawing.Size(50, 34);
            this.comboBox_min.TabIndex = 4;
            this.comboBox_min.SelectedIndexChanged += new System.EventHandler(this.comboBox_min_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(54, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "時";
            // 
            // comboBox_hr
            // 
            this.comboBox_hr.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_hr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_hr.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_hr.FormattingEnabled = true;
            this.comboBox_hr.IntegralHeight = false;
            this.comboBox_hr.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_hr.Location = new System.Drawing.Point(3, -2);
            this.comboBox_hr.Name = "comboBox_hr";
            this.comboBox_hr.Size = new System.Drawing.Size(50, 34);
            this.comboBox_hr.TabIndex = 3;
            this.comboBox_hr.SelectedIndexChanged += new System.EventHandler(this.comboBox_hr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(124, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "分";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_時鐘
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_時鐘";
            this.Text = "Form_時鐘";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_床;
        private System.Windows.Forms.Label label_起;
        private System.Windows.Forms.Button button_關閉;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_sec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_hr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}