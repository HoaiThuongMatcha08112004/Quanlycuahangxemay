using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BanXeMayTTCS.DTO;
using System.Windows.Forms;

namespace BanXeMayTTCS.DAO
{
    public class CTDonDatHangDAO
    {
        private static CTDonDatHangDAO instance;
        public static CTDonDatHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTDonDatHangDAO();
                return instance;
            }
        }
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
    }
}
