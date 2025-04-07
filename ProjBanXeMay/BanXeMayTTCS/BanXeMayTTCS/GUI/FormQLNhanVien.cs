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
    public partial class FormQLNhanVien : Form
    {
        private List<NhanVien> listNhanVien;
        private BindingSource bindingSource = new BindingSource();

        private const int CHUCNANG_THEM = 0;
        private int chucNangThucThi;

        public FormQLNhanVien()
        {
            InitializeComponent();
            LoadUI();
            LoadData();
        }
        private void LoadData()
        {
            listNhanVien = NhanVienDAO.Instance.GetListNhanVien();
            bindingSource.DataSource = listNhanVien;
            gridControlNhanVien.DataSource = bindingSource;
            bindingSource.Position = 0;
        }
        private void LoadUI()
        {
            ResetTatCaComponent();
            // Combobox giới tính
            comboBoxGioiTinh.DataSource = new string[] { "Nam", "Nữ" };
        }
        private void FillInput()
        {
            NhanVien nhanVien = listNhanVien[bindingSource.Position];
            txtMaNhanVien.Text = nhanVien.MaNhanVien.ToString();
            txtHo.Text = nhanVien.Ho;
            txtTen.Text = nhanVien.Ten;
            txtSDT.Text = nhanVien.Sdt;
            comboBoxGioiTinh.Text = nhanVien.GioiTinh;
            dateTimePickerNgaySinh.Value = nhanVien.NgaySinh;
            txtEmail.Text = nhanVien.Email;
            txtTaiKhoan.Text = nhanVien.TaiKhoan;
            txtDiaChi.Text = nhanVien.DiaChi;
        }
        private void ResetTatCaComponent()
        {
            chucNangThucThi = -1;
            // Enable các input và chuyển về ReadOnly
            ThayDoiInputEnabled(true);
            ThayDoiInputReadOnly(true);
            // Enable Grid control xe máy
            gridControlNhanVien.Enabled = true;
            // Enable tất cả nút trừ Ghi và Thoát chức năng
            ThayDoiButtonEnabled(true);
            btnGhi.Enabled = false;
            btnThoatChucNang.Enabled = false;
        }
        private void ResetGiaTriInput()
        {
            txtMaNhanVien.Text = "Tự động sinh";
            txtHo.ResetText();
            txtTen.ResetText();
            txtSDT.ResetText();
            comboBoxGioiTinh.SelectedIndex = 0;
            dateTimePickerNgaySinh.ResetText();
            txtEmail.ResetText();
            txtTaiKhoan.ResetText();
            txtDiaChi.ResetText();
        }
        private void ThayDoiInputEnabled(bool enabled)
        {
            txtMaNhanVien.Enabled = enabled;
            txtHo.Enabled = enabled;
            txtTen.Enabled = enabled;
            txtSDT.Enabled = enabled;
            comboBoxGioiTinh.Enabled = enabled;
            dateTimePickerNgaySinh.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtTaiKhoan.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
        }
        private void ThayDoiInputReadOnly(bool readOnly)
        {
            txtMaNhanVien.ReadOnly = readOnly;
            txtHo.ReadOnly = readOnly;
            txtTen.ReadOnly = readOnly;
            txtSDT.ReadOnly = readOnly;
            comboBoxGioiTinh.Enabled = !readOnly;
            dateTimePickerNgaySinh.Enabled = !readOnly;
            txtEmail.ReadOnly = readOnly;
            txtTaiKhoan.ReadOnly = readOnly;
            txtDiaChi.ReadOnly = readOnly;
        }
        private void ThayDoiButtonEnabled(bool enabled)
        {
            btnThem.Enabled = enabled;
            btnGhi.Enabled = enabled;
            btnTaiLai.Enabled = enabled;
            btnThoatChucNang.Enabled = enabled;
        }
        private void ThemNhanVien()
        {
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text;
            string gioiTinh = comboBoxGioiTinh.Text;
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string taiKhoan = txtTaiKhoan.Text;
            NhanVien nhanVien = new NhanVien(ho, ten, gioiTinh, ngaySinh, diaChi, sdt, email, taiKhoan);
            nhanVien.MaNhanVien = NhanVienDAO.Instance.ThemNhanVien(nhanVien);
            if (nhanVien.MaNhanVien != -1)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                listNhanVien.Add(nhanVien);
                bindingSource.Position = listNhanVien.Count - 1;
                gridViewNhanVien.RefreshData();
                ResetTatCaComponent();
            }
            else
                MessageBox.Show("Thêm nhân viên thất bại");
        }
        private void ThucThiChucNang()
        {
            // Disable tất cả nút chức năng khác trừ Ghi và Thoát
            ThayDoiInputEnabled(true);
            ThayDoiInputReadOnly(false);
            ThayDoiButtonEnabled(false);
            btnGhi.Enabled = true;
            btnThoatChucNang.Enabled = true;
            // Thực thi
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    gridControlNhanVien.Enabled = false;
                    txtMaNhanVien.Enabled = false;
                    ResetGiaTriInput();
                    break;
            }
        }
        private void GhiDuLieu()
        {
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    if (InputHopLe())
                        ThemNhanVien();
                    break;
            }
        }
        private bool InputHopLe()
        {
            if (txtHo.Text.Equals(""))
            {
                MessageBox.Show("Họ không được trống");
                return false;
            }
            if (txtTen.Text.Equals(""))
            {
                MessageBox.Show("Tên không được trống");
                return false;
            }
            if (!txtSDT.Text.StartsWith("0") || txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đúng định dạng: Có 10 ký số và bắt đầu bằng 0");
                return false;
            }
            if (txtHo.Text.Equals(""))
            {
                MessageBox.Show("Họ không được trống");
                return false;
            }
            if (txtEmail.Text.Equals("") || !MyFormat.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            if (txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản không được trống");
                return false;
            }
            if (txtDiaChi.Text.Equals(""))
            {
                MessageBox.Show("Địa chỉ không được trống");
                return false;
            }
            return true;
        }
        private void gridViewNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chucNangThucThi = CHUCNANG_THEM;
            ThucThiChucNang();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            GhiDuLieu();
        }

        private void btnThoatChucNang_Click(object sender, EventArgs e)
        {
            ResetTatCaComponent();
            FillInput();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
