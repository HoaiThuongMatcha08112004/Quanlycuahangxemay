using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class CtDatHangKh
    {
        private int maCtPhieuDat;
        private int maPhieuDat;
        private string maXeMay;
        private int soLuong;
        private decimal donGia;

        public CtDatHangKh(int maCtPhieuDat, int maPhieuDat, string maXeMay, int soLuong, decimal donGia)
        {
            this.maCtPhieuDat = maCtPhieuDat;
            this.maPhieuDat = maPhieuDat;
            this.maXeMay = maXeMay;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public CtDatHangKh(int maPhieuDat, string maXeMay, int soLuong, decimal donGia)
        {
            this.maPhieuDat = maPhieuDat;
            this.maXeMay = maXeMay;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public int MaCtPhieuDat { get => maCtPhieuDat; set => maCtPhieuDat = value; }
        public int MaPhieuDat { get => maPhieuDat; set => maPhieuDat = value; }
        public string MaXeMay { get => maXeMay; set => maXeMay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
