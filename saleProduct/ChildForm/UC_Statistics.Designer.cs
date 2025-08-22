namespace saleProduct.ChildForm
{
    partial class UC_Statistics
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
            this.dgvBestSelling = new System.Windows.Forms.DataGridView();
            this.dgvTopCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBestSelling
            // 
            this.dgvBestSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestSelling.Location = new System.Drawing.Point(60, 318);
            this.dgvBestSelling.Name = "dgvBestSelling";
            this.dgvBestSelling.RowHeadersWidth = 51;
            this.dgvBestSelling.RowTemplate.Height = 24;
            this.dgvBestSelling.Size = new System.Drawing.Size(336, 245);
            this.dgvBestSelling.TabIndex = 0;
            // 
            // dgvTopCustomers
            // 
            this.dgvTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomers.Location = new System.Drawing.Point(526, 318);
            this.dgvTopCustomers.Name = "dgvTopCustomers";
            this.dgvTopCustomers.RowHeadersWidth = 51;
            this.dgvTopCustomers.RowTemplate.Height = 24;
            this.dgvTopCustomers.Size = new System.Drawing.Size(302, 245);
            this.dgvTopCustomers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Best Selling Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Most Purchased Customers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTopCustomers);
            this.Controls.Add(this.dgvBestSelling);
            this.Name = "UC_Statistics";
            this.Size = new System.Drawing.Size(884, 593);
            this.Load += new System.EventHandler(this.UC_Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBestSelling;
        private System.Windows.Forms.DataGridView dgvTopCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
