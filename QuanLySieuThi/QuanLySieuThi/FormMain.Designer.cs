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
            this.MenuItem_AllSP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SearchSP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SearchSP_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SearchSP_Price = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AllKH = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SearchKH = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SearchKH_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SearchKH_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốSảnPhẩmBánĐượcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_SoSP1N = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_SoSPNN = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_DT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_DT1N = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_DTNN = new System.Windows.Forms.ToolStripMenuItem();
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
            this.kháchHàngToolStripMenuItem,
            this.MenuItem_Employee,
            this.thốngKêToolStripMenuItem,
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
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
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
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AllSP,
            this.MenuItem_SearchSP});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // MenuItem_AllSP
            // 
            this.MenuItem_AllSP.Name = "MenuItem_AllSP";
            this.MenuItem_AllSP.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_AllSP.Text = "Danh sách sản phẩm";
            // 
            // MenuItem_SearchSP
            // 
            this.MenuItem_SearchSP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SearchSP_Name,
            this.MenuItem_SearchSP_Price});
            this.MenuItem_SearchSP.Name = "MenuItem_SearchSP";
            this.MenuItem_SearchSP.Size = new System.Drawing.Size(184, 22);
            this.MenuItem_SearchSP.Text = "Tìm kiếm sản phẩm";
            // 
            // MenuItem_SearchSP_Name
            // 
            this.MenuItem_SearchSP_Name.Name = "MenuItem_SearchSP_Name";
            this.MenuItem_SearchSP_Name.Size = new System.Drawing.Size(121, 22);
            this.MenuItem_SearchSP_Name.Text = "Theo tên";
            // 
            // MenuItem_SearchSP_Price
            // 
            this.MenuItem_SearchSP_Price.Name = "MenuItem_SearchSP_Price";
            this.MenuItem_SearchSP_Price.Size = new System.Drawing.Size(121, 22);
            this.MenuItem_SearchSP_Price.Text = "Theo giá";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AllKH,
            this.MenuItem_SearchKH});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // MenuItem_AllKH
            // 
            this.MenuItem_AllKH.Name = "MenuItem_AllKH";
            this.MenuItem_AllKH.Size = new System.Drawing.Size(194, 22);
            this.MenuItem_AllKH.Text = "Danh sách khách hàng";
            // 
            // MenuItem_SearchKH
            // 
            this.MenuItem_SearchKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SearchKH_Name,
            this.MenuItem_SearchKH_ID});
            this.MenuItem_SearchKH.Name = "MenuItem_SearchKH";
            this.MenuItem_SearchKH.Size = new System.Drawing.Size(194, 22);
            this.MenuItem_SearchKH.Text = "Tìm kiếm khách hàng";
            // 
            // MenuItem_SearchKH_Name
            // 
            this.MenuItem_SearchKH_Name.Name = "MenuItem_SearchKH_Name";
            this.MenuItem_SearchKH_Name.Size = new System.Drawing.Size(121, 22);
            this.MenuItem_SearchKH_Name.Text = "Theo tên";
            // 
            // MenuItem_SearchKH_ID
            // 
            this.MenuItem_SearchKH_ID.Name = "MenuItem_SearchKH_ID";
            this.MenuItem_SearchKH_ID.Size = new System.Drawing.Size(121, 22);
            this.MenuItem_SearchKH_ID.Text = "Theo mã";
            // 
            // MenuItem_Employee
            // 
            this.MenuItem_Employee.Name = "MenuItem_Employee";
            this.MenuItem_Employee.Size = new System.Drawing.Size(74, 20);
            this.MenuItem_Employee.Text = "Nhân Viên";
            this.MenuItem_Employee.Click += new System.EventHandler(this.MenuItem_Employee_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốSảnPhẩmBánĐượcToolStripMenuItem,
            this.MenuItem_Stat_DT,
            this.MenuItem_AllHD});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // sốSảnPhẩmBánĐượcToolStripMenuItem
            // 
            this.sốSảnPhẩmBánĐượcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Stat_SoSP1N,
            this.MenuItem_Stat_SoSPNN});
            this.sốSảnPhẩmBánĐượcToolStripMenuItem.Name = "sốSảnPhẩmBánĐượcToolStripMenuItem";
            this.sốSảnPhẩmBánĐượcToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sốSảnPhẩmBánĐượcToolStripMenuItem.Text = "Số sản phẩm bán được";
            // 
            // MenuItem_Stat_SoSP1N
            // 
            this.MenuItem_Stat_SoSP1N.Name = "MenuItem_Stat_SoSP1N";
            this.MenuItem_Stat_SoSP1N.Size = new System.Drawing.Size(208, 22);
            this.MenuItem_Stat_SoSP1N.Text = "Trong 1 ngày";
            // 
            // MenuItem_Stat_SoSPNN
            // 
            this.MenuItem_Stat_SoSPNN.Name = "MenuItem_Stat_SoSPNN";
            this.MenuItem_Stat_SoSPNN.Size = new System.Drawing.Size(208, 22);
            this.MenuItem_Stat_SoSPNN.Text = "Trong 1 khoảng thời gian";
            // 
            // MenuItem_Stat_DT
            // 
            this.MenuItem_Stat_DT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Stat_DT1N,
            this.MenuItem_Stat_DTNN});
            this.MenuItem_Stat_DT.Name = "MenuItem_Stat_DT";
            this.MenuItem_Stat_DT.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_Stat_DT.Text = "Doanh thu";
            // 
            // MenuItem_Stat_DT1N
            // 
            this.MenuItem_Stat_DT1N.Name = "MenuItem_Stat_DT1N";
            this.MenuItem_Stat_DT1N.Size = new System.Drawing.Size(208, 22);
            this.MenuItem_Stat_DT1N.Text = "Trong 1 ngày";
            // 
            // MenuItem_Stat_DTNN
            // 
            this.MenuItem_Stat_DTNN.Name = "MenuItem_Stat_DTNN";
            this.MenuItem_Stat_DTNN.Size = new System.Drawing.Size(208, 22);
            this.MenuItem_Stat_DTNN.Text = "Trong 1 khoảng thời gian";
            // 
            // MenuItem_AllHD
            // 
            this.MenuItem_AllHD.Name = "MenuItem_AllHD";
            this.MenuItem_AllHD.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_AllHD.Text = "Danh sách hóa đơn";
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
            this.MenuItem_Help.Size = new System.Drawing.Size(65, 20);
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
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AllSP;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SearchSP;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SearchSP_Name;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SearchSP_Price;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AllKH;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SearchKH;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SearchKH_Name;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SearchKH_ID;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Employee;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốSảnPhẩmBánĐượcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_SoSP1N;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_SoSPNN;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_DT;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_DT1N;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_DTNN;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AllHD;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Import;
    }
}

