namespace Basic_Calculator
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
            txtScreen = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnClear = new Button();
            btnMultiply = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnDivide = new Button();
            btnCalculate = new Button();
            btnClearAll = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtScreen
            // 
            txtScreen.BackColor = SystemColors.HighlightText;
            txtScreen.BorderStyle = BorderStyle.FixedSingle;
            txtScreen.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtScreen.Location = new Point(9, 12);
            txtScreen.Multiline = true;
            txtScreen.Name = "txtScreen";
            txtScreen.ReadOnly = true;
            txtScreen.Size = new Size(483, 72);
            txtScreen.TabIndex = 0;
            txtScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 101);
            btn1.Name = "btn1";
            btn1.Size = new Size(83, 78);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(110, 101);
            btn2.Name = "btn2";
            btn2.Size = new Size(83, 78);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 185);
            btn4.Name = "btn4";
            btn4.Size = new Size(83, 78);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(110, 185);
            btn5.Name = "btn5";
            btn5.Size = new Size(83, 78);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 269);
            btn7.Name = "btn7";
            btn7.Size = new Size(83, 78);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(110, 269);
            btn8.Name = "btn8";
            btn8.Size = new Size(83, 78);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(210, 101);
            btn3.Name = "btn3";
            btn3.Size = new Size(83, 78);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(211, 185);
            btn6.Name = "btn6";
            btn6.Size = new Size(83, 78);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(210, 269);
            btn9.Name = "btn9";
            btn9.Size = new Size(83, 78);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(310, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 78);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(311, 185);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(83, 78);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(310, 101);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 78);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(408, 101);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(83, 78);
            btnSub.TabIndex = 13;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(409, 185);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(83, 78);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(110, 366);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(184, 78);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearAll.Location = new Point(311, 366);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(182, 78);
            btnClearAll.TabIndex = 16;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 366);
            btn0.Name = "btn0";
            btn0.Size = new Size(83, 78);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 456);
            Controls.Add(btn0);
            Controls.Add(btnClearAll);
            Controls.Add(btnCalculate);
            Controls.Add(btnDivide);
            Controls.Add(btnSub);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtScreen);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScreen;
        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn5;
        private Button btn7;
        private Button btn8;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnClear;
        private Button btnMultiply;
        private Button btnAdd;
        private Button btnSub;
        private Button btnDivide;
        private Button btnCalculate;
        private Button btnClearAll;
        private Button btn0;
    }
}