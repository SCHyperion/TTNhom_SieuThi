namespace QuanLySieuThi
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AccountDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_SoSPBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_DT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AllHD = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.MenuItem_Customer,
            this.MenuItem_Employee,
            this.MenuItem_Stat,
            this.MenuItem_Import,
            this.MenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AccountDetail,
            this.toolStripSeparator1,
            this.MenuItem_Logout,
            this.MenuItem_Exit});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // MenuItem_AccountDetail
            // 
            this.MenuItem_AccountDetail.Name = "MenuItem_AccountDetail";
            this.MenuItem_AccountDetail.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_AccountDetail.Text = "Thông tin tài khoản";
            this.MenuItem_AccountDetail.Click += new System.EventHandler(this.MenuItem_AccountDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItem_Logout
            // 
            this.MenuItem_Logout.Name = "MenuItem_Logout";
            this.MenuItem_Logout.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Logout.Text = "Đăng xuất";
            this.MenuItem_Logout.Click += new System.EventHandler(this.MenuItem_Logout_Click);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Exit.Text = "Thoát";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // MenuItem_Customer
            // 
            this.MenuItem_Customer.Name = "MenuItem_Customer";
            this.MenuItem_Customer.Size = new System.Drawing.Size(84, 20);
            this.MenuItem_Customer.Text = "Khách Hàng";
            this.MenuItem_Customer.Click += new System.EventHandler(this.MenuItem_Customer_Click);
            // 
            // MenuItem_Employee
            // 
            this.MenuItem_Employee.Name = "MenuItem_Employee";
            this.MenuItem_Employee.Size = new System.Drawing.Size(74, 20);
            this.MenuItem_Employee.Text = "Nhân Viên";
            this.MenuItem_Employee.Click += new System.EventHandler(this.MenuItem_Employee_Click);
            // 
            // MenuItem_Stat
            // 
            this.MenuItem_Stat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Stat_SoSPBan,
            this.MenuItem_Stat_DT,
            this.MenuItem_AllHD});
            this.MenuItem_Stat.Name = "MenuItem_Stat";
            this.MenuItem_Stat.Size = new System.Drawing.Size(69, 20);
            this.MenuItem_Stat.Text = "Thống Kê";
            // 
            // MenuItem_Stat_SoSPBan
            // 
            this.MenuItem_Stat_SoSPBan.Name = "MenuItem_Stat_SoSPBan";
            this.MenuItem_Stat_SoSPBan.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_Stat_SoSPBan.Text = "Số sản phẩm bán được";
            this.MenuItem_Stat_SoSPBan.Click += new System.EventHandler(this.MenuItem_Stat_SoSPBan_Click);
            // 
            // MenuItem_Stat_DT
            // 
            this.MenuItem_Stat_DT.Name = "MenuItem_Stat_DT";
            this.MenuItem_Stat_DT.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_Stat_DT.Text = "Doanh thu";
            this.MenuItem_Stat_DT.Click += new System.EventHandler(this.MenuItem_Stat_DT_Click);
            // 
            // MenuItem_AllHD
            // 
            this.MenuItem_AllHD.Name = "MenuItem_AllHD";
            this.MenuItem_AllHD.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_AllHD.Text = "Danh sách hóa đơn";
            this.MenuItem_AllHD.Click += new System.EventHandler(this.MenuItem_AllHD_Click);
            // 
            // MenuItem_Import
            // 
            this.MenuItem_Import.Name = "MenuItem_Import";
            this.MenuItem_Import.Size = new System.Drawing.Size(80, 20);
            this.MenuItem_Import.Text = "Nhập Hàng";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(63, 20);
            this.MenuItem_Help.Text = "Trợ Giúp";
            this.MenuItem_Help.Click += new System.EventHandler(this.MenuItem_Help_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Siêu Thị";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AccountDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Logout;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Customer;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Employee;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_SoSPBan;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_DT;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AllHD;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Import;
    }
}

