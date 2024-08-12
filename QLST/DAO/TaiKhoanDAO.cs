using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance { get {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance; } }
        private TaiKhoanDAO()
        {

        }
        public DataTable loadRecord(int page,int status)
        {
            List<TaiKhoan> tk = new List<TaiKhoan>();
            int count = 0;
            List<TaiKhoan> ds = new List<TaiKhoan>();
            string query = "select * from TaiKhoan where TrangThaiTK=" + status.ToString();
            ds = this.Xem(query);
            if (page == 1)
            {
               for(int i = 0; i < ds.Count; i++)
                {
                    if (count < 10)
                    {
                        tk.Add(ds[i]);
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
                        tk.Add(ds[i]);
                        count++;
                    }
                }
            }
            ListtoDataTableConverter convert = new ListtoDataTableConverter();
            DataTable dt = convert.ToDataTable(tk);
            return dt;
        }
        public bool updateTaiKhoan(object[] o)
        {
            string query = "EXEC updateTaiKhoan @TENTAIKHOAN , @MATKHAU , @CHOPHEPLOGON , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query,o);
            if(count>0)
                return true;
            return false;
        }
        public DataTable Search(string strSearch, string strOption, int status)
        {
            DataTable data = new DataTable();

            string query = "select * from TaiKhoan where " + strOption + " Like '%" + strSearch + "%' and TrangThaiTK="+status.ToString();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int PageNumber(int status)
        {
            DataTable data = new DataTable();
            string query = "select * from TaiKhoan where TrangThaiTK="+status.ToString();
           
            data = DataProvider.Instance.ExecuteQuery(query);
            
            if (data.Rows.Count % 10 == 0)
            {
                return data.Rows.Count / 10;
            }
            return data.Rows.Count/10+1;
        }
        public List<TaiKhoan> Xem(string query)
        {
            
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<TaiKhoan> ds = new List<TaiKhoan>();
            foreach (DataRow item in data.Rows)
            {
                string tentk = item["TEN_TAIKHOAN"].ToString();
                string matkhau = item["MATKHAU"].ToString();
                bool chopheplogon = (bool)item["CHOPHEP_LOGON"];
                bool trangthai = (bool)item["TRANGTHAITK"];
                TaiKhoan tk = new TaiKhoan(tentk, matkhau, trangthai, chopheplogon);
                ds.Add(tk);
            }
            
            return ds;
        }
        public bool changeStatusTaiKhoan(object[] array)
        {

            string query = string.Format("EXEC updateStatusTaiKhoan @MANV , @TRANGTHAI");
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;

        }
        public bool insertTaiKhoan(object[] array)
        {
            string query = "EXEC insertTaiKhoan @TENTAIKHOAN , @MATKHAU , @CHOPHEPLOGON , @TRANGTHAI";
            int count = DataProvider.Instance.ExecuteNonQuery(query, array);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkTaiKhoanExist(string tentk)
        {
            string query = "select * from TaiKhoan where TEN_TAIKHOAN='" + tentk + "'";

            List<TaiKhoan> ds = new List<TaiKhoan>();
            ds = Xem(query);
            if (ds.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
