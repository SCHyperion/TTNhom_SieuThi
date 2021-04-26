using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace QuanLySieuThi.User_Controls
{
    public partial class HDNhap : UserControl
    {
        int row = 0;
        public HDNhap()
        {
            InitializeComponent();
        }
        void loadButton()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, button_Add.Width - 8, button_Add.Height - 8);
            button_Add.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Confirm.Width - 8, button_Confirm.Height - 8);
            button_Confirm.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Delete.Width - 8, button_Delete.Height - 8);
            button_Delete.Region = new Region(path);
            path.Reset();
        }
        void init_ListHD()
        {
            using(SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                string query1 = "SELECT MaHD as 'Mã Hóa Đơn', NgayNhap as 'Ngày Nhập' FROM HDNhap ";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                DataTable hdtable = new DataTable();
                SqlDataReader hdlist = cmd1.ExecuteReader();
                hdtable.Load(hdlist);
                dgv_ListHD.DataSource = hdtable;
            }
        }
        void init_ListSP()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                string query2 = "SELECT MaHang as 'Mã Hàng', TenHang as 'Tên Hàng', GiaBan as 'Giá Bán', SoLuongTon as 'Số Lượng Tồn' FROM MatHang ";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                DataTable sptable = new DataTable();
                SqlDataReader splist = cmd2.ExecuteReader();
                sptable.Load(splist);
                dgv_ListSP.DataSource = sptable;
            }
        }
        void updateData()
        {
            dgv_ListHD.DataSource = null;
            if (dgv_ListSP.Rows.Count > 1 && dgv_ListSP.Rows != null)
                dgv_ListSP.DataSource = null;
            dgv_Current.Rows.Clear();
            dgv_Current.Refresh();
            init_ListHD();
            init_ListSP();
        }
        bool validHDID(string input)
        {
            if (input == "") return false;
            using(SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                string query = "Select * From HDNhap Where MaHD = " + Int32.Parse(input);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows) return false;
                else return true;
            }
        }

        private void HDNhap_Load(object sender, EventArgs e)
        {
            loadButton();
            init_ListHD();
            init_ListSP();
            dgv_Current.Columns.Add("col1", "Mã Hàng");
            dgv_Current.Columns.Add("col2", "Tên Hàng");
            dgv_Current.Columns.Add("col3", "Giá Nhập");
            dgv_Current.Columns.Add("col4", "Số Lượng");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            dgv_Current.Rows.Clear();
            dgv_Current.Refresh();
            if (dgv_ListSP.Rows.Count > 1 && dgv_ListSP.Rows != null)
                dgv_ListSP.DataSource = null;
            dgv_ListSP.Refresh();
            init_ListSP();
            row = 0;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                try
                {
                    if (dgv_ListSP.Rows.Count > 1 && dgv_ListSP.Rows != null)
                    {
                        row = dgv_Current.Rows.Add();
                        dgv_Current.Rows[row].Cells[0].Value = dgv_ListSP.CurrentRow.Cells[0].Value;
                        dgv_Current.Rows[row].Cells[1].Value = dgv_ListSP.CurrentRow.Cells[1].Value;
                        dgv_Current.Rows[row].Cells[2].Value = dgv_ListSP.CurrentRow.Cells[2].Value;
                        dgv_Current.Rows[row].Cells[3].Value = dgv_ListSP.CurrentRow.Cells[3].Value;

                        dgv_ListSP.Rows.RemoveAt(dgv_ListSP.CurrentCell.RowIndex);
                    }
                    else MessageBox.Show("Bạn chưa chọn sản phẩm");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            row += 1;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Current.Rows.Count > 1 && dgv_Current.Rows != null && validHDID(textbox_MaHD.Text))
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.str))
                {
                    con.Open();
                    try
                    {
                        string query1 = "Insert into HDNhap(MaHD, NgayNhap) " +
                                        "Values(" + Int32.Parse(textbox_MaHD.Text) +
                                        ", '" + DateTime.Today.ToString() + "')";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.ExecuteNonQuery();
                        for (int i = 0; i < dgv_Current.Rows.Count - 1; i++)
                        {
                            int id = Int32.Parse(dgv_Current.Rows[i].Cells[0].Value.ToString());
                            int hd = Int32.Parse(textbox_MaHD.Text);
                            long price = long.Parse(dgv_Current.Rows[i].Cells[2].Value.ToString());
                            int quantity = Int32.Parse(dgv_Current.Rows[i].Cells[3].Value.ToString());

                            string query2 = "Insert into CTHDNHap(MaHD, MaHang, GiaNhap, SoLuong) " +
                                            "Values(" + hd + ", " + id + ", " + price + "," + quantity + ")";
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.ExecuteNonQuery();

                            SqlCommand cmd3 = new SqlCommand("Select * From MatHang Where MaHang = " + id, con);
                            SqlDataReader reader = cmd3.ExecuteReader();
                            reader.Read();
                            int soluong = Int32.Parse(reader["SoLuongTon"].ToString()) + quantity;
                            reader.Close();
                            string query3 = "Update MatHang" +
                                            " Set SoLuongTon = " + soluong +
                                            " Where MaHang = " + id;
                            SqlCommand cmd4 = new SqlCommand(query3, con);
                            cmd4.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm hóa đơn nhập thành công");
                        updateData();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else MessageBox.Show("Bạn chưa có sản phẩm nào để nhập\nhoặc bạn chưa nhập mã hóa đơn mới!", "Chú ý",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
