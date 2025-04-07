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
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        public List<NhanVien> GetListNhanVien()
        {
            string query = "SELECT * FROM V_GET_NHANVIEN";
            List<NhanVien> list = new List<NhanVien>();
            NhanVien nhanVien;
            int maNhanVien;
            string ho;
            string ten;
            string gioiTinh;
            DateTime ngaySinh;
            string diaChi;
            string sdt;
            string email;
            string taiKhoan;
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                foreach(DataRow dr in dt.Rows)
                {
                    maNhanVien = (int)dr["MaNhanVien"];
                    ho = (string)dr["Ho"];
                    ten = (string)dr["Ten"];
                    gioiTinh = (string)dr["GioiTinh"];
                    ngaySinh = (DateTime)dr["NgaySinh"];
                    diaChi = (string)dr["DiaChi"];
                    sdt = (string)dr["SDT"];
                    email = (string)dr["Email"];
                    taiKhoan = (string)dr["TaiKhoan"];
                    nhanVien = new NhanVien(maNhanVien, ho, ten, gioiTinh, ngaySinh, diaChi, sdt, email, taiKhoan);
                    list.Add(nhanVien);
                }
                return list;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách nhân viên. " + e.Message);
                return null;
            }
        }
        public int ThemNhanVien(NhanVien nhanVien)
        {
            int maNhanVien = -1; // biểu thị fail nếu ko thêm được
            string query = "EXEC SP_THEM_NHANVIEN @HO , @TEN , @GIOITINH , @NGAYSINH , @DIACHI , @SDT , @EMAIL , @TAIKHOAN";
            try{
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] {
                    nhanVien.Ho,
                    nhanVien.Ten,
                    nhanVien.GioiTinh,
                    nhanVien.NgaySinh,
                    nhanVien.DiaChi,
                    nhanVien.Sdt,
                    nhanVien.Email,
                    nhanVien.TaiKhoan
                });
                //Rows[0]: truy cập dòng đầu tiên của DataTable => lấy gtri cột MaNhanVien (ép kiểu thành int)
                maNhanVien = (int)dt.Rows[0]["MaNhanVien"];
                return maNhanVien; // trả về maNhanVien được tạo
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm nhân viên. " + e.Message);
                return maNhanVien; // trả về -1 (default)
            }
        }
    }
}
