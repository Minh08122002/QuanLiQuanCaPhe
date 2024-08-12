using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThemNhanVienBUS
    {
        private static ThemNhanVienBUS instance;

        public static ThemNhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThemNhanVienBUS();
                return instance;
            }
        }
        public string getMaNhanVienMoi(string type)
        {
            DataTable data = new DataTable();
            data = ThemNhanVienDAO.Instance.getmaNhanVienMoi(type);
            string manv = data.Rows[0].ItemArray[0].ToString();
            return manv;
        }
        public bool insertNhanVien(object[] array)
        {
            return ThemNhanVienDAO.Instance.insertNhanVien(array);

        }
        public bool checkTaiKhoan(string tentk)
        {
            DataTable data = new DataTable();
            data = ThemNhanVienDAO.Instance.TaiKhoanChuaSuDung();
            foreach(DataRow r in data.Rows)
            {
                if (tentk == r.ItemArray[0].ToString())
                    return true;
            }
            return false;
        }
    }
}
