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
    public class DonDatHangDAO
    {
        private static DonDatHangDAO instance;
        public static DonDatHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonDatHangDAO();
                return instance;
            }
        }
        public List<DonDatHang> GetListDonDatHang()
        {
            string query = "EXEC SP_GET_DONDATHANG";
            string maDonDatHang;
            DateTime ngayDatHang;
            int maNhanVien;
            string nhaCungCap;
            int daNhapHang;
            try
            {
                List<DonDatHang> list = new List<DonDatHang>();
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                foreach (DataRow dr in dt.Rows)
                {
                    maDonDatHang = (string)dr["MaDonDatHang"];
                    ngayDatHang = (DateTime)dr["NgayDatHang"];
                    maNhanVien = (int)dr["MaNhanVien"];
                    nhaCungCap = (string)dr["NhaCungCap"];
                    daNhapHang = (int)dr["DaNhapHang"];
                    list.Add(new DonDatHang(maDonDatHang, ngayDatHang, maNhanVien, nhaCungCap, daNhapHang));
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách đơn đặt hàng. " + e.Message);
                return null;
            }
        }
        /*public List<DonDatHang> GetDonDatHangByKhachHang(int maKhachHang)
        {
            string query = "SELECT * FROM DonDatHang WHERE MaKhachHang = @MaKhachHang";
            string maDonDatHang;
            DateTime ngayDatHang;
            int maNhanVien;
            string nhaCungCap;
            int daNhapHang;
            try
            {
                List<DonDatHang> list = new List<DonDatHang>();
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maKhachHang });
                foreach (DataRow dr in dt.Rows)
                {
                    maDonDatHang = (string)dr["MaDonDatHang"];
                    ngayDatHang = (DateTime)dr["NgayDatHang"];
                    maNhanVien = (int)dr["MaNhanVien"];
                    nhaCungCap = (string)dr["NhaCungCap"];
                    daNhapHang = (int)dr["DaNhapHang"];
                    list.Add(new DonDatHang(maDonDatHang, ngayDatHang, maNhanVien, nhaCungCap, daNhapHang));
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi khi lấy danh sách đơn đặt hàng theo khách hàng: " + e.Message);
            }
        }*/
        public List<CTDonDatHang> GetListCTDonDatHang(string maDonDatHang)
        {
            string query = "EXEC SP_GET_CT_DONDATHANG @MADONDATHANG";
            string maXeMay;
            int soLuong;
            decimal donGia;
            try
            {
                List<CTDonDatHang> list = new List<CTDonDatHang>();
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maDonDatHang });
                foreach (DataRow dr in dt.Rows)
                {
                    maXeMay = (string)dr["MaXeMay"];
                    soLuong = (int)dr["SoLuong"];
                    donGia = (decimal)dr["DonGia"];
                    list.Add(new CTDonDatHang(maDonDatHang, maXeMay, soLuong, donGia));
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách chi tiết đơn đặt hàng. " + e.Message);
                return null;
            }
        }
        public CTDonDatHang GetCTDonDatHang(string maDonDatHang, string maXeMay)
        {
            string query = "EXEC SP_GET_1_CT_DONDATHANG @MADONDATHANG , @MAXEMAY";
            int soLuong;
            decimal donGia;
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query,
                    new object[] { maDonDatHang, maXeMay });
                soLuong = (int)dt.Rows[0]["SoLuong"];
                donGia = (decimal)dt.Rows[0]["DonGia"];
                return new CTDonDatHang(maDonDatHang, maXeMay, soLuong, donGia);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy chi tiết đơn đặt hàng. " + e.Message);
                return null;
            }
        }
        public bool ThemDonDatHang(DonDatHang donDatHang)
        {
            string query = "EXEC SP_THEM_DONDATHANG @MADONDATHANG , @MANHANVIEN , @MANHACUNGCAP";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                {
                    donDatHang.MaDonDatHang,
                    donDatHang.MaNhanVien,
                    donDatHang.NhaCungCap
                });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi tạo đơn đặt hàng. " + e.Message);
                return false;
            }
        }
        public bool XoaDonDatHang(string maDonDatHang)
        {
            string query = "EXEC SP_XOA_DONDATHANG @MADONDATHANG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maDonDatHang });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa đơn đặt hàng. " + e.Message);
                return false;
            }
        }
        public bool ThemCTDonDatHang(CTDonDatHang chiTiet)
        {
            string query = "EXEC SP_THEM_CT_DONDATHANG @MADONDATHANG , @MAXEMAY , @SOLUONG , @DONGIA";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                {
                    chiTiet.MaDonDatHang,
                    chiTiet.MaXeMay,
                    chiTiet.SoLuong,
                    chiTiet.DonGia
                });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm chi tiết đơn đặt hàng. " + e.Message);
                return false;
            }
        }
        public bool SuaCTDonDatHang(CTDonDatHang chiTiet)
        {
            string query = "EXEC SP_SUA_CT_DONDATHANG @MADONDATHANG , @MAXEMAY , @SOLUONG , @DONGIA";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                {
                    chiTiet.MaDonDatHang,
                    chiTiet.MaXeMay,
                    chiTiet.SoLuong,
                    chiTiet.DonGia
                });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi sửa chi tiết đơn đặt hàng. " + e.Message);
                return false;
            }
        }
        public bool XoaCTDonDatHang(CTDonDatHang chiTiet)
        {
            string query = "EXEC SP_XOA_CT_DONDATHANG @MADONDATHANG , @MAXEMAY";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                {
                    chiTiet.MaDonDatHang,
                    chiTiet.MaXeMay
                });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa chi tiết đơn đặt hàng. " + e.Message);
                return false;
            }
        }
    }
}
