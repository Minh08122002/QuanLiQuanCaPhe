using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Text.RegularExpressions;
using System.Data;



namespace DAO
{
   
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;

        public static LoaiSanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiSanPhamDAO();
                }
                return instance;
            }
        }
        public int insertLSP(string query)
        {
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            return count;
        }
        public LoaiSanPhamDAO()
        {

        }
        public DataTable TimKiemLoaiSanPham(string query)
        {
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable searchLSP(string malsp)
        {
            DataTable dtHangHoa = new DataTable();
            string query = "select * from SanPham where MASP = '" + malsp + "'";

            dtHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtHangHoa;
        }
    }
}
