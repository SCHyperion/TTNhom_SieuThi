namespace QuanLySieuThi
{
    partial class Help
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
            this.treeview_All = new System.Windows.Forms.TreeView();
            this.richtextbox_Display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeview_All
            // 
            this.treeview_All.BackColor = System.Drawing.Color.PaleTurquoise;
            this.treeview_All.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeview_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeview_All.ForeColor = System.Drawing.Color.Red;
            this.treeview_All.Location = new System.Drawing.Point(0, 0);
            this.treeview_All.Name = "treeview_All";
            this.treeview_All.Size = new System.Drawing.Size(247, 584);
            this.treeview_All.TabIndex = 0;
            this.treeview_All.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_All_AfterSelect);
            // 
            // richtextbox_Display
            // 
            this.richtextbox_Display.BackColor = System.Drawing.Color.White;
            this.richtextbox_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtextbox_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextbox_Display.Location = new System.Drawing.Point(247, 0);
            this.richtextbox_Display.Name = "richtextbox_Display";
            this.richtextbox_Display.ReadOnly = true;
            this.richtextbox_Display.Size = new System.Drawing.Size(680, 584);
            this.richtextbox_Display.TabIndex = 1;
            this.richtextbox_Display.Text = "";
            this.richtextbox_Display.ZoomFactor = 1.6F;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 584);
            this.Controls.Add(this.richtextbox_Display);
            this.Controls.Add(this.treeview_All);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeview_All;
        private System.Windows.Forms.RichTextBox richtextbox_Display;
    }
}