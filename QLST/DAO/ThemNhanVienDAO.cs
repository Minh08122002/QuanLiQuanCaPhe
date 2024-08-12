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
    public class ThemNhanVienDAO
    {
        private static ThemNhanVienDAO instance;

        public static ThemNhanVienDAO Instance { 
            get
            {
                if (instance == null)
                    instance = new ThemNhanVienDAO();
                return instance;
            }
        }
        public DataTable getmaNhanVienMoi(string type)
        {
            DataTable data = new DataTable();
            string query = string.Format("select count(manv)+1 from nhanvien where manv like'{0}%'", type);
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool insertNhanVien(object[] array)
        {
            string query = "EXEC insertNhanVien @MANV , @TENTK , @TENNV , @CMND_CCCD , @NGAYSINH , @GIOITINH , @SDT , @DIACHI , @CHUCVU , @HINHANH , @NGAYVAOLAM , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
                return true;
            return false ;
        }
        public DataTable TaiKhoanChuaSuDung()
        {
            string query = "SELECT TEN_TAIKHOAN FROM TaiKhoan EXCEPT SELECT TEN_TAIKHOAN FROM TaiKhoan WHERE TEN_TAIKHOAN IN(SELECT TENTK FROM NhanVien WHERE TENTK IS NOT NULL)";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
