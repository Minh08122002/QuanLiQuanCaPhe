using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
        }
        public int takeMaHDNext()
        {
            string query = "select COUNT(Mahd)+1 from HoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return (int)data.Rows[0].ItemArray[0];
        }
        public string[] searchMaKHAndTenKh(string sdt)
        {
            string query = string.Format("select MaKH,TenKh from KhachHang where SDT='{0}' and TrangThaiKH=1", sdt);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string[] str = { "", ""};
            if (data.Rows.Count == 0)
            {
                
                return str;
            }
            str[0] = data.Rows[0].ItemArray[0].ToString();
             
            str[1] =data.Rows[0].ItemArray[1].ToString();
            return str;
        }
        public bool updateStatusHD(object[] array) 
        {
            string query = "EXEC updateStatusHD @MAHD , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        
        public bool AddHoaDon(object[] array,int iTypeNotNull)
        {
            string query = "";
            if (iTypeNotNull == 5)
            {
                query = "EXEC insertHoaDon @MAHD , @MANV , @MAKH , @NGAYLAP , @TRANGTHAI ";
            }
            else
            {
                query = "EXEC insertHoaDonWhenKHNULL @MAHD , @MANV , @NGAYLAP , @TRANGTHAI ";
            }
           
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public int updateHD(string query)
        {
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            return count;
        }
        public List<HoaDon> XemHD(string query)
        {
            List<HoaDon> list = new List<HoaDon>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                int mahd = int.Parse(item["MAHD"].ToString());
                DateTime ngaylap = DateTime.Parse(item["NGLAP"].ToString());
                bool trangthaihd = (bool)item["TRANGTHAIHD"];
                string manv = item["MA_NHANVIEN"].ToString();
                List<NhanVien> listnv = new List<NhanVien>();
                listnv = NhanVienDAO.Instance.Xem(string.Format("select * from NhanVien where MANV='{0}'", manv));
                NhanVien nv = null;
                if (listnv.Count == 1)
                {
                    nv = listnv[0];
                    
                }
               
                string makh = item["MA_KHACHHANG"].ToString();
                List<KhachHang> listkh = new List<KhachHang>();
                listkh = KhachHangDAO.Instance.Xem(string.Format("select * from KhachHang where MAKH='{0}'", makh));
                KhachHang kh = null;
                if (listkh.Count == 1)
                {
                    kh = listkh[0];
                }
                HoaDon hd = new HoaDon(mahd, nv, kh, ngaylap, trangthaihd);
                list.Add(hd);
            }
            return list;
        }
        public DataTable year()
        {
            string query = "select distinct year(NGLAP) from HoaDon ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public List<HangHoa> Xem(string query)
        {
            List<HangHoa> list = new List<HangHoa>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                string maSP = item["MASP"].ToString();
                string malsp=item["MA_LOAI_SP"].ToString();
                string tenlsp = item["TEN_LOAI_SP"].ToString();
                bool trangthaiLSP =(bool) item["TRANGTHAILSP"];
                LoaiSanPham lsp = new LoaiSanPham(malsp, tenlsp, trangthaiLSP);
                
                string tenSP=item["TENSP"].ToString();
                string mancc = item["MA_NCC"].ToString();
                string tenncc = item["TENNCC"].ToString();
                string diachi = item["DIACHI"].ToString();
                bool trangthaincc =(bool) item["TRANGTHAINCC"];
                NhaCungCap ncc = new NhaCungCap(mancc, tenncc, diachi,trangthaincc);
                string[] array = item["DONGIA"].ToString().Split('.');
                int donGia=int.Parse(array[0]);
                array = item["GIAGOC"].ToString().Split('.');
                int giaGoc=int.Parse(array[0]);
                string dvTinh=item["DONVITINH"].ToString();
                int soLuong=int.Parse(item["SOLUONG"].ToString());
                int soLuongTon=int.Parse(item["SOLUONGTON"].ToString());
                float giamGia=float.Parse(item["GIAMGIA"].ToString());
                
                DateTime? ngSanxuat= item["NGAYSX"].ToString() == string.Empty ? null : (DateTime?)item["NGAYSX"];

                DateTime? hanSD= item["HANSD"].ToString() == string.Empty ? null : (DateTime?)item["HANSD"];
                byte[] hinhAnh = null;
                if (item["HINHANH"].ToString() != "")
                {
                    hinhAnh = (byte[])item["HINHANH"];
                }
                
                bool trangThai=bool.Parse(item["TRANGTHAISP"].ToString());
                HangHoa hh = new HangHoa(maSP, lsp, tenSP, ncc, dvTinh, donGia, giaGoc, soLuong, soLuongTon, giamGia, ngSanxuat, hanSD, hinhAnh, trangThai);
                list.Add(hh);
            }
            return list;
        }
    }
}
