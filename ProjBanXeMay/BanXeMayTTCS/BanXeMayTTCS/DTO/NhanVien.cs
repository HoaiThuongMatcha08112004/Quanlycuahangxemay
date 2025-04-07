using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class NhanVien
    {
        private int maNhanVien;
        private string ho;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;
        private string email;
        private string taiKhoan;

        public NhanVien(string ho, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email, string taiKhoan)
        {
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
            this.taiKhoan = taiKhoan;
        }

        public NhanVien(int maNhanVien, string ho, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email, string taiKhoan)
        {
            this.maNhanVien = maNhanVien;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
            this.taiKhoan = taiKhoan;
        }

        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
