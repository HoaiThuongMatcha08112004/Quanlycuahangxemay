using BanXeMayTTCS.DTO;
using BanXeMayTTCS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.DAO
{
    public class PhieuDatKhDAO
    {
        private static PhieuDatKhDAO instance;

        public static PhieuDatKhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatKhDAO();
                return instance;
            }
        }

        public int ThemPhieuDatHang(PhieuDatKh phieuDat)
        {
            int maPhieuDat = -1;
            string query = "EXEC SP_THEM_PHIEU_DAT @HoTenNN , @DiaChiNN , @SDTNN , @MaKhachHang";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[]
                {
                    phieuDat.HoTenNguoiNhan,
                    phieuDat.DiaChiNguoiNhan,
                    phieuDat.SdtNguoiNhan,
                    phieuDat.MaKhachHang
                });
                maPhieuDat = (int)dt.Rows[0]["MaPhieuDat"];
                return maPhieuDat;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi tạo đơn đặt hàng. " + e.Message);
                return maPhieuDat;
            }
        }

        public bool ThemCTPhieuDat(CtDatHangKh chiTiet)
        {
            string query = "EXEC SP_THEM_CT_PHIEU_DAT @MaPhieuDat , @MAXEMAY , @SOLUONG , @DonGia";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { chiTiet.MaPhieuDat, chiTiet.MaXeMay, chiTiet.SoLuong, chiTiet.DonGia });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm chi tiết phiếu nhập. " + e.Message);
                return false;
            }
        }
    }
}
