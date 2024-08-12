using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonDAO();
                return instance;
            }
        }
        public bool deleteCTHD(int mahd)
        {
            string query = "EXEC deleteCTHD @MAHD";
            object[] array = new object[] { mahd};
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if(count>=0)
                return true;
            return false;
        }
        public bool updateStatusCTHD(ChiTietHoaDon cthd,bool b)
        {
            string query = "EXEC updateStatusCTHD @MAHD INT , @MASP , @TRANGTHAI";
            object[] array = new object[] { cthd.maHD, cthd.Hh.MaSP, b };
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            return true;
        }
        public bool insertCTHD(ChiTietHoaDon cthd)
        {
            string query = "EXEC insertCTHD @MAHD , @MASP , @SOLUONG , @DONGIA , @GIAMGIA , @TRANGTHAI";
            object[] array = { cthd.Hd.Mahd, cthd.Hh.MaSP, cthd.Soluong,cthd.Dongia, cthd.Giamgia, true };
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public bool updateSLSPcuaCTHD(string masp, int soluong)
        {
            string query = "EXEC updateSoLuongSPTuCTHD @MASP , @SOLUONG ";
            object[] array = new object[] { masp, soluong };
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if(count > 0)
            {
                return true;
            }
            return false;
        }
        
        public List<ChiTietHoaDon> Xem(string query)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string queryhd = "select * from HoaDon";
            List<HoaDon> listhd = DAO.HoaDonDAO.Instance.XemHD(queryhd);
            string querysp = "select * from SanPham,LoaiSanPham,NhaCungCap where MALSP=MA_LOAI_SP AND MANCC=MA_NCC AND TrangThaiSP=1 AND TrangThaiLSP=1";
            List<HangHoa> listhh = DAO.HoaDonDAO.Instance.Xem(querysp);
            foreach(DataRow item in data.Rows)
            {
                HoaDon hd = null;
                
                foreach(HoaDon bill in listhd)
                {
                    if (int.Parse(item["MA_HD"].ToString()) == bill.Mahd)
                    {
                        hd = bill;
                        break;
                    }
                }
                HangHoa hh = null;
                foreach(HangHoa sp in listhh)
                {
                    if (item["MASP"].ToString() == sp.MaSP)
                    {
                        hh = sp;
                        break;
                    }
                }
                int soluong =int.Parse( item["SOLUONG"].ToString());
                string[] array = item["DONGIA"].ToString().Split('.');
                int dongia = int.Parse(array[0]);

                float giamgia=float.Parse(item["GIAMGIA"].ToString());
                bool trangthai=(bool)item["TRANGTHAICTHD"];
                ChiTietHoaDon cthd = new ChiTietHoaDon(hd, hh, soluong, dongia, giamgia, trangthai);
                list.Add(cthd);
            }
            return list;

        }
        public bool AddChiTietHoaDon(object[] array)
        {
            string query = "EXEC insertCTHD @MAHD , @MASP , @SOLUONG , @DONGIA , @GIAMGIA , @TRANGTHAI ";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
                return true;
            return false;
        }
        
    }
}
