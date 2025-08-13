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
    public partial class UC_Employee : UserControl
    {
        SqlConnection conn;
        private static UC_Employee _instance;
        public static UC_Employee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Employee();
                }
                return _instance;
            }
        }
        public UC_Employee()
        {
            InitializeComponent();
            conn = new SqlConnection("server=WINDOWS-11; database=SaleStoreX; integrated security=true");
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            FillData();
            GetRoles();
        }

        public void FillData() // load dữ liệu Employee
        {
            conn.Open();
            string query = "SELECT * FROM Employee ";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgrEmployee.DataSource = dt;
            conn.Close();
        }
        public void GetRoles() // load Roles vào ComboBox
        {
            conn.Open();
            string query = "SELECT RoleID, RoleName FROM Roles";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            cbRole.DataSource = dt;
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "RoleID";
            conn.Close();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insert = "INSERT INTO Employee (EmployeeID, FullName, Phone, RoleID) " +
                            "VALUES (@id, @name, @phone, @roleid)";
            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtEmployeeID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtFullName.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
            cmd.Parameters.Add("@roleid", SqlDbType.VarChar).Value = cbRole.SelectedValue.ToString();

            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }

        private void dgrEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgrEmployee.Rows[e.RowIndex];
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                cbRole.SelectedValue = row.Cells["RoleID"].Value.ToString();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();
            string update = "UPDATE Employee SET FullName=@name, Phone=@phone, RoleID=@roleid " +
                            "WHERE EmployeeID=@id";
            SqlCommand cmd = new SqlCommand(update, conn);

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtEmployeeID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtFullName.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
            cmd.Parameters.Add("@roleid", SqlDbType.VarChar).Value = cbRole.SelectedValue.ToString();

            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();
            string delete = "DELETE FROM Employee WHERE EmployeeID=@id";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtEmployeeID.Text;
            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }
    }
}
