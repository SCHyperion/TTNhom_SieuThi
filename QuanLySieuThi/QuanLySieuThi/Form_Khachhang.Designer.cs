
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(15, 168);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.RowHeadersWidth = 51;
            this.dataGridView_khachhang.RowTemplate.Height = 24;
            this.dataGridView_khachhang.Size = new System.Drawing.Size(927, 403);
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
            this.panel1.Location = new System.Drawing.Point(948, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 559);
            this.panel1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = global::QuanLySieuThi.Properties.Resources.binoculars;
            this.button5.Location = new System.Drawing.Point(34, 417);
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
            this.button4.Location = new System.Drawing.Point(34, 238);
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
            this.button3.Location = new System.Drawing.Point(34, 328);
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
            this.button2.Location = new System.Drawing.Point(34, 148);
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
            this.button1.Location = new System.Drawing.Point(34, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cập Nhật";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_sdt);
            this.panel2.Controls.Add(this.textBox_diachi);
            this.panel2.Controls.Add(this.textBox_tenkh);
            this.panel2.Controls.Add(this.textBox_makh);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 142);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên khách hàng:";
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdt.Location = new System.Drawing.Point(425, 89);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(191, 27);
            this.textBox_sdt.TabIndex = 12;
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diachi.Location = new System.Drawing.Point(644, 24);
            this.textBox_diachi.Multiline = true;
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(249, 95);
            this.textBox_diachi.TabIndex = 11;
            // 
            // textBox_tenkh
            // 
            this.textBox_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenkh.Location = new System.Drawing.Point(226, 24);
            this.textBox_tenkh.Name = "textBox_tenkh";
            this.textBox_tenkh.Size = new System.Drawing.Size(280, 27);
            this.textBox_tenkh.TabIndex = 10;
            // 
            // textBox_makh
            // 
            this.textBox_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_makh.Location = new System.Drawing.Point(163, 89);
            this.textBox_makh.Name = "textBox_makh";
            this.textBox_makh.Size = new System.Drawing.Size(132, 27);
            this.textBox_makh.TabIndex = 9;
            // 
            // Form_Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1246, 584);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
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