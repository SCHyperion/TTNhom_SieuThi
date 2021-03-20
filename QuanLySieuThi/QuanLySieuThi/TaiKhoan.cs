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
    public partial class TaiKhoan : Form
    {
        string id = "";
        string pass = "";
        public TaiKhoan(string id, string pass)
        {
            this.id = id;
            this.pass = pass;
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                string query = "SELECT * FROM NhanVien " +
                    "WHERE MaNV = " + Int32.Parse(id);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textbox_MaNV.Text = reader["MaNV"].ToString();
                textbox_TenNV.Text = reader["TenNV"].ToString();
                textbox_DiaChi.Text= reader["DiaChi"].ToString();
                textbox_Luong.Text = reader["Luong"].ToString();
                textbox_SDT.Text = reader["SoDT"].ToString();
                textbox_Pass.Text = pass;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
