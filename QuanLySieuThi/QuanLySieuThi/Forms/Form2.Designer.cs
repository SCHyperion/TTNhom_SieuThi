namespace QuanLySieuThi
{
    partial class frmHDBan1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgayMua = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMaKh = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.btnDauTien = new System.Windows.Forms.Button();
            this.btnCuoiCung = new System.Windows.Forms.Button();
            this.btnLen = new System.Windows.Forms.Button();
            this.btnXuong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HD:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(188, 66);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(153, 27);
            this.txtMaHD.TabIndex = 1;
            // 
            // txtNgayMua
            // 
            this.txtNgayMua.AutoSize = true;
            this.txtNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMua.Location = new System.Drawing.Point(82, 106);
            this.txtNgayMua.Name = "txtNgayMua";
            this.txtNgayMua.Size = new System.Drawing.Size(89, 20);
            this.txtNgayMua.TabIndex = 2;
            this.txtNgayMua.Text = "Ngày mua:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtMaKh
            // 
            this.txtMaKh.AutoSize = true;
            this.txtMaKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKh.Location = new System.Drawing.Point(82, 145);
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.Size = new System.Drawing.Size(66, 20);
            this.txtMaKh.TabIndex = 4;
            this.txtMaKh.Text = "Mã KH:";
            // 
            // cboMaKH
            // 
            this.cboMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(188, 142);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(153, 28);
            this.cboMaKH.TabIndex = 5;
            // 
            // btnDauTien
            // 
            this.btnDauTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTien.Location = new System.Drawing.Point(86, 448);
            this.btnDauTien.Name = "btnDauTien";
            this.btnDauTien.Size = new System.Drawing.Size(93, 31);
            this.btnDauTien.TabIndex = 6;
            this.btnDauTien.Text = "Đầu tiên";
            this.btnDauTien.UseVisualStyleBackColor = true;
            this.btnDauTien.Click += new System.EventHandler(this.btnDauTien_Click);
            // 
            // btnCuoiCung
            // 
            this.btnCuoiCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoiCung.Location = new System.Drawing.Point(216, 448);
            this.btnCuoiCung.Name = "btnCuoiCung";
            this.btnCuoiCung.Size = new System.Drawing.Size(108, 31);
            this.btnCuoiCung.TabIndex = 7;
            this.btnCuoiCung.Text = "Cuối cùng";
            this.btnCuoiCung.UseVisualStyleBackColor = true;
            this.btnCuoiCung.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLen
            // 
            this.btnLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLen.Location = new System.Drawing.Point(365, 448);
            this.btnLen.Name = "btnLen";
            this.btnLen.Size = new System.Drawing.Size(78, 31);
            this.btnLen.TabIndex = 9;
            this.btnLen.Text = "Lên";
            this.btnLen.UseVisualStyleBackColor = true;
            this.btnLen.Click += new System.EventHandler(this.btnLen_Click);
            // 
            // btnXuong
            // 
            this.btnXuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuong.Location = new System.Drawing.Point(484, 448);
            this.btnXuong.Name = "btnXuong";
            this.btnXuong.Size = new System.Drawing.Size(81, 31);
            this.btnXuong.TabIndex = 10;
            this.btnXuong.Text = "Xuống";
            this.btnXuong.UseVisualStyleBackColor = true;
            this.btnXuong.Click += new System.EventHandler(this.btnLen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.GiaBan,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(30, 189);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 221);
            this.dataGridView1.TabIndex = 11;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaHang
            // 
            this.MaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(672, 419);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(83, 20);
            this.lb.TabIndex = 12;
            this.lb.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(781, 416);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(131, 27);
            this.txtTongTien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "HÓA ĐƠN BÁN";
            // 
            // frmHDBan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXuong);
            this.Controls.Add(this.btnLen);
            this.Controls.Add(this.btnCuoiCung);
            this.Controls.Add(this.btnDauTien);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.txtMaKh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNgayMua);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Name = "frmHDBan1";
            this.Text = "frmHDBan1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label txtNgayMua;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtMaKh;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Button btnDauTien;
        private System.Windows.Forms.Button btnCuoiCung;
        private System.Windows.Forms.Button btnLen;
        private System.Windows.Forms.Button btnXuong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}