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

namespace QuanLySieuThi
{
    public partial class frmHoaDon : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionString.str);
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM CTHDBan", connection);
                SqlDataReader read2 = cmd2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Load(read2);
                CTHDBan.DataSource = table2;

                SqlCommand cmd3 = new SqlCommand("SELECT * FROM HDNhap", connection);
                SqlDataReader read3 = cmd3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Load(read3);
                HDNhap.DataSource = table3;

                SqlCommand cmd4 = new SqlCommand("SELECT * FROM CTHDNhap", connection);
                SqlDataReader read4 = cmd4.ExecuteReader();
                DataTable table4 = new DataTable();
                table4.Load(read4);
                CTHDNhap.DataSource = table4;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = HDBan.CurrentRow.Index;
            txtMaHDBan.Text = HDBan.Rows[i].Cells[0].Value.ToString();
            txtMaKH.Text = HDBan.Rows[i].Cells[1].Value.ToString();
            dateTimeNgayMua.Text = HDBan.Rows[i].Cells[2].Value.ToString();
        }

        private void CTHDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = CTHDBan.CurrentRow.Index;
            txtMaHDBanCT.Text = CTHDBan.Rows[i].Cells[0].Value.ToString();
            txtMaHangBan.Text = CTHDBan.Rows[i].Cells[1].Value.ToString();
            txtSoLuongBan.Text = CTHDBan.Rows[i].Cells[2].Value.ToString();
        }

        private void HDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = HDNhap.CurrentRow.Index;
            txtMaHDNhap.Text = HDNhap.Rows[i].Cells[0].Value.ToString();
            dateTimeNgayNhap.Text = HDNhap.Rows[i].Cells[1].Value.ToString();
        }

        private void CTHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = CTHDNhap.CurrentRow.Index;
            txtMaHDNhapCT.Text = CTHDNhap.Rows[i].Cells[0].Value.ToString();
            txtMaHangNhap.Text = CTHDNhap.Rows[i].Cells[1].Value.ToString();
            txtGiaNhap.Text = CTHDNhap.Rows[i].Cells[2].Value.ToString();
            txtSoLuongNhap.Text = CTHDNhap.Rows[i].Cells[3].Value.ToString();
        }
    }
}
