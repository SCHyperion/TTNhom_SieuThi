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

namespace QuanLySieuThi
{

    public partial class fNhanVien : Form
    {
        short manv;
        string ten;
        string diachi;
        string sdt;
        long luong;
        public fNhanVien()
        {
            InitializeComponent();
        }
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

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            string query = "select * from NhanVien";
            dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNV.DataSource = ExecuteQuery(query);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string query = "Insert into NhanVien values( @MaNV , @TenNV , @DiaChi , @SoDT , @Luong )";
            
            
            if (txbMaNV.Text != "")
            {
                manv = Convert.ToInt16(txbMaNV.Text);
                ten = txbTenNV.Text;
                diachi = txbDiaChiNV.Text;
                sdt = txbSDTNV.Text;
                luong = Convert.ToInt64(txbLuongNV.Text);
            }
            else
            {
                if (dtgvNV.DataSource == null)
                {
                    MessageBox.Show("Thêm Dữ Liệu Vào Bảng Dữ Liệu Hoặc Thêm Dữ Liệu Vào Text");
                    return;
                }
                DataGridViewRow row = dtgvNV.SelectedCells[0].OwningRow;

                manv = Convert.ToInt16(row.Cells["MaNV"].Value.ToString());
                ten = row.Cells["TenNV"].Value.ToString();
                diachi = row.Cells["DiaChi"].Value.ToString();
                sdt = row.Cells["SoDT"].Value.ToString();
                luong = Convert.ToInt64(row.Cells["Luong"].Value.ToString());
            }

            object[] para = new object[] { manv, ten, diachi, sdt, luong  };
            if (ExecuteNonQuery(query, para) > 0)
            {
                MessageBox.Show("Thêm Thành Công!");
                txbMaNV.Text = "";
                txbTenNV.Text = "";
                txbLuongNV.Text = "";
                txbDiaChiNV.Text = "";
                txbSDTNV.Text = "";
                btnXemNV_Click(sender, e);
            }
            else
                MessageBox.Show("Thêm Không Thành Công!");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string query = "update NhanVien set TenNV = @tennv , DiaChi = @diachi , SoDT = @sdt , Luong = @luong where MaNV = @manv";


            if (txbMaNV.Text != "")
            {
                manv = Convert.ToInt16(txbMaNV.Text);
                ten = txbTenNV.Text;
                diachi = txbDiaChiNV.Text;
                sdt = txbSDTNV.Text;
                if (txbLuongNV.Text == "")
                {
                    luong = 0;
                }else
                    luong = Convert.ToInt64(txbLuongNV.Text);
            }
            else
            {
                if (dtgvNV.DataSource == null)
                {
                    MessageBox.Show("Không Thể Sửa Khi Chưa Có Đủ Dữ Liệu!");
                }
                else
                {
                    DataGridViewRow row = dtgvNV.SelectedCells[0].OwningRow;

                    manv = Convert.ToInt16(row.Cells["MaNV"].Value.ToString());
                    ten = row.Cells["TenNV"].Value.ToString();
                    diachi = row.Cells["DiaChi"].Value.ToString();
                    sdt = row.Cells["SoDT"].Value.ToString();
                    luong = Convert.ToInt64(row.Cells["Luong"].Value.ToString());
                }

            }

            object[] para = new object[] { ten, diachi, sdt, luong, manv };

            if (ExecuteNonQuery(query, para) > 0)
            {
                MessageBox.Show("Sửa Thành Công!");

                txbMaNV.Text = "";
                txbTenNV.Text = "";
                txbLuongNV.Text = "";
                txbDiaChiNV.Text = "";
                txbSDTNV.Text = "";
                btnXemNV_Click(sender, e);
            }
            else
                MessageBox.Show("Sửa Không Thành Công!");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dtgvNV.DataSource == null)
            {
                MessageBox.Show("Chọn Trường Cần Xóa Trong Bảng Dữ Liệu!");
            }
            else
            {
                string ID = dtgvNV.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString();
                object[] para = new object[] { ID };
                string query = "exec xoaNV @ID";
                if (ExecuteNonQuery(query, para) > 0)
                {

                    MessageBox.Show("Xóa Thành Công!");
                    btnXemNV_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa Không Thành Công!");
            }
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            if(rbtnMaNV.Checked==false && rbtnTenNV.Checked == false)
            {
                MessageBox.Show("Mời Chọn Trường Cần Tìm Kiếm");
            }
            else
            {
                if (rbtnTenNV.Checked == true)
                {
                    
                    string que = "select * from NhanVien Where TenNV like N'" + txbTimKiemNV.Text + "'";
                    dtgvNV.DataSource = ExecuteQuery(que);
                }
                else
                {
                    
                    string que = "select * from NhanVien Where MaNV = N'" + txbTimKiemNV.Text + "'";
                    dtgvNV.DataSource = ExecuteQuery(que);
                }
            }
        }
    }
}
