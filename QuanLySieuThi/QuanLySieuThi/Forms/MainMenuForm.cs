using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using QuanLySieuThi.User_Controls;

namespace QuanLySieuThi.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        void loadButton()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, button_Help.Width - 8, button_Help.Height - 8);
            button_Help.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_System.Width - 8, button_System.Height - 8);
            button_System.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Products.Width - 8, button_Products.Height - 8);
            button_Products.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Customer.Width - 8, button_Customer.Height - 8);
            button_Customer.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Employee.Width - 8, button_Employee.Height - 8);
            button_Employee.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Statistics.Width - 8, button_Statistics.Height - 8);
            button_Statistics.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Bill.Width - 8, button_Bill.Height - 8);
            button_Bill.Region = new Region(path);
            path.Reset();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            panel_Main.BackgroundImage = Properties.Resources.sieuthi;
            //this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            //this.WindowState = FormWindowState.Maximized;
            loadButton();
        }

        private void button_Customer_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            uc_KhachHang kh = new uc_KhachHang();
            panel_Main.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            uc_NhanVien nv = new uc_NhanVien();
            panel_Main.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
        }

        private void button_Statistics_Click(object sender, EventArgs e)
        {

        }

        private void button_Bill_Click(object sender, EventArgs e)
        {

        }

        private void button_Help_Click(object sender, EventArgs e)
        {

        }

        private void button_System_Click(object sender, EventArgs e)
        {

        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            uc_SanPham sp = new uc_SanPham();
            panel_Main.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
        }
    }
}
