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
    public partial class TKSoSP : UserControl
    {
        public TKSoSP()
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, btnThongKeNgay.Width - 8, btnThongKeNgay.Height - 8);
            btnThongKeNgay.Region = new Region(path);
            path.Reset();
            path.AddEllipse(4, 4, btnThongKeNgay_Ngay.Width - 8, btnThongKeNgay_Ngay.Height - 8);
            btnThongKeNgay_Ngay.Region = new Region(path);
            path.Reset();
        }
        SqlConnection connection = new SqlConnection(ConnectionString.str);

        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT c.MaHang as 'Mã Hàng', m.TenHang as 'Tên Hàng', SUM(c.SoLuong) AS 'Số Lượng'" +
                                           " FROM HDBan h join CTHDBan c on h.MaHD = c.MaHD, MatHang m" +
                                           " WHERE h.NgayMua LIKE '" + txtNgay.Text + "' and c.MaHang = m.MaHang" +
                                           " GROUP BY c.MaHang, m.TenHang", connection);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                dataGridView1.DataSource = table;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKeNgay_Ngay_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT c.MaHang as 'Mã Hàng', m.TenHang as 'Tên Hàng', SUM(c.SoLuong) AS 'Số Lượng'" +
                                           " FROM HDBan h join CTHDBan c on h.MaHD = c.MaHD, MatHang m" +
                                           " WHERE h.NgayMua  BETWEEN CONVERT(date,'" + txtNgay_Ngay1.Text + "') and CONVERT(date,'" + txtNgay_Ngay2.Text + "') and c.MaHang = m.MaHang" +
                                           " GROUP BY c.MaHang, m.TenHang", connection);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                dataGridView2.DataSource = table;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
