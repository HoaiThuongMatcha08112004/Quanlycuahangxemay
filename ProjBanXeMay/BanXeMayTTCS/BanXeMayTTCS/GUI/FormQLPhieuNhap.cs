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
    public partial class FormQLPhieuNhap : Form
    {
        List<PhieuNhap> listPhieuNhap;
        List<CTPhieuNhap> listChiTiet;
        BindingSource bindingSourcePhieuNhap = new BindingSource();
        BindingSource bindingSourceChiTiet = new BindingSource();
        public FormQLPhieuNhap()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            listPhieuNhap = PhieuNhapDAO.Instance.GetListPhieuNhap();
            bindingSourcePhieuNhap.DataSource = listPhieuNhap;
            bindingSourcePhieuNhap.Position = 0;
            gridControlPhieuNhap.DataSource = bindingSourcePhieuNhap;
        }
        private void FillChiTiet()
        {
            if (listChiTiet != null)
                listChiTiet.Clear();
            listChiTiet = PhieuNhapDAO.Instance.GetListCTPhieuNhap(listPhieuNhap[bindingSourcePhieuNhap.Position].MaPhieuNhap);
            bindingSourceChiTiet.DataSource = listChiTiet;
            bindingSourceChiTiet.Position = 0;
            gridControlCTPhieuNhap.DataSource = bindingSourceChiTiet;
        }

        private void gridViewPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(listPhieuNhap.Count > 0)
            {
                FillChiTiet();
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if(listPhieuNhap.Count > 0)
            {
                string maPhieuNhap = listPhieuNhap[bindingSourcePhieuNhap.Position].MaPhieuNhap;
                FormThemCTPhieuNhap form = new FormThemCTPhieuNhap(maPhieuNhap);
                form.ShowDialog();
                if (form.IsAdded)
                {
                    listChiTiet.Add(form.ChiTiet);
                    bindingSourceChiTiet.Position = listChiTiet.Count - 1;
                    gridViewCTPhieuNhap.RefreshData();
                }
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (listChiTiet.Count < 1)
                return;
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa phiếu nhập này?\nSau khi xóa sẽ không thể phục hồi",
                "Xóa chi tiết phiếu nhập",
                MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                if (PhieuNhapDAO.Instance.XoaCTPhieuNhap(listChiTiet[bindingSourceChiTiet.Position]))
                {
                    MessageBox.Show("Xóa chi tiết phiếu nhập thành công");
                    listChiTiet.RemoveAt(bindingSourceChiTiet.Position);
                    bindingSourceChiTiet.Position = 0;
                    gridViewCTPhieuNhap.RefreshData();
                }
                else
                    MessageBox.Show("Xóa chi tiết phiếu nhập thất bại");
            }
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            if (listChiTiet.Count > 0)
            {
                CTPhieuNhap chiTiet = listChiTiet[bindingSourceChiTiet.Position];
                FormSuaCTPhieuNhap form = new FormSuaCTPhieuNhap(chiTiet);
                form.ShowDialog();
                if (form.IsUpdated)
                {
                    gridViewCTPhieuNhap.RefreshData();
                }
            }
        }

        private void btnTaiLaiChiTiet_Click(object sender, EventArgs e)
        {
            if(listPhieuNhap.Count > 0)
            {
                FillChiTiet();
            }
        }

        private void btnTaiLaiDonDatHang_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (listPhieuNhap.Count < 1)
                return;
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa phiếu nhập này?\nSau khi xóa không thể khôi phục lại.",
                "Xóa phiếu nhập",
                MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                string maPhieuNhap = listPhieuNhap[bindingSourcePhieuNhap.Position].MaPhieuNhap;
                if (PhieuNhapDAO.Instance.XoaPhieuNhap(maPhieuNhap, listChiTiet))
                {
                    MessageBox.Show("Xóa phiếu nhập thành công");
                    listPhieuNhap.RemoveAt(bindingSourcePhieuNhap.Position);
                    bindingSourcePhieuNhap.Position = 0;
                    listChiTiet.Clear();
                    gridViewCTPhieuNhap.RefreshData();
                    gridViewPhieuNhap.RefreshData();
                }
                else
                    MessageBox.Show("Xóa phiếu nhập thất bại");
            }
        }
    }
}
