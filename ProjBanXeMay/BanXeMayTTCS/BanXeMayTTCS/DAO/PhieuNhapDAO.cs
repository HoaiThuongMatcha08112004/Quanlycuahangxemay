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
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;
        public static PhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapDAO();
                return instance;
            }
        }
        public List<PhieuNhap> GetListPhieuNhap()
        {
            string query = "SELECT * FROM V_GET_PHIEUNHAP";
            string maPhieuNhap;
            DateTime ngayNhap;
            int maNhanVien;
            try
            {
                List<PhieuNhap> list = new List<PhieuNhap>();
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                foreach (DataRow dr in dt.Rows)
                {
                    maPhieuNhap = (string)dr["MaPhieuNhap"];
                    ngayNhap = (DateTime)dr["NgayNhap"];
                    maNhanVien = (int)dr["MaNhanVien"];
                    list.Add(new PhieuNhap(maPhieuNhap, ngayNhap, maNhanVien));
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách phiếu nhập. " + e.Message);
                return null;
            }
        }
        public List<CTPhieuNhap> GetListCTPhieuNhap(string maPhieuNhap)
        {
            string query = "EXEC SP_GET_CT_PHIEUNHAP @MAPHIEUNHAP";
            string maXeMay;
            decimal donGia;
            int soLuong;
            try
            {
                List<CTPhieuNhap> list = new List<CTPhieuNhap>();
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maPhieuNhap });
                foreach(DataRow dr in dt.Rows)
                {
                    maXeMay = (string)dr["MaXeMay"];
                    donGia = (decimal)dr["DonGia"];
                    soLuong = (int)dr["SoLuong"];
                    CTPhieuNhap chiTiet = new CTPhieuNhap(maPhieuNhap, maXeMay, donGia, soLuong);
                    list.Add(chiTiet);
                }
                return list;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách chi tiết phiếu nhập. " + e.Message);
                return null;
            }
        }
        public bool ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            string query = "EXEC SP_THEM_PHIEUNHAP @MAPHIEUNHAP , @MANHANVIEN";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { phieuNhap.MaPhieuNhap, phieuNhap.MaNhanVien });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm phiếu nhập. " + e.Message);
                return false;
            }
        }
        public bool XoaPhieuNhap(string maPhieuNhap, List<CTPhieuNhap> listChiTiet)
        {
            bool thanhCong = true;
            List<CTPhieuNhap> listChiTietDaXoa = new List<CTPhieuNhap>();
            foreach(CTPhieuNhap c in listChiTiet)
            {
                if (XoaCTPhieuNhap(c))
                {
                    listChiTietDaXoa.Add(c);
                }
                else
                {
                    thanhCong = false;
                    break;
                }
            }
            if (thanhCong)
            {
                string query = "EXEC SP_XOA_PHIEUNHAP @MAPHIEUNHAP";
                try
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maPhieuNhap });
                    return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show("ERROR: Có lỗi khi xóa phiếu nhập. " + e.Message);
                    foreach (CTPhieuNhap c in listChiTietDaXoa)
                    {
                        ThemCTPhieuNhap(c);
                    }
                    return false;
                }
            }
            else
            {
                foreach (CTPhieuNhap c in listChiTietDaXoa)
                {
                    ThemCTPhieuNhap(c);
                }
                return false;
            }
        }
        public bool ThemCTPhieuNhap(CTPhieuNhap chiTiet)
        {
            string query = "EXEC SP_THEM_CT_PHIEUNHAP @MAPHIEUNHAP , @MAXEMAY , @DONGIA , @SOLUONG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { chiTiet.MaPhieuNhap, chiTiet.MaXeMay, chiTiet.DonGia, chiTiet.SoLuong });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm chi tiết phiếu nhập. " + e.Message);
                return false;
            }
        }
        public bool XoaCTPhieuNhap(CTPhieuNhap chiTiet)
        {
            string query = "EXEC SP_XOA_CT_PHIEUNHAP @MAPHIEUNHAP , @MAXEMAY , @DONGIA , @SOLUONG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { chiTiet.MaPhieuNhap, chiTiet.MaXeMay, chiTiet.DonGia, chiTiet.SoLuong });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa chi tiết phiếu nhập. " + e.Message);
                return false;
            }
        }
        public bool SuaCTPhieuNhap(CTPhieuNhap chiTiet)
        {
            string query = "EXEC SP_SUA_CT_PHIEUNHAP @MAPHIEUNHAP , @MAXEMAY , @DONGIA , @SOLUONG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { chiTiet.MaPhieuNhap, chiTiet.MaXeMay, chiTiet.DonGia, chiTiet.SoLuong });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi sửa chi tiết phiếu nhập. " + e.Message);
                return false;
            }
        }
    }
}
