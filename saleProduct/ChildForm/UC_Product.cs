using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleProduct.ChildForm
{
    public partial class UC_Product : UserControl
    {
        SqlConnection conn;
        private static UC_Product _instance;
        public static UC_Product Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Product();
                }
                return _instance;
            }
        }
        public UC_Product()
        {
            InitializeComponent();
            conn = new SqlConnection("server = WINDOWS-11; database = XStore ; integrated security = true ");
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {
            //conn.Open();
            //MessageBox.Show(this, "successful", "results", MessageBoxButtons.OK);
            //conn.Close();
            FillData(); // fill data from database in dataGridView
            GetCategory(); // get category from database and fill in comboBox
           

        }

        public void FillData()// fill data form database in dataGridView
        {
            conn.Open();
            string query = "SELECT * FROM Product";    
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgrProduct.DataSource = dt;
            conn.Close();

        }
        public void GetCategory()
        {
            conn.Open();
            string query = "select CategoryID , CategoryName from Category";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(dataTable);
            cbCategory.DataSource = dataTable;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string insert = "INSERT INTO Product (ProductID, ProductName, QuantityStock, CategoryID, Price, ImageURL)" +
                "VALUES (@id, @name, @quantity, @catid, @price, @img)";

            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@id", SqlDbType.VarChar);
            cmd.Parameters["@id"].Value = txtProductID.Text;

            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = txtProductName.Text;

            cmd.Parameters.Add("@price", SqlDbType.Decimal);
            cmd.Parameters["@price"].Value = Convert.ToDecimal(txtProductPrice.Text);

            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters["@quantity"].Value = txtProductQuantity.Text;

            string fileName = Path.GetFileName(txtImage.Text); // from TextBox
            string imagePathInDb = "img/" + fileName;
            cmd.Parameters.Add("@img", SqlDbType.VarChar).Value = imagePathInDb;

            
            cmd.Parameters.Add("@catid", SqlDbType.VarChar);
            cmd.Parameters["@catid"].Value = cbCategory.SelectedValue.ToString();

            cmd.ExecuteNonQuery();
            conn.Close();

            FillData();
        }

        private void dgrProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgrProduct.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtProductPrice.Text = row.Cells["Price"].Value.ToString();
                txtProductQuantity.Text = row.Cells["QuantityStock"].Value.ToString();
                cbCategory.SelectedValue = row.Cells["CategoryID"].Value.ToString();
            }
        }

        private void ClearData()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductQuantity.Clear();
            txtProductPrice.Clear();
            txtImage.Clear();

            // Reset combobox về giá trị mặc định
            if (cbCategory.Items.Count > 0)
                cbCategory.SelectedIndex = 0;

            // Xóa ảnh trong PictureBox
            pbProduct.Image = null;

            // Đưa focus về ô nhập tên sản phẩm
            txtProductName.Focus();
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\...";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialog1.FileName;
                pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                pbProduct.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = @"UPDATE Product 
                          SET ProductName = @name,
                              QuantityStock = @quantity,
                              CategoryID = @catid,
                              Price = @price,
                              ImageURL = @img
                          WHERE ProductID = @id";

                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtProductID.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtProductName.Text;
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtProductPrice.Text);
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtProductQuantity.Text;
                cmd.Parameters.Add("@catid", SqlDbType.VarChar).Value = cbCategory.SelectedValue.ToString();

                // Lưu đường dẫn ảnh theo format giống Add Product
                string fileName = Path.GetFileName(txtImage.Text);
                string imagePathInDb = "img/" + fileName;
                cmd.Parameters.Add("@img", SqlDbType.VarChar).Value = imagePathInDb;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "DELETE FROM Product WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(delete, conn);

                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtProductID.Text;

                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Deleted successfully!", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}