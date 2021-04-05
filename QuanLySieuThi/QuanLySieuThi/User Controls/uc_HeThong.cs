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
    public partial class uc_HeThong : UserControl
    {
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
        public uc_HeThong()
        {
            InitializeComponent();
            loadButton();
        }
    }
}
