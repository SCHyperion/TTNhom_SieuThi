
namespace QuanLySieuThi.User_Controls
{
    partial class uc_ThongKe
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
            this.button_ListHD = new System.Windows.Forms.Button();
            this.button_SoSPBan = new System.Windows.Forms.Button();
            this.button_DoanhThu = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel_Control.Controls.Add(this.button_ListHD);
            this.panel_Control.Controls.Add(this.button_SoSPBan);
            this.panel_Control.Controls.Add(this.button_DoanhThu);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(170, 537);
            this.panel_Control.TabIndex = 0;
            // 
            // button_ListHD
            // 
            this.button_ListHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_ListHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListHD.ForeColor = System.Drawing.Color.Black;
            this.button_ListHD.Location = new System.Drawing.Point(15, 392);
            this.button_ListHD.Name = "button_ListHD";
            this.button_ListHD.Size = new System.Drawing.Size(140, 88);
            this.button_ListHD.TabIndex = 2;
            this.button_ListHD.Text = "Danh sách hóa đơn";
            this.button_ListHD.UseVisualStyleBackColor = false;
            this.button_ListHD.Click += new System.EventHandler(this.button_ListHD_Click);
            // 
            // button_SoSPBan
            // 
            this.button_SoSPBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_SoSPBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SoSPBan.ForeColor = System.Drawing.Color.Black;
            this.button_SoSPBan.Location = new System.Drawing.Point(15, 65);
            this.button_SoSPBan.Name = "button_SoSPBan";
            this.button_SoSPBan.Size = new System.Drawing.Size(140, 88);
            this.button_SoSPBan.TabIndex = 0;
            this.button_SoSPBan.Text = "Số sản phẩm bán được";
            this.button_SoSPBan.UseVisualStyleBackColor = false;
            this.button_SoSPBan.Click += new System.EventHandler(this.button_SoSPBan_Click);
            // 
            // button_DoanhThu
            // 
            this.button_DoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DoanhThu.ForeColor = System.Drawing.Color.Black;
            this.button_DoanhThu.Location = new System.Drawing.Point(15, 233);
            this.button_DoanhThu.Name = "button_DoanhThu";
            this.button_DoanhThu.Size = new System.Drawing.Size(140, 88);
            this.button_DoanhThu.TabIndex = 1;
            this.button_DoanhThu.Text = "Doanh thu";
            this.button_DoanhThu.UseVisualStyleBackColor = false;
            this.button_DoanhThu.Click += new System.EventHandler(this.button_DoanhThu_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(170, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(990, 537);
            this.panel_Main.TabIndex = 1;
            // 
            // uc_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Control);
            this.Name = "uc_ThongKe";
            this.Size = new System.Drawing.Size(1160, 537);
            this.panel_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button_ListHD;
        private System.Windows.Forms.Button button_SoSPBan;
        private System.Windows.Forms.Button button_DoanhThu;
    }
}
