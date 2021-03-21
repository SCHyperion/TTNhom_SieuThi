namespace QuanLySieuThi
{
    partial class frmHoaDon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HDBan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CTHDBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDBanCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHangBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeNgayMua = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HDNhap = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CTHDNhap = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHDNhap = new System.Windows.Forms.TextBox();
            this.txtMaHDNhapCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHangNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDNhap)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn bán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa đơn nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HDBan);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn bán";
            // 
            // HDBan
            // 
            this.HDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HDBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HDBan.Location = new System.Drawing.Point(3, 18);
            this.HDBan.Name = "HDBan";
            this.HDBan.RowHeadersWidth = 51;
            this.HDBan.RowTemplate.Height = 24;
            this.HDBan.Size = new System.Drawing.Size(400, 250);
            this.HDBan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.dateTimeNgayMua);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHDBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 494);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.txtSoLuongBan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaHangBan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMaHDBanCT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(486, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 492);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CTHDBan);
            this.groupBox2.Location = new System.Drawing.Point(42, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 271);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn bán";
            // 
            // CTHDBan
            // 
            this.CTHDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTHDBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTHDBan.Location = new System.Drawing.Point(3, 18);
            this.CTHDBan.Name = "CTHDBan";
            this.CTHDBan.RowHeadersWidth = 51;
            this.CTHDBan.RowTemplate.Height = 24;
            this.CTHDBan.Size = new System.Drawing.Size(397, 250);
            this.CTHDBan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(177, 338);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(132, 22);
            this.txtMaHDBan.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(177, 383);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(132, 22);
            this.txtMaKH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã khách hàng";
            // 
            // txtMaHDBanCT
            // 
            this.txtMaHDBanCT.Location = new System.Drawing.Point(151, 336);
            this.txtMaHDBanCT.Name = "txtMaHDBanCT";
            this.txtMaHDBanCT.Size = new System.Drawing.Size(134, 22);
            this.txtMaHDBanCT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã hóa đơn";
            // 
            // txtMaHangBan
            // 
            this.txtMaHangBan.Location = new System.Drawing.Point(151, 389);
            this.txtMaHangBan.Name = "txtMaHangBan";
            this.txtMaHangBan.Size = new System.Drawing.Size(134, 22);
            this.txtMaHangBan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã hàng";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(151, 434);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(134, 22);
            this.txtSoLuongBan.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày mua";
            // 
            // dateTimeNgayMua
            // 
            this.dateTimeNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayMua.Location = new System.Drawing.Point(177, 434);
            this.dateTimeNgayMua.Name = "dateTimeNgayMua";
            this.dateTimeNgayMua.Size = new System.Drawing.Size(132, 22);
            this.dateTimeNgayMua.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimeNgayNhap);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtMaHDNhap);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 494);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSoLuongNhap);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtGiaNhap);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtMaHangNhap);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtMaHDNhapCT);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Location = new System.Drawing.Point(403, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 494);
            this.panel4.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HDNhap);
            this.groupBox3.Location = new System.Drawing.Point(21, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 331);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn nhập";
            // 
            // HDNhap
            // 
            this.HDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HDNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HDNhap.Location = new System.Drawing.Point(3, 18);
            this.HDNhap.Name = "HDNhap";
            this.HDNhap.RowHeadersWidth = 51;
            this.HDNhap.RowTemplate.Height = 24;
            this.HDNhap.Size = new System.Drawing.Size(332, 310);
            this.HDNhap.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CTHDNhap);
            this.groupBox4.Location = new System.Drawing.Point(38, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 328);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn nhập";
            // 
            // CTHDNhap
            // 
            this.CTHDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTHDNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTHDNhap.Location = new System.Drawing.Point(3, 18);
            this.CTHDNhap.Name = "CTHDNhap";
            this.CTHDNhap.RowHeadersWidth = 51;
            this.CTHDNhap.RowTemplate.Height = 24;
            this.CTHDNhap.Size = new System.Drawing.Size(487, 307);
            this.CTHDNhap.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã hóa đơn";
            // 
            // txtMaHDNhap
            // 
            this.txtMaHDNhap.Location = new System.Drawing.Point(152, 386);
            this.txtMaHDNhap.Name = "txtMaHDNhap";
            this.txtMaHDNhap.Size = new System.Drawing.Size(135, 22);
            this.txtMaHDNhap.TabIndex = 2;
            // 
            // txtMaHDNhapCT
            // 
            this.txtMaHDNhapCT.Location = new System.Drawing.Point(144, 393);
            this.txtMaHDNhapCT.Name = "txtMaHDNhapCT";
            this.txtMaHDNhapCT.Size = new System.Drawing.Size(118, 22);
            this.txtMaHDNhapCT.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã hóa đơn";
            // 
            // txtMaHangNhap
            // 
            this.txtMaHangNhap.Location = new System.Drawing.Point(400, 388);
            this.txtMaHangNhap.Name = "txtMaHangNhap";
            this.txtMaHangNhap.Size = new System.Drawing.Size(128, 22);
            this.txtMaHangNhap.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã hàng";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(144, 450);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(118, 22);
            this.txtGiaNhap.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Giá nhập";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(400, 450);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(131, 22);
            this.txtSoLuongNhap.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ngày nhập";
            // 
            // dateTimeNgayNhap
            // 
            this.dateTimeNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayNhap.Location = new System.Drawing.Point(152, 441);
            this.dateTimeNgayNhap.Name = "dateTimeNgayNhap";
            this.dateTimeNgayNhap.Size = new System.Drawing.Size(135, 22);
            this.dateTimeNgayNhap.TabIndex = 12;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HDBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HDNhap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHangBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHDBanCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CTHDBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeNgayMua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView HDBan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaHangNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHDNhapCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView CTHDNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaHDNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView HDNhap;
    }
}