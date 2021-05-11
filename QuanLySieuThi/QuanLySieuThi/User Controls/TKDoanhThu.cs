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
    public partial class TKDoanhThu : UserControl
    {
        public TKDoanhThu()
        {
            InitializeComponent();
            load();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, buttonLoc.Width - 8, buttonLoc.Height - 8);
            buttonLoc.Region = new Region(path);
            path.Reset();
        }
        private string connectString = ConnectionString.str;

        #region tools
        void load()
        {
            textBoxNgayBD.Text = DateTime.Now.ToString("MM/dd/yyyy");
            textBoxNgayKT.Text = DateTime.Now.ToString("MM/dd/yyyy");
            textBoxTong.Enabled = false;
        }
        bool soSanhNgay(string d1, string d2)
        {
            DateTime dat1 = DateTime.Parse(d1);
            DateTime dat2 = DateTime.Parse(d2);
            if (dat1 <= dat2) return true;
            else return false;
        }
        #endregion
        #region Excute Query
        public DataTable InstallQuery(string query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
        public int InstallNonQuery(string query)
        {
            int data = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    data = command.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
        #endregion
        #region Event
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxNgayBD.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBoxNgayKT.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
        }
        #endregion

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            if (soSanhNgay(textBoxNgayBD.Text, textBoxNgayKT.Text))
            {
                try
                {
                    dataGridView1.DataSource = InstallQuery("Select * from dbo.thongKeTheoNgay('" + textBoxNgayBD.Text + "','" + textBoxNgayKT.Text + "')");
                    dataGridView2.DataSource = InstallQuery("select mahd, sum(dbo.thongKeBan(mahang,mahd)) as TongTien from CTHDBan Group by mahd");
                    DataTable data = InstallQuery("Select * from dbo.thongKeTheoNgay('" + textBoxNgayBD.Text + "','" + textBoxNgayKT.Text + "')");
                    textBoxTong.Clear();
                    //textBoxTong.Text = dataGridView2.Rows[0].Cells[1].Value.ToString() + " vnđ";
                    double total = 0;
                    if (dataGridView1.RowCount > 1)
                    {
                        foreach (DataRow item in data.Rows)
                        {
                            total += Convert.ToDouble(item["TongTien"].ToString());
                        }
                        textBoxTong.Text = total.ToString() + " vnđ";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ngayBan = "";
            try
            {
                ngayBan = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không nhấn vào đây!!!");
            }
            //DateTime date = new DateTime(ngayBan);
            if (ngayBan != "")
            {
                int maHD = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                int maHang = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);

                try
                {
                    string query = "select ngaymua, kh.makh, tenkh, ct.mahd, ct.mahang, mh.TenHang, soluong, giaban, dbo.thongKeBan(ct.mahang, ct.mahd) AS TongTien " +
                               "from KhachHang kh, HDBan hdb, CTHDBan ct, MatHang mh " +
                               "where kh.MaKH = hdb.MaKH and hdb.MaHD = ct.MaHD and ct.MaHang = mh.MaHang and ct.MaHang = '" + maHang + "' and ct.MaHD = '" + maHD + "' ";
                    dataGridView3.DataSource = InstallQuery(query);

                    string details = "";
                    details = details + "Thời gian bán      : " + dataGridView3.Rows[0].Cells[0].Value.ToString();
                    details = details + "\r\nMã khách hàng   : " + dataGridView3.Rows[0].Cells[1].Value.ToString();
                    details = details + "\r\nTên khách hàng   : " + dataGridView3.Rows[0].Cells[2].Value.ToString();
                    details = details + "\r\nMã hóa đơn         : " + dataGridView3.Rows[0].Cells[3].Value.ToString();
                    details = details + "\r\nMã mặt hàng       : " + dataGridView3.Rows[0].Cells[4].Value.ToString();
                    details = details + "\r\nTên mặt hàng       : " + dataGridView3.Rows[0].Cells[5].Value.ToString();
                    details = details + "\r\nSố lượng              : " + dataGridView3.Rows[0].Cells[6].Value.ToString();
                    details = details + "\r\nGiá bán                : " + dataGridView3.Rows[0].Cells[7].Value.ToString();
                    details = details + "\r\nTổng tiền             : " + dataGridView3.Rows[0].Cells[8].Value.ToString();
                    textBoxDetail.Text = details;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
