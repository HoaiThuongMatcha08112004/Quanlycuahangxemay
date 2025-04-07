using BanXeMayTTCS.DAO;
using BanXeMayTTCS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.GUI
{
    public partial class FormSuaCTPhieuNhap : Form
    {
        private CTPhieuNhap chiTietPhieuNhap;
        private bool isUpdated = false;

        public bool IsUpdated { get => isUpdated; }

        public FormSuaCTPhieuNhap(CTPhieuNhap chiTietPhieuNhap)
        {
            InitializeComponent();
            this.chiTietPhieuNhap = chiTietPhieuNhap;
            LoadUI();
        }
        private void LoadUI()
        {
            txtMaPhieuNhap.Text = chiTietPhieuNhap.MaPhieuNhap;
            txtXeMay.Text = chiTietPhieuNhap.MaXeMay;
            txtDonGia.Text = chiTietPhieuNhap.DonGia.ToString();
            numericUpDownSoLuong.Value = chiTietPhieuNhap.SoLuong;
            // Gán số lượng nhập tối đa
            CTDonDatHang chiTietDonDatHang = DonDatHangDAO.Instance.GetCTDonDatHang(
                chiTietPhieuNhap.MaPhieuNhap, chiTietPhieuNhap.MaXeMay);
            numericUpDownSoLuong.Maximum = chiTietPhieuNhap.SoLuong + chiTietDonDatHang.SoLuong;
        }
        private bool InputHopLe()
        {
            if (txtDonGia.Text.Equals(""))
            {
                MessageBox.Show("Đơn giá không được trống");
                return false;
            }
            return true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                decimal donGia = chiTietPhieuNhap.DonGia;
                int soLuong = chiTietPhieuNhap.SoLuong;
                chiTietPhieuNhap.DonGia = decimal.Parse(txtDonGia.Text);
                chiTietPhieuNhap.SoLuong = (int)numericUpDownSoLuong.Value;
                if (PhieuNhapDAO.Instance.SuaCTPhieuNhap(chiTietPhieuNhap))
                {
                    MessageBox.Show("Sửa chi tiết phiếu nhập thành công");
                    isUpdated = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa chi tiết phiếu nhập thất bại");
                    chiTietPhieuNhap.DonGia = donGia;
                    chiTietPhieuNhap.SoLuong = soLuong;
                }
            }
        }
    }
}
