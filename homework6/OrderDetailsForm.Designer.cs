namespace homework6
{
    partial class OrderDetailsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoodsNameComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addDetailIdTextBox1 = new System.Windows.Forms.TextBox();
            this.deleteDetailsIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteDetailsButton = new System.Windows.Forms.Button();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderDetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.detailsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GoodsNameComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.addDetailIdTextBox1);
            this.panel1.Controls.Add(this.deleteDetailsIdTextBox);
            this.panel1.Controls.Add(this.deleteDetailsButton);
            this.panel1.Controls.Add(this.addDetailButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 108);
            this.panel1.TabIndex = 0;
            // 
            // GoodsNameComboBox
            // 
            this.GoodsNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoodsNameComboBox.FormattingEnabled = true;
            this.GoodsNameComboBox.Items.AddRange(new object[] {
            "egg",
            "pear"});
            this.GoodsNameComboBox.Location = new System.Drawing.Point(592, 61);
            this.GoodsNameComboBox.Name = "GoodsNameComboBox";
            this.GoodsNameComboBox.Size = new System.Drawing.Size(151, 28);
            this.GoodsNameComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "货物：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "货物总量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "添加明细ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "删除明细ID：";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(374, 60);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(155, 27);
            this.quantityTextBox.TabIndex = 4;
            // 
            // addDetailIdTextBox1
            // 
            this.addDetailIdTextBox1.Location = new System.Drawing.Point(117, 61);
            this.addDetailIdTextBox1.Name = "addDetailIdTextBox1";
            this.addDetailIdTextBox1.Size = new System.Drawing.Size(155, 27);
            this.addDetailIdTextBox1.TabIndex = 4;
            // 
            // deleteDetailsIdTextBox
            // 
            this.deleteDetailsIdTextBox.Location = new System.Drawing.Point(117, 25);
            this.deleteDetailsIdTextBox.Name = "deleteDetailsIdTextBox";
            this.deleteDetailsIdTextBox.Size = new System.Drawing.Size(201, 27);
            this.deleteDetailsIdTextBox.TabIndex = 4;
            // 
            // deleteDetailsButton
            // 
            this.deleteDetailsButton.Location = new System.Drawing.Point(333, 23);
            this.deleteDetailsButton.Name = "deleteDetailsButton";
            this.deleteDetailsButton.Size = new System.Drawing.Size(94, 29);
            this.deleteDetailsButton.TabIndex = 2;
            this.deleteDetailsButton.Text = "删除明细";
            this.deleteDetailsButton.UseVisualStyleBackColor = true;
            this.deleteDetailsButton.Click += new System.EventHandler(this.deleteDetailsButton_Click);
            // 
            // addDetailButton
            // 
            this.addDetailButton.Location = new System.Drawing.Point(767, 59);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(105, 29);
            this.addDetailButton.TabIndex = 1;
            this.addDetailButton.Text = "添加明细";
            this.addDetailButton.UseVisualStyleBackColor = true;
            this.addDetailButton.Click += new System.EventHandler(this.addDetailButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单ID：11";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.OrderDetailsdataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 368);
            this.panel2.TabIndex = 1;
            // 
            // OrderDetailsdataGridView
            // 
            this.OrderDetailsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDetailsdataGridView.AutoGenerateColumns = false;
            this.OrderDetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailsIdDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.OrderDetailsdataGridView.DataSource = this.orderDetailsBindingSource;
            this.OrderDetailsdataGridView.Location = new System.Drawing.Point(12, 3);
            this.OrderDetailsdataGridView.Name = "OrderDetailsdataGridView";
            this.OrderDetailsdataGridView.RowHeadersWidth = 51;
            this.OrderDetailsdataGridView.RowTemplate.Height = 29;
            this.OrderDetailsdataGridView.Size = new System.Drawing.Size(946, 362);
            this.OrderDetailsdataGridView.TabIndex = 0;
            this.OrderDetailsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDetailsdataGridView_CellContentClick);
            // 
            // detailsIdDataGridViewTextBoxColumn
            // 
            this.detailsIdDataGridViewTextBoxColumn.DataPropertyName = "DetailsId";
            this.detailsIdDataGridViewTextBoxColumn.HeaderText = "DetailsId";
            this.detailsIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailsIdDataGridViewTextBoxColumn.Name = "detailsIdDataGridViewTextBoxColumn";
            this.detailsIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailsIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(homework6.OrderDetails);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button deleteDetailsButton;
        private Button addDetailButton;
        private Label label1;
        private Panel panel2;
        private DataGridView OrderDetailsdataGridView;
        private Label label3;
        private TextBox deleteDetailsIdTextBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailIdDataGridViewTextBoxColumn;
        private ComboBox GoodsNameComboBox;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox quantityTextBox;
        private TextBox addDetailIdTextBox1;
        private DataGridViewTextBoxColumn detailsIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource orderDetailsBindingSource;
    }
}