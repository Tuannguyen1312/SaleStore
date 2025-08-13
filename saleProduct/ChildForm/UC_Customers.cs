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
    public partial class UC_Customers : UserControl
    {
        SqlConnection conn;
        private static UC_Customers _instance;
       
        public static UC_Customers Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Customers();
                }
                return _instance;
            }
        }
        public UC_Customers()
        {
            InitializeComponent();
            conn = new SqlConnection("server=WINDOWS-11; database=SaleStoreX; integrated security=true");
        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {
            FillData();
        }
        public void FillData() // Load data từ Customer vào DataGridView
        {
            conn.Open();
            string query = "SELECT * FROM Customer";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgrCustomer.DataSource = dt;
            conn.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insert = "INSERT INTO Customer (CustomerID, CustomerName, CustomerPhone, Address) " +
                            "VALUES (@id, @name, @phone, @address)";
            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtCustomerID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtCustomerName.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtCustomerPhone.Text;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;

            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }

        private void dgrCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgrCustomer.Rows[e.RowIndex];
                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtCustomerPhone.Text = row.Cells["CustomerPhone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string update = "UPDATE Customer SET CustomerName=@name, CustomerPhone=@phone, Address=@address " +
                            "WHERE CustomerID=@id";
            SqlCommand cmd = new SqlCommand(update, conn);

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtCustomerID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtCustomerName.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtCustomerPhone.Text;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;

            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            conn.Open();
            string delete = "DELETE FROM Customer WHERE CustomerID=@id";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtCustomerID.Text;
            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }
    }

}
