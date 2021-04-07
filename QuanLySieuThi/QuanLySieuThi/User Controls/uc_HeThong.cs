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
using QuanLySieuThi.Forms;

namespace QuanLySieuThi.User_Controls
{
    public partial class uc_HeThong : UserControl
    {
        int id;
        string pass;
        void loadButton()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, button_TTTK.Width - 8, button_TTTK.Height - 8);
            button_TTTK.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_DangXuat.Width - 8, button_DangXuat.Height - 8);
            button_DangXuat.Region = new Region(path);
            path.Reset();

            path.AddEllipse(4, 4, button_Thoat.Width - 8, button_Thoat.Height - 8);
            button_Thoat.Region = new Region(path);
            path.Reset();
        }
        public uc_HeThong(int id, string pass)
        {
            this.id = id;
            this.pass = pass;
            InitializeComponent();
            loadButton();
        }

        private void button_TTTK_Click(object sender, EventArgs e)
        {
            uc_TaiKhoan uc = new uc_TaiKhoan(id, pass);
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            
            //var flogin = new Login();
            //flogin.Closed += (s, args) => mf.Close();
            //flogin.Show();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát chuong trinh", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                Application.Exit();
            
        }
    }
}
