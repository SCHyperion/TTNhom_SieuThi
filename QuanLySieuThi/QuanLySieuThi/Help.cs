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

            treeview_All.Nodes.Add("Product", "Sản Phẩm");
            treeview_All.Nodes["Product"].Nodes.Add("Danh sách sản phẩm");
            treeview_All.Nodes["Product"].Nodes.Add("Tìm kiếm sản phẩm");

            treeview_All.Nodes.Add("Customer", "Khách hàng");
            treeview_All.Nodes["Customer"].Nodes.Add("Danh sách khách hàng");
            treeview_All.Nodes["Customer"].Nodes.Add("Tìm kiếm khách hàng");

            treeview_All.Nodes.Add("Employee", "Nhân viên");

            treeview_All.Nodes.Add("Statistics", "Thống kê");
            treeview_All.Nodes["Statistics"].Nodes.Add("Số sản phẩm bán được");
            treeview_All.Nodes["Statistics"].Nodes.Add("Doanh thu");
            treeview_All.Nodes["Statistics"].Nodes.Add("Danh sách hóa đơn");

            treeview_All.Nodes.Add("Import", "Nhập hàng");
        }

        private void treeview_All_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Thông tin tài khoản":
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"Help\test.txt");
                        Clipboard.SetImage(Image.FromFile(@"Help\test.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Đăng xuất":
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
