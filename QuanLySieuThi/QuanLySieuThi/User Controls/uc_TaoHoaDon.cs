using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.User_Controls
{
    public partial class uc_TaoHoaDon : UserControl
    {
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

        }
    }
}
