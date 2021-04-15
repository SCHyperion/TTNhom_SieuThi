using QuanLySieuThi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frm_MatHang : Form
    {
        BindingSource mathanglist = new BindingSource();
        public frm_MatHang()
        {
            InitializeComponent();
            load();
            MatHangBinding();
        }

        void MatHangBinding()
        {
            txb_MaHang.DataBindings.Add(new Binding("Text", dtgvMatHang.DataSource, "Mã mặt hàng", true, DataSourceUpdateMode.Never));
            txb_TenHang.DataBindings.Add(new Binding("Text", dtgvMatHang.DataSource, "Tên mặt hàng", true, DataSourceUpdateMode.Never));
            txb_GiaBan.DataBindings.Add(new Binding("Text", dtgvMatHang.DataSource, "Giá bán", true, DataSourceUpdateMode.Never));
            txb_SLT.DataBindings.Add(new Binding("Text", dtgvMatHang.DataSource, "Số lượng tồn", true, DataSourceUpdateMode.Never));
        }

        void load()
        {
            string query = "select MaHang as [Mã mặt hàng],TenHang as[Tên mặt hàng],GiaBan as [Giá bán], SoLuongTon as[Số lượng tồn] from dbo.MatHang";
            dtgvMatHang.DataSource = mathanglist;
            mathanglist.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (txb_MaHang.Text == "" || txb_TenHang.Text == "" || txb_GiaBan.Text == "" || txb_SLT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int mahang = Convert.ToInt32(txb_MaHang.Text);
                string tenhang = txb_TenHang.Text;
                int giaban = Convert.ToInt32(txb_GiaBan.Text);
                int soluongton = Convert.ToInt32(txb_SLT.Text);
                string query1 = string.Format("Select MaHang from dbo.MatHang where MaHang = '{0}'", mahang);
                string query2 = string.Format("Select TenHang from dbo.MatHang where TenHang = '{0}'", tenhang);
                if (mahang == Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query1)))
                {
                    MessageBox.Show("Mã hàng trùng với mã hàng đã có!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(DataProvider.Instance.ExecuteScalar(query2)!=null && tenhang.Equals(DataProvider.Instance.ExecuteScalar(query2).ToString()))
                    {

                        MessageBox.Show("Tên hàng trùng với tên hàng đã có!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        
                        {
                            if (MatHangDAO.Instance.InsertMatHang(mahang, tenhang, giaban, soluongton))
                            {
                                MessageBox.Show("Thêm mặt hàng thành công!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                load();
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi khi thêm mặt hàng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }    
                    }
                }
                
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (txb_MaHang.Text == "" || txb_TenHang.Text == "" || txb_GiaBan.Text == "" || txb_SLT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int mahang = Convert.ToInt32(txb_MaHang.Text);
                string tenhang = txb_TenHang.Text;
                int giaban = Convert.ToInt32(txb_GiaBan.Text);
                int soluongton = Convert.ToInt32(txb_SLT.Text);
                string query = string.Format("Select MaHang from dbo.MatHang where MaHang = '{0}'", mahang);
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin mặt hàng:\n" + txb_MaHang.Text + "| " + txb_TenHang.Text + "| " + txb_GiaBan.Text + "| " + txb_SLT.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MatHangDAO.Instance.UpdateMatHang(mahang, tenhang, giaban, soluongton))
                    {
                        MessageBox.Show("Sửa mặt hàng thành công!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa mặt hàng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txb_Timkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rb_TenMH.Checked == true)
                {
                    string query = string.Format("select MaHang as [Mã mặt hàng],TenHang as[Tên mặt hàng],GiaBan as [Giá bán], SoLuongTon as[Số lượng tồn] from dbo.MatHang where TenHang like '%{0}%'", txb_Timkiem.Text);
                    mathanglist.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    int count = dtgvMatHang.Rows.Count - 1;
                    MessageBox.Show("Tìm thấy " + count + " kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rb_MaMH.Checked == true)
                {
                    string query = string.Format("select MaHang as [Mã mặt hàng],TenHang as[Tên mặt hàng],GiaBan as [Giá bán], SoLuongTon as[Số lượng tồn] from dbo.MatHang where MaHang like '%{0}%'", txb_Timkiem.Text);
                    mathanglist.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    int count = dtgvMatHang.Rows.Count - 1;
                    MessageBox.Show("Tìm thấy " + count + " kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                load();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int mahang = Convert.ToInt32(txb_MaHang.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa :\n" + txb_MaHang.Text + "| " + txb_TenHang.Text + "| " + txb_GiaBan.Text + "| " + txb_SLT.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (MatHangDAO.Instance.DeleteMatHang(mahang))
                {
                    MessageBox.Show("Xóa mặt hàng thành công!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa mặt hàng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
