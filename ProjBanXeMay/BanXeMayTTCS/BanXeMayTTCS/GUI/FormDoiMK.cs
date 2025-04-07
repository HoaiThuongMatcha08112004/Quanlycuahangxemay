using BanXeMayTTCS.DAO;
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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
            LoadUI();
        }
        private void LoadUI()
        {
            txtTaiKhoan.Text = DangNhapDAO.Instance.TaiKhoan;
        }
        private bool InputHopLe()
        {
            if (txtMatKhauCu.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu cũ không được trống");
                return false;
            }
            if (txtMatKhauMoi.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu mới không được trống");
                return false;
            }
            if (!txtMatKhauMoi.Text.Equals(txtNhapLaiMK.Text))
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp");
                return false;
            }
            return true;
        }
        private void DoiMatKhau()
        {
            if (DangNhapDAO.Instance.DoiMatKhau(txtMatKhauCu.Text, txtMatKhauMoi.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Dispose();
            }
            else
                MessageBox.Show("Đổi mật khẩu thất bại");
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                DoiMatKhau();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
