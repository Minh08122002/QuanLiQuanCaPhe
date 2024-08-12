using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;

        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
        }
        public void searchKhachHang(DataGridView dtgv, string str,int status,string[] array)
        {
            string query=string.Format("select * from KhachHang where (TenKh Like N'%{0}%' OR MaKH Like N'%{0}%') And TrangThaiKH={1}",str,status);
            dtgv.DataSource = KhachHangDAO.Instance.Xem(query);
            foreach(string c in array)
            {
                dtgv.Columns[c].Visible = false;
            }
        }
        public void loadRecord(DataGridView dtgv, int page,int status,string[] str=null)
        {
            dtgv.DataSource = KhachHangDAO.Instance.loadRecord(page,status);
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
            return KhachHangDAO.Instance.PageNumber(status);
        }
        public void searchKhachHang(DataGridView dtGV, string strSearch, string strOption,int status,string[] strs=null)
        {

            dtGV.DataSource = KhachHangDAO.Instance.Search(strSearch, strOption,status);
            foreach(string str in strs)
            {
                dtGV.Columns[str].Visible = false;
            }

        }
        public DataTable binDingNamSinh(int status)
        {
            return KhachHangDAO.Instance.bindingNamSinh(status);
        }
        public DataTable searchNamSinh(string namsinh,int status)
        {
            return KhachHangDAO.Instance.fillOfYear(namsinh,status);
            
        }
        public List<KhachHang> getListKH()
        {
            string query = "select * from KhachHang where TrangThaiKH=1";
            
            return KhachHangDAO.Instance.Xem(query);
        }
        public void exportFile(List<KhachHang> list, string sheetname, string title)
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
            Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Time New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao tieu de cot
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Khách Hàng";
            cl1.ColumnWidth = 12;
            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Khách Hàng";
            cl2.ColumnWidth = 15;
            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "CMND_CCCD";
            cl3.ColumnWidth = 30;
            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 30;
            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Giới Tính";
            cl5.ColumnWidth = 30;
            Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số Điện Thoại";
            cl6.ColumnWidth = 36;
            Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Địa chỉ";
            cl7.ColumnWidth = 40;
            Excel.Range rowhead = oSheet.get_Range("A3", "G3");
            rowhead.Font.Bold = true;
            //Ke vien
            rowhead.Borders.LineStyle = Excel.Constants.xlSolid;
            //Thiet lap mau nen
            rowhead.Interior.ColorIndex = 6;
            rowhead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao mang theo list
            object[,] arr = new object[list.Count, 7];
            //Chuyen du lieu tu list vào mang
            for (int row = 0; row < list.Count; row++)
            {
                arr[row, 0] = list[row].Makh;
                arr[row, 1] = list[row].Tenkh;
                arr[row, 2] = "'" + list[row].Cmnd.ToString();
                arr[row, 3] = list[row].Ngaysinh.ToString();
                arr[row, 4] = list[row].Gioitinh;
                arr[row, 5] = "'" + list[row].Sdt;
                arr[row, 6] = list[row].Diachi;
            }
            //Thiet lap vung truyen du lieu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + list.Count - 1;
            int columnEnd = 7;
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
        public bool exsitKH(string makh)
        {
            List<KhachHang> kh = new List<KhachHang>();
            kh = KhachHangDAO.Instance.Xem(string.Format("select * from KhachHang where MaKH='{0}' and TrangThaiKH=1", makh));
            if (kh.Count == 0) return false;
            else return true;
        }
        private KhachHangBUS()
        {

        }
    }
}
