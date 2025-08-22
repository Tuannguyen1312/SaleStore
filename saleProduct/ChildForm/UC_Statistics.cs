using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleProduct.ChildForm
{
    public partial class UC_Statistics : UserControl
    {
        private string connectionString = "server = WINDOWS-11; database = XStore ; integrated security = true ";
        private static UC_Statistics _instance;
        public static UC_Statistics Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Statistics();
                }
                return _instance;
            }
        }
        public UC_Statistics()
        {
            InitializeComponent();
        }

        // Load danh sách sản phẩm bán chạy (Top 5)
        private void LoadBestSellingProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 5 * 
                    FROM View_BestSellingProducts 
                    ORDER BY TotalSold DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBestSelling.DataSource = dt;

                dgvBestSelling.Columns[0].HeaderText = "Product ID";
                dgvBestSelling.Columns[1].HeaderText = "Product Name";
                dgvBestSelling.Columns[2].HeaderText = "Total Sold";
            }
        }

        // Load danh sách khách hàng chi tiêu nhiều nhất (Top 5)
        private void LoadMostPurchasedCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 5 * 
                    FROM View_MostPurchasedCustomers 
                    ORDER BY TotalSpent DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTopCustomers.DataSource = dt;

                dgvTopCustomers.Columns[0].HeaderText = "Customer ID";
                dgvTopCustomers.Columns[1].HeaderText = "Customer Name";
                dgvTopCustomers.Columns[2].HeaderText = "Total Spent";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_Statistics_Load(object sender, EventArgs e)
        {
            LoadBestSellingProducts();
            LoadMostPurchasedCustomers();
        }
    }
}
