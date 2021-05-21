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

namespace QuanLySieuThi.User_Controls
{
    public partial class uc_HDBan : UserControl
    {
        public uc_HDBan()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConnectionString.str);

        short mahd;
        DateTime ngaymua;
        short makh;
        short mahd_cthd;
        short mahang;
        short soluong;

        DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString.str))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch { }

                connection.Close();
            }
            return data;
        }
        // trả về 1 data table  gọi trong phương thức xem, lấy dữ liệu qua câu truy vấn
        int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int acceptedRows = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.str))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();
                        foreach (string item in temp)
                        {
                            if (item[0] == '@')
                                listPara.Add(item);
                        }
                        for (int i = 0; i < parameter.Length; i++)
                        {
                            command.Parameters.AddWithValue(listPara[i], parameter[i]);
                        }
                    }
                    //thực thi câu query chả về số dòng câu truy vấn thực hiện được
                    acceptedRows = -1;

                    acceptedRows = command.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Lỗi Dữ Liệu"); }
                connection.Close();
            }
            return acceptedRows;
        }
        // trả về kiểu int, gọi trong phương thức thêm và xoám, kiểu int là số dòng  thực thi thay dổi database


        private void HDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = HDBan.CurrentRow.Index;
            txtMaHDBan.Text = HDBan.Rows[i].Cells[0].Value.ToString();
            txtMaKH.Text = HDBan.Rows[i].Cells[1].Value.ToString();
            dateTimeNgayMua.Text = HDBan.Rows[i].Cells[2].Value.ToString();
            mahd = Convert.ToInt16(txtMaHDBan.Text);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM CTHDBan where MaHD = " + mahd.ToString() + "", connection);
                SqlDataReader read2 = cmd2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Load(read2);
                CTHDBan.DataSource = table2;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CTHDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = CTHDBan.CurrentRow.Index;
            txtMaHDBanCT.Text = CTHDBan.Rows[i].Cells[0].Value.ToString();
            txtMaHangBan.Text = CTHDBan.Rows[i].Cells[1].Value.ToString();
            txtSoLuongBan.Text = CTHDBan.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_Them_HD_Click(object sender, EventArgs e)
        {
            if (txtMaHDBan.Text != "")
            {
                mahd = Convert.ToInt16(txtMaHDBan.Text);
                if (txtMaKH.Text == "") { makh = 0; }
                else makh = Convert.ToInt16(txtMaKH.Text);
                ngaymua = (DateTime)dateTimeNgayMua.Value;
                string query = "Insert into HDban values(  " + mahd.ToString() + "," + makh.ToString() + ",'" + ngaymua.ToString() + "' )";
                int i = -1;
                i = ExecuteNonQuery(query);
                if (i != -1)
                {
                    MessageBox.Show("Đã Thêm Thành Công!");
                    txtMaHDBan.Text = "";
                    txtMaKH.Text = "";

                    uc_HDBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công!");
                }
            }
            else
                MessageBox.Show("Hãy Thêm Mã Hóa Đơn");
        }

        private void btn_Sua_HD_Click(object sender, EventArgs e)
        {
            if (txtMaHDBan.Text != "")
            {
                mahd = Convert.ToInt16(txtMaHDBan.Text);
                if (txtMaKH.Text == "") { makh = 0; }
                else makh = Convert.ToInt16(txtMaKH.Text);
                ngaymua = (DateTime)dateTimeNgayMua.Value;
                string query = @"update HDBan set  MaHD = " + mahd.ToString() + ", MaKH = " + makh.ToString() + ", ngaymua ='" + ngaymua.ToString() + "'  where MaHD = " + mahd.ToString() + " ";

                int i = -1;
                i = ExecuteNonQuery(query);
                if (i != -1)
                {
                    MessageBox.Show("Đã Sửa Thành Công!");
                    txtMaHDBan.Text = "";
                    txtMaKH.Text = "";
                    uc_HDBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công!");
                }
            }
        }

        private void btn_Xoa_HD_Click(object sender, EventArgs e)
        {
            if (txtMaHDBan.Text != "")
            {
                mahd = Convert.ToInt16(txtMaHDBan.Text);
                makh = Convert.ToInt16(txtMaKH.Text);
                ngaymua = (DateTime)dateTimeNgayMua.Value;
                string query = "exec xoahdban @mahd = " + mahd.ToString() + " ";

                int i = -1;
                i = ExecuteNonQuery(query);
                if (i != -1)
                {
                    MessageBox.Show("Đã Xóa Thành Công!");
                    txtMaHDBan.Text = "";
                    txtMaKH.Text = "";
                    uc_HDBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }

        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHDBanCT.Text != "" || txtMaHangBan.Text != "")
            {
                mahd_cthd = Convert.ToInt16(txtMaHDBanCT.Text);
                if (txtMaHangBan.Text == "") { mahang = 0; }
                else mahang = Convert.ToInt16(txtMaHangBan.Text);
                if (txtSoLuongBan.Text == "") { soluong = 0; }
                else soluong = Convert.ToInt16(txtSoLuongBan.Text);
                string query = "Insert into CTHDBan values(  " + mahd_cthd.ToString() + "," + mahang.ToString() + ",'" + soluong.ToString() + "' )";
                int i = -1;
                i = ExecuteNonQuery(query);
                if (i != -1)
                {
                    MessageBox.Show("Đã Thêm Thành Công!");
                    txtMaHDBanCT.Text = "";
                    txtMaHangBan.Text = "";
                    txtSoLuongBan.Text = "";
                    uc_HDBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công!");
                }
            }
            else
                MessageBox.Show("Hãy Thêm Mã Hóa Đơn Và Mã Hàng");
        }

        private void btn_SuaCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHDBanCT.Text != "")
            {
                mahd_cthd = Convert.ToInt16(txtMaHDBanCT.Text);
                mahang = Convert.ToInt16(txtMaHangBan.Text);
                if (txtSoLuongBan.Text == "") { soluong = 0; }
                else soluong = Convert.ToInt16(txtSoLuongBan.Text);
                string query = @"update CTHDBan set SoLuong = " + soluong.ToString() + "  where MaHD = " + mahd_cthd.ToString() + " and MaHang = " + mahang.ToString();

                int i = -1;
                i = ExecuteNonQuery(query);
                if (i != -1)
                {
                    MessageBox.Show("Đã Sửa Thành Công!");
                    txtMaHDBanCT.Text = "";
                    txtMaHangBan.Text = "";
                    txtSoLuongBan.Text = "";
                    uc_HDBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công!");
                }
            }
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHDBanCT.Text != "" || txtMaHangBan.Text != "")
            {
                mahd_cthd = Convert.ToInt16(txtMaHDBanCT.Text);
                mahang = Convert.ToInt16(txtMaHangBan.Text);
                soluong = Convert.ToInt16(txtSoLuongBan.Text);
                string query = "delete from CTHDBan where MaHD = " + mahd_cthd.ToString() + " and MaHang = " + mahang.ToString();
                int i = -1;
                i = ExecuteNonQuery(query);
                if (i != -1)
                {
                    MessageBox.Show("Đã Xóa Thành Công!");
                    txtMaHDBanCT.Text = "";
                    txtMaHangBan.Text = "";
                    txtSoLuongBan.Text = "";
                    uc_HDBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }

        private void uc_HDBan_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM HDBan", connection);
                SqlDataReader read1 = cmd1.ExecuteReader();
                DataTable table1 = new DataTable();
                table1.Load(read1);
                HDBan.DataSource = table1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
