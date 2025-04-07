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
    public partial class FormDangKy : Form
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private bool isAdded = false;

        public string TaiKhoan { get => taiKhoan;}
        public string MatKhau { get => matKhau;}
        public bool IsAdded { get => isAdded; }

        public FormDangKy()
        {
            InitializeComponent();
            LoadUI();
        }
        private void LoadUI()
        {
            comboBoxGioiTinh.DataSource = new string[] { "Nam", "Nữ" };
        }
        private bool InputHopLe()
        {
            if (txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtXacNhanMK.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtMatKhau.Text.Equals(txtXacNhanMK.Text))
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtHo.Text.Equals("") || txtTen.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải điền đủ họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCMND.Text.Length != 10)
            {
                MessageBox.Show("CMND/CCCD phải có đúng 10 ký số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiaChi.Text.Equals(""))
            {
                MessageBox.Show("Địa chỉ không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSoDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Số điện thoại không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtEmail.Text.Equals("") && !MyFormat.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void DangKyKhachHang()
        {
            KhachHang khachHang = new KhachHang(
                txtCMND.Text,
                txtHo.Text,
                txtTen.Text,
                comboBoxGioiTinh.Text,
                datePickerNgaySinh.Value,
                txtDiaChi.Text,
                txtSoDienThoai.Text,
                txtEmail.Text.Equals("") ? null : txtEmail.Text,
                txtMaSoThue.Text.Equals("") ? null : txtMaSoThue.Text,
                txtTaiKhoan.Text
            );

            if (DangNhapDAO.Instance.DangKyKhachHang(khachHang, txtMatKhau.Text))
            {
                MessageBox.Show("Đăng ký khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                taiKhoan = txtTaiKhoan.Text;
                matKhau = txtMatKhau.Text;
                isAdded = true;
                this.Dispose();
            }
            else
                MessageBox.Show("Đăng ký khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                DangKyKhachHang();
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
