using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.User_Controls;
using System.Data.SqlClient;

namespace QuanLySieuThi.Forms
{
    public partial class MainForm : MetroSetForm
    {
        int curID;
        string curPass = "";
        public MainForm(int id, string pass)
        {
            curID = id;
            curPass = pass;
            InitializeComponent();
        }
        
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl.SelectedIndex)
            {
                case 0: // Hệ Thống
                    {
                        uc_HeThong uc = new uc_HeThong(curID, curPass);
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
                        break;
                    }
                case 1: // Sản Phẩm
                    {
                        uc_SanPham uc = new uc_SanPham();
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;                       
                        break;
                    }
                case 2: // Khách Hàng
                    {
                        uc_KhachHang uc = new uc_KhachHang();
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
                        break;
                    }
                case 3: // Nhân VIên
                    {
                        uc_NhanVien uc = new uc_NhanVien();
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
                        break;
                    }
                case 4: // Thống Kê
                    {
                        uc_ThongKe uc = new uc_ThongKe();
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
                        break;
                    }
                case 5: // Tạo Hóa Đơn
                    {
                        MetroSetMessageBox.Show(this, "Under Construction");
                        break;
                    }
                case 6: // Trợ giúp
                    {
                        Help h = new Help();
                        h.Show();
                        break;
                    }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.str))
            {
                con.Open();
                string query = "SELECT * FROM NhanVien " +
                    "WHERE MaNV = '" + curID.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                this.Text = "Chào mừng " + reader["TenNV"].ToString() + " đến với chương trình quản lý siêu thị, hôm nay bạn muốn làm gì ?";
                this.TextColor = Color.Orange;
                this.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Italic);
                tabControl.ItemSize = new Size(100, 42);
                Font font = new Font("Segoe UI", 11, FontStyle.Italic);
                tabControl.Font = font;

                uc_HeThong uc = new uc_HeThong(curID, curPass);
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                
            }
        }
    }
}
