
namespace QuanLySieuThi
{
    partial class Test
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
            this.controlbox = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.SuspendLayout();
            // 
            // controlbox
            // 
            this.controlbox.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.controlbox.CloseHoverForeColor = System.Drawing.Color.White;
            this.controlbox.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.controlbox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.controlbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlbox.IsDerivedStyle = true;
            this.controlbox.Location = new System.Drawing.Point(390, 0);
            this.controlbox.MaximizeBox = false;
            this.controlbox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.controlbox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.controlbox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.controlbox.MinimizeBox = true;
            this.controlbox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.controlbox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.controlbox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.controlbox.Name = "controlbox";
            this.controlbox.Size = new System.Drawing.Size(100, 25);
            this.controlbox.Style = MetroSet_UI.Enums.Style.Light;
            this.controlbox.StyleManager = this.styleManager1;
            this.controlbox.TabIndex = 1;
            this.controlbox.Text = "metroSetControlBox1";
            this.controlbox.ThemeAuthor = null;
            this.controlbox.ThemeName = null;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 27);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(490, 276);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = this.styleManager1;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = null;
            this.metroSetPanel1.ThemeName = null;
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Crimson Dragon\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml" +
    "";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(490, 303);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.controlbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox controlbox;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
    }
}