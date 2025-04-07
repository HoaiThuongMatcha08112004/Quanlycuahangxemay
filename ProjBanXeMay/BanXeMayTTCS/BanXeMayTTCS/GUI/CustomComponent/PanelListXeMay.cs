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

namespace BanXeMayTTCS.GUI.CustomComponent
{
    public partial class PanelListXeMay : UserControl
    {
        public static List<XeMayKH> listXeMay;
        public static int trangThai; // 0 là của giỏ hàng, 1 là của trang chủ
        //Loai loaiXeMay = new Loai("", "Loại xe máy");
        public PanelListXeMay()
        {
            InitializeComponent();
            //LoadCbLoai();
            loadCom();
            LoadData();
            LoadUI();
        }

        public void LoadData()
        {
            listXeMay = XeMayDAO.Instance.GetListXeMay_KH();
        }

        public void loadCom()
        {
            // Combobox loại xe máy
            cmbLoai.DataSource = XeMayDAO.Instance.GetListLoai();
            cmbLoai.DisplayMember = "TenLoai";
            cmbLoai.ValueMember = "MaLoai";
            // Combobox hãng xe máy
            cmbHang.DataSource = XeMayDAO.Instance.GetListHang();
            cmbHang.DisplayMember = "TenHang";
            cmbHang.ValueMember = "MaHang";
            // Combobox nhà cung cấp
            cmbNhaCc.DataSource = XeMayDAO.Instance.GetLisNhaCungCap();
            cmbNhaCc.DisplayMember = "TenNhaCungCap";
            cmbNhaCc.ValueMember = "MaNhaCungCap";
        }
        public void LoadUI()
        {
            if (listXeMay != null)
            {
                flowLayoutPanelMain.Controls.Clear();
                foreach (XeMayKH dh in listXeMay)
                {
                    flowLayoutPanelMain.Controls.Add(new ItemXeMay(dh));
                }
            }

        }

        public void LoadCbLoai()
        {
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            trangThai = 1;
            if (ItemXeMay.listDatHang.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để đặt hàng", "", MessageBoxButtons.OK);
            }
            else
            {
                FormDatHang form = new FormDatHang();
                form.ShowDialog();
                if (form.IsAdded)
                {
                    LoadData();
                    LoadUI();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadUI();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string loai = (string)cmbLoai.SelectedValue;
            string hang = (string)cmbHang.SelectedValue;
            string nhaCungCap = (string)cmbNhaCc.SelectedValue;
            listXeMay = XeMayDAO.Instance.Search_XeMay(loai, nhaCungCap, hang);
            if(listXeMay.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào phù hợp", "", MessageBoxButtons.OK);
            } else
            {
                LoadUI();
            }
        }
    }
}
