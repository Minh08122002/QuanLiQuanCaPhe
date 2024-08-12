using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ThemKhachHangDAO
    {
        private static ThemKhachHangDAO instance;

        public static ThemKhachHangDAO Instance { 
            get
            {
                if (instance == null)
                    instance = new ThemKhachHangDAO();
                return instance;
            }
        }
        public DataTable getmaKhachHangMoi(string type)
        {
            DataTable data = new DataTable();
            string query = string.Format("select count(makh)+1 from KhachHang where makh like'{0}%'", type);
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool insertKhachHang(object[] array)
        {
            string query = "EXEC insertKhachHang @MAKH , @TENKH , @CMND_CCCD , @NGAYSINH , @GIOITINH , @SDT , @DIACHI , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
                return true;
            return false ;
        }
    }
}
