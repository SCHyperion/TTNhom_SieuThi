using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class FormMain : Form
    {
        string curID = "";
        string curPass = "";
        //public FormMain(string id, string pass)
        public FormMain()
        {
            //curID = id;
            //curPass = pass;
            InitializeComponent();
        }


        private void MenuItem_Employee_Click(object sender, EventArgs e)
        {
            fNhanVien nv = new fNhanVien();
            nv.Show();
        }

        private void MenuItem_AccountDetail_Click(object sender, EventArgs e)
        {
            //TaiKhoan tk = new TaiKhoan(curID,curPass);
            //tk.Show();
        }

        private void MenuItem_Logout_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
