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
    public class ThemKhachHangBUS
    {
        private static ThemKhachHangBUS instance;

        public static ThemKhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThemKhachHangBUS();
                return instance;
            }
        }
        public string getMaKhachHangMoi(string type)
        {
            DataTable data = new DataTable();
            data = ThemKhachHangDAO.Instance.getmaKhachHangMoi(type);
            string manv = data.Rows[0].ItemArray[0].ToString();
            return manv;
        }
        public bool insertKhachHang(object[] array)
        {
            return ThemKhachHangDAO.Instance.insertKhachHang(array);

        }
    }
}
