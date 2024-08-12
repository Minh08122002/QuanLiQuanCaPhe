using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        public void searchTaiKhoan(DataGridView dtGV, string strSearch, string strOption, int status, string[] strs = null)
        {
            dtGV.DataSource = TaiKhoanDAO.Instance.Search(strSearch, strOption, status);
            foreach (string str in strs)
            {
                dtGV.Columns[str].Visible = false;
            }
        }
        public List<TaiKhoan> dsTaiKhoan(string query)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            list = TaiKhoanDAO.Instance.Xem(query);
            return list;
        }
        public void loadRecord(DataGridView dtgv, int page,int status,string[] str=null)
        {
            dtgv.DataSource = TaiKhoanDAO.Instance.loadRecord(page, status);
            if (str != null)
            {
                foreach(string c in str)
                {
                    dtgv.Columns[c].Visible = false;
                }
            }
        }
        public int loadPageNumber(int status)
        {
            return TaiKhoanDAO.Instance.PageNumber(status);
        }
        
        public NhanVien searchNhanVienOfTaiKhoan(string tentaikhoan)
        {
            string query = "select * from nhanvien where tentk='" +tentaikhoan + "'";
            List<NhanVien> ds = NhanVienDAO.Instance.Xem(query);
            string manv = "", tentk = "",tennv="", cmnd_cccd = "", gioitinh = "", sdt = "", diachi = "", chucvu = "";
            
            DateTime? ngayvaolam = System.DateTime.Today, ngaysinh=System.DateTime.Today;
            NhanVien nv = null;
            bool trangthai = false; byte[] hinhanh = null;
            if (ds.Count != 0)
            {
                manv = ds[0].Manv;
                tentk = ds[0].Tentk;
                tennv = ds[0].Tennv;
                cmnd_cccd = ds[0].Cmnd_cccd;
                ngaysinh = ds[0].Ngaysinh.ToString() == string.Empty ? null : (DateTime?)ds[0].Ngaysinh;
                gioitinh = ds[0].Gioitinh;
                sdt = ds[0].Sdt;
                diachi = ds[0].Diachi;
                chucvu = ds[0].Chucvu;
                trangthai = ds[0].Trangthai;
                hinhanh = ds[0].Hinhanh;
                ngayvaolam = ds[0].Ngayvaolam.ToString() == string.Empty ? null : (DateTime?)ds[0].Ngayvaolam;
                nv = new NhanVien(manv, tentk, tennv, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, chucvu, hinhanh, ngayvaolam, trangthai);
                
            }
            nv = new NhanVien(manv, tentk, tennv, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, chucvu, hinhanh, ngayvaolam, trangthai);
            return nv;
            
        }
        
        private TaiKhoanBUS()
        {

        }
        public bool updateTaiKhoan( string tentaikhoan,string matkhau,bool chopheplogon,bool trangthai)
        {
            object[] array = new object[] { tentaikhoan, matkhau, chopheplogon, trangthai };
            return TaiKhoanDAO.Instance.updateTaiKhoan(array);
        }
        public TaiKhoan bindingInformation(string tentaikhoan)
        {
            string query = "select * from TaiKhoan where TEN_TAIKHOAN='" + tentaikhoan + "'";
            List<TaiKhoan> ds = TaiKhoanDAO.Instance.Xem(query);
            string username, password;
            bool chopheplogon, trangthai;
            username = ds[0].Tentk;
            password = ds[0].Matkhau;
            chopheplogon = ds[0].Chopheplogon;
            trangthai = ds[0].Trangthai;
            TaiKhoan tk = new TaiKhoan(username, password, chopheplogon, trangthai);
            return tk;

        }
        public bool changeStatusTaiKhoan(object[] array)
        {
            return TaiKhoanDAO.Instance.changeStatusTaiKhoan(array);
        }
        public bool insertTaiKhoan(object[] array)
        {
            return TaiKhoanDAO.Instance.insertTaiKhoan(array);
        }
       public bool checkTaiKhoanExist(string tentaikhoan)
        {
            return TaiKhoanDAO.Instance.checkTaiKhoanExist(tentaikhoan);
        }

    }
}
