
namespace QuanLySieuThi.User_Controls
{
    partial class uc_HDBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_XoaCTHD = new System.Windows.Forms.Button();
            this.btn_SuaCTHD = new System.Windows.Forms.Button();
            this.btn_ThemCTHD = new System.Windows.Forms.Button();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHangBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHDBanCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CTHDBan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Xoa_HD = new System.Windows.Forms.Button();
            this.btn_Sua_HD = new System.Windows.Forms.Button();
            this.btn_Them_HD = new System.Windows.Forms.Button();
            this.dateTimeNgayMua = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HDBan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBan)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 497);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.btn_XoaCTHD);
            this.panel3.Controls.Add(this.btn_SuaCTHD);
            this.panel3.Controls.Add(this.btn_ThemCTHD);
            this.panel3.Controls.Add(this.txtSoLuongBan);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMaHangBan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMaHDBanCT);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(475, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 497);
            this.panel3.TabIndex = 3;
            // 
            // btn_XoaCTHD
            // 
            this.btn_XoaCTHD.Location = new System.Drawing.Point(341, 430);
            this.btn_XoaCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaCTHD.Name = "btn_XoaCTHD";
            this.btn_XoaCTHD.Size = new System.Drawing.Size(67, 29);
            this.btn_XoaCTHD.TabIndex = 13;
            this.btn_XoaCTHD.Text = "Xóa";
            this.btn_XoaCTHD.UseVisualStyleBackColor = true;
            this.btn_XoaCTHD.Click += new System.EventHandler(this.btn_XoaCTHD_Click);
            // 
            // btn_SuaCTHD
            // 
            this.btn_SuaCTHD.Location = new System.Drawing.Point(341, 386);
            this.btn_SuaCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaCTHD.Name = "btn_SuaCTHD";
            this.btn_SuaCTHD.Size = new System.Drawing.Size(67, 29);
            this.btn_SuaCTHD.TabIndex = 12;
            this.btn_SuaCTHD.Text = "Sửa";
            this.btn_SuaCTHD.UseVisualStyleBackColor = true;
            this.btn_SuaCTHD.Click += new System.EventHandler(this.btn_SuaCTHD_Click);
            // 
            // btn_ThemCTHD
            // 
            this.btn_ThemCTHD.Location = new System.Drawing.Point(341, 343);
            this.btn_ThemCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemCTHD.Name = "btn_ThemCTHD";
            this.btn_ThemCTHD.Size = new System.Drawing.Size(67, 29);
            this.btn_ThemCTHD.TabIndex = 11;
            this.btn_ThemCTHD.Text = "Thêm";
            this.btn_ThemCTHD.UseVisualStyleBackColor = true;
            this.btn_ThemCTHD.Click += new System.EventHandler(this.btn_ThemCTHD_Click);
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(178, 433);
            this.txtSoLuongBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(124, 22);
            this.txtSoLuongBan.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng:";
            // 
            // txtMaHangBan
            // 
            this.txtMaHangBan.Location = new System.Drawing.Point(178, 389);
            this.txtMaHangBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHangBan.Name = "txtMaHangBan";
            this.txtMaHangBan.Size = new System.Drawing.Size(124, 22);
            this.txtMaHangBan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã hàng:";
            // 
            // txtMaHDBanCT
            // 
            this.txtMaHDBanCT.Location = new System.Drawing.Point(178, 346);
            this.txtMaHDBanCT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHDBanCT.Name = "txtMaHDBanCT";
            this.txtMaHDBanCT.Size = new System.Drawing.Size(124, 22);
            this.txtMaHDBanCT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CTHDBan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(475, 315);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn bán";
            // 
            // CTHDBan
            // 
            this.CTHDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTHDBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTHDBan.Location = new System.Drawing.Point(2, 17);
            this.CTHDBan.Margin = new System.Windows.Forms.Padding(2);
            this.CTHDBan.Name = "CTHDBan";
            this.CTHDBan.RowHeadersWidth = 51;
            this.CTHDBan.RowTemplate.Height = 24;
            this.CTHDBan.Size = new System.Drawing.Size(471, 296);
            this.CTHDBan.TabIndex = 0;
            this.CTHDBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CTHDBan_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.btn_Xoa_HD);
            this.panel2.Controls.Add(this.btn_Sua_HD);
            this.panel2.Controls.Add(this.btn_Them_HD);
            this.panel2.Controls.Add(this.dateTimeNgayMua);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaHDBan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 497);
            this.panel2.TabIndex = 2;
            // 
            // btn_Xoa_HD
            // 
            this.btn_Xoa_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_HD.Location = new System.Drawing.Point(337, 430);
            this.btn_Xoa_HD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa_HD.Name = "btn_Xoa_HD";
            this.btn_Xoa_HD.Size = new System.Drawing.Size(67, 29);
            this.btn_Xoa_HD.TabIndex = 9;
            this.btn_Xoa_HD.Text = "Xóa";
            this.btn_Xoa_HD.UseVisualStyleBackColor = true;
            this.btn_Xoa_HD.Click += new System.EventHandler(this.btn_Xoa_HD_Click);
            // 
            // btn_Sua_HD
            // 
            this.btn_Sua_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_HD.Location = new System.Drawing.Point(337, 386);
            this.btn_Sua_HD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua_HD.Name = "btn_Sua_HD";
            this.btn_Sua_HD.Size = new System.Drawing.Size(67, 29);
            this.btn_Sua_HD.TabIndex = 8;
            this.btn_Sua_HD.Text = "Sửa";
            this.btn_Sua_HD.UseVisualStyleBackColor = true;
            this.btn_Sua_HD.Click += new System.EventHandler(this.btn_Sua_HD_Click);
            // 
            // btn_Them_HD
            // 
            this.btn_Them_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_HD.Location = new System.Drawing.Point(337, 343);
            this.btn_Them_HD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them_HD.Name = "btn_Them_HD";
            this.btn_Them_HD.Size = new System.Drawing.Size(67, 29);
            this.btn_Them_HD.TabIndex = 7;
            this.btn_Them_HD.Text = "Thêm";
            this.btn_Them_HD.UseVisualStyleBackColor = true;
            this.btn_Them_HD.Click += new System.EventHandler(this.btn_Them_HD_Click);
            // 
            // dateTimeNgayMua
            // 
            this.dateTimeNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayMua.Location = new System.Drawing.Point(170, 431);
            this.dateTimeNgayMua.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNgayMua.Name = "dateTimeNgayMua";
            this.dateTimeNgayMua.Size = new System.Drawing.Size(124, 22);
            this.dateTimeNgayMua.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày mua:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(170, 389);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(124, 22);
            this.txtMaKH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã khách hàng:";
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDBan.Location = new System.Drawing.Point(170, 346);
            this.txtMaHDBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(124, 22);
            this.txtMaHDBan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HDBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(475, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn bán";
            // 
            // HDBan
            // 
            this.HDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HDBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HDBan.Location = new System.Drawing.Point(2, 17);
            this.HDBan.Margin = new System.Windows.Forms.Padding(2);
            this.HDBan.Name = "HDBan";
            this.HDBan.RowHeadersWidth = 51;
            this.HDBan.RowTemplate.Height = 24;
            this.HDBan.Size = new System.Drawing.Size(471, 296);
            this.HDBan.TabIndex = 0;
            this.HDBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HDBan_CellClick);
            // 
            // uc_HDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_HDBan";
            this.Size = new System.Drawing.Size(990, 537);
            this.Load += new System.EventHandler(this.uc_HDBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HDBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Xoa_HD;
        private System.Windows.Forms.Button btn_Sua_HD;
        private System.Windows.Forms.Button btn_Them_HD;
        private System.Windows.Forms.DateTimePicker dateTimeNgayMua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView HDBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_XoaCTHD;
        private System.Windows.Forms.Button btn_SuaCTHD;
        private System.Windows.Forms.Button btn_ThemCTHD;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHangBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHDBanCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CTHDBan;
    }
}
