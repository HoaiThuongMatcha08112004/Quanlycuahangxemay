using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class PhieuDatKh
    {

        private int maPhieuDat;
        private DateTime ngayDat;
        private string hoTenNguoiNhan;
        private string diaChiNguoiNhan;
        private string sdtNguoiNhan;
        private DateTime ngayGiaoHang;
        private string trangThai;
        private int maKhachHang;
        private int maNhanVien;

        public PhieuDatKh(int maPhieuDat, DateTime ngayDat, string hoTenNguoiNhan, string diaChiNguoiNhan, string sdtNguoiNhan, DateTime ngayGiaoHang, string trangThai, int maKhachHang, int maNhanVien)
        {
            this.maPhieuDat = maPhieuDat;
            this.ngayDat = ngayDat;
            this.hoTenNguoiNhan = hoTenNguoiNhan;
            this.diaChiNguoiNhan = diaChiNguoiNhan;
            this.sdtNguoiNhan = sdtNguoiNhan;
            this.ngayGiaoHang = ngayGiaoHang;
            this.trangThai = trangThai;
            this.maKhachHang = maKhachHang;
            this.maNhanVien = maNhanVien;
        }

        public PhieuDatKh(DateTime ngayDat, string hoTenNguoiNhan, string diaChiNguoiNhan, string sdtNguoiNhan, int maKhachHang)
        {
            this.ngayDat = ngayDat;
            this.hoTenNguoiNhan = hoTenNguoiNhan;
            this.diaChiNguoiNhan = diaChiNguoiNhan;
            this.sdtNguoiNhan = sdtNguoiNhan;
            this.maKhachHang = maKhachHang;
        }



        public int MaPhieuDat { get => maPhieuDat; set => maPhieuDat = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public string HoTenNguoiNhan { get => hoTenNguoiNhan; set => hoTenNguoiNhan = value; }
        public string DiaChiNguoiNhan { get => diaChiNguoiNhan; set => diaChiNguoiNhan = value; }
        public string SdtNguoiNhan { get => sdtNguoiNhan; set => sdtNguoiNhan = value; }
        public DateTime NgayGiaoHang { get => ngayGiaoHang; set => ngayGiaoHang = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
