namespace homework6
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findOrderIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.viewOrderDetailsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.findOrderIdTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sortComboBox);
            this.panel1.Controls.Add(this.deleteOrderButton);
            this.panel1.Controls.Add(this.addOrderButton);
            this.panel1.Controls.Add(this.viewOrderDetailsButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 83);
            this.panel1.TabIndex = 0;
            // 
            // findOrderIdTextBox
            // 
            this.findOrderIdTextBox.Location = new System.Drawing.Point(456, 42);
            this.findOrderIdTextBox.Name = "findOrderIdTextBox";
            this.findOrderIdTextBox.Size = new System.Drawing.Size(183, 27);
            this.findOrderIdTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "查询明细的订单ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "功能按键:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "订单排序";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "订单排序";
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "按订单总金额从大到小排序",
            "按订单号从小到大排序"});
            this.sortComboBox.Location = new System.Drawing.Point(86, 7);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(230, 28);
            this.sortComboBox.TabIndex = 2;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(203, 41);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(94, 29);
            this.deleteOrderButton.TabIndex = 1;
            this.deleteOrderButton.Text = "删除订单";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(87, 41);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(94, 29);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "添加订单";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // viewOrderDetailsButton
            // 
            this.viewOrderDetailsButton.Location = new System.Drawing.Point(645, 41);
            this.viewOrderDetailsButton.Name = "viewOrderDetailsButton";
            this.viewOrderDetailsButton.Size = new System.Drawing.Size(116, 29);
            this.viewOrderDetailsButton.TabIndex = 0;
            this.viewOrderDetailsButton.Text = "查询订单";
            this.viewOrderDetailsButton.UseVisualStyleBackColor = true;
            this.viewOrderDetailsButton.Click += new System.EventHandler(this.viewOrderDetailsButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.orderDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 337);
            this.panel2.TabIndex = 1;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customersDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 3);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 29;
            this.orderDataGridView.Size = new System.Drawing.Size(770, 331);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderAmountDataGridViewTextBoxColumn
            // 
            this.orderAmountDataGridViewTextBoxColumn.DataPropertyName = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.HeaderText = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderAmountDataGridViewTextBoxColumn.Name = "orderAmountDataGridViewTextBoxColumn";
            this.orderAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customersDataGridViewTextBoxColumn
            // 
            this.customersDataGridViewTextBoxColumn.DataPropertyName = "customers";
            this.customersDataGridViewTextBoxColumn.HeaderText = "customers";
            this.customersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customersDataGridViewTextBoxColumn.Name = "customersDataGridViewTextBoxColumn";
            this.customersDataGridViewTextBoxColumn.ReadOnly = true;
            this.customersDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework6.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private ComboBox sortComboBox;
        private Button deleteOrderButton;
        private Button addOrderButton;
        private Button viewOrderDetailsButton;
        private Panel panel2;
        private DataGridView orderDataGridView;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customersDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private Label label2;
        private TextBox findOrderIdTextBox;
        private Label label3;
    }
}