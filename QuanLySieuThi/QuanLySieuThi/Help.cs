using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLySieuThi
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            treeview_All.Nodes.Add("System", "Hệ thống");
            treeview_All.Nodes["System"].Nodes.Add("Thông tin tài khoản");
            treeview_All.Nodes["System"].Nodes.Add("Đăng xuất");

            treeview_All.Nodes.Add("Product", "Sản phẩm");

            treeview_All.Nodes.Add("Customer", "Khách hàng");

            treeview_All.Nodes.Add("Employee", "Nhân viên");

            treeview_All.Nodes.Add("Statistics", "Thống kê");
            treeview_All.Nodes["Statistics"].Nodes.Add("Số sản phẩm bán được");
            treeview_All.Nodes["Statistics"].Nodes.Add("Doanh thu");
            treeview_All.Nodes["Statistics"].Nodes.Add("Danh sách hóa đơn");

            treeview_All.Nodes.Add("Bill", "Tạo hóa đơn");
        }

        private void treeview_All_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Thông tin tài khoản":             // done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\TaiKhoan.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\TaiKhoan.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Đăng xuất":                       // done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\DangXuat.txt");
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Sản phẩm":                        // done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\QLSanPham.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\QLSanPham.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Khách hàng":                      // done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\KhachHang.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\KhachHang.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Nhân viên":
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Số sản phẩm bán được":            // done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\SoSP_Ngay.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\SoSP_Ngay.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.AppendText(File.ReadAllText(@"Help\SoSP_TG.txt"));
                        Clipboard.SetImage(Image.FromFile(@"Help\SoSP_TG.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Doanh thu":
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Danh sách hóa đơn":               // done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\HDBan.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\HDBan.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.AppendText(File.ReadAllText(@"Help\HDNhap.txt"));
                        Clipboard.SetImage(Image.FromFile(@"Help\HDNhap.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Tạo hóa đơn":
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
            }
        }
    }
}
