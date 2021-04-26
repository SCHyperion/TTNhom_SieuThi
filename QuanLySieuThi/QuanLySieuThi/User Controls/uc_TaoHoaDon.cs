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
    public partial class uc_TaoHoaDon : UserControl
    {
        void loadButton()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, button_HDNhap.Width - 8, button_HDNhap.Height - 8);
            button_HDNhap.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_HDBan.Width - 8, button_HDBan.Height - 8);
            button_HDBan.Region = new Region(path);
            path.Reset();
        }
        public uc_TaoHoaDon()
        {
            InitializeComponent();
        }

        private void button_HDNhap_Click(object sender, EventArgs e)
        {
            HDNhap uc = new HDNhap();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button_HDBan_Click(object sender, EventArgs e)
        {
            frmHDBan1 f = new frmHDBan1();
            f.Show();
        }
    }
}
