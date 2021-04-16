
namespace QuanLySieuThi.User_Controls
{
    partial class HDNhap
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
            this.dgv_ListHD = new System.Windows.Forms.DataGridView();
            this.dgv_ListSP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textbox_MaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Current = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Current)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ListHD
            // 
            this.dgv_ListHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListHD.Location = new System.Drawing.Point(3, 18);
            this.dgv_ListHD.Name = "dgv_ListHD";
            this.dgv_ListHD.Size = new System.Drawing.Size(412, 218);
            this.dgv_ListHD.TabIndex = 0;
            // 
            // dgv_ListSP
            // 
            this.dgv_ListSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListSP.Location = new System.Drawing.Point(3, 18);
            this.dgv_ListSP.Name = "dgv_ListSP";
            this.dgv_ListSP.Size = new System.Drawing.Size(409, 225);
            this.dgv_ListSP.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 497);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textbox_MaHD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_Add);
            this.panel2.Controls.Add(this.button_Delete);
            this.panel2.Controls.Add(this.button_Confirm);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(427, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 497);
            this.panel2.TabIndex = 4;
            // 
            // textbox_MaHD
            // 
            this.textbox_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_MaHD.ForeColor = System.Drawing.Color.Black;
            this.textbox_MaHD.Location = new System.Drawing.Point(259, 383);
            this.textbox_MaHD.Name = "textbox_MaHD";
            this.textbox_MaHD.Size = new System.Drawing.Size(121, 24);
            this.textbox_MaHD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(156, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Location = new System.Drawing.Point(195, 424);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(137, 66);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Thêm Sản Phẩm";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.Black;
            this.button_Delete.Location = new System.Drawing.Point(15, 425);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(137, 66);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.ForeColor = System.Drawing.Color.Black;
            this.button_Confirm.Location = new System.Drawing.Point(371, 424);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(137, 66);
            this.button_Confirm.TabIndex = 1;
            this.button_Confirm.Text = "Xác Nhận";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Current);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 365);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn nhập hiện tại";
            // 
            // dgv_Current
            // 
            this.dgv_Current.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Current.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Current.Location = new System.Drawing.Point(3, 18);
            this.dgv_Current.Name = "dgv_Current";
            this.dgv_Current.Size = new System.Drawing.Size(511, 344);
            this.dgv_Current.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ListSP);
            this.groupBox2.Location = new System.Drawing.Point(6, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm hiện có";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ListHD);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn nhập hiện có";
            // 
            // HDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Name = "HDNhap";
            this.Size = new System.Drawing.Size(990, 537);
            this.Load += new System.EventHandler(this.HDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Current)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListHD;
        private System.Windows.Forms.DataGridView dgv_ListSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Current;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.TextBox textbox_MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add;
    }
}
