namespace saleProduct.ChildForm
{
    partial class UC_Orders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.dgrOrder = new System.Windows.Forms.DataGridView();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(453, 91);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(224, 22);
            this.txtEmployeeName.TabIndex = 37;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(748, 160);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(99, 43);
            this.btnDeleteOrder.TabIndex = 35;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(748, 85);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(99, 43);
            this.btnUpdateOrder.TabIndex = 34;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(748, 14);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(99, 43);
            this.btnAddOrder.TabIndex = 33;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(346, 94);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(106, 16);
            this.lblEmployeeName.TabIndex = 30;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(346, 23);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(101, 16);
            this.lblCustomerName.TabIndex = 29;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(113, 228);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(224, 22);
            this.txtTotalPrice.TabIndex = 28;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(18, 234);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(69, 16);
            this.lblTotalPrice.TabIndex = 27;
            this.lblTotalPrice.Text = "TotalPrice";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(113, 160);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 22);
            this.txtQuantity.TabIndex = 26;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(38, 166);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 85);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 22);
            this.txtProductName.TabIndex = 24;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(14, 91);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(90, 16);
            this.lblProductName.TabIndex = 23;
            this.lblProductName.Text = "ProductName";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(113, 20);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(224, 22);
            this.txtOrderID.TabIndex = 22;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(38, 26);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(54, 16);
            this.lblOrderID.TabIndex = 21;
            this.lblOrderID.Text = "OrderID";
            // 
            // dgrOrder
            // 
            this.dgrOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.ProductName,
            this.Quantiy,
            this.TotalPrice,
            this.CustomerName,
            this.EmployeeName,
            this.OrderDate});
            this.dgrOrder.Location = new System.Drawing.Point(0, 307);
            this.dgrOrder.Name = "dgrOrder";
            this.dgrOrder.RowHeadersWidth = 51;
            this.dgrOrder.RowTemplate.Height = 24;
            this.dgrOrder.Size = new System.Drawing.Size(884, 272);
            this.dgrOrder.TabIndex = 20;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(453, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(224, 22);
            this.txtCustomerName.TabIndex = 38;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(453, 163);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(224, 22);
            this.txtOrderDate.TabIndex = 40;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(364, 169);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(70, 16);
            this.lblOrderDate.TabIndex = 39;
            this.lblOrderDate.Text = "OrderDate";
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Quantiy
            // 
            this.Quantiy.HeaderText = "Quantiy";
            this.Quantiy.MinimumWidth = 6;
            this.Quantiy.Name = "Quantiy";
            this.Quantiy.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 125;
            // 
            // UC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.dgrOrder);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(884, 593);
            ((System.ComponentModel.ISupportInitialize)(this.dgrOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DataGridView dgrOrder;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}
