
namespace QuanLySieuThi.User_Controls
{
    partial class uc_HeThong
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
            this.panel_Control = new System.Windows.Forms.Panel();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_DangXuat = new System.Windows.Forms.Button();
            this.button_TTTK = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel_Control.Controls.Add(this.button_Thoat);
            this.panel_Control.Controls.Add(this.button_DangXuat);
            this.panel_Control.Controls.Add(this.button_TTTK);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.ForeColor = System.Drawing.Color.Black;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(170, 537);
            this.panel_Control.TabIndex = 0;
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.Red;
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(15, 392);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(140, 88);
            this.button_Thoat.TabIndex = 2;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangXuat.Location = new System.Drawing.Point(15, 233);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(140, 88);
            this.button_DangXuat.TabIndex = 1;
            this.button_DangXuat.Text = "Đăng xuất";
            this.button_DangXuat.UseVisualStyleBackColor = false;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // button_TTTK
            // 
            this.button_TTTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_TTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TTTK.Location = new System.Drawing.Point(15, 65);
            this.button_TTTK.Name = "button_TTTK";
            this.button_TTTK.Size = new System.Drawing.Size(140, 88);
            this.button_TTTK.TabIndex = 0;
            this.button_TTTK.Text = "Thông tin tài khoản";
            this.button_TTTK.UseVisualStyleBackColor = false;
            this.button_TTTK.Click += new System.EventHandler(this.button_TTTK_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.ForeColor = System.Drawing.Color.Black;
            this.panel_Main.Location = new System.Drawing.Point(170, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(990, 537);
            this.panel_Main.TabIndex = 1;
            // 
            // uc_HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Control);
            this.Name = "uc_HeThong";
            this.Size = new System.Drawing.Size(1160, 537);
            this.panel_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button_DangXuat;
        private System.Windows.Forms.Button button_TTTK;
        private System.Windows.Forms.Button button_Thoat;
    }
}
