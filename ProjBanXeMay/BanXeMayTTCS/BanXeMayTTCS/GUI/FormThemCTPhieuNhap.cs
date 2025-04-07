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
    public partial class FormThemCTPhieuNhap : Form
    {
        private bool isAdded = false;
        private CTPhieuNhap chiTiet;

        public bool IsAdded { get => isAdded;}
        public CTPhieuNhap ChiTiet { get => chiTiet; }

        public FormThemCTPhieuNhap(string maPhieuNhap)
        {
            InitializeComponent();
            LoadUI(maPhieuNhap);
        }

        private void LoadUI(string maPhieuNhap)
        {
            txtMaPhieuNhap.Text = maPhieuNhap;
            // Load combobox xe máy trong đơn đặt hàng
            DataTable dt = XeMayDAO.Instance.GetListXeMayTrongDonDat(maPhieuNhap);
            comboBoxXeMay.DataSource = dt;
            comboBoxXeMay.DisplayMember = "TenXeMay";
            comboBoxXeMay.ValueMember = "MaXeMay";
        }
        private bool InputHopLe()
        {
            if(numericUpDownSoLuong.Value == 0)
            {
                MessageBox.Show("Xe máy này đã nhập đủ số lượng, không thể nhập thêm");
                return false;
            }
            if (txtDonGia.Text.Equals(""))
            {
                MessageBox.Show("Đơn giá không được trống");
                return false;
            }
            return true;
        }
        private void comboBoxXeMay_SelectedValueChanged(object sender, EventArgs e)
        {
            string maXeMay = comboBoxXeMay.SelectedValue.ToString();
            if (!maXeMay.Equals("System.Data.DataRowView"))
            {
                CTDonDatHang chiTiet = DonDatHangDAO.Instance.GetCTDonDatHang(txtMaPhieuNhap.Text, maXeMay);
                if(chiTiet != null)
                {
                    txtDonGia.Text = chiTiet.DonGia.ToString();
                    numericUpDownSoLuong.Maximum = chiTiet.SoLuong;
                    numericUpDownSoLuong.Value = chiTiet.SoLuong;
                    numericUpDownSoLuong.Minimum = chiTiet.SoLuong == 0 ? 0 : 1;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                string maPhieNhap = txtMaPhieuNhap.Text;
                string maXeMay = comboBoxXeMay.SelectedValue.ToString();
                decimal donGia = Decimal.Parse(txtDonGia.Text);
                int soLuong = (int)numericUpDownSoLuong.Value;
                chiTiet = new CTPhieuNhap(maPhieNhap, maXeMay, donGia, soLuong);
                if (PhieuNhapDAO.Instance.ThemCTPhieuNhap(chiTiet))
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công");
                    isAdded = true;
                    this.Dispose();
                }
                else
                    MessageBox.Show("Thêm chi tiết phiếu nhập thất bại");
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
