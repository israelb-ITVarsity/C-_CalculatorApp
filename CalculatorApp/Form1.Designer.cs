namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            DecimalBtn = new Button();
            ClearBtn = new Button();
            EqualsBtn = new Button();
            MinusBtn = new Button();
            Addbtn = new Button();
            DivisionBtn = new Button();
            MultiplyBtn = new Button();
            NO_0 = new Button();
            NO_9 = new Button();
            NO_8 = new Button();
            NO_7 = new Button();
            NO_6 = new Button();
            NO_5 = new Button();
            NO_4 = new Button();
            NO_3 = new Button();
            NO_2 = new Button();
            NO_1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(242, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 395);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(DecimalBtn);
            panel2.Controls.Add(ClearBtn);
            panel2.Controls.Add(EqualsBtn);
            panel2.Controls.Add(MinusBtn);
            panel2.Controls.Add(Addbtn);
            panel2.Controls.Add(DivisionBtn);
            panel2.Controls.Add(MultiplyBtn);
            panel2.Controls.Add(NO_0);
            panel2.Controls.Add(NO_9);
            panel2.Controls.Add(NO_8);
            panel2.Controls.Add(NO_7);
            panel2.Controls.Add(NO_6);
            panel2.Controls.Add(NO_5);
            panel2.Controls.Add(NO_4);
            panel2.Controls.Add(NO_3);
            panel2.Controls.Add(NO_2);
            panel2.Controls.Add(NO_1);
            panel2.Location = new Point(12, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 313);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // DecimalBtn
            // 
            DecimalBtn.BackColor = Color.FromArgb(64, 64, 64);
            DecimalBtn.ForeColor = SystemColors.ButtonHighlight;
            DecimalBtn.Location = new Point(7, 193);
            DecimalBtn.Margin = new Padding(0);
            DecimalBtn.Name = "DecimalBtn";
            DecimalBtn.Size = new Size(63, 59);
            DecimalBtn.TabIndex = 16;
            DecimalBtn.Text = ".";
            DecimalBtn.UseVisualStyleBackColor = false;
            DecimalBtn.Click += DecimalBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.FromArgb(64, 64, 64);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(145, 195);
            ClearBtn.Margin = new Padding(0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(63, 57);
            ClearBtn.TabIndex = 15;
            ClearBtn.Text = "C";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // EqualsBtn
            // 
            EqualsBtn.BackColor = Color.FromArgb(224, 224, 224);
            EqualsBtn.Location = new Point(7, 260);
            EqualsBtn.Margin = new Padding(0);
            EqualsBtn.Name = "EqualsBtn";
            EqualsBtn.Size = new Size(201, 41);
            EqualsBtn.TabIndex = 14;
            EqualsBtn.Text = "=";
            EqualsBtn.UseVisualStyleBackColor = false;
            EqualsBtn.Click += EqualsBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.BackColor = Color.Silver;
            MinusBtn.Location = new Point(214, 232);
            MinusBtn.Margin = new Padding(0);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(54, 69);
            MinusBtn.TabIndex = 13;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = false;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Silver;
            Addbtn.Location = new Point(214, 156);
            Addbtn.Margin = new Padding(0);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(54, 70);
            Addbtn.TabIndex = 12;
            Addbtn.Text = "+";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // DivisionBtn
            // 
            DivisionBtn.BackColor = Color.Silver;
            DivisionBtn.Location = new Point(214, 83);
            DivisionBtn.Margin = new Padding(0);
            DivisionBtn.Name = "DivisionBtn";
            DivisionBtn.Size = new Size(54, 67);
            DivisionBtn.TabIndex = 11;
            DivisionBtn.Text = "/";
            DivisionBtn.UseVisualStyleBackColor = false;
            DivisionBtn.Click += DivisionBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.BackColor = Color.Silver;
            MultiplyBtn.Location = new Point(214, 3);
            MultiplyBtn.Margin = new Padding(0);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(54, 74);
            MultiplyBtn.TabIndex = 10;
            MultiplyBtn.Text = "*";
            MultiplyBtn.UseVisualStyleBackColor = false;
            MultiplyBtn.Click += button11_Click;
            // 
            // NO_0
            // 
            NO_0.BackColor = Color.FromArgb(64, 64, 64);
            NO_0.ForeColor = Color.White;
            NO_0.Location = new Point(76, 193);
            NO_0.Margin = new Padding(0);
            NO_0.Name = "NO_0";
            NO_0.Size = new Size(63, 61);
            NO_0.TabIndex = 9;
            NO_0.Text = "0";
            NO_0.UseVisualStyleBackColor = false;
            NO_0.Click += NO_0_Click;
            // 
            // NO_9
            // 
            NO_9.BackColor = Color.FromArgb(64, 64, 64);
            NO_9.ForeColor = Color.White;
            NO_9.Location = new Point(145, 130);
            NO_9.Margin = new Padding(0);
            NO_9.Name = "NO_9";
            NO_9.Size = new Size(63, 59);
            NO_9.TabIndex = 8;
            NO_9.Text = "9";
            NO_9.UseVisualStyleBackColor = false;
            NO_9.Click += NO_9_Click;
            // 
            // NO_8
            // 
            NO_8.BackColor = Color.FromArgb(64, 64, 64);
            NO_8.ForeColor = Color.White;
            NO_8.Location = new Point(76, 130);
            NO_8.Margin = new Padding(0);
            NO_8.Name = "NO_8";
            NO_8.Size = new Size(63, 59);
            NO_8.TabIndex = 7;
            NO_8.Text = "8";
            NO_8.UseVisualStyleBackColor = false;
            NO_8.Click += NO_8_Click;
            // 
            // NO_7
            // 
            NO_7.BackColor = Color.FromArgb(64, 64, 64);
            NO_7.ForeColor = Color.White;
            NO_7.Location = new Point(7, 128);
            NO_7.Margin = new Padding(0);
            NO_7.Name = "NO_7";
            NO_7.Size = new Size(63, 59);
            NO_7.TabIndex = 6;
            NO_7.Text = "7";
            NO_7.UseVisualStyleBackColor = false;
            NO_7.Click += NO_7_Click;
            // 
            // NO_6
            // 
            NO_6.BackColor = Color.FromArgb(64, 64, 64);
            NO_6.ForeColor = Color.White;
            NO_6.Location = new Point(145, 65);
            NO_6.Margin = new Padding(0);
            NO_6.Name = "NO_6";
            NO_6.Size = new Size(63, 59);
            NO_6.TabIndex = 5;
            NO_6.Text = "6";
            NO_6.UseVisualStyleBackColor = false;
            NO_6.Click += NO_6_Click;
            // 
            // NO_5
            // 
            NO_5.BackColor = Color.FromArgb(64, 64, 64);
            NO_5.ForeColor = Color.White;
            NO_5.Location = new Point(76, 65);
            NO_5.Margin = new Padding(0);
            NO_5.Name = "NO_5";
            NO_5.Size = new Size(63, 59);
            NO_5.TabIndex = 4;
            NO_5.Text = "5";
            NO_5.UseVisualStyleBackColor = false;
            NO_5.Click += NO_5_Click;
            // 
            // NO_4
            // 
            NO_4.BackColor = Color.FromArgb(64, 64, 64);
            NO_4.ForeColor = Color.White;
            NO_4.Location = new Point(7, 65);
            NO_4.Margin = new Padding(0);
            NO_4.Name = "NO_4";
            NO_4.Size = new Size(63, 59);
            NO_4.TabIndex = 3;
            NO_4.Text = "4";
            NO_4.UseVisualStyleBackColor = false;
            NO_4.Click += NO_4_Click;
            // 
            // NO_3
            // 
            NO_3.BackColor = Color.FromArgb(64, 64, 64);
            NO_3.ForeColor = Color.White;
            NO_3.Location = new Point(145, 0);
            NO_3.Margin = new Padding(0);
            NO_3.Name = "NO_3";
            NO_3.Size = new Size(63, 59);
            NO_3.TabIndex = 2;
            NO_3.Text = "3";
            NO_3.UseVisualStyleBackColor = false;
            NO_3.Click += NO_3_Click;
            // 
            // NO_2
            // 
            NO_2.BackColor = Color.FromArgb(64, 64, 64);
            NO_2.ForeColor = Color.White;
            NO_2.Location = new Point(76, 0);
            NO_2.Margin = new Padding(0);
            NO_2.Name = "NO_2";
            NO_2.Size = new Size(63, 59);
            NO_2.TabIndex = 1;
            NO_2.Text = "2";
            NO_2.UseVisualStyleBackColor = false;
            NO_2.Click += NO_2_Click;
            // 
            // NO_1
            // 
            NO_1.BackColor = Color.FromArgb(64, 64, 64);
            NO_1.ForeColor = Color.White;
            NO_1.Location = new Point(7, 0);
            NO_1.Margin = new Padding(0);
            NO_1.Name = "NO_1";
            NO_1.Size = new Size(63, 59);
            NO_1.TabIndex = 0;
            NO_1.Text = "1\r\n";
            NO_1.UseVisualStyleBackColor = false;
            NO_1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button NO_1;
        private Button DecimalBtn;
        private Button ClearBtn;
        private Button EqualsBtn;
        private Button MinusBtn;
        private Button Addbtn;
        private Button DivisionBtn;
        private Button MultiplyBtn;
        private Button NO_0;
        private Button NO_9;
        private Button NO_8;
        private Button NO_7;
        private Button NO_6;
        private Button NO_5;
        private Button NO_4;
        private Button NO_3;
        private Button NO_2;
        private TextBox textBox1;
    }
}