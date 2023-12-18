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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlycanbo
{
    public partial class Trinhdo : Form
    {
        public string conn = "Server=DESKTOP-M9OV124\\HINH;Database=quanlycanbo1;Integrated Security=SSPI;";
        public SqlConnection sqlConnection;
        public Form1 form1;

        public Trinhdo(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            sqlConnection = new SqlConnection(conn);
        }

        private void DonVi_Load(object sender, EventArgs e)
        {
            viewData();
        }
        public void viewData()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                string sql = "SELECT ten_trinhdo AS TrinhDO, trinhdo_id AS trinhdo_id " +
                             "FROM trinhDo ";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["trinhdo_id"].Visible = false;

                }

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        int trinhdoId;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string trinhdo = txttrinhdo.Text;
                if (!string.IsNullOrEmpty(trinhdo))
                {
                    string sql = "INSERT INTO trinhDo(ten_trinhdo) " +
                                 "VALUES (@trinhdo)";


                    using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@trinhdo", trinhdo);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công");
                            txttrinhdo.Text = "";
                            viewData();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ky Tự Không hop le");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                form1.DisplayCellContent(selectedRow, "TrinhDO", txttrinhdo);
                if (dataGridView1.Columns.Contains("trinhdo_id"))
                {
                    object giaovienIdObj = selectedRow.Cells["trinhdo_id"].Value;
                    trinhdoId = giaovienIdObj != DBNull.Value ? Convert.ToInt32(giaovienIdObj) : 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string trinhdo = txttrinhdo.Text;
                string sql1 = @"UPDATE trinhDo
                                SET 
                                ten_trinhdo = @trinhdo 
                                WHERE trinhdo_id = @trinhdoId";
                SqlCommand command = new SqlCommand(sql1, sqlConnection);
                command.Parameters.AddWithValue("@trinhdo", trinhdo);
                command.Parameters.AddWithValue("@trinhdoId", trinhdoId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    txttrinhdo.Text = "";
                    viewData();
                }
                else
                {
                    MessageBox.Show("Không có gì được cập nhật.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                try
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }
                    string sql = "DELETE FROM trinhDo WHERE trinhdo_id = " + trinhdoId;
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        txttrinhdo.Text = "";

                        viewData();
                    }
                    else
                    {
                        MessageBox.Show("Không có gì được Xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);

                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void DonVi_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.UpdateDonViComboBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
