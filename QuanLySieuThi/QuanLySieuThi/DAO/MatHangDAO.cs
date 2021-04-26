using QuanLySieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAO
{
    class MatHangDAO
    {
        private static MatHangDAO instance;

        public static MatHangDAO Instance
        {
            get { if (instance == null) instance = new MatHangDAO(); return MatHangDAO.instance; }
            private set { MatHangDAO.instance = value; }
        }

        private MatHangDAO() { }

        

        public bool InsertMatHang(int mahang, string tenhang, int giaban, int soluongton)
        {
            string query1 = string.Format("insert dbo.MatHang (MaHang, TenHang, GiaBan, SoLuongTon) values ({0},N'{1}',{2},{3})", mahang, tenhang, giaban, soluongton);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }

        public bool UpdateMatHang(int mahang, string tenhang, int giaban, int soluongton)
        {
            string query1 = string.Format("update dbo.MatHang set TenHang = N'{0}',GiaBan = {1},SoLuongTon = {2} where MaHang ={3} ",tenhang, giaban, soluongton,mahang);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }

        public bool DeleteMatHang(int mahang)
        {
            string query1 = string.Format("delete from CTHDBan where CTHDBan.MaHang={0} delete from CTHDNhap where CTHDNhap.MaHang = {0} delete from MatHang where MatHang.MaHang = {0}",mahang);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }
    }
}
