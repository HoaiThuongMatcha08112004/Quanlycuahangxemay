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
    public partial class ItemXeMay : UserControl
    {
        public static List<XeMayKH> listGioHang = new List<XeMayKH>();
        public static List<XeMayKH> listDatHang = new List<XeMayKH>();
        public XeMayKH dongHo;
        public ItemXeMay(XeMayKH dongHo)
        {
            InitializeComponent();
            this.dongHo = dongHo;
            Reset(false);
            LoadUI();
        }

        public void LoadUI()
        {
            // Các label thông tin
            lbTen.Text = dongHo.TenXeMay;
            lbGia.Text = "Giá: " + MyFormat.FormatMoney(dongHo.Gia) + " VNĐ";
            lbSl.Text = "Số lượng tồn: " + dongHo.SoLuongTon;
            lbLoai.Text = "Loại: " + dongHo.Loai;
            lbHang.Text = "Hãng: " + dongHo.Hang;
            lbNhaCc.Text = "Nhà cung cấp: " + dongHo.NhaCungCap;
            lbTrangThai.Text = "Trạng thái: " + dongHo.TrangThai;
            lbMoTa.Text = "Mô tả: " + dongHo.MoTa;
            // Trạng thái
            if (dongHo.TrangThai.Equals("Tạm hết hàng"))
            {
                btnAdd.Enabled = false;
                cbDatHang.Enabled = false;
            }
            // Hình tham khảo
            try
            {
                picXeMay.Image = Image.FromFile(MyFormat.GetFilePath(dongHo.HinhAnh));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi load hình. " + ex.Message);
            }
        }

        public void Reset(bool enable)
        {
            numSl.Value = 1;
            cbDatHang.Checked = enable;
        }


        public int productIsInCart(XeMayKH dongHo, List<XeMayKH> listXeMay)
        {
            for (int i = 0; i < listGioHang.Count; i++)
            {
                if (listXeMay[i].MaXeMay.Equals(dongHo.MaXeMay))
                {
                    return 0;
                }
            }
            return -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int kq = productIsInCart(dongHo, listGioHang);
            if (kq == 0)
            {
                if (dongHo.SoLuong + Convert.ToInt32(numSl.Value) <= dongHo.SoLuongTon)
                {
                    dongHo.SoLuong += Convert.ToInt32(numSl.Value);
                    MessageBox.Show("Số lượng: " + dongHo.SoLuong, "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Số lượng tồn không đủ");
            }
            else
            {
                dongHo.SoLuong = Convert.ToInt32(numSl.Value);
                listGioHang.Add(dongHo);
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
            }
            numSl.Value = 1;
        }

        private void cbDatHang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDatHang.Checked) // nếu được check thì thêm vào list
            {
                dongHo.SoLuong = Convert.ToInt32(numSl.Value);
                numSl.Enabled = false;
                if (dongHo.SoLuong == 0)
                {
                    MessageBox.Show("Chọn số lượng sản phẩm " + dongHo.TenXeMay + " > 0", "", MessageBoxButtons.OK);
                    cbDatHang.Checked = false;
                }
                else
                {
                    listDatHang.Add(dongHo);
                }
            }
            else
            {
                numSl.Enabled = true;
                listDatHang.Remove(dongHo);
            }
        }

        private void numSl_ValueChanged(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(numSl.Value);
            if (sl > dongHo.SoLuongTon)
            {
                numSl.Value--;
                //numSl.Enabled = false;
                MessageBox.Show("Không còn đủ hàng", "", MessageBoxButtons.OK);
            }
        }
    }
}
