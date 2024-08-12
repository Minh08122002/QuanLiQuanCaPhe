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
    public class ThongTinKhachHangBUS
    {
        private static ThongTinKhachHangBUS instance;

        public static ThongTinKhachHangBUS Instance { 
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinKhachHangBUS();
                }
                return instance;
            }
        }
        private ThongTinKhachHangBUS()
        {

        }
        public DataTable ThongTinKhachHang(string makh)
        {
            DataTable dt = new DataTable();
            dt = ThongTinKhachHangDAO.Instance.searchKhachHang(makh);
           
            return dt;
        }
        public bool updateThongTinKhachHang(object[] b)
        {
            //Xử lí thêm Khách hàng
            
            return ThongTinKhachHangDAO.Instance.updateThongTinKhachHang(b);

        }
        public bool changeStatusKhachHang(object[] array)
        {
            return ThongTinKhachHangDAO.Instance.changeStatusKhachHang(array);
        }
    }
}
