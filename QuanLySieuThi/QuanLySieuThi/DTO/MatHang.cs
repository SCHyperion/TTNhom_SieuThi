using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    public class MatHang
    {
        public MatHang(int maHang, string tenHang,int giaBan, int soLuongTon )
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.GiaBan = giaBan;
            this.SoLuongTon = soLuongTon;

        }

        public MatHang(DataRow row)
        {
            this.MaHang = (int)row["maHang"];
            this.TenHang = row["tenHang"].ToString();
            this.GiaBan = (int)row["giaBan"];
            this.SoLuongTon = (int)row["soLuongTon"];
        }
        private int maHang;
        public int MaHang
        {
            get
            {
                return maHang;
            }

            set
            {
                maHang = value;
            }
        }


        private string tenHang;

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }
        private int giaBan;

        public int GiaBan
        {
            get
            {
                return giaBan;
            }

            set
            {
                giaBan = value;
            }
        }

        private int soLuongTon;

        public int SoLuongTon
        {
            get
            {
                return soLuongTon;
            }

            set
            {
                soLuongTon = value;
            }
        }
    }

    
}




   


