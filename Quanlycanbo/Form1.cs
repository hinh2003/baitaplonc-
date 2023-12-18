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
    public partial class Form1 : Form
    {
        public string conn = "Server=DESKTOP-M9OV124\\HINH;Database=quanlycanbo1;Integrated Security=SSPI;";
        public SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(conn);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewData();
            info();
        }
        public void info()
        {
            sqlConnection.Open();
            string sqlchucvu = "SELECT ten_chucvu FROM chucVu";
            SqlCommand commandchucvu = new SqlCommand(sqlchucvu, sqlConnection);
            SqlDataReader readerchucvu = commandchucvu.ExecuteReader();

            while (readerchucvu.Read())
            {
                cbchucvu.Items.Add(readerchucvu["ten_chucvu"].ToString());
            }

            readerchucvu.Close();
            string sqldonvi = "SELECT ten_donvi FROM donVi";
            SqlCommand commanddonvi = new SqlCommand(sqldonvi, sqlConnection);
            SqlDataReader readerdonvi = commanddonvi.ExecuteReader();

            while (readerdonvi.Read())
            {
                cbdonvi.Items.Add(readerdonvi["ten_donvi"].ToString());
            }

            readerdonvi.Close();


            string sqlLuongGV = "SELECT mucluong FROM luong";
            SqlCommand commandLuongGV = new SqlCommand(sqlLuongGV, sqlConnection);
            SqlDataReader readerLuongGV = commandLuongGV.ExecuteReader();

            while (readerLuongGV.Read())
            {
                cbluong.Items.Add(readerLuongGV["mucluong"].ToString());
            }

            readerLuongGV.Close();


            string sqltrinhdo = "SELECT ten_trinhdo FROM trinhDo";
            SqlCommand commandtrinhdo = new SqlCommand(sqltrinhdo, sqlConnection);
            SqlDataReader readertrinhdo = commandtrinhdo.ExecuteReader();

            while (readertrinhdo.Read())
            {
                cbtrinhdo.Items.Add(readertrinhdo["ten_trinhdo"].ToString());
            }

            readertrinhdo.Close();
            sqlConnection.Close();
        }

        public void viewData()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql =
                            "SELECT giaoVien.ten_giaovien AS TenGiaoVien, " +
                            "giaovien.sdt AS SDT, " +
                            "giaovien.tuoi AS Tuoi, " +
                            "giaovien.email AS Email, " +
                            "giaovien.giaovien_id ," +
                            "chucVu.ten_chucvu AS ChucVu, " +
                            "luong.mucluong AS Luong, " +
                            "donVi.ten_donvi AS DonVi, " +
                            "trinhDo.ten_trinhdo AS TrinhDo " +
                            "FROM giaoVien " +
                            "JOIN chucVu ON giaoVien.chucvu_id = chucVu.chucvu_id " +
                            "JOIN luong ON giaoVien.luong_id = luong.luong_id " +
                            "JOIN donVi ON giaoVien.donvi_id = donVi.donvi_id " +
                            "JOIN trinhDo ON giaoVien.trinhdo_id = trinhDo.trinhdo_id;";


                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["giaovien_id"].Visible = false;
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

        private void btnxoa_Click(object sender, EventArgs e)
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
                    string sql = "DELETE FROM giaovien WHERE giaovien_id = " + giaovienId;
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
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
        public void DisplayCellContent(DataGridViewRow row, string columnName, Control control)
        {
            if (row.Cells[columnName].Value != DBNull.Value)
            {
                control.Text = row.Cells[columnName].Value.ToString();
            }
            else
            {
                control.Text = string.Empty;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                DisplayCellContent(selectedRow, "TenGiaoVien", txtten);
                DisplayCellContent(selectedRow, "Luong", cbluong);
                DisplayCellContent(selectedRow, "SDT", txtsdt);
                DisplayCellContent(selectedRow, "Email", txtemail);
                DisplayCellContent(selectedRow, "ChucVu", cbchucvu);
                DisplayCellContent(selectedRow, "TrinhDo", cbtrinhdo);
                DisplayCellContent(selectedRow, "DonVi", cbdonvi);
                DisplayCellContent(selectedRow, "Tuoi", txttuoi);

                if (dataGridView1.Columns.Contains("giaovien_id"))
                {
                    object giaovienIdObj = selectedRow.Cells["giaovien_id"].Value;
                    giaovienId = giaovienIdObj != DBNull.Value ? Convert.ToInt32(giaovienIdObj) : 0;
                }
            }
        }
        int giaovienId;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string name = txtten.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string tuoi = txttuoi.Text;
            string donVi = cbdonvi.SelectedItem?.ToString();
            string chucvu = cbchucvu.SelectedItem?.ToString();
            string luong = cbluong.SelectedItem?.ToString();
            string trinhDo = cbtrinhdo.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sdt) && !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(chucvu) && !string.IsNullOrEmpty(donVi) &&
                !string.IsNullOrEmpty(luong) && !string.IsNullOrEmpty(trinhDo))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        string sql = @" 
                    INSERT INTO giaovien (ten_giaovien, sdt, email, tuoi, donvi_id, trinhdo_id, luong_id, chucvu_id)
                            VALUES (
                            @ten, 
                            @sdt, 
                            @email,
                            @tuoi,
                            (SELECT donvi_id FROM donVi WHERE ten_donvi = @donVi),
                            (SELECT trinhdo_id FROM trinhDo WHERE ten_trinhdo = @trinhDo),
                            (SELECT luong_id FROM luong WHERE mucluong = @luong),
                            (SELECT chucvu_id FROM chucVu WHERE ten_chucvu = @chucvu))";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ten", name);
                            command.Parameters.AddWithValue("@sdt", sdt);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@tuoi", tuoi);
                            command.Parameters.AddWithValue("@trinhDo", trinhDo);
                            command.Parameters.AddWithValue("@donVi", donVi);
                            command.Parameters.AddWithValue("@luong", luong);
                            command.Parameters.AddWithValue("@chucvu", chucvu);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm dữ liệu thành công");
                                viewData();
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra");
                            }

                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số điện thoại phải là số nguyên");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string name = txtten.Text;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;
                string tuoi = txttuoi.Text;
                string donVi = cbdonvi.SelectedItem?.ToString();
                string chucvu = cbchucvu.SelectedItem?.ToString();
                string luong = cbluong.SelectedItem?.ToString();
                string trinhDo = cbtrinhdo.SelectedItem?.ToString();
                string sql1 = @"UPDATE giaovien
                                SET 
                                ten_giaovien = @ten,
                                tuoi = @tuoi,
                                email = @email,
                                sdt = @sdt,
                                donvi_id = (SELECT donvi_id FROM donVi WHERE ten_donvi = @donVi),
                                luong_id = (SELECT luong_id FROM luong WHERE mucluong = @luong),
                                chucvu_id = (SELECT chucvu_id FROM chucVu WHERE ten_chucvu = @chucvu),
                                trinhdo_id = (SELECT trinhdo_id FROM trinhDo WHERE ten_trinhdo = @trinhDo)
                                WHERE giaovien_id = @giaovienId";

                SqlCommand command = new SqlCommand(sql1, sqlConnection);
                command.Parameters.AddWithValue("@ten", name);
                command.Parameters.AddWithValue("@sdt", sdt);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@tuoi", tuoi);
                command.Parameters.AddWithValue("@trinhDo", trinhDo);
                command.Parameters.AddWithValue("@donVi", donVi);
                command.Parameters.AddWithValue("@luong", luong);
                command.Parameters.AddWithValue("@chucvu", chucvu);
                command.Parameters.AddWithValue("@giaovienId", giaovienId);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    txtten.Text = "";
                    txttuoi.Text = "";
                    txtsdt.Text = "";
                    txtemail.Text = "";
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

        private void btnluong_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string donvi = cbdonvi.Text;
                string sql = @"
                            SELECT giaovien.ten_giaovien, luong.mucluong
                            FROM giaovien
                            JOIN luong ON giaovien.luong_id = luong.luong_id
                            JOIN donVi ON donVi.donvi_id = giaovien.donvi_id
                            WHERE donVi.ten_donvi = @tenDonVi";

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.AddWithValue("@tenDonVi", donvi);

                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin lương cho đơn vị này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btntuoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql = @"SELECT giaoVien.ten_giaovien AS TenGiaoVien, " +
                           "giaovien.sdt AS SDT, " +
                           "giaovien.tuoi AS Tuoi, " +
                           "giaovien.email AS Email, " +
                           "giaovien.giaovien_id ," +
                           "chucVu.ten_chucvu AS ChucVu, " +
                           "luong.mucluong AS Luong, " +
                           "donVi.ten_donvi AS DonVi, " +
                           "trinhDo.ten_trinhdo AS TrinhDo " +
                           "FROM giaoVien " +
                           "JOIN chucVu ON giaoVien.chucvu_id = chucVu.chucvu_id " +
                           "JOIN luong ON giaoVien.luong_id = luong.luong_id " +
                           "JOIN donVi ON giaoVien.donvi_id = donVi.donvi_id " +
                           "JOIN trinhDo ON giaoVien.trinhdo_id = trinhDo.trinhdo_id " +
                           "WHERE giaovien.tuoi > 60;";

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không có người nào có tuổi trên 60.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btndonvi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string donvi = cbdonvi.Text;
                string sql = @"SELECT giaoVien.ten_giaovien AS TenGiaoVien, " +
                           "giaovien.sdt AS SDT, " +
                           "giaovien.tuoi AS Tuoi, " +
                           "giaovien.email AS Email, " +
                           "giaovien.giaovien_id ," +
                           "chucVu.ten_chucvu AS ChucVu, " +
                           "luong.mucluong AS Luong, " +
                           "donVi.ten_donvi AS DonVi, " +
                           "trinhDo.ten_trinhdo AS TrinhDo " +
                           "FROM giaoVien " +
                           "JOIN chucVu ON giaoVien.chucvu_id = chucVu.chucvu_id " +
                           "JOIN luong ON giaoVien.luong_id = luong.luong_id " +
                           "JOIN donVi ON giaoVien.donvi_id = donVi.donvi_id " +
                           "JOIN trinhDo ON giaoVien.trinhdo_id = trinhDo.trinhdo_id " +
                           "WHERE donVi.ten_donvi = @tenDonVi";

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.AddWithValue("@tenDonVi", donvi);
                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không có người ở  :" + donvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
                string chucvu = cbchucvu.Text;
                string sql = @"SELECT giaoVien.ten_giaovien AS TenGiaoVien, " +
                           "giaovien.sdt AS SDT, " +
                           "giaovien.tuoi AS Tuoi, " +
                           "giaovien.email AS Email, " +
                           "giaovien.giaovien_id ," +
                           "chucVu.ten_chucvu AS ChucVu, " +
                           "luong.mucluong AS Luong, " +
                           "donVi.ten_donvi AS DonVi, " +
                           "trinhDo.ten_trinhdo AS TrinhDo " +
                           "FROM giaoVien " +
                           "JOIN chucVu ON giaoVien.chucvu_id = chucVu.chucvu_id " +
                           "JOIN luong ON giaoVien.luong_id = luong.luong_id " +
                           "JOIN donVi ON giaoVien.donvi_id = donVi.donvi_id " +
                           "JOIN trinhDo ON giaoVien.trinhdo_id = trinhDo.trinhdo_id " +
                           "WHERE chucVu.ten_chucvu = @tenchucvu";

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.AddWithValue("@tenchucvu", chucvu);
                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không có người ở  :" + chucvu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thoát ứng dụng
                Application.Exit();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string giaovien = txttimkiem.Text;
                string sql = @"SELECT giaoVien.ten_giaovien AS TenGiaoVien, " +
                           "giaovien.sdt AS SDT, " +
                           "giaovien.tuoi AS Tuoi, " +
                           "giaovien.email AS Email, " +
                           "giaovien.giaovien_id ," +
                           "chucVu.ten_chucvu AS ChucVu, " +
                           "luong.mucluong AS Luong, " +
                           "donVi.ten_donvi AS DonVi, " +
                           "trinhDo.ten_trinhdo AS TrinhDo " +
                           "FROM giaoVien " +
                           "JOIN chucVu ON giaoVien.chucvu_id = chucVu.chucvu_id " +
                           "JOIN luong ON giaoVien.luong_id = luong.luong_id " +
                           "JOIN donVi ON giaoVien.donvi_id = donVi.donvi_id " +
                           "JOIN trinhDo ON giaoVien.trinhdo_id = trinhDo.trinhdo_id " +
                           "WHERE ten_giaovien LIKE @giaovien";


                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.AddWithValue("@giaovien", giaovien);
                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không có người tên  :" + giaovien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                string sql =
                            "SELECT giaoVien.ten_giaovien AS TenGiaoVien, " +
                            "giaovien.sdt AS SDT, " +
                            "giaovien.tuoi AS Tuoi, " +
                            "giaovien.email AS Email, " +
                            "giaovien.giaovien_id ," +
                            "chucVu.ten_chucvu AS ChucVu, " +
                            "luong.mucluong AS Luong, " +
                            "donVi.ten_donvi AS DonVi, " +
                            "trinhDo.ten_trinhdo AS TrinhDo " +
                            "FROM giaoVien " +
                            "JOIN chucVu ON giaoVien.chucvu_id = chucVu.chucvu_id " +
                            "JOIN luong ON giaoVien.luong_id = luong.luong_id " +
                            "JOIN donVi ON giaoVien.donvi_id = donVi.donvi_id " +
                            "JOIN trinhDo ON giaoVien.trinhdo_id = trinhDo.trinhdo_id " +
                            "ORDER BY giaovien_id DESC;";

                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["giaovien_id"].Visible = false;
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
    }
}



