using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance { get {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance; } }
        private NhanVienDAO()
        {

        }
        public DataTable loadRecord(int page,int status)
        {
            List<NhanVien> nv = new List<NhanVien>();
            int count = 0;
            List<NhanVien> ds = new List<NhanVien>();
            string query = "select * from NhanVien where TrangThaiNV="+status.ToString();
            ds = this.Xem(query);
            if (ds.Count == 0)
                return null ;
            if (page == 1)
            {
               for(int i = 0; i < ds.Count; i++)
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
                for(int i = (page - 1) * 10; i < ds.Count; i++)
                {
                    if (count < 10)
                    {
                        nv.Add(ds[i]);
                        count++;
                    }
                }
            }
            ListtoDataTableConverter convert = new ListtoDataTableConverter();
            DataTable dt = convert.ToDataTable(nv);
            return dt;
        }
        
        public DataTable Search(String strSearch, String strOption,int status)
        {
            DataTable data = new DataTable();

            string query = "select * from nhanvien where " + strOption + " Like N'%" + strSearch + "%' and TrangThaiNV="+status.ToString();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable Search(string query)
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public int PageNumber(int status)
        {
            DataTable data = new DataTable();
            string query = "select * from nhanvien where TrangThaiNV="+status.ToString();
           
            data = DataProvider.Instance.ExecuteQuery(query);
            
            if (data.Rows.Count % 10 == 0)
            {
                return data.Rows.Count / 10;
            }
            return data.Rows.Count/10+1;
        }
        public List<NhanVien> Xem(string query)
        {
         
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<NhanVien> nv = new List<NhanVien>();
            foreach (DataRow item in data.Rows)
            {
                string manv=item["MANV"].ToString();
                string tentk=item["TENTK"].ToString();
                string tennv=item["TENNV"].ToString();
                string cmnd_cccd = item["CMND_CCCD"].ToString();
                DateTime? ngaysinh = item["NGAYSINH"].ToString() == string.Empty ? null : (DateTime?)item["NGAYSINH"];
                string gioitinh = item["GIOITINH"].ToString();
                string sdt=item["SDT"].ToString();
                string diachi = item["DIACHI"].ToString();
                string chucvu=item["CHUCVU"].ToString();
                DateTime? ngayvaolam = item["NGAYVAOLAM"].ToString() == string.Empty ? null : (DateTime?)item["NGAYVAOLAM"];
                bool trangthai=(bool)item["TRANGTHAINV"];
                byte[] hinhanh = Encoding.ASCII.GetBytes(item["HINHANH"].ToString());
                NhanVien newnv = new NhanVien(manv,tentk,tennv,cmnd_cccd,ngaysinh,gioitinh,sdt,diachi,chucvu, hinhanh, ngayvaolam,trangthai);
                nv.Add(newnv);
            
            }
            
            return nv;
        }
        public DataTable bindingNamSinh(int status)
        {
            DataTable dt = new DataTable();
            string query = "select Year(NGAYSINH) AS NAMSINH from NhanVien WHERE TRANGTHAINV="+status.ToString()+" GROUP BY YEAR(NGAYSINH) ORDER BY YEAR(NGAYSINH)";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable fillOfYear(string namsinh,int status)
        {
            DataTable data = new DataTable();
            string query = String.Format("select * from nhanvien where year(NGAYSINH)='{0}' AND TRANGTHAINV={1}", namsinh,status);
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable fillOfChucvu(string chucvu,int status)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from nhanvien where CHUCVU=N'{0}' AND TRANGTHAINV={1}", chucvu,status);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
