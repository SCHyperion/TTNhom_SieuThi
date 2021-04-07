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

namespace QuanLySieuThi.User_Controls
{
    public partial class uc_ThongKe : UserControl
    {
        void loadButton()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, button_SoSPBan.Width - 8, button_SoSPBan.Height - 8);
            button_SoSPBan.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_DoanhThu.Width - 8, button_DoanhThu.Height - 8);
            button_DoanhThu.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_ListHD.Width - 8, button_ListHD.Height - 8);
            button_ListHD.Region = new Region(path);
            path.Reset();
        }
        public uc_ThongKe()
        {
            InitializeComponent();
            loadButton();
        }

        private void button_SoSPBan_Click(object sender, EventArgs e)
        {
            TKSoSP uc = new TKSoSP();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button_DoanhThu_Click(object sender, EventArgs e)
        {
            TKDoanhThu uc = new TKDoanhThu();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button_ListHD_Click(object sender, EventArgs e)
        {
            TKHoaDon uc = new TKHoaDon();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
