namespace QuanLySieuThi.User_Controls
{
    partial class uc_NhanVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.txbLuongNV = new System.Windows.Forms.TextBox();
            this.txbSDTNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXemNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txbDiaChiNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnMaNV = new System.Windows.Forms.RadioButton();
            this.rbtnTenNV = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTimKiemNV = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.69088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.30913F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 436);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Viên";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtgvNV);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 134);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1148, 299);
            this.panel10.TabIndex = 3;
            // 
            // dtgvNV
            // 
            this.dtgvNV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNV.Location = new System.Drawing.Point(0, 0);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersWidth = 51;
            this.dtgvNV.RowTemplate.Height = 24;
            this.dtgvNV.Size = new System.Drawing.Size(1148, 299);
            this.dtgvNV.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoaNV);
            this.panel3.Controls.Add(this.txbLuongNV);
            this.panel3.Controls.Add(this.txbSDTNV);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnSuaNV);
            this.panel3.Controls.Add(this.btnXemNV);
            this.panel3.Controls.Add(this.btnThemNV);
            this.panel3.Controls.Add(this.txbDiaChiNV);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txbTenNV);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbMaNV);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 112);
            this.panel3.TabIndex = 0;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(725, 61);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(95, 42);
            this.btnXoaNV.TabIndex = 3;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // txbLuongNV
            // 
            this.txbLuongNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLuongNV.Location = new System.Drawing.Point(845, 6);
            this.txbLuongNV.Name = "txbLuongNV";
            this.txbLuongNV.Size = new System.Drawing.Size(187, 22);
            this.txbLuongNV.TabIndex = 1;
            // 
            // txbSDTNV
            // 
            this.txbSDTNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDTNV.Location = new System.Drawing.Point(564, 33);
            this.txbSDTNV.Name = "txbSDTNV";
            this.txbSDTNV.Size = new System.Drawing.Size(187, 22);
            this.txbSDTNV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lương:";
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Location = new System.Drawing.Point(601, 61);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(95, 42);
            this.btnSuaNV.TabIndex = 2;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXemNV
            // 
            this.btnXemNV.BackColor = System.Drawing.Color.Yellow;
            this.btnXemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemNV.Location = new System.Drawing.Point(361, 61);
            this.btnXemNV.Name = "btnXemNV";
            this.btnXemNV.Size = new System.Drawing.Size(95, 42);
            this.btnXemNV.TabIndex = 0;
            this.btnXemNV.Text = "Xem";
            this.btnXemNV.UseVisualStyleBackColor = false;
            this.btnXemNV.Click += new System.EventHandler(this.btnXemNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.Lime;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(482, 61);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(95, 42);
            this.btnThemNV.TabIndex = 1;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txbDiaChiNV
            // 
            this.txbDiaChiNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChiNV.Location = new System.Drawing.Point(564, 5);
            this.txbDiaChiNV.Name = "txbDiaChiNV";
            this.txbDiaChiNV.Size = new System.Drawing.Size(187, 22);
            this.txbDiaChiNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txbTenNV
            // 
            this.txbTenNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNV.Location = new System.Drawing.Point(229, 32);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(187, 22);
            this.txbTenNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNV.Location = new System.Drawing.Point(229, 4);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(187, 22);
            this.txbMaNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemNV);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1154, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.BackColor = System.Drawing.Color.Magenta;
            this.btnTimKiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNV.Location = new System.Drawing.Point(728, 22);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(137, 53);
            this.btnTimKiemNV.TabIndex = 2;
            this.btnTimKiemNV.Text = "Tìm Kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = false;
            this.btnTimKiemNV.Click += new System.EventHandler(this.btnTimKiemNV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnMaNV);
            this.panel2.Controls.Add(this.rbtnTenNV);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(611, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 53);
            this.panel2.TabIndex = 1;
            // 
            // rbtnMaNV
            // 
            this.rbtnMaNV.AutoSize = true;
            this.rbtnMaNV.Location = new System.Drawing.Point(7, 25);
            this.rbtnMaNV.Name = "rbtnMaNV";
            this.rbtnMaNV.Size = new System.Drawing.Size(76, 20);
            this.rbtnMaNV.TabIndex = 1;
            this.rbtnMaNV.TabStop = true;
            this.rbtnMaNV.Text = "Theo Mã";
            this.rbtnMaNV.UseVisualStyleBackColor = true;
            // 
            // rbtnTenNV
            // 
            this.rbtnTenNV.AutoSize = true;
            this.rbtnTenNV.Location = new System.Drawing.Point(7, 3);
            this.rbtnTenNV.Name = "rbtnTenNV";
            this.rbtnTenNV.Size = new System.Drawing.Size(79, 20);
            this.rbtnTenNV.TabIndex = 0;
            this.rbtnTenNV.TabStop = true;
            this.rbtnTenNV.Text = "Theo Tên";
            this.rbtnTenNV.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTimKiemNV);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(235, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Tìm Kiếm:";
            // 
            // txbTimKiemNV
            // 
            this.txbTimKiemNV.Location = new System.Drawing.Point(180, 10);
            this.txbTimKiemNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTimKiemNV.Name = "txbTimKiemNV";
            this.txbTimKiemNV.Size = new System.Drawing.Size(172, 22);
            this.txbTimKiemNV.TabIndex = 1;
            // 
            // uc_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_NhanVien";
            this.Size = new System.Drawing.Size(1160, 537);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiemNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnMaNV;
        private System.Windows.Forms.RadioButton rbtnTenNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTimKiemNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXemNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbLuongNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSDTNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDiaChiNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.Label label3;
    }
}
