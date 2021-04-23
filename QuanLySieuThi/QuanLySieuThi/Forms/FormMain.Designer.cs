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
            this.MenuItem_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_SoSPBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Stat_DT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AllHD = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CreateBill = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.MenuItem_SanPham,
            this.MenuItem_Customer,
            this.MenuItem_Employee,
            this.MenuItem_Stat,
            this.MenuItem_CreateBill,
            this.MenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1164, 30);
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
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // MenuItem_AccountDetail
            // 
            this.MenuItem_AccountDetail.Name = "MenuItem_AccountDetail";
            this.MenuItem_AccountDetail.Size = new System.Drawing.Size(220, 26);
            this.MenuItem_AccountDetail.Text = "Thông tin tài khoản";
            this.MenuItem_AccountDetail.Click += new System.EventHandler(this.MenuItem_AccountDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuItem_Logout
            // 
            this.MenuItem_Logout.Name = "MenuItem_Logout";
            this.MenuItem_Logout.Size = new System.Drawing.Size(220, 26);
            this.MenuItem_Logout.Text = "Đăng xuất";
            this.MenuItem_Logout.Click += new System.EventHandler(this.MenuItem_Logout_Click);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(220, 26);
            this.MenuItem_Exit.Text = "Thoát";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // MenuItem_SanPham
            // 
            this.MenuItem_SanPham.Name = "MenuItem_SanPham";
            this.MenuItem_SanPham.Size = new System.Drawing.Size(88, 26);
            this.MenuItem_SanPham.Text = "Sản Phẩm";
            this.MenuItem_SanPham.Click += new System.EventHandler(this.MenuItem_SanPham_Click);
            // 
            // MenuItem_Customer
            // 
            this.MenuItem_Customer.Name = "MenuItem_Customer";
            this.MenuItem_Customer.Size = new System.Drawing.Size(103, 26);
            this.MenuItem_Customer.Text = "Khách Hàng";
            this.MenuItem_Customer.Click += new System.EventHandler(this.MenuItem_Customer_Click);
            // 
            // MenuItem_Employee
            // 
            this.MenuItem_Employee.Name = "MenuItem_Employee";
            this.MenuItem_Employee.Size = new System.Drawing.Size(91, 26);
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
            this.MenuItem_Stat.Size = new System.Drawing.Size(86, 26);
            this.MenuItem_Stat.Text = "Thống Kê";
            // 
            // MenuItem_Stat_SoSPBan
            // 
            this.MenuItem_Stat_SoSPBan.Name = "MenuItem_Stat_SoSPBan";
            this.MenuItem_Stat_SoSPBan.Size = new System.Drawing.Size(244, 26);
            this.MenuItem_Stat_SoSPBan.Text = "Số sản phẩm bán được";
            this.MenuItem_Stat_SoSPBan.Click += new System.EventHandler(this.MenuItem_Stat_SoSPBan_Click);
            // 
            // MenuItem_Stat_DT
            // 
            this.MenuItem_Stat_DT.Name = "MenuItem_Stat_DT";
            this.MenuItem_Stat_DT.Size = new System.Drawing.Size(244, 26);
            this.MenuItem_Stat_DT.Text = "Doanh thu";
            this.MenuItem_Stat_DT.Click += new System.EventHandler(this.MenuItem_Stat_DT_Click);
            // 
            // MenuItem_AllHD
            // 
            this.MenuItem_AllHD.Name = "MenuItem_AllHD";
            this.MenuItem_AllHD.Size = new System.Drawing.Size(244, 26);
            this.MenuItem_AllHD.Text = "Danh sách hóa đơn";
            this.MenuItem_AllHD.Click += new System.EventHandler(this.MenuItem_AllHD_Click);
            // 
            // MenuItem_CreateBill
            // 
            this.MenuItem_CreateBill.Name = "MenuItem_CreateBill";
            this.MenuItem_CreateBill.Size = new System.Drawing.Size(107, 26);
            this.MenuItem_CreateBill.Text = "Tạo hóa đơn";
            this.MenuItem_CreateBill.Click += new System.EventHandler(this.MenuItem_CreateBill_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(79, 26);
            this.MenuItem_Help.Text = "Trợ Giúp";
            this.MenuItem_Help.Click += new System.EventHandler(this.MenuItem_Help_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1164, 31);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CurrentUser
            // 
            this.CurrentUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUser.ForeColor = System.Drawing.Color.Red;
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.Size = new System.Drawing.Size(93, 25);
            this.CurrentUser.Text = "Xin chào ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLySieuThi.Properties.Resources.sieuthi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Siêu Thị";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SanPham;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Customer;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Employee;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_SoSPBan;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Stat_DT;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AllHD;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_CreateBill;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

