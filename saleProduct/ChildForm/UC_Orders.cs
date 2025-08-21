using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace saleProduct.ChildForm
{
    public partial class UC_Orders : UserControl
    {
        SqlConnection conn;
        private static UC_Orders _instance;

        public static UC_Orders Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Orders();
                return _instance;
            }
        }

        public UC_Orders()
        {
            InitializeComponent();
            conn = new SqlConnection("server=WINDOWS-11; database=XStore; integrated security=true");
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            FillData();
            GetProducts();
            GetCustomers();
            GetEmployees();
        }

        public void FillData()
        {
            conn.Open();
            string query = @"SELECT o.OrderID, 
                                o.CustomerID, c.CustomerName, 
                                o.EmployeeID, e.Fullname AS EmployeeName, 
                                o.OrderDate, 
                                od.ProductID, p.ProductName, 
                                od.Quantity, od.TotalPrice
                         FROM Orders o
                         JOIN Customer c ON o.CustomerID = c.CustomerID
                         JOIN Employee e ON o.EmployeeID = e.EmployeeID
                         JOIN OrderDetail od ON o.OrderID = od.OrderID
                         JOIN Product p ON od.ProductID = p.ProductID";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgrOrders.DataSource = dt;

            // Ẩn cột ID
            dgrOrders.Columns["CustomerID"].Visible = false;
            dgrOrders.Columns["EmployeeID"].Visible = false;
            dgrOrders.Columns["ProductID"].Visible = false;
            conn.Close();
        }

        private void GetProducts()
        {
            conn.Open();
            string query = "SELECT ProductID, ProductName FROM Product";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            cbProductName.DataSource = dt;
            cbProductName.DisplayMember = "ProductName";
            cbProductName.ValueMember = "ProductID";
            conn.Close();
        }

        private void GetCustomers()
        {
            conn.Open();
            string query = "SELECT CustomerID, CustomerName FROM Customer";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            cbCustomer.DataSource = dt;
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.ValueMember = "CustomerID";
            conn.Close();
        }

        private void GetEmployees()
        {
            conn.Open();
            string query = "SELECT EmployeeID, Fullname FROM Employee";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            cbEmployee.DataSource = dt;
            cbEmployee.DisplayMember = "Fullname";
            cbEmployee.ValueMember = "EmployeeID";
            conn.Close();
        }

        private void ClearData()
        {
            txtOrderID.Clear();
            txtQuantity.Clear();
            cbProductName.SelectedIndex = -1;
            cbCustomer.SelectedIndex = -1;
            cbEmployee.SelectedIndex = -1;
            dtOrder.Value = DateTime.Now;
            txtOrderID.Focus();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            conn.Open();

            string insertOrder = "INSERT INTO Orders(OrderID, CustomerID, EmployeeID, OrderDate) " +
                                 "VALUES(@OrderID, @CustomerID, @EmployeeID, @OrderDate)";

            SqlCommand cmdOrder = new SqlCommand(insertOrder, conn);
            cmdOrder.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
            cmdOrder.Parameters.AddWithValue("@CustomerID", cbCustomer.SelectedValue);
            cmdOrder.Parameters.AddWithValue("@EmployeeID", cbEmployee.SelectedValue);
            cmdOrder.Parameters.AddWithValue("@OrderDate", dtOrder.Value);
            cmdOrder.ExecuteNonQuery();

            // Lấy giá sản phẩm
            string priceQuery = "SELECT Price FROM Product WHERE ProductID=@ProductID";
            SqlCommand cmdPrice = new SqlCommand(priceQuery, conn);
            cmdPrice.Parameters.AddWithValue("@ProductID", cbProductName.SelectedValue);
            decimal unitPrice = Convert.ToDecimal(cmdPrice.ExecuteScalar());

            int qty = int.Parse(txtQuantity.Text);
            decimal total = unitPrice * qty;

            string insertDetail = "INSERT INTO OrderDetail(OrderID, ProductID, Quantity, TotalPrice) " +
                                  "VALUES(@OrderID, @ProductID, @Quantity, @TotalPrice)";
            SqlCommand cmdDetail = new SqlCommand(insertDetail, conn);
            cmdDetail.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
            cmdDetail.Parameters.AddWithValue("@ProductID", cbProductName.SelectedValue);
            cmdDetail.Parameters.AddWithValue("@Quantity", qty);
            cmdDetail.Parameters.AddWithValue("@TotalPrice", total);
            cmdDetail.ExecuteNonQuery();

            conn.Close();

            FillData();
            ClearData();
            MessageBox.Show(this, "Order added successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                string updateOrder = @"UPDATE Orders 
                                    SET CustomerID=@CustomerID, EmployeeID=@EmployeeID, OrderDate=@OrderDate 
                                    WHERE OrderID=@OrderID";

                SqlCommand cmdOrder = new SqlCommand(updateOrder, conn);
                cmdOrder.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
                cmdOrder.Parameters.AddWithValue("@CustomerID", cbCustomer.SelectedValue);
                cmdOrder.Parameters.AddWithValue("@EmployeeID", cbEmployee.SelectedValue);
                cmdOrder.Parameters.AddWithValue("@OrderDate", dtOrder.Value);
                cmdOrder.ExecuteNonQuery();

                string priceQuery = "SELECT Price FROM Product WHERE ProductID=@ProductID";
                SqlCommand cmdPrice = new SqlCommand(priceQuery, conn);
                cmdPrice.Parameters.AddWithValue("@ProductID", cbProductName.SelectedValue);
                decimal unitPrice = Convert.ToDecimal(cmdPrice.ExecuteScalar());

                int qty = int.Parse(txtQuantity.Text);
                decimal total = unitPrice * qty;

                string updateDetail = @"UPDATE OrderDetail 
                                        SET ProductID=@ProductID, Quantity=@Quantity, TotalPrice=@TotalPrice 
                                        WHERE OrderID=@OrderID";

                SqlCommand cmdDetail = new SqlCommand(updateDetail, conn);
                cmdDetail.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
                cmdDetail.Parameters.AddWithValue("@ProductID", cbProductName.SelectedValue);
                cmdDetail.Parameters.AddWithValue("@Quantity", qty);
                cmdDetail.Parameters.AddWithValue("@TotalPrice", total);
                cmdDetail.ExecuteNonQuery();

                conn.Close();

                FillData();
                ClearData();
                MessageBox.Show(this, "Order updated successfully!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                string deleteDetail = "DELETE FROM OrderDetail WHERE OrderID=@OrderID";
                SqlCommand cmdDetail = new SqlCommand(deleteDetail, conn);
                cmdDetail.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
                cmdDetail.ExecuteNonQuery();

                string deleteOrder = "DELETE FROM Orders WHERE OrderID=@OrderID";
                SqlCommand cmdOrder = new SqlCommand(deleteOrder, conn);
                cmdOrder.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
                int i = cmdOrder.ExecuteNonQuery();

                conn.Close();

                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Order deleted successfully!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgrOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgrOrders.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                dtOrder.Value = Convert.ToDateTime(row.Cells["OrderDate"].Value);
                cbCustomer.SelectedValue = row.Cells["CustomerID"].Value;
                cbEmployee.SelectedValue = row.Cells["EmployeeID"].Value;
                cbProductName.SelectedValue = row.Cells["ProductID"].Value;
            }
        }
    }
}
