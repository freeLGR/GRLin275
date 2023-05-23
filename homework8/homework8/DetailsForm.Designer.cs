
namespace homework8
{
    partial class DetailsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.deleteDetailButton = new System.Windows.Forms.Button();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteDetailIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addDetailIdTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addGoodsComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addGoodsComboBox);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.addDetailIdTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deleteDetailIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.orderIdLabel);
            this.panel1.Controls.Add(this.deleteDetailButton);
            this.panel1.Controls.Add(this.addDetailButton);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 128);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(13, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 292);
            this.panel2.TabIndex = 1;
            // 
            // addDetailButton
            // 
            this.addDetailButton.Location = new System.Drawing.Point(539, 97);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(119, 26);
            this.addDetailButton.TabIndex = 0;
            this.addDetailButton.Text = "添加明细";
            this.addDetailButton.UseVisualStyleBackColor = true;
            this.addDetailButton.Click += new System.EventHandler(this.addDetailButton_Click);
            // 
            // deleteDetailButton
            // 
            this.deleteDetailButton.Location = new System.Drawing.Point(102, 65);
            this.deleteDetailButton.Name = "deleteDetailButton";
            this.deleteDetailButton.Size = new System.Drawing.Size(105, 26);
            this.deleteDetailButton.TabIndex = 1;
            this.deleteDetailButton.Text = "删除明细";
            this.deleteDetailButton.UseVisualStyleBackColor = true;
            this.deleteDetailButton.Click += new System.EventHandler(this.deleteDetailButton_Click);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(8, 6);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(144, 15);
            this.orderIdLabel.TabIndex = 2;
            this.orderIdLabel.Text = "操作的订单ID为：11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "想要删除的明细ID：";
            // 
            // deleteDetailIdTextBox
            // 
            this.deleteDetailIdTextBox.Location = new System.Drawing.Point(148, 34);
            this.deleteDetailIdTextBox.Name = "deleteDetailIdTextBox";
            this.deleteDetailIdTextBox.Size = new System.Drawing.Size(179, 25);
            this.deleteDetailIdTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "添加的明细ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "添加的货物：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "添加货物的质量:";
            // 
            // addDetailIdTextBox
            // 
            this.addDetailIdTextBox.Location = new System.Drawing.Point(512, 3);
            this.addDetailIdTextBox.Name = "addDetailIdTextBox";
            this.addDetailIdTextBox.Size = new System.Drawing.Size(220, 25);
            this.addDetailIdTextBox.TabIndex = 7;
            this.addDetailIdTextBox.TextChanged += new System.EventHandler(this.addDetailIdTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(512, 66);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(220, 25);
            this.quantityTextBox.TabIndex = 8;
            // 
            // addGoodsComboBox
            // 
            this.addGoodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGoodsComboBox.FormattingEnabled = true;
            this.addGoodsComboBox.Items.AddRange(new object[] {
            "egg",
            "pear"});
            this.addGoodsComboBox.Location = new System.Drawing.Point(512, 34);
            this.addGoodsComboBox.Name = "addGoodsComboBox";
            this.addGoodsComboBox.Size = new System.Drawing.Size(220, 23);
            this.addGoodsComboBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(764, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox addGoodsComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addDetailIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deleteDetailIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Button deleteDetailButton;
        private System.Windows.Forms.Button addDetailButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}