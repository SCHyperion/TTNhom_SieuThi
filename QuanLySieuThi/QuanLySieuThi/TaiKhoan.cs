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
        int id;
        string pass = "";
        bool writeMode = false;
        public TaiKhoan(int id, string pass)
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
                    "WHERE MaNV = " + id.ToString();
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
            if (writeMode == false)
            {
                writeMode = true;
                textbox_TenNV.Enabled = true;   textbox_TenNV.ReadOnly = false;
                textbox_DiaChi.Enabled = true;  textbox_DiaChi.ReadOnly = false;
                textbox_Luong.Enabled = true;   textbox_Luong.ReadOnly = false;
                textbox_SDT.Enabled = true;     textbox_SDT.ReadOnly = false;
                textbox_Pass.Enabled = true;    textbox_Pass.ReadOnly = false;
                button_Confirm.Enabled = true;
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.str))
                {
                    using (SqlCommand cmd = new SqlCommand("TaiKhoan_Sua", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@maNV", SqlDbType.SmallInt).Value = textbox_MaNV.Text;
                        cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = textbox_TenNV.Text;
                        cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = textbox_DiaChi.Text;
                        cmd.Parameters.Add("@sodt", SqlDbType.VarChar).Value = textbox_Luong.Text;
                        cmd.Parameters.Add("@luong", SqlDbType.BigInt).Value = textbox_SDT.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = textbox_Pass.Text;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi\n" + ex.Message);
            }
            writeMode = false;
            textbox_TenNV.Enabled = false;  textbox_TenNV.ReadOnly = true;
            textbox_DiaChi.Enabled = false; textbox_DiaChi.ReadOnly = true;
            textbox_Luong.Enabled = false;  textbox_Luong.ReadOnly = true;
            textbox_SDT.Enabled = false;    textbox_SDT.ReadOnly = true;
            textbox_Pass.Enabled = false;   textbox_Pass.ReadOnly = true;
            button_Confirm.Enabled = false;
        }
    }
}
