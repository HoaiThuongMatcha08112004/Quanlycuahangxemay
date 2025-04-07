using BanXeMayTTCS.DAO;
using BanXeMayTTCS.DTO;
using BanXeMayTTCS.GUI.CustomComponent;
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
    public partial class FormDatHang : Form
    {
        private bool isAdded = false;
        public bool IsAdded { get => isAdded; }
        private PhieuDatKh phieuDat;
        private CtDatHangKh chiTiet;
        public FormDatHang()
        {
            InitializeComponent();
            FillInputKh();
            LoadUI();

        }

        public void LoadUI()
        {
            if (ItemXeMay.listDatHang != null)
            {
                flowLayoutPanel2.Controls.Clear();
                foreach (XeMayKH dh in ItemXeMay.listDatHang)
                {
                    flowLayoutPanel2.Controls.Add(new ItemDatHang(dh));
                }
            }

        }

        private void FillInputKh()
        {
            txtHoTenKh.Text = DangNhapDAO.Instance.HoTen;
            txtSdtKh.Text = DangNhapDAO.Instance.Sdt;
            txtDiaChiKh.Text = DangNhapDAO.Instance.DiaChi;
        }

        private bool InputHopLe()
        {
            if (txtTenNN.Text.Equals(""))
            {
                MessageBox.Show("Họ tên người nhận không được trống"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtSdtKh.Text.StartsWith("0") || txtSdtKh.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đúng định dạng: Có 10 ký số và bắt đầu bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiaChiNN.Text.Equals(""))
            {
                MessageBox.Show("Địa chỉ người nhận không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void ThemCtPhieuDat()
        {
            foreach (XeMayKH dh in ItemXeMay.listDatHang)
            {
                chiTiet = new CtDatHangKh(phieuDat.MaPhieuDat, dh.MaXeMay, dh.SoLuong, dh.SoLuong * dh.Gia);
                if (PhieuDatKhDAO.Instance.ThemCTPhieuDat(chiTiet))
                {
                }
            }
            if(PanelListXeMay.trangThai == 0)
            {
                foreach(XeMayKH dh in ItemXeMay.listDatHang)
                {
                    ItemXeMay.listGioHang.Remove(dh);
                }
            }

            ItemXeMay.listDatHang.Clear();

        }

        public void ThemPhieuDat()
        {
            if (cbNguoiNhan.Checked)
            {
                if (InputHopLe())
                {
                    phieuDat = new PhieuDatKh(DateTime.Now, txtTenNN.Text, txtDiaChiNN.Text, txtSdtNN.Text, DangNhapDAO.Instance.Id);
                    phieuDat.MaPhieuDat = PhieuDatKhDAO.Instance.ThemPhieuDatHang(phieuDat);
                    if (phieuDat.MaPhieuDat != -1)
                    {
                        ThemCtPhieuDat();
                        MessageBox.Show("Tạo phiếu đặt hàng thành công " + phieuDat.MaPhieuDat);
                        isAdded = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tạo phiếu đặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                phieuDat = new PhieuDatKh(DateTime.Now, txtHoTenKh.Text, txtDiaChiKh.Text, txtSdtKh.Text, DangNhapDAO.Instance.Id);
                phieuDat.MaPhieuDat = PhieuDatKhDAO.Instance.ThemPhieuDatHang(phieuDat);
                if (phieuDat.MaPhieuDat != -1)
                {
                    ThemCtPhieuDat();
                    MessageBox.Show("Tạo phiếu đặt hàng thành công " + phieuDat.MaPhieuDat);
                    isAdded = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tạo phiếu đặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void cbNguoiNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNguoiNhan.Checked == true)
            {
                pnNguoiNhan.Size = pnNguoiNhan.MaximumSize;
            }
            else
            {
                pnNguoiNhan.Size = pnNguoiNhan.MinimumSize;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ThemPhieuDat();
            
        }

        private void txtSdtKh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
