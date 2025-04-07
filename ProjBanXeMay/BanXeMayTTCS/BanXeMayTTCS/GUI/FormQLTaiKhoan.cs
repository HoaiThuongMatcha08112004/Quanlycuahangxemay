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
    public partial class FormQLTaiKhoan : Form
    {
        private FormMainNV formMainNV;
        private FormMainKH formMainKH;
        public FormQLTaiKhoan(FormMainNV formMainNV)
        {
            InitializeComponent();
            this.formMainNV = formMainNV;
            LoadUI();
        }
        public FormQLTaiKhoan(FormMainKH formMainKH)
        {
            InitializeComponent();
            this.formMainKH = formMainKH;
            LoadUI();
        }
        private void LoadUI()
        {
            lbHoTen.Text = DangNhapDAO.Instance.HoTen.ToUpper();
            lbTaiKhoan.Text = "Tài khoản: " + DangNhapDAO.Instance.TaiKhoan;
            lbNhom.Text = "Nhóm người dùng: " + DangNhapDAO.Instance.Nhom;
            btnSdt.Text = "Số điện thoại: " + DangNhapDAO.Instance.Sdt;
            btnDiaChi.Text = "Địa chỉ: " + DangNhapDAO.Instance.DiaChi;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormDoiMK().ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if(formMainNV != null)
            {
                formMainNV.IsDangXuat = true;
                formMainNV.Dispose();
            }
            else
            {
                formMainKH.IsDangXuat = true;
                formMainKH.Dispose();
            }
        }
    }
}
