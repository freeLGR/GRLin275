namespace WinFormsApp1
{
    partial class sub
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.RadioButton();
            this.sub2 = new System.Windows.Forms.RadioButton();
            this.multiply = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 251);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(217, 41);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(125, 27);
            this.Number1.TabIndex = 5;
            this.Number1.TextChanged += new System.EventHandler(this.第一个数_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "第一个运算数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "第二个运算数";
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(217, 80);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(125, 27);
            this.Number2.TabIndex = 8;
            this.Number2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(84, 169);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(58, 24);
            this.add.TabIndex = 9;
            this.add.TabStop = true;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sub2
            // 
            this.sub2.AutoSize = true;
            this.sub2.Location = new System.Drawing.Point(244, 169);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(56, 24);
            this.sub2.TabIndex = 10;
            this.sub2.TabStop = true;
            this.sub2.Text = "sub";
            this.sub2.UseVisualStyleBackColor = true;
            this.sub2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(398, 169);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(89, 24);
            this.multiply.TabIndex = 11;
            this.multiply.TabStop = true;
            this.multiply.Text = "multiply";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(575, 169);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(52, 24);
            this.div.TabIndex = 12;
            this.div.TabStop = true;
            this.div.Text = "div";
            this.div.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(111, 306);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(99, 20);
            this.result.TabIndex = 13;
            this.result.Text = "运算的结果是";
            // 
            // sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.sub2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.button1);
            this.Name = "sub";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private TextBox Number1;
        private Label label1;
        private Label label2;
        private TextBox Number2;
        private RadioButton add;
        private RadioButton sub2;
        private RadioButton multiply;
        private RadioButton div;
        private Label result;
    }
}