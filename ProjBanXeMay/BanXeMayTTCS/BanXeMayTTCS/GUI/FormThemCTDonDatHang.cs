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
    public partial class FormThemCTDonDatHang : Form
    {
        private bool isAdded = false;
        private CTDonDatHang chiTiet;

        public bool IsAdded { get => isAdded;}
        public CTDonDatHang ChiTiet { get => chiTiet;}

        public FormThemCTDonDatHang(DonDatHang donDatHang)
        {
            InitializeComponent();
            LoadUI(donDatHang);
        }
        private void LoadUI(DonDatHang donDatHang)
        {
            txtMaDonDatHang.Text = donDatHang.MaDonDatHang;
            txtNhaCungCap.Text = donDatHang.NhaCungCap;
            DataTable dt = XeMayDAO.Instance.GetListXeMayNCC(donDatHang.MaDonDatHang);
            comboBoxXeMay.DataSource = dt;
            comboBoxXeMay.DisplayMember = "TenXeMay";
            comboBoxXeMay.ValueMember = "MaXeMay";
        }
        private bool InputHopLe()
        {
            if(comboBoxXeMay.SelectedValue == null)
            {
                MessageBox.Show("Xe máy không được trống");
                return false;
            }
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
                string maDonDatHang = txtMaDonDatHang.Text;
                string maXeMay = comboBoxXeMay.SelectedValue.ToString();
                int soLuong = (int)numericUpDownSoLuong.Value;
                decimal donGia = Convert.ToDecimal(txtDonGia.Text);
                chiTiet = new CTDonDatHang(maDonDatHang, maXeMay, soLuong, donGia);
                if (DonDatHangDAO.Instance.ThemCTDonDatHang(chiTiet))
                {
                    MessageBox.Show("Thêm chi tiết đơn đặt hàng thành công");
                    isAdded = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm chi tiết đơn đặt hàng thất bại");
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
