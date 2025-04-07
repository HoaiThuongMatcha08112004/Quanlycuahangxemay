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
    public class DangNhapDAO
    {
        public const string NHOM_NHANVIEN = "nhanvien";
        public const string NHOM_KHACHHANG = "khachhang";   
        public const string NHOM_QUANTRI = "quantri";

        private static DangNhapDAO instance; //đảm bảo rằng chỉ có một instance của DangNhapDAO được tạo ra trong ứng dụng.
        private int id;
        private string nhom;
        private string hoTen;
        private string taiKhoan;
        private string sdt;
        private string diaChi;
        public static DangNhapDAO Instance
        {
            get //là phần getter của property Instance, định nghĩa cách lấy giá trị của property.
                //Khi bạn gọi DangNhapDAO.Instance
                //khối lệnh trong get sẽ được thực thi để trả về instance của DangNhapDAO.
            {
                if (instance == null) //bước kiểm tra đảm bảo instance chỉ được tạo 1 lần duy nhất 
                    instance = new DangNhapDAO(); //một instance mới của DangNhapDAO sẽ được tạo và lưu vào biến instance
                return instance;
            }
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            string query = "EXEC SP_DANGNHAP @TAIKHOAN , @MATKHAU";
            try
            {//Gọi property Instance của class DataProvider
             //là một class dùng để quản lý kết nối và truy vấn cơ sở dữ liệu.
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { taiKhoan, matKhau });
                if(dt != null)
                {
                    this.id = (int)dt.Rows[0]["ID"];
                    this.nhom = (string)dt.Rows[0]["Nhom"];
                    this.hoTen = (string)dt.Rows[0]["HoTen"];
                    this.taiKhoan = (string)dt.Rows[0]["TaiKhoan"];
                    this.sdt = (string)dt.Rows[0]["SDT"];
                    this.diaChi = (string)dt.Rows[0]["DiaChi"];
                    if (nhom.Equals(NHOM_NHANVIEN) || nhom.Equals(NHOM_QUANTRI))
                    {//thiết lập chuỗi kết nối phù hợp để các truy vấn sau này sử dụng đúng cơ sở dữ liệu
                        DataProvider.Instance.SetConnectionStrNhanVien();
                    }
                    else if (nhom.Equals(NHOM_KHACHHANG))
                    {//tương tự như trên
                        DataProvider.Instance.SetConnectionStrKhachHang();
                    }
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool DangKyKhachHang(KhachHang khachHang, string matKhau)
        {
            string query = "EXEC SP_DANGKY_KHACHHANG @TAIKHOAN , @MATKHAU , @CMND , @HO , @TEN , @GIOITINH , @NGAYSINH , @DIACHI , @SDT , @EMAIL , @MASOTHUE";
            try
            {
                if(khachHang.Email != null && khachHang.MaSoThue != null)
                {//ExcuteNonQuery: thực thi các câu lệnh SQL
                 //new object: một mảng đối tượng chứa các giá trị truyền vào các tham số của SP theo tt
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                    {
                        khachHang.TaiKhoan,
                        matKhau,
                        khachHang.Cmnd,
                        khachHang.Ho,
                        khachHang.Ten,
                        khachHang.GioiTinh,
                        khachHang.NgaySinh,
                        khachHang.DiaChi,
                        khachHang.Sdt,
                        khachHang.Email,
                        khachHang.MaSoThue
                    });
                }
                else if(khachHang.Email == null && khachHang.MaSoThue == null)
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                    {
                        khachHang.TaiKhoan,
                        matKhau,
                        khachHang.Cmnd,
                        khachHang.Ho,
                        khachHang.Ten,
                        khachHang.GioiTinh,
                        khachHang.NgaySinh,
                        khachHang.DiaChi,
                        khachHang.Sdt,
                        //truyền DBNull.Value cho hai tham số @EMAIL và @MASOTHUE
                        //Đại diện cho giá trị NULL trong cơ sở dữ liệu SQL Server nếu ko đc cung cấp
                        DBNull.Value,
                        DBNull.Value
                    });
                }
                else if(khachHang.Email != null)
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                    {
                        khachHang.TaiKhoan,
                        matKhau,
                        khachHang.Cmnd,
                        khachHang.Ho,
                        khachHang.Ten,
                        khachHang.GioiTinh,
                        khachHang.NgaySinh,
                        khachHang.DiaChi,
                        khachHang.Sdt,
                        khachHang.Email,
                        DBNull.Value
                    });
                }
                else
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                    {
                        khachHang.TaiKhoan,
                        matKhau,
                        khachHang.Cmnd,
                        khachHang.Ho,
                        khachHang.Ten,
                        khachHang.GioiTinh,
                        khachHang.NgaySinh,
                        khachHang.DiaChi,
                        khachHang.Sdt,
                        DBNull.Value,
                        khachHang.MaSoThue
                    });
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi đăng ký khách hàng. " + e.Message);
                return false;
            }
        }
        public bool DoiMatKhau(string matKhauCu, string matKhauMoi)
        {
            string query = "EXEC SP_DOI_MATKHAU @TAIKHOAN , @MATKHAUCU , @MATKHAUMOI";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { taiKhoan, matKhauCu, matKhauMoi });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi đăng nhập " + e.Message);
                return false;
            }
        }
        //tạo 1 Property cung cấp cách công khai để đọc và ghi giá trị của biến id
        public int Id { get => id; set => id = value; } //Getter, trả về giá trị của biến id, Setter, gán giá trị value (giá trị được truyền vào) cho biến id
        public string Nhom { get => nhom; set => nhom = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
