﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Forms;

namespace QuanLySieuThi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* //Application.Run(new FormMain(1, "1"));
<<<<<<< HEAD
            //Application.Run(new frmHoaDon());
            //Application.Run(new MainForm(1, "1"));
=======
            //Application.Run(new frmHDBan1());
            Application.Run(new MainForm(1, "1"));
>>>>>>> 1135dbc2b1c4619abd020234f4e4cf916112826a
            //Application.Run(new Test());
            //Application.Run(new Login());*/
            Application.Run(new frmHoaDon());
        }
    }
}
