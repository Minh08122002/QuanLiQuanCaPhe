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
    public class ThongTinNhanVienDAO
    {
        private static ThongTinNhanVienDAO instance;

        public static ThongTinNhanVienDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinNhanVienDAO();
                }
                return instance;
            }
                }
        private ThongTinNhanVienDAO()
        {

        }
        public DataTable searchNhanVien(string manv)
        {
            DataTable dt = new DataTable();
            string query = "select * from nhanvien where MANV='" + manv + "'";
            dt = DataProvider.Instance.ExecuteQuery(query);

           
            return dt;
        }
        public bool updateThongTinNhanVien(object[] b)
        {
            
           
            string query = "EXEC UpdateNhanVien @MANV , @TENTK , @TENNV , @CMND_CCCD ,  @NGAYSINH , @GIOITINH , @SDT , @DIACHI , @CHUCVU , @HINHANH , @NGAYVAOLAM , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query,b);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public bool changeStatusNhanVien(object[] array)
        {

            string query = string.Format("EXEC updateStatusNhanVien @MANV , @TRANGTHAI");
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;

        }



    }
}
