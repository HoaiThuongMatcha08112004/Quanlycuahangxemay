using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class PhieuNhap
    {
        private string maPhieuNhap;
        private DateTime ngayNhap;
        private int maNhanVien;

        public PhieuNhap(string maPhieuNhap, DateTime ngayNhap, int maNhanVien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.ngayNhap = ngayNhap;
            this.maNhanVien = maNhanVien;
        }

        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
