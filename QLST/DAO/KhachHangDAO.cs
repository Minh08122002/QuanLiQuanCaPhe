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
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }
        private KhachHangDAO()
        {

        }
        public List<KhachHang> loadRecord(int page, int status)
        {
            List<KhachHang> kh = new List<KhachHang>();
            int count = 0;
            List<KhachHang> ds = new List<KhachHang>();
            string query = "select * from KhachHang where TrangThaiKH=" + status.ToString();
            ds = this.Xem(query);
            if (ds.Count == 0)
                return null;
            if (page == 1)
            {
                for (int i = 0; i < ds.Count; i++)
                {
                    if (count < 10)
                    {
                        kh.Add(ds[i]);
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
                        kh.Add(ds[i]);
                        count++;
                    }
                }
            }
            return kh;
        }
        public DataTable Search(String strSearch, String strOption, int status)
        {
            DataTable data = new DataTable();

            string query = "select * from KhachHang where " + strOption + " Like N'%" + strSearch + "%' and TrangThaiKH=" + status.ToString();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int PageNumber(int status)
        {
            DataTable data = new DataTable();
            string query = "select * from KhachHang where TrangThaiKH=" + status.ToString();

            data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count % 10 == 0)
            {
                return data.Rows.Count / 10;
            }
            return data.Rows.Count / 10 + 1;
        }
        public List<KhachHang> Xem(string query)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<KhachHang> kh = new List<KhachHang>();
            foreach (DataRow item in data.Rows)
            {
                string manv = item["MAKH"].ToString();
                string tennv = item["TENKH"].ToString();
                string cmnd_cccd = item["CMND_CCCD"].ToString();
                DateTime ngaysinh = (DateTime)item["NGAYSINH"];
                string gioitinh = item["GIOITINH"].ToString();
                string sdt = item["SDT"].ToString();
                string diachi = item["DIACHI"].ToString();

                bool trangthai = (bool)item["TRANGTHAIKH"];
                KhachHang newkh = new KhachHang(manv, tennv, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, trangthai);
                kh.Add(newkh);

            }

            return kh;
        }
        public DataTable bindingNamSinh(int status)
        {
            DataTable dt = new DataTable();
            string query = "select Year(NGAYSINH) AS NAMSINH from KhachHang WHERE TRANGTHAIKH=" + status.ToString() + " GROUP BY YEAR(NGAYSINH) ORDER BY YEAR(NGAYSINH)";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable fillOfYear(string namsinh, int status)
        {
            DataTable data = new DataTable();
            string query = String.Format("select * from KhachHang where year(NGAYSINH)='{0}' AND TRANGTHAIKH={1}", namsinh, status);
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
