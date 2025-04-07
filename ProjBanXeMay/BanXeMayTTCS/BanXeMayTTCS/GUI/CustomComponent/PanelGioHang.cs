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
    public partial class PanelGioHang : UserControl
    {
        public PanelGioHang()
        {
            InitializeComponent();
        }

        public void LoadUI(List<XeMayKH> listXeMay)
        {
            if (listXeMay != null)
            {
                flowLayoutPanelMain.Controls.Clear();
                foreach (XeMayKH dh in listXeMay)
                {
                    flowLayoutPanelMain.Controls.Add(new ItemGioHang(dh));
                }
            }

        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            PanelListXeMay.trangThai = 0;
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
                    LoadUI(ItemXeMay.listGioHang);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ItemXeMay.listDatHang.Count > 0)
            {
                foreach (XeMayKH dh in ItemXeMay.listDatHang)
                {
                    ItemXeMay.listGioHang.Remove(dh);
                }
                ItemXeMay.listDatHang.Clear();
                MessageBox.Show("Xóa khỏi giỏ hàng thành công");
                LoadUI(ItemXeMay.listGioHang);
            } else
            {
                MessageBox.Show("Chọn sản phẩm để xóa");
            }
            
        }
    }
}
