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
    public partial class FormSuaCTDonHang : Form
    {
        private bool isUpdated = false;
        private CTDonDatHang chiTiet;

        public bool IsUpdated { get => isUpdated;}

        public FormSuaCTDonHang(DonDatHang donDatHang, CTDonDatHang chiTiet)
        {
            InitializeComponent();
            this.chiTiet = chiTiet;
            LoadUI(donDatHang);
        }
        private void LoadUI(DonDatHang donDatHang)
        {
            txtMaDonDatHang.Text = donDatHang.MaDonDatHang;
            txtNhaCungCap.Text = donDatHang.NhaCungCap;
            txtXeMay.Text = chiTiet.MaXeMay;
            numericUpDownSoLuong.Value = chiTiet.SoLuong;
            txtDonGia.Text = chiTiet.DonGia.ToString();
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                // Lưu giá trị cũ
                int soLuong = this.chiTiet.SoLuong;
                decimal donGia = this.chiTiet.DonGia;
                // Thay đổi giá trị mới trong chi tiết
                chiTiet.SoLuong = (int)numericUpDownSoLuong.Value;
                chiTiet.DonGia = Convert.ToDecimal(txtDonGia.Text);
                if (DonDatHangDAO.Instance.SuaCTDonDatHang(chiTiet))
                {
                    MessageBox.Show("Sửa chi tiết đơn đặt hàng thành công");
                    isUpdated = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa chi tiết đơn đặt hàng thất bại");
                    chiTiet.SoLuong = soLuong;
                    chiTiet.DonGia = donGia;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
