namespace homework6
{
    partial class OrderAddForm
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
            this.orderAddButton = new System.Windows.Forms.Button();
            this.orderAddId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderAddCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // orderAddButton
            // 
            this.orderAddButton.Location = new System.Drawing.Point(150, 107);
            this.orderAddButton.Name = "orderAddButton";
            this.orderAddButton.Size = new System.Drawing.Size(94, 29);
            this.orderAddButton.TabIndex = 0;
            this.orderAddButton.Text = "创建订单";
            this.orderAddButton.UseVisualStyleBackColor = true;
            this.orderAddButton.Click += new System.EventHandler(this.orderAddButton_Click);
            // 
            // orderAddId
            // 
            this.orderAddId.AutoSize = true;
            this.orderAddId.Location = new System.Drawing.Point(12, 9);
            this.orderAddId.Name = "orderAddId";
            this.orderAddId.Size = new System.Drawing.Size(69, 20);
            this.orderAddId.TabIndex = 1;
            this.orderAddId.Text = "订单ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户选择:";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(85, 6);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(208, 27);
            this.orderIdTextBox.TabIndex = 2;
            // 
            // orderAddCustomerComboBox
            // 
            this.orderAddCustomerComboBox.FormattingEnabled = true;
            this.orderAddCustomerComboBox.Items.AddRange(new object[] {
            "li",
            "wang"});
            this.orderAddCustomerComboBox.Location = new System.Drawing.Point(85, 49);
            this.orderAddCustomerComboBox.Name = "orderAddCustomerComboBox";
            this.orderAddCustomerComboBox.Size = new System.Drawing.Size(208, 28);
            this.orderAddCustomerComboBox.TabIndex = 3;
            // 
            // OrderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 148);
            this.Controls.Add(this.orderAddCustomerComboBox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderAddId);
            this.Controls.Add(this.orderAddButton);
            this.Name = "OrderAddForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button orderAddButton;
        private Label orderAddId;
        private Label label2;
        private TextBox orderIdTextBox;
        private ComboBox orderAddCustomerComboBox;
    }
}