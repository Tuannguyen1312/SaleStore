using saleProduct.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleProduct
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!ucPanel.Controls.Contains(UC_Product.Instance))
            {
                ucPanel.Controls.Add(UC_Product.Instance);
                UC_Product.Instance.Dock = DockStyle.Fill;
                UC_Product.Instance.BringToFront();
            }
            else
            {
                UC_Product.Instance.BringToFront();
            }

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!ucPanel.Controls.Contains(UC_Employee.Instance))
            {
                ucPanel.Controls.Add(UC_Employee.Instance);
                UC_Employee.Instance.Dock = DockStyle.Fill;
                UC_Employee.Instance.BringToFront();
            }
            else
            {
                UC_Employee.Instance.BringToFront();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (!ucPanel.Controls.Contains(UC_Customers.Instance))
            {
                ucPanel.Controls.Add(UC_Customers.Instance);
                UC_Customers.Instance.Dock = DockStyle.Fill;
                UC_Customers.Instance.BringToFront();
            }
            else
            {
                UC_Customers.Instance.BringToFront();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!ucPanel.Controls.Contains(UC_Orders.Instance))
            {
                ucPanel.Controls.Add(UC_Orders.Instance);
                UC_Orders.Instance.Dock = DockStyle.Fill;
                UC_Orders.Instance.BringToFront();
            }
            else
            {
                UC_Orders.Instance.BringToFront();
            }
        }

        private void btnImportReceipt_Click(object sender, EventArgs e)
        {
            if (!ucPanel.Controls.Contains(UC_ImportReceipt.Instance))
            {
                ucPanel.Controls.Add(UC_ImportReceipt.Instance);
                UC_ImportReceipt.Instance.Dock = DockStyle.Fill;
                UC_ImportReceipt.Instance.BringToFront();
            }
            else
            {
                UC_ImportReceipt.Instance.BringToFront();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (!ucPanel.Controls.Contains(UC_Statistics.Instance))
            {
                ucPanel.Controls.Add(UC_Statistics.Instance);
                UC_Statistics.Instance.Dock = DockStyle.Fill;
                UC_Statistics.Instance.BringToFront();
            }
            else
            {
                UC_Statistics.Instance.BringToFront();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
              "Bạn có chắc muốn đăng xuất?",
               "Xác nhận",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Mở lại form đăng nhập
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Đóng form hiện tại (MainForm)
                this.Hide();
            }
        }
    }
}
