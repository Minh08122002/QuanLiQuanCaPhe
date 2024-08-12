using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        private static LoaiSanPhamBUS instance;

        public static LoaiSanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiSanPhamBUS();
                }
                return instance;
            }
        }
        public bool insertLSP(string malsp,string tenlsp)
        {
            string query = string.Format("insert LoaiSanPham values('{0}',N'{1}',{2})", malsp, tenlsp, 1);
            int count = LoaiSanPhamDAO.Instance.insertLSP(query);
            if (count > 0) return true;
            return false;
        }
        public void TimKiemLoaiSP(DataGridView dtgv, string str)
        {
            string query = string.Format("select * from LoaiSanPham where( MA_LOAI_SP Like '%{0}%' OR TEN_LOAI_SP Like N'%{0}%') and TrangThaiLSP=1", str);

            dtgv.DataSource = LoaiSanPhamDAO.Instance.TimKiemLoaiSanPham(query);
        }
        private LoaiSanPhamBUS()
        {
            
        }
        public void thongtinLSP(DataGridView dtgv, string malsp)
        {
           //dtgv.DataSource = 
        }
    }
}
