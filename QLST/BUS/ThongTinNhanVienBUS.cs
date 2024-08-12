using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Drawing;

namespace BUS
{
    public class ThongTinNhanVienBUS
    {
        private static ThongTinNhanVienBUS instance;

        public static ThongTinNhanVienBUS Instance { 
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinNhanVienBUS();
                }
                return instance;
            }
        }
        private ThongTinNhanVienBUS()
        {

        }
        public DataTable ThongTinNhanVien(string manv)
        {
            NhanVien nv = new NhanVien();
            DataTable dt = new DataTable();
            dt = ThongTinNhanVienDAO.Instance.searchNhanVien(manv);
           
            return dt;
        }
        public bool updateThongTinNhanVien(object[] b)
        {
            
            return ThongTinNhanVienDAO.Instance.updateThongTinNhanVien(b);

        }
        public bool changeStatusNhanVien(object[] array)
        {
            return ThongTinNhanVienDAO.Instance.changeStatusNhanVien(array);
        }
    }
}
