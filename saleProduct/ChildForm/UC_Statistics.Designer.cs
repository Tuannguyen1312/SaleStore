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
            this.Statistic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Statistic
            // 
            this.Statistic.AutoSize = true;
            this.Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistic.Location = new System.Drawing.Point(386, 280);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(115, 32);
            this.Statistic.TabIndex = 2;
            this.Statistic.Text = "Statistic";
          
            // 
            // UC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Statistic);
            this.Name = "UC_Statistics";
            this.Size = new System.Drawing.Size(884, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Statistic;
    }
}
