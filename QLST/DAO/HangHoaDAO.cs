using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Text.RegularExpressions;

namespace DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO instance;

        public static HangHoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangHoaDAO();
                return instance;
            }
        }
        public HangHoaDAO()
        {

        }

        public int PageNumber()
        {
            DataTable data = new DataTable();
            string query = "select * from SANPHAM where TRANGTHAISP = 1";

            data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count % 10 == 0)
            {
                return data.Rows.Count / 10;
            }
            return data.Rows.Count / 10 + 1;
        }
        public List<HangHoa> searchIDHangHoa(string masp)
        {
            List<HangHoa> dtHangHoa = new List<HangHoa>();
            string query = "Select* from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and MANCC = MA_NCC and TRANGTHAISP = 1 and MASP like '%" + masp + "%'";

            dtHangHoa = Xem(query);

            return dtHangHoa;
        }
        public DataTable searchIDHangHoaTable(string masp)
        {
            DataTable dtHangHoa = new DataTable();
            string query = "Select* from SanPham where MASP = '" + masp + "'";

            dtHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtHangHoa;
        }
        public DataTable loadSP()
        {
            DataTable dtHangHoa = new DataTable();
            string query = "select * from SanPham where TRANGTHAISP = 1";

            dtHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtHangHoa;
        }
        public List<HangHoa> loadSPExcel()
        {
            List<HangHoa> dtHangHoa = new List<HangHoa>();
            string query = "Select* from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and MANCC = MA_NCC and TrangThaiSP=1";

            dtHangHoa = Xem(query);

            return dtHangHoa;
        }

        public List<HangHoa> searchTenHangHoa(string tensp)
        {
            List<HangHoa> dtHangHoa = new List<HangHoa>();
            string query = "Select* from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and MANCC = MA_NCC and TRANGTHAISP = 1 and TENSP like N'%" + tensp + "%'";

            dtHangHoa = Xem(query);

            return dtHangHoa;
        }
        public DataTable returnLSP(string tenlsp)
        {
            DataTable dtLoaiHangHoa = new DataTable();
            string query = "select * from LOAISANPHAM where TEN_LOAI_SP = N'" + tenlsp + "'";

            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtLoaiHangHoa;
        }
    
        public int CreateLSP(string tenlsp , string malsp)
        {

            DataTable dtLoaiHangHoa = new DataTable();

            string query = " insert into  LOAISANPHAM Values( '" + malsp + "' , '" + tenlsp + "' , 1)";

            int count = DataProvider.Instance.ExecuteNonQuery(query);

            return count; 
        }
        public int CreateNCC(string tenncc, string mancc,string diachi)
        {

            DataTable dtLoaiHangHoa = new DataTable();

            string query = " insert into  NhaCungCap Values( '" + mancc + "' ,N'" + tenncc + "' ,N'" + diachi + "' , 1 )";

            int count = DataProvider.Instance.ExecuteNonQuery(query);

            return count;
        }
        public bool CreateSanPham(object[] array)
        {
            DataTable dtLoaiHangHoa = new DataTable();
            
            string query = " exec themSanPham  @masp , @malsp , @tensp , @mancc , @donvitinh , @dongia , @giagoc , @soluong , @soluongton , @giamgia , @ngaysx , @hansd , @hinhanh , @trangthai ";
            
            int count = DataProvider.Instance.ExecuteNonQuery(query,array);
            if (count > 0) return true;
            return false;
           
        }
        public bool SuaSanPham(object[] array)
        {
            DataTable dtLoaiHangHoa = new DataTable();
            string query = " exec suaSanPham @masp ,  @malsp , @tensp , @mancc , @donvitinh , @dongia , @giagoc , @soluong , @soluongton , @giamgia , @ngaysx , @hansd , @hinhanh , @trangthai ";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0) return true;
            return false;
        }
        public bool SuaLoaiSanPham(object[] array)
        {
            DataTable dtLoaiHangHoa = new DataTable();
            string query = " exec suaLoaiSanPham @malsp , @tenlsp , @trangthai  ";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0) return true;
            return false;
        }
        public DataTable checkMSP(string masp)
        {

            DataTable dtLoaiHangHoa = new DataTable();
            string query = " select * from SANPHAM where MASP = '" + masp + "'";
            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtLoaiHangHoa;
        }
        public DataTable CheckMALSP(string malsp)
        {
            DataTable dtLoaiHangHoa = new DataTable();

 
            string query = " select * from LOAISANPHAM where MA_LOAI_SP = '" + malsp + "'";

            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);
            
            return dtLoaiHangHoa;

        }
        public DataTable CheckMANCC(string mancc)
        {
            DataTable dtLoaiHangHoa = new DataTable();


            string query = " select * from NhaCungCap where MA_NCC = '" + mancc + "'";

            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtLoaiHangHoa;

        }
        public DataTable LoadLSP()
        {
            DataTable dtLoaiHangHoa = new DataTable();

            string query = " select * from LOAISANPHAM where TRANGTHAILSP = 1";

            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);

            return dtLoaiHangHoa;
        }
        public DataTable loadNCC()
        {
            DataTable dtncc = new DataTable();
            string query = "select * from NhaCungCap where TRANGTHAINCC = 1";

            dtncc = DataProvider.Instance.ExecuteQuery(query);

            return dtncc;
        }
        public DataTable MALSP_TENLSP()
        {
            DataTable dtLoaiHangHoa = new DataTable();
            string query = "select TEN_LOAI_SP,MA_LOAI_SP, TRANGTHAILSP,MA_LOAI_SP + '-' + TEN_LOAI_SP AS MA_TENLSP from LOAISANPHAM where TRANGTHAILSP = 1";
            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);
            return dtLoaiHangHoa;
        }
        public DataTable MANCC_TENNCC()
        {
            DataTable dtLoaiHangHoa = new DataTable();
            string query = "SELECT MA_NCC, TENNCC, MA_NCC + '-' + TENNCC AS MA_TENNCC FROM NhaCungCap WHERE TRANGTHAINCC = 1 ";
            dtLoaiHangHoa = DataProvider.Instance.ExecuteQuery(query);
            return dtLoaiHangHoa;
        }
       
        public string searchMALSP(string tenlsp)
        {
            DataTable LSP = new DataTable();
            string MALSP = null;

            LSP = returnLSP(tenlsp);

            MALSP = LSP.Rows[0].ItemArray[0].ToString();

            return MALSP;
        }
        public List<HangHoa> searchTenLSP(string tenLSP)
        {
            List<HangHoa> dtHangHoa = new List<HangHoa>();

            string MALSP = searchMALSP(tenLSP);

            string query = "Select * from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and  MANCC = MA_NCC and TRANGTHAISP = 1 and MALSP ='" + MALSP + "'";

            dtHangHoa = Xem(query);

            return dtHangHoa;
        }
        public bool deleteHangHoa(string MASP)
        {
            string query = "update SanPham set TRANGTHAISP = 0 where MASP ='" + MASP + "'";
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            if(count >  0 ) return true;
            return false;
        }
        public bool XoaLSP(string MALSP)
        {
            string query = "update LOAISANPHAM set TRANGTHAILSP = 0 where MA_LOAI_SP ='" + MALSP + "'";
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            return false;
        }
        public bool XoaNCC(string MANCC)
        {
            string query = "update NhaCungCap set TRANGTHAINCC = 0 where MA_NCC ='" + MANCC + "'";
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            return false;
        }

        public List<HangHoa> SanPhamTon(string str1 , string str2)
        {
            List<HangHoa> dtHangHoa = new List<HangHoa>();
            string query = "Select* from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and MANCC = MA_NCC AND  SOLUONGTON " + str1 + "  " + str2 + "  and TRANGTHAISP = 1 "  ;
            dtHangHoa = Xem(query);
            return dtHangHoa;
        }

 
        public List<HangHoa> loadData(int page)
        {
            List<HangHoa> nv = new List<HangHoa>();
            int count = 0;
            //**
            string query = "Select * from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and  MANCC = MA_NCC and TRANGTHAISP = 1";
            List<HangHoa> ds = new List<HangHoa>();
            ds = this.Xem(query);


            if (page == 1)
            {
                for (int i = 0; i < ds.Count; i++)
                {
                    if (count < 10)
                    {
                        nv.Add(ds[i]);
                        count++;
                    }
                }
            }
            else
            {
                for (int i = (page - 1) * 10; i < ds.Count; i++)
                {
                    if (count < 10)
                    {
                        nv.Add(ds[i]);
                        count++;
                    }
                }
            }

            return nv;

        }

        public List<HangHoa> Xem(string query)
        {
            List<HangHoa> list = new List<HangHoa>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string maSP = item["MASP"].ToString();
                string malsp = item["MA_LOAI_SP"].ToString();
                string tenlsp = item["TEN_LOAI_SP"].ToString();//
                bool trangthaiLSP = (bool)item["TRANGTHAILSP"];//
                LoaiSanPham lsp = new LoaiSanPham(malsp, tenlsp, trangthaiLSP);

                string tenSP = item["TENSP"].ToString();
                string mancc = item["MANCC"].ToString();//
                string tenncc = item["TENNCC"].ToString();//
                string diachi = item["DIACHI"].ToString();//
                bool trangthaincc = (bool)item["TRANGTHAINCC"];//
                NhaCungCap ncc = new NhaCungCap(mancc, tenncc, diachi, trangthaincc);
                string[] array = item["DONGIA"].ToString().Split('.');
                int donGia = int.Parse(array[0]);
                array = item["GIAGOC"].ToString().Split('.');//
                int giaGoc = int.Parse(array[0]);
                string dvTinh = item["DONVITINH"].ToString();
                int soLuong = int.Parse(item["SOLUONG"].ToString());//
                int soLuongTon = int.Parse(item["SOLUONGTON"].ToString());
                float giamGia = float.Parse(item["GIAMGIA"].ToString());//

                DateTime? ngSanxuat = item["NGAYSX"].ToString() == string.Empty ? null : (DateTime?)item["NGAYSX"];//
                
                DateTime? hanSD = item["HANSD"].ToString() == string.Empty ? null : (DateTime?)item["HANSD"];//

                byte[] hinhAnh = Encoding.ASCII.GetBytes(item["HINHANH"].ToString());//
                bool trangThai = bool.Parse(item["TRANGTHAISP"].ToString());//
                HangHoa hh = new HangHoa(maSP, lsp, tenSP, ncc, dvTinh, donGia, giaGoc, soLuong, soLuongTon, giamGia, ngSanxuat, hanSD, hinhAnh, trangThai);
                list.Add(hh);
            }
            return list;
        }
        public int updateNCC(string mancc, string tenncc, string diachi, int status)
        {
            string query = string.Format("Update NhaCungCap set TenNCC=N'{0}', DiaChi=N'{1}', TrangThaiNCC={2} where MA_NCC='{3}'", tenncc, diachi, status, mancc);
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            return count;
        }
        public DataTable searchNCC(string query)
        {
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable loadNCC(int status)
        {
            DataTable dtncc = new DataTable();
            string query = "select * from NhaCungCap where TRANGTHAINCC = " + status;
            dtncc = DataProvider.Instance.ExecuteQuery(query);


            return dtncc;
        }
    }
}
