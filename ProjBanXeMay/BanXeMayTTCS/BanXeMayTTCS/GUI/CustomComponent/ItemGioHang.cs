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
    public partial class ItemGioHang : UserControl
    {
        XeMayKH dongHo;
        //public static List<XeMay> listDatHang = new List<XeMay>();
        public ItemGioHang(XeMayKH dongHo)
        {
            InitializeComponent();
            this.dongHo = dongHo;
            LoadUI();
        }

        public void LoadUI()
        {
            // Các label thông tin
            lbTen.Text = dongHo.TenXeMay;
            lbGia.Text = "Giá: " + MyFormat.FormatMoney(dongHo.Gia) + " VNĐ";
            numSl.Value =  dongHo.SoLuong;
            lbLoai.Text = "Loại: " + dongHo.Loai;
            lbHang.Text = "Hãng: " + dongHo.Hang;
            lbNhaCc.Text = "Nhà cung cấp: " + dongHo.NhaCungCap;
            lbTrangThai.Text = "Trạng thái: " + dongHo.TrangThai;
            lbMoTa.Text = "Mô tả: " + dongHo.MoTa;
            try
            {
                picXeMay.Image = Image.FromFile(MyFormat.GetFilePath(dongHo.HinhAnh));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi load hình. " + ex.Message);
            }
        }

        private void numSl_ValueChanged(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(numSl.Value);
            foreach (XeMayKH dh in PanelListXeMay.listXeMay)
            {
                if (dh.MaXeMay.Equals(dongHo.MaXeMay))
                {
                    dongHo.SoLuongTon = dh.SoLuongTon;
                }
            }
            if (sl > dongHo.SoLuongTon)
            {
                numSl.Value--;
                //numSl.Enabled = false;
                //MessageBox.Show("Không còn đủ hàng", "", MessageBoxButtons.OK);
            }
        }

        private void cbDatHang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDatHang.Checked) // nếu được check thì thêm vào list
            {
              /* foreach(XeMay dh in PanelListXeMay.listXeMay)
                {
                    if (dh.MaXeMay.Equals(dongHo.MaXeMay))
                    {
                        dongHo.SoLuongTon = dh.SoLuongTon;
                    }
                }*/


                    dongHo.SoLuong = Convert.ToInt32(numSl.Value);
                    numSl.Enabled = false;
                
                
                if (dongHo.SoLuong == 0)
                {
                    MessageBox.Show("Chọn số lượng sản phẩm " + dongHo.TenXeMay + " > 0", "", MessageBoxButtons.OK);
                    cbDatHang.Checked = false;
                }
                else
                {
                    ItemXeMay.listDatHang.Add(dongHo);
                }
            }
            else
            {
                numSl.Enabled = true;
                ItemXeMay.listDatHang.Remove(dongHo);
            }
        }
    }
}
