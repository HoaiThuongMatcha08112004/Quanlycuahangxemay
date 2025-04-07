using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class CTDonDatHang
    {
        private string maDonDatHang;
        private string maXeMay;
        private int soLuong;
        private decimal donGia;

        public CTDonDatHang(string maDonDatHang, string maXeMay, int soLuong, decimal donGia)
        {
            this.maDonDatHang = maDonDatHang;
            this.maXeMay = maXeMay;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public string MaDonDatHang { get => maDonDatHang; set => maDonDatHang = value; }
        public string MaXeMay { get => maXeMay; set => maXeMay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
