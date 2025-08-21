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
            conn = new SqlConnection("server=WINDOWS-11; database=XStore; integrated security=true");
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            FillData();
            GetRoles();
        }

        public void FillData() // load dữ liệu Employee
        {
            conn.Open();
            string query = @"SELECT e.EmployeeID, e.FullName, e.Phone, r.RoleName, e.RoleID
                     FROM Employee e
                     INNER JOIN Roles r ON e.RoleID = r.RoleID";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgrEmployee.DataSource = dt;
            conn.Close();

            // Ẩn cột RoleID (nếu chỉ muốn hiển thị RoleName)
            if (dgrEmployee.Columns.Contains("RoleID"))
            {
                dgrEmployee.Columns["RoleID"].Visible = false;
            }
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

        private void ClearData()
        {
            txtEmployeeID.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            if (cbRole.Items.Count > 0)
                cbRole.SelectedIndex = 0;
            txtFullName.Focus();
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
            if (MessageBox.Show(this, "Do you want to update?", "Question",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string update = @"UPDATE Employee 
                                  SET FullName=@name, Phone=@phone, RoleID=@roleid 
                                  WHERE EmployeeID=@id";
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtEmployeeID.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtFullName.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
                cmd.Parameters.Add("@roleid", SqlDbType.VarChar).Value = cbRole.SelectedValue.ToString();

                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Updated successfully!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                // Bước 1: Set EmployeeID trong Users = NULL nếu có nhân viên tham chiếu
                string setNullQuery = "UPDATE Users SET EmployeeID = NULL WHERE EmployeeID = @id";
                using (SqlCommand setNullCmd = new SqlCommand(setNullQuery, conn))
                {
                    setNullCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtEmployeeID.Text.Trim();
                    setNullCmd.ExecuteNonQuery();
                }

                // Bước 2: Xóa nhân viên
                string deleteQuery = "DELETE FROM Employee WHERE EmployeeID = @id";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtEmployeeID.Text.Trim();
                    int i = deleteCmd.ExecuteNonQuery();

                    conn.Close();

                    if (i > 0)
                    {
                        FillData();
                        ClearData();
                        MessageBox.Show(this, "Deleted successfully!", "Result",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Failed to delete employee.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();

            string insert = @"INSERT INTO Employee (EmployeeID, FullName, Phone, RoleID) 
                  VALUES (@id, @name, @phone, @roleid)";
            SqlCommand cmd = new SqlCommand(insert, conn);

            // EmployeeID
            cmd.Parameters.Add("@id", SqlDbType.VarChar);
            cmd.Parameters["@id"].Value = txtEmployeeID.Text.Trim();

            // FullName
            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = txtFullName.Text.Trim();

            // Phone
            cmd.Parameters.Add("@phone", SqlDbType.VarChar);
            cmd.Parameters["@phone"].Value = txtPhone.Text.Trim();

            // RoleID
            cmd.Parameters.Add("@roleid", SqlDbType.VarChar);
            cmd.Parameters["@roleid"].Value = cbRole.SelectedValue.ToString();

            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                FillData();
                ClearData();
                MessageBox.Show(this, "Added successfully!", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Failed to add employee.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
