namespace saleProduct
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnImportReceipt = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.ucPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnStatistics);
            this.splitContainer1.Panel1.Controls.Add(this.btnImportReceipt);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btnEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.btnProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucPanel);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 664);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::saleProduct.Properties.Resources.logo_btec1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(40, 540);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(113, 47);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnImportReceipt
            // 
            this.btnImportReceipt.Location = new System.Drawing.Point(40, 453);
            this.btnImportReceipt.Name = "btnImportReceipt";
            this.btnImportReceipt.Size = new System.Drawing.Size(113, 47);
            this.btnImportReceipt.TabIndex = 4;
            this.btnImportReceipt.Text = "ImportReceipt";
            this.btnImportReceipt.UseVisualStyleBackColor = true;
            this.btnImportReceipt.Click += new System.EventHandler(this.btnImportReceipt_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(40, 367);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 47);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(40, 281);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(113, 47);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(40, 197);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(113, 47);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(40, 113);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(113, 47);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // ucPanel
            // 
            this.ucPanel.Location = new System.Drawing.Point(3, 71);
            this.ucPanel.Name = "ucPanel";
            this.ucPanel.Size = new System.Drawing.Size(884, 593);
            this.ucPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store\'X Manager";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 664);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnImportReceipt;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ucPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}