namespace saleProduct.ChildForm
{
    partial class UC_Product
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
            this.dgrProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrProduct
            // 
            this.dgrProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.QuantityStock,
            this.ImageURL,
            this.CategoryID});
            this.dgrProduct.Location = new System.Drawing.Point(0, 321);
            this.dgrProduct.Name = "dgrProduct";
            this.dgrProduct.RowHeadersWidth = 51;
            this.dgrProduct.RowTemplate.Height = 24;
            this.dgrProduct.Size = new System.Drawing.Size(884, 272);
            this.dgrProduct.TabIndex = 0;
            this.dgrProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProduct_CellClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // QuantityStock
            // 
            this.QuantityStock.DataPropertyName = "QuantityStock";
            this.QuantityStock.HeaderText = "Quantity";
            this.QuantityStock.MinimumWidth = 6;
            this.QuantityStock.Name = "QuantityStock";
            this.QuantityStock.Width = 125;
            // 
            // ImageURL
            // 
            this.ImageURL.DataPropertyName = "ImageURL";
            this.ImageURL.HeaderText = "Image";
            this.ImageURL.MinimumWidth = 6;
            this.ImageURL.Name = "ImageURL";
            this.ImageURL.Width = 125;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Category";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Width = 125;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(38, 40);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(66, 16);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(113, 34);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(224, 22);
            this.txtProductID.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 99);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(14, 105);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(90, 16);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "ProductName";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(113, 174);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(224, 22);
            this.txtProductPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(38, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(113, 242);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(224, 22);
            this.txtProductQuantity.TabIndex = 8;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(18, 248);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(89, 16);
            this.lblStockQuantity.TabIndex = 7;
            this.lblStockQuantity.Text = "QuantityStock";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(378, 36);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(395, 108);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(45, 16);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "Image";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(453, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(224, 24);
            this.cbCategory.TabIndex = 12;
            // 
            // pbProduct
            // 
            this.pbProduct.Location = new System.Drawing.Point(463, 138);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(192, 126);
            this.pbProduct.TabIndex = 13;
            this.pbProduct.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(748, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(748, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 43);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(748, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 43);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(593, 270);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(84, 30);
            this.btnBrowser.TabIndex = 17;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(453, 105);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(224, 22);
            this.txtImage.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.dgrProduct);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(884, 593);
            this.Load += new System.EventHandler(this.UC_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrProduct;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
