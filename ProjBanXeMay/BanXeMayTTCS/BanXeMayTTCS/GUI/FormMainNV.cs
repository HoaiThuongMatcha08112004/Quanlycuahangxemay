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
    public partial class FormMainNV : Form
    {
        private FormDangNhap formDangNhap;
        private bool isDangXuat = false;

        private int btnThucThi = -1;
        private const int BTN_QLXEMAY = 0;
        private const int BTN_QLDONDATHANG = 1;
        private const int BTN_QLPHIEUNHAP = 2;
        private const int BTN_QLNHANVIEN = 3;
        private const int BTN_BACKUP_RESTORE = 4;
        private const int BTN_QLTAIKHOAN = 5;

        public bool IsDangXuat { get => isDangXuat; set => isDangXuat = value; }

        public FormMainNV(FormDangNhap formDangNhap)
        {
            InitializeComponent();
            Text = "QUẢN LÝ BÁN XE MÁY";
            this.formDangNhap = formDangNhap;
            LoadUI();
        }
        private void LoadUI()
        {
            btnQLTaiKhoan.Text = "        " + DangNhapDAO.Instance.HoTen;
            if (DangNhapDAO.Instance.Nhom.Equals(DangNhapDAO.NHOM_QUANTRI))
            {
                btnQLNhanVien.Visible = true;
                btnBackupRestore.Visible = true;
            }
        }
        private void MoFormCon(Form formCon)
        {
            if (!panelContainer.Controls.Contains(formCon))
            {
                formCon.TopLevel = false;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(formCon);
                formCon.Show();
            }
        }
        private void EnableButton()
        {
            Color enableColor = Color.FromArgb(3, 169, 244);
            switch (btnThucThi)
            {
                case BTN_QLXEMAY:
                    btnQLXeMay.Enabled = true;
                    btnQLXeMay.BackColor = enableColor;
                    break;
                case BTN_QLDONDATHANG:
                    btnQLDonDatHang.Enabled = true;
                    btnQLDonDatHang.BackColor = enableColor;
                    break;
                case BTN_QLPHIEUNHAP:
                    btnQLNhapHang.Enabled = true;
                    btnQLNhapHang.BackColor = enableColor;
                    break;
                case BTN_QLNHANVIEN:
                    btnQLNhanVien.Enabled = true;
                    btnQLNhanVien.BackColor = enableColor;
                    break;
                case BTN_BACKUP_RESTORE:
                    btnBackupRestore.Enabled = true;
                    btnBackupRestore.BackColor = enableColor;
                    break;
                case BTN_QLTAIKHOAN:
                    btnQLTaiKhoan.Enabled = true;
                    btnQLTaiKhoan.BackColor = enableColor;
                    break;
            }
        }
        private void DisableButton()
        {
            Color disableColor = Color.FromArgb(1, 87, 155);
            switch (btnThucThi)
            {
                case BTN_QLXEMAY:
                    btnQLXeMay.BackColor = disableColor;
                    break;
                case BTN_QLDONDATHANG:
                    btnQLDonDatHang.BackColor = disableColor;
                    break;
                case BTN_QLPHIEUNHAP:
                    btnQLNhapHang.BackColor = disableColor;
                    break;
                case BTN_QLNHANVIEN:
                    btnQLNhanVien.BackColor = disableColor;
                    break;
                case BTN_BACKUP_RESTORE:
                    btnBackupRestore.BackColor = disableColor;
                    break;
                case BTN_QLTAIKHOAN:
                    btnQLTaiKhoan.BackColor = disableColor;
                    break;
            }
        }
        private void btnQLXeMay_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLXEMAY;
            DisableButton();
            MoFormCon(new FormQLXeMay());
        }

        private void btnQLDonDatHang_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLDONDATHANG;
            DisableButton();
            MoFormCon(new FormQLDonDatHang());
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLPHIEUNHAP;
            DisableButton();
            MoFormCon(new FormQLPhieuNhap());
        }
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLNHANVIEN;
            DisableButton();
            MoFormCon(new FormQLNhanVien());
        }
        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_BACKUP_RESTORE;
            DisableButton();
            MoFormCon(new FormBackupRestore());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLTAIKHOAN;
            DisableButton();
            MoFormCon(new FormQLTaiKhoan(this));
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (isDangXuat)
            {
                formDangNhap.Visible = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void FormMainNV_Load(object sender, EventArgs e)
        {
            btnQLXeMay_Click(sender, e);
        }

        private void panelOption_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
