﻿using System;
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
    public partial class FormMain : Form
    {
        int curID;
        string curPass = "";
        //public FormMain(string id, string pass)
        public FormMain(int id, string pass)
        {
            curID = id;
            curPass = pass;
            InitializeComponent();
        }

        // Nhan vien
        private void MenuItem_Employee_Click(object sender, EventArgs e)
        {
            fNhanVien nv = new fNhanVien();
            nv.Show();
        }                   

        // Thong tin tai khoan
        private void MenuItem_AccountDetail_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(curID, curPass);
            tk.Show();
        }          

        // Logout
        private void MenuItem_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var flogin = new Login();
            flogin.Closed += (s, args) => this.Close();
            flogin.Show();
        }                   

        // Exit
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Help
        private void MenuItem_Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        // So san pham ban
        private void MenuItem_Stat_SoSPBan_Click(object sender, EventArgs e)
        {
            frmThongKe soSP = new frmThongKe();
            soSP.Show();
        }

        // Doanh thu
        private void MenuItem_Stat_DT_Click(object sender, EventArgs e)
        {
            FormDoanhThuBan dt = new FormDoanhThuBan();
            dt.Show();
        }

        // Danh sach hoa don
        private void MenuItem_AllHD_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.Show();
        }

        // Khach hang
        private void MenuItem_Customer_Click(object sender, EventArgs e)
        {
            Form_Khachhang kh = new Form_Khachhang();
            kh.Show();
        }

        // San pham
        private void MenuItem_SanPham_Click(object sender, EventArgs e)
        {
            frm_MatHang mh = new frm_MatHang();
            mh.Show();
        }

        // Tao hoa don
        private void MenuItem_CreateBill_Click(object sender, EventArgs e)
        {

        }

        // Init
        private void FormMain_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                string query = "SELECT * FROM NhanVien " +
                    "WHERE MaNV = '" + curID.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                CurrentUser.Text = "Xin chào " + reader["TenNV"].ToString();
            }
        }
    }
}
