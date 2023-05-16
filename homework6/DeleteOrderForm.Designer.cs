namespace homework6
{
    partial class DeleteOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteOrderIdtextBox = new System.Windows.Forms.TextBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单ID：";
            // 
            // deleteOrderIdtextBox
            // 
            this.deleteOrderIdtextBox.Location = new System.Drawing.Point(91, 23);
            this.deleteOrderIdtextBox.Name = "deleteOrderIdtextBox";
            this.deleteOrderIdtextBox.Size = new System.Drawing.Size(240, 27);
            this.deleteOrderIdtextBox.TabIndex = 1;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(142, 70);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(94, 29);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "删除订单";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 128);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.deleteOrderIdtextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteOrderForm";
            this.Text = "DeleteOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox deleteOrderIdtextBox;
        private Button deleteOrderButton;
    }
}