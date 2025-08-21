using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleProduct
{
    public partial class Register : Form
    {
        private string connectionString = "server=WINDOWS-11;database=SaleStoreX;integrated security=true";
        public Register()
        {
            InitializeComponent();
            this.Load += Register_Load; // Load của Form, không phải Panel
        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();
          

            if (fullName == "" || username == "" || password == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Tạo EmployeeID mới
                    string empID = GenerateID(conn, "Employee", "EMP", "EmployeeID");
                   

                    // 2. Thêm vào bảng Employee

                    string insertEmp = "INSERT INTO Employee (EmployeeID, FullName, Phone) VALUES (@empID, @fullName, @phone)";
                    SqlCommand cmdEmp = new SqlCommand(insertEmp, conn);
                    cmdEmp.Parameters.AddWithValue("@empID", empID);
                    cmdEmp.Parameters.AddWithValue("@fullName", fullName);
                    cmdEmp.Parameters.AddWithValue("@phone", phone);
                   
                    cmdEmp.ExecuteNonQuery();

                    // 3. Tạo UserID mới
                    string userID = GenerateID(conn, "Users", "USR","UserID");

                    // 4. Thêm vào bảng Users
                    string insertUser = "INSERT INTO Users (UserID, Username, Password, EmployeeID) VALUES (@userID, @username, @password, @empID)";
                    SqlCommand cmdUser = new SqlCommand(insertUser, conn);
                    cmdUser.Parameters.AddWithValue("@userID", userID);
                    cmdUser.Parameters.AddWithValue("@username", username);
                    cmdUser.Parameters.AddWithValue("@password", hashedPassword);
                    cmdUser.Parameters.AddWithValue("@empID", empID);
                    cmdUser.ExecuteNonQuery();

                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();

                    // Đóng hoặc ẩn form hiện tại
                    this.Close(); // hoặc this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng ký: " + ex.Message);
                }
            }
        }
        // Hàm sinh ID tự động: EMP001, USR001
        private string GenerateID(SqlConnection conn, string tableName, string prefix, string idColumn)
        {
            string query = $@"
        SELECT TOP 1 {idColumn}
        FROM {tableName}
        WHERE {idColumn} LIKE @prefix + '%'
        ORDER BY CAST(SUBSTRING({idColumn}, LEN(@prefix) + 1,  LEN({idColumn}) - LEN(@prefix)) AS INT) DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@prefix", prefix);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string lastID = result.ToString();
                    int num = int.Parse(lastID.Substring(prefix.Length)) + 1;
                    return $"{prefix}{num:D3}";

                }
                else
                {
                    return $"{prefix}001";
                }
            }


        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close(); // Đóng form hiện tại
        }

      
    }
}
