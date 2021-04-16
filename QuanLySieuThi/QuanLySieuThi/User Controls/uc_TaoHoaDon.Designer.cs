
namespace QuanLySieuThi.User_Controls
{
    partial class uc_TaoHoaDon
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
            this.button_HDBan = new System.Windows.Forms.Button();
            this.button_HDNhap = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.panel_Control.Controls.Add(this.button_HDBan);
            this.panel_Control.Controls.Add(this.button_HDNhap);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Control.ForeColor = System.Drawing.Color.Black;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(170, 537);
            this.panel_Control.TabIndex = 0;
            // 
            // button_HDBan
            // 
            this.button_HDBan.Location = new System.Drawing.Point(15, 328);
            this.button_HDBan.Name = "button_HDBan";
            this.button_HDBan.Size = new System.Drawing.Size(140, 88);
            this.button_HDBan.TabIndex = 1;
            this.button_HDBan.Text = "Hóa đơn bán";
            this.button_HDBan.UseVisualStyleBackColor = true;
            this.button_HDBan.Click += new System.EventHandler(this.button_HDBan_Click);
            // 
            // button_HDNhap
            // 
            this.button_HDNhap.Location = new System.Drawing.Point(15, 120);
            this.button_HDNhap.Name = "button_HDNhap";
            this.button_HDNhap.Size = new System.Drawing.Size(140, 88);
            this.button_HDNhap.TabIndex = 0;
            this.button_HDNhap.Text = "Hóa đơn nhập";
            this.button_HDNhap.UseVisualStyleBackColor = true;
            this.button_HDNhap.Click += new System.EventHandler(this.button_HDNhap_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(170, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(990, 537);
            this.panel_Main.TabIndex = 1;
            // 
            // uc_TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Control);
            this.Name = "uc_TaoHoaDon";
            this.Size = new System.Drawing.Size(1160, 537);
            this.panel_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button_HDNhap;
        private System.Windows.Forms.Button button_HDBan;
    }
}
