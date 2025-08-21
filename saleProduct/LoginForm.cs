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
    public partial class LoginForm : Form
    {
        private string connectionString = "server = WINDOWS-11; database = XStore ; integrated security = true ";
        public LoginForm()
        {
            InitializeComponent();
           
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
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string hashedPassword = HashPassword(password);

            string role = GetUserRole(username, hashedPassword);

            if (role != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                Form formToOpen = null;
                switch (role)
                {
                    case "admin":
                        formToOpen = new MainForm();
                        break;
                    case "staff":
                        formToOpen = new StaffForm();
                        break;
                    case "warehouse":
                        formToOpen = new WareHouseForm();
                        break;
                    default:
                        MessageBox.Show("Vai trò không hợp lệ!");
                        return;
                }

                this.Hide();
                formToOpen.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!"); 
                        MainForm mainForm = new MainForm(); // Form chính sau khi login
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }  



        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();    // Mở form mới
            this.Hide();            // Ẩn form hiện tại (Login)
        }

        private string GetUserRole(string username, string password)
        {
            string role = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT r.RoleName 
                                 FROM Users u
                                 JOIN Employee e ON u.EmployeeID = e.EmployeeID
                                 JOIN Roles r ON e.RoleID = r.RoleID
                                 WHERE u.Username=@u AND u.Password=@p";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        role = result.ToString();
                }
            }

            return role;
        }

      
        

    }
}
