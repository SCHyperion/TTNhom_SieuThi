namespace QuanLySieuThi.Forms
{
    partial class MainMenuForm
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
            this.panel_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.button_Employee = new System.Windows.Forms.Button();
            this.button_Statistics = new System.Windows.Forms.Button();
            this.button_Bill = new System.Windows.Forms.Button();
            this.button_System = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Customer = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_Controls.ColumnCount = 7;
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_Controls.Controls.Add(this.button_Employee, 0, 0);
            this.panel_Controls.Controls.Add(this.button_Statistics, 0, 0);
            this.panel_Controls.Controls.Add(this.button_Bill, 0, 0);
            this.panel_Controls.Controls.Add(this.button_System, 0, 0);
            this.panel_Controls.Controls.Add(this.button_Products, 0, 0);
            this.panel_Controls.Controls.Add(this.button_Customer, 0, 0);
            this.panel_Controls.Controls.Add(this.button_Help, 3, 0);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Controls.Location = new System.Drawing.Point(0, 0);
            this.panel_Controls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.RowCount = 1;
            this.panel_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_Controls.Size = new System.Drawing.Size(1168, 58);
            this.panel_Controls.TabIndex = 2;
            // 
            // button_Employee
            // 
            this.button_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Employee.Location = new System.Drawing.Point(500, 2);
            this.button_Employee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Employee.Name = "button_Employee";
            this.button_Employee.Size = new System.Drawing.Size(162, 54);
            this.button_Employee.TabIndex = 6;
            this.button_Employee.Text = "Nhân Viên";
            this.button_Employee.UseVisualStyleBackColor = true;
            this.button_Employee.Click += new System.EventHandler(this.button_Employee_Click);
            // 
            // button_Statistics
            // 
            this.button_Statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Statistics.Location = new System.Drawing.Point(666, 2);
            this.button_Statistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Statistics.Name = "button_Statistics";
            this.button_Statistics.Size = new System.Drawing.Size(162, 54);
            this.button_Statistics.TabIndex = 5;
            this.button_Statistics.Text = "Thống Kê";
            this.button_Statistics.UseVisualStyleBackColor = true;
            this.button_Statistics.Click += new System.EventHandler(this.button_Statistics_Click);
            // 
            // button_Bill
            // 
            this.button_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Bill.Location = new System.Drawing.Point(832, 2);
            this.button_Bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Bill.Name = "button_Bill";
            this.button_Bill.Size = new System.Drawing.Size(162, 54);
            this.button_Bill.TabIndex = 4;
            this.button_Bill.Text = "Tạo Hóa Đơn";
            this.button_Bill.UseVisualStyleBackColor = true;
            this.button_Bill.Click += new System.EventHandler(this.button_Bill_Click);
            // 
            // button_System
            // 
            this.button_System.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_System.Location = new System.Drawing.Point(2, 2);
            this.button_System.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_System.Name = "button_System";
            this.button_System.Size = new System.Drawing.Size(162, 54);
            this.button_System.TabIndex = 3;
            this.button_System.Text = "Hệ Thống";
            this.button_System.UseVisualStyleBackColor = true;
            this.button_System.Click += new System.EventHandler(this.button_System_Click);
            // 
            // button_Products
            // 
            this.button_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Products.Location = new System.Drawing.Point(168, 2);
            this.button_Products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(162, 54);
            this.button_Products.TabIndex = 2;
            this.button_Products.Text = "Sản Phẩm";
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Customer
            // 
            this.button_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Customer.Location = new System.Drawing.Point(334, 2);
            this.button_Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Customer.Name = "button_Customer";
            this.button_Customer.Size = new System.Drawing.Size(162, 54);
            this.button_Customer.TabIndex = 1;
            this.button_Customer.Text = "Khách Hàng";
            this.button_Customer.UseVisualStyleBackColor = true;
            this.button_Customer.Click += new System.EventHandler(this.button_Customer_Click);
            // 
            // button_Help
            // 
            this.button_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(998, 2);
            this.button_Help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(168, 54);
            this.button_Help.TabIndex = 0;
            this.button_Help.Text = "Trợ Giúp";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 58);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1168, 564);
            this.panel_Main.TabIndex = 3;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 622);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Controls);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ SIÊU THỊ";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel panel_Controls;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_Employee;
        private System.Windows.Forms.Button button_Statistics;
        private System.Windows.Forms.Button button_Bill;
        private System.Windows.Forms.Button button_System;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Customer;
    }
}