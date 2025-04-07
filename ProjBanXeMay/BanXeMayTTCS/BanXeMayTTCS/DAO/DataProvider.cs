using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.DAO
{
    public class DataProvider
    {
        static string strConn = ConfigurationManager.ConnectionStrings["BanXeMayTTCS.Properties.Settings.BanXeMayConnectionString"].ConnectionString;

        private static DataProvider instance;

        public  string connectionStrHTDN = strConn; //"Data Source=.;Initial Catalog=BanXeMay;Integrated Security=True;";
        public  string connectionStrHTRS = strConn; // "Data Source=.;Initial Catalog=BanXeMay;Integrated Security=True;";
        public  string connectionStrNhanVien = strConn; // "Data Source=.;Initial Catalog=BanXeMay;Integrated Security=True;";
        public  string connectionStrKhachHang = strConn; // "Data Source=.;Initial Catalog=BanXeMay;Integrated Security=True;";
        public static string connectionStr = "";

        private SqlConnection connection;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set => instance = value;
        }
        // Thay đổi chuổi kết nối
        public void SetConnectionStr(string dataSource, string userId, string pwd)
        {
            connectionStr = "Data Source=" + dataSource + ";Initial Catalog=BanXeMay;User ID=" + userId + ";Pwd=" + pwd + ";";
            connection = new SqlConnection(connectionStr);
        }
        // Thay đổi chuổi kết nối thành mặc định (hỗ trợ đăng nhập)
        public void SetConnectionStrDefault()
        {
            connectionStr = connectionStrHTDN;
            connection = new SqlConnection(connectionStr);
        }
        //SetConnectionStrRestore chuyển đổi chuỗi kết nối của đối tượng connection
        //sang chuỗi kết nối dành cho việc khôi phục dữ liệu (connectionStrHTRS)
        public void SetConnectionStrRestore()
        {
            connection.Close();
            connectionStr = connectionStrHTRS;
            connection = new SqlConnection(connectionStr);
        }
        public void SetConnectionStrNhanVien()
        {
            connection.Close();
            connectionStr = connectionStrNhanVien;
            connection = new SqlConnection(connectionStr);
        }
        public void SetConnectionStrKhachHang()
        {
            connection.Close();
            connectionStr = connectionStrKhachHang;
            connection = new SqlConnection(connectionStr);
        }
        // Thực thi query trả về datatable & thực thi câu truy vấn SQL
        public DataTable ExecuteQuerry(string query, object[] parameter = null)
        {//Biến data sẽ được dùng để lưu trữ kết quả của câu truy vấn SQL.
            DataTable data = new DataTable();
            // Format lại query: thay các từ có chứa @ bằng tham số
            //Tạo một đối tượng SqlCommand để thực thi câu truy vấn SQL trên kết nối đã được thiết lập.
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string str in listPara)
                {
                    if (str.Contains('@'))
                    {
                        command.Parameters.AddWithValue(str, parameter[i]);
                        i++;
                    }
                }
            }
            // Thực hiện lấy dữ liệu từ db
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return data;
        }
        // Thực thi query
        public int ExecuteNonQuerry(string query, object[] parameter = null)
        {
            int data = 0;
            // Format lại query: thay các từ có chứa @ bằng tham số
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string str in listPara)
                {
                    if (str.Contains('@'))
                    {
                        command.Parameters.AddWithValue(str, parameter[i]);
                        i++;
                    }
                }
            }
            // Thực hiện lấy dữ liệu từ db
            try
            {
                connection.Open();
                data = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return data;
        }
        // Thực thi query trả về datareader
        public SqlDataReader ExecuteSqlDataReader(String query, object[] parameter = null)
        {
            SqlDataReader myReader = null;
            // Format lại query: thay các từ có chứa @ bằng tham số
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string str in listPara)
                {
                    if (str.Contains('@'))
                    {
                        command.Parameters.AddWithValue(str, parameter[i]);
                        i++;
                    }
                }
            }
            // Thực hiện lấy dữ liệu từ db
            try
            {
                myReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
            return myReader;
        }
    }
}
