using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class frmHDBan1 : Form
    {
        int ViTri = -1;

        public frmHDBan1()
        {
            InitializeComponent();
        }
        void NapMaKH()
        {
            //string connectionStr = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString.str);
            string query = "select  MaKH from KhachHang ";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            cboMaKH.DataSource = data;
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DisplayMember = "MaKH";
        }

        void NapTenHang()
        {
            //string connectionStr = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString.str);
            string query = "select TenHang from MatHang  ";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            TenHang.DataSource = data;
            TenHang.ValueMember = "TenHang";
            TenHang.DisplayMember = "TenHang";


        }
        void NapChiTietHD(string mhd)
        {
            
            NapTenHang();

            //string connectionStr = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString.str);
            string query = @"select CTHDBan.MaHD, CTHDBan.MaHang, MatHang.TenHang, CTHDBan.SoLuong, 
                            MatHang.GiaBan,CTHDBan.SoLuong * MatHang.GiaBan as ThanhTien
                            from CTHDBan, MatHang
                            where MatHang.MaHang = CTHDBan.MaHang and MaHD = @MHD";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@MHD", mhd);
            DataTable data = new DataTable();

            data.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();

            //tinh tong tien
            double tongtien = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                double sl = Convert.ToDouble(data.Rows[i]["SoLuong"]);
                double gb = Convert.ToDouble(data.Rows[i]["GiaBan"]);
                tongtien += sl * gb;

            }
            txtTongTien.Text = tongtien.ToString();
        }

        private DataTable doDuLieuRaDataTabe()
        {
            //string connectionStr = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLSieuThi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString.str);
            string query = @"select * from HDBan";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);


            adapter.Fill(data);


            connection.Close();
            return data;
        }

        
        void DiChuyen(int i)
        {
            DataTable data = new DataTable();
            
            data = doDuLieuRaDataTabe();
            txtMaHD.Text = data.Rows[i]["MaHD"].ToString();
            dateTimePicker1.Value = DateTime.Now;

            try
            {
                dateTimePicker1.Value = (DateTime)data.Rows[i]["NgayMua"];
            }
            catch { dateTimePicker1.Value = DateTime.Now; }
            

            cboMaKH.SelectedValue = data.Rows[i]["MaKH"].ToString();
            //Hiện ra dữ liệu trong hóa đơn Bán tương ứng với MÃ Hóa Đơn = i
        }

        private void button2_Click(object sender, EventArgs e)//button cuoi cung
        {
            DataTable data = new DataTable();
            data = doDuLieuRaDataTabe();//dứ liệu trong bảng HdBan
            if (ViTri < data.Rows.Count - 1)
            {
                ViTri = data.Rows.Count - 1;
                DiChuyen(ViTri);
                NapChiTietHD(txtMaHD.Text);

            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = doDuLieuRaDataTabe();

            NapMaKH();
            NapTenHang();

            // NapDanhSachHD();
            if (data.Rows.Count > 0)
            {
                ViTri = 1;
                // lấy trong database dòng thứ 2 
                DiChuyen(ViTri);
                NapChiTietHD(txtMaHD.Text);

            }
        }
        

        private void btnDauTien_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = doDuLieuRaDataTabe();
            if (data.Rows.Count > 0)
            {
                ViTri = 0;
                // lấy trong database dòng thứ 2 
                DiChuyen(ViTri);
                NapChiTietHD(txtMaHD.Text);

            }
        }

        private void btnLen_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = doDuLieuRaDataTabe();
            if (ViTri > 0)
            {
                ViTri -= 1;
                DiChuyen(ViTri);
                NapChiTietHD(txtMaHD.Text);

            }
        }

        private void btnXuong_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = doDuLieuRaDataTabe();
            if (ViTri < data.Rows.Count - 1)
            {
                ViTri += 1;
                DiChuyen(ViTri);
                NapChiTietHD(txtMaHD.Text);

            }
        }
    }
}
