using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class DonDatHang
    {
        private string maDonDatHang;
        private DateTime ngayDatHang;
        private int maNhanVien;
        private string nhaCungCap;
        private int daNhapHang;

        // Hàm khởi tạo của lớp DonDatHang
        public DonDatHang(string maDonDatHang, DateTime ngayDatHang, int maNhanVien, string nhaCungCap, int daNhapHang)
        {
            this.maDonDatHang = maDonDatHang;
            this.ngayDatHang = ngayDatHang;
            this.maNhanVien = maNhanVien;
            this.nhaCungCap = nhaCungCap;
            this.daNhapHang = daNhapHang;
        }

        public string MaDonDatHang { get => maDonDatHang; set => maDonDatHang = value; }
        public DateTime NgayDatHang { get => ngayDatHang; set => ngayDatHang = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }
        public int DaNhapHang { get => daNhapHang; set => daNhapHang = value; }
        public int MaKhachHang { get; internal set; }
    }
}
