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
    public partial class FormQLDonDatHang : Form
    {
        List<DonDatHang> listDonDatHang;
        List<CTDonDatHang> listChiTiet;
        BindingSource bindingSourceDonDatHang = new BindingSource();
        BindingSource bindingSourceChiTiet = new BindingSource();
        public FormQLDonDatHang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            listDonDatHang = DonDatHangDAO.Instance.GetListDonDatHang();
            bindingSourceDonDatHang.DataSource = listDonDatHang;
            bindingSourceDonDatHang.Position = 0;
            gridControlDonDatHang.DataSource = bindingSourceDonDatHang;
        }
        private void FillChiTiet()
        {
            if(listChiTiet != null)
                listChiTiet.Clear();
            listChiTiet = DonDatHangDAO.Instance.GetListCTDonDatHang(listDonDatHang[bindingSourceDonDatHang.Position].MaDonDatHang);
            bindingSourceChiTiet.DataSource = listChiTiet;
            bindingSourceChiTiet.Position = 0;
            gridControlCTDonDatHang.DataSource = bindingSourceChiTiet;
        }
        private void XoaDonDatHang()
        {
            if(listDonDatHang.Count > 0)
            {
                string maDonDatHang = listDonDatHang[bindingSourceDonDatHang.Position].MaDonDatHang;
                if (DonDatHangDAO.Instance.XoaDonDatHang(maDonDatHang)){
                    MessageBox.Show("Xóa đơn đặt hàng thành công");
                    listDonDatHang.RemoveAt(bindingSourceDonDatHang.Position);
                    bindingSourceDonDatHang.Position = 0;
                    gridViewDonDatHang.RefreshData();
                }
                else
                    MessageBox.Show("Xóa đơn đặt hàng thất bại");
            }
        }
        private void DaNhapHang(bool daNhapHang)
        {
            btnXoaDonDatHang.Enabled = !daNhapHang;
            btnThemChiTiet.Enabled = btnSuaChiTiet.Enabled = btnXoaChiTiet.Enabled = btnThemPhieuNhap.Enabled = !daNhapHang;
        }
        private void btnThemDonDatHang_Click(object sender, EventArgs e)
        {
            FormThemDonDatHang form = new FormThemDonDatHang();
            form.ShowDialog();
            if (form.IsAdded)
            {
                listDonDatHang.Add(form.DonDatHang);
                bindingSourceDonDatHang.Position = listDonDatHang.Count - 1;
                gridViewDonDatHang.RefreshData();
            }
        }
        private void btnXoaDonDatHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa đơn đặt hàng này?\nSau khi xóa sẽ không thể khôi phục",
                "Xóa đơn đặt hàng",
                MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                XoaDonDatHang();
            }
        }

        private void btnTaiLaiDonDatHang_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if(listChiTiet.Count == 0)
            {
                MessageBox.Show("Đơn đặt hàng trống, không thể tạo phiếu nhập hàng");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn tạo phiếu nhập cho đơn đặt hàng này?",
                "Tạo phiếu nhập cho đơn đặt hàng",
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                PhieuNhap phieuNhap = new PhieuNhap(
                    listDonDatHang[bindingSourceDonDatHang.Position].MaDonDatHang,
                    DateTime.Now,
                    DangNhapDAO.Instance.Id);
                if (PhieuNhapDAO.Instance.ThemPhieuNhap(phieuNhap))
                {
                    MessageBox.Show("Tạo phiếu nhập thành công");
                    listDonDatHang[bindingSourceDonDatHang.Position].DaNhapHang = 1;
                    gridViewDonDatHang.RefreshData();
                }
                else
                    MessageBox.Show("Tạo phiếu nhập thất bại");
            }
        }
        private void gridViewDonDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(listDonDatHang.Count > 0) {
                FillChiTiet();
                // Nếu đã nhập hàng thì không cho chỉnh sửa đơn đặt hàng
                if(listDonDatHang[bindingSourceDonDatHang.Position].DaNhapHang == 1)
                {
                    DaNhapHang(true);
                }
                else
                {
                    DaNhapHang(false);
                }
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if(listDonDatHang.Count > 0)
            {
                DonDatHang donDatHang = listDonDatHang[bindingSourceDonDatHang.Position];
                FormThemCTDonDatHang form = new FormThemCTDonDatHang(donDatHang);
                form.ShowDialog();
                if (form.IsAdded)
                {
                    listChiTiet.Add(form.ChiTiet);
                    bindingSourceChiTiet.Position = listChiTiet.Count - 1;
                    gridViewCTDonDatHang.RefreshData();
                }
            }
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            if(listChiTiet.Count > 0)
            {
                DonDatHang donDatHang = listDonDatHang[bindingSourceDonDatHang.Position];
                CTDonDatHang chiTiet = listChiTiet[bindingSourceChiTiet.Position];
                FormSuaCTDonHang form = new FormSuaCTDonHang(donDatHang, chiTiet);
                form.ShowDialog();
                if (form.IsUpdated)
                {
                    gridViewCTDonDatHang.RefreshData();
                }
            }
        }
        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (listChiTiet.Count < 1)
                return;
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa chi tiết đơn đặt hàng này?\nSau khi xóa không thể khôi phục",
                "Xóa chi tiết đơn đặt hàng",
                MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                if (DonDatHangDAO.Instance.XoaCTDonDatHang(listChiTiet[bindingSourceChiTiet.Position]))
                {
                    MessageBox.Show("Xóa chi tiết đơn đặt hàng thành công");
                    listChiTiet.RemoveAt(bindingSourceChiTiet.Position);
                    gridViewCTDonDatHang.RefreshData();
                }
                else
                    MessageBox.Show("Xóa chi tiết đơn đặt hàng thất bại");
            }
        }
        private void btnTaiLaiChiTiet_Click(object sender, EventArgs e)
        {
            if (listDonDatHang.Count > 0)
            {
                FillChiTiet();
            }
        }

        private void FormQLDonDatHang_Load(object sender, EventArgs e)
        {

        }

        private void panelCTDonDatHang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
