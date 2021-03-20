
namespace QuanLySieuThi
{
    partial class Form_Khachhang
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
            this.dataGridView_khachhang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_makh = new System.Windows.Forms.RadioButton();
            this.radioButton_ten = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.textBox_tenkh = new System.Windows.Forms.TextBox();
            this.textBox_makh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(15, 213);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.RowHeadersWidth = 51;
            this.dataGridView_khachhang.RowTemplate.Height = 24;
            this.dataGridView_khachhang.Size = new System.Drawing.Size(927, 464);
            this.dataGridView_khachhang.TabIndex = 0;
            this.dataGridView_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khachhang_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(948, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 464);
            this.panel1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = global::QuanLySieuThi.Properties.Resources.binoculars;
            this.button5.Location = new System.Drawing.Point(57, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 60);
            this.button5.TabIndex = 18;
            this.button5.Text = "Tìm Kiếm Khách hàng";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Image = global::QuanLySieuThi.Properties.Resources.edit;
            this.button4.Location = new System.Drawing.Point(57, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 60);
            this.button4.TabIndex = 17;
            this.button4.Text = "Sửa thông tin";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Image = global::QuanLySieuThi.Properties.Resources.user_1_;
            this.button3.Location = new System.Drawing.Point(57, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xóa Khách hàng";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Image = global::QuanLySieuThi.Properties.Resources.add_user;
            this.button2.Location = new System.Drawing.Point(57, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "Thêm Khách hàng";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Image = global::QuanLySieuThi.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(57, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cập Nhật";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.radioButton_makh);
            this.groupBox2.Controls.Add(this.radioButton_ten);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều kiện";
            // 
            // radioButton_makh
            // 
            this.radioButton_makh.AutoSize = true;
            this.radioButton_makh.Location = new System.Drawing.Point(141, 21);
            this.radioButton_makh.Name = "radioButton_makh";
            this.radioButton_makh.Size = new System.Drawing.Size(132, 22);
            this.radioButton_makh.TabIndex = 4;
            this.radioButton_makh.TabStop = true;
            this.radioButton_makh.Text = "Mã Khách hàng";
            this.radioButton_makh.UseVisualStyleBackColor = true;
            // 
            // radioButton_ten
            // 
            this.radioButton_ten.AutoSize = true;
            this.radioButton_ten.Checked = true;
            this.radioButton_ten.Location = new System.Drawing.Point(6, 21);
            this.radioButton_ten.Name = "radioButton_ten";
            this.radioButton_ten.Size = new System.Drawing.Size(136, 22);
            this.radioButton_ten.TabIndex = 3;
            this.radioButton_ten.TabStop = true;
            this.radioButton_ten.Text = "Tên Khách hàng";
            this.radioButton_ten.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textBox_info);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // textBox_info
            // 
            this.textBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_info.Location = new System.Drawing.Point(16, 21);
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(280, 27);
            this.textBox_info.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(949, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 195);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox_sdt);
            this.groupBox4.Controls.Add(this.textBox_diachi);
            this.groupBox4.Controls.Add(this.textBox_tenkh);
            this.groupBox4.Controls.Add(this.textBox_makh);
            this.groupBox4.Location = new System.Drawing.Point(15, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(927, 194);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên khách hàng:";
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdt.Location = new System.Drawing.Point(425, 115);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(191, 27);
            this.textBox_sdt.TabIndex = 20;
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diachi.Location = new System.Drawing.Point(644, 50);
            this.textBox_diachi.Multiline = true;
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(249, 95);
            this.textBox_diachi.TabIndex = 19;
            // 
            // textBox_tenkh
            // 
            this.textBox_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenkh.Location = new System.Drawing.Point(226, 50);
            this.textBox_tenkh.Name = "textBox_tenkh";
            this.textBox_tenkh.Size = new System.Drawing.Size(280, 27);
            this.textBox_tenkh.TabIndex = 18;
            // 
            // textBox_makh
            // 
            this.textBox_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_makh.Location = new System.Drawing.Point(163, 115);
            this.textBox_makh.Name = "textBox_makh";
            this.textBox_makh.Size = new System.Drawing.Size(132, 27);
            this.textBox_makh.TabIndex = 17;
            // 
            // Form_Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1281, 689);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_khachhang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Khachhang";
            this.Text = "Quản lý thông tin khách hàng";
            this.Load += new System.EventHandler(this.Form_Khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_khachhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_makh;
        private System.Windows.Forms.RadioButton radioButton_ten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.TextBox textBox_tenkh;
        private System.Windows.Forms.TextBox textBox_makh;
    }
}