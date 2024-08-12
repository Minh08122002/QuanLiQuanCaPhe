using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DTO;


namespace DAO
{
    public class ThongTinKhachHangDAO
    {
        private static ThongTinKhachHangDAO instance;

        public static ThongTinKhachHangDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinKhachHangDAO();
                }
                return instance;
            }
                }
        private ThongTinKhachHangDAO()
        {

        }
        public DataTable searchKhachHang(string makh)
        {
            DataTable dt = new DataTable();
            string query = "select * from KhachHang where MAKH='" + makh + "'";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public bool updateThongTinKhachHang(object[] b)
        {
            
           
            string query = "EXEC UpdateKhachHang @MAKH , @TENKH , @CMND_CCCD , @NGAYSINH , @GIOITINH , @SDT , @DIACHI , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query,b);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public bool changeStatusKhachHang(object[] array)
        {

            string query = string.Format("EXEC updateStatusKhachHang @MAKH , @TRANGTHAI");
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;

        }



    }
}
