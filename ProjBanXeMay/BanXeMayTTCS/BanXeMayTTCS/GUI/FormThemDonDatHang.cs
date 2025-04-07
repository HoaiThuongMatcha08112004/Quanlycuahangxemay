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
    public partial class FormThemDonDatHang : Form
    {
        private bool isAdded = false;
        private DonDatHang donDatHang;
        public bool IsAdded { get => isAdded;}
        public DonDatHang DonDatHang { get => donDatHang;}

        public FormThemDonDatHang()
        {
            InitializeComponent();
            LoadUI();
        }
        private void LoadUI()
        {
            txtMaDonDatHang.Text = "DH" + DateTime.Now.ToString("yyyyMMddhhmmss");
            txtMaNVTao.Text = DangNhapDAO.Instance.Id.ToString();
            DataTable lisNhaCungCap = XeMayDAO.Instance.GetLisNhaCungCap();
            comboBoxNhaCungCap.DataSource = lisNhaCungCap;
            comboBoxNhaCungCap.DisplayMember = "TenNhaCungCap";
            comboBoxNhaCungCap.ValueMember = "MaNhaCungCap";
        }
        private bool InputHopLe()
        {
            if (txtMaDonDatHang.Equals(""))
            {
                MessageBox.Show("Mã đơn đặt hàng không được trống");
                return false;
            }
            return true;
        }
        private void ThemDonDatHang()
        {
            donDatHang = new DonDatHang(
                txtMaDonDatHang.Text,
                DateTime.Now,
                int.Parse(txtMaNVTao.Text),
                comboBoxNhaCungCap.SelectedValue.ToString(),
                0);
            if (DonDatHangDAO.Instance.ThemDonDatHang(donDatHang))
            {
                MessageBox.Show("Tạo đơn đặt hàng thành công");
                donDatHang.NhaCungCap = comboBoxNhaCungCap.Text;
                isAdded = true;
                this.Hide();
            }
            else
                MessageBox.Show("Tạo đơn đặt hàng thất bại");
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
                ThemDonDatHang();
        }

        private void txtMaDonDatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
