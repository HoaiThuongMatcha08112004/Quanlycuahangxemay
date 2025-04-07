using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class CTPhieuNhap
    {
        private string maPhieuNhap;
        private string maXeMay;
        private decimal donGia;
        private int soLuong;

        public CTPhieuNhap(string maPhieuNhap, string maXeMay, decimal donGia, int soLuong)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maXeMay = maXeMay;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string MaXeMay { get => maXeMay; set => maXeMay = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
