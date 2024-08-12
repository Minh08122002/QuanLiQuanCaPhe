using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }


        public void loadRecord(DataGridView dtgv, int page,int status,string[] str=null)
        {
            dtgv.DataSource = NhanVienDAO.Instance.loadRecord(page,status);
            if (dtgv.Rows.Count==0)
                return;
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
            return NhanVienDAO.Instance.PageNumber(status);

        }
        public NhanVien searchNhanvienTheoTenTaiKhoan(string tentk)
        {
            string query = "select * from NhanVien where TenTK = '" + tentk + "'";
            List<NhanVien> list=NhanVienDAO.Instance.Xem(query);
            if (list.Count > 0)
            {
                return list[0];
            }
            return null;
        }
       
        public void searchNhanvien(DataGridView dtGV, string strSearch, string strOption,ComboBox cbChucvu,ComboBox cbNamSinh,int status,string[] strs=null)
        {
            string query = null;
            if (cbNamSinh.Text != "")
            {
                query = string.Format("select * from NhanVien where {0} like N'%{1}%' AND CHUCVU like N'%{2}%' AND YEAR(NGAYSINH)={3} AND TRANGTHAINV= {4}", strOption, strSearch, cbChucvu.Text, cbNamSinh.Text, status);
            }
            else query = string.Format("select * from NhanVien where {0} like N'%{1}%' AND CHUCVU like N'%{2}%' AND TRANGTHAINV={3} ", strOption, strSearch, cbChucvu.Text,status);
            dtGV.DataSource = NhanVienDAO.Instance.Search(query);
            foreach(string str in strs)
            {
                dtGV.Columns[str].Visible = false;
            }

        }
        public List<NhanVien> listNhanVien()
        {
            string query = "select * from NhanVien where TrangThaiNV=1";
            return NhanVienDAO.Instance.Xem(query);
        }
        public DataTable binDingNamSinh(int status)
        {
            return NhanVienDAO.Instance.bindingNamSinh(status);
        }
        public DataTable searchNamSinh(string namsinh,int status)
        {
            return NhanVienDAO.Instance.fillOfYear(namsinh,status);
            
        }
        public DataTable searchChucVu(string chucvu,int status)
        {
            return NhanVienDAO.Instance.fillOfChucvu(chucvu,status);
        }
        public void exportFile(List<NhanVien> list, string sheetname,string title)
        {
            Excel.Application oExcel = new Excel.Application();
            Excel.Workbooks oBooks;
            Excel.Sheets oSheets;
            Excel.Workbook oBook;
            Excel.Worksheet oSheet;
            //Tao moi mot Excel Workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            //Tao phan tieu de
            Excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Time New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao tieu de cot
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã nhân viên";
            cl1.ColumnWidth = 12;
            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên tài khoản";
            cl2.ColumnWidth = 15;
            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên nhân viên";
            cl3.ColumnWidth = 30;
            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 30;
            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số CMND";
            cl5.ColumnWidth = 36;
            Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Giới tính";
            cl6.ColumnWidth = 15;
            Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "SĐT";
            cl7.ColumnWidth = 30;
            Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Địa chỉ";
            cl8.ColumnWidth = 40;
            Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Chức vụ";
            cl9.ColumnWidth = 15;
            Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Ngày vào làm";
            cl10.ColumnWidth = 20;
            
            Excel.Range rowhead = oSheet.get_Range("A3", "J3");
            rowhead.Font.Bold = true;
            //Ke vien
            rowhead.Borders.LineStyle = Excel.Constants.xlSolid;
            //Thiet lap mau nen
            rowhead.Interior.ColorIndex = 6;
            rowhead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao mang theo list
            object[,] arr = new object[list.Count, 10];
            //Chuyen du lieu tu list vào mang
            for(int row = 0; row < list.Count; row++)
            {
                arr[row, 0] = list[row].Manv;
                arr[row, 1] = list[row].Tentk;
                arr[row, 2] = list[row].Tennv;
                arr[row, 3] = list[row].Ngaysinh.ToString();
                arr[row, 4] = "'" + list[row].Cmnd_cccd.ToString();
                arr[row, 5] = list[row].Gioitinh;
                arr[row, 6] = "'" + list[row].Sdt;
                arr[row, 7] = list[row].Diachi;
                arr[row, 8] = list[row].Chucvu;
                arr[row, 9] = list[row].Ngayvaolam.ToString();
            }
            //Thiet lap vung truyen du lieu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + list.Count - 1;
            int columnEnd = 10;
            //O bat dau dien du lieu
            Excel.Range c1 = (Excel.Range)oSheet.Cells[rowStart, columnStart];
            //O ket thuc dien du lieu
            Excel.Range c2 = (Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // lay ve vung dien du lieu
            Excel.Range range = oSheet.get_Range(c1, c2);
            //Dien du lieu vao vùng thiet lap
            range.Value2 = arr;
            //Ke vien
            range.Borders.LineStyle = Excel.Constants.xlSolid;
            //Can giua ca ban
            oSheet.get_Range(c1, c2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }
        public NhanVien getNhanVien(string manv)
        {
            List<NhanVien> nv = new List<NhanVien>();
            nv = NhanVienDAO.Instance.Xem(string.Format("select * from NhanVien where MaNV='{0}'", manv));
            return nv[0];
        }
        public void exportNhanVien()
        {
            

        }
        private NhanVienBUS()
        {

        }
    }
}
