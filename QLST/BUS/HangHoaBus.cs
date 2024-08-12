using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DAO;
using DTO;

namespace BUS
{
    public class HangHoaBUS
    {
        private static HangHoaBUS instance;

        public static HangHoaBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HangHoaBUS();
                }
                return instance;
            }
        }
        private HangHoaBUS()
        {

        }

        public void loadData(DataGridView dtgv, int page, string[] str)
        {
            dtgv.DataSource = HangHoaDAO.Instance.loadData(page);
            if (str != null)
            {
                foreach (string c in str)
                {
                    dtgv.Columns[c].Visible = false;
                }
            }
        }

        public DataTable loadLSP()
        {


            DataTable dt = new DataTable();

            dt = HangHoaDAO.Instance.LoadLSP();

            return dt;
        }
        public DataTable loadSP()
        {


            DataTable dt = new DataTable();

            dt = HangHoaDAO.Instance.loadSP();

            return dt;
        }
        public List<HangHoa> loadSPExcel()
        {

            List<HangHoa> dt = new List<HangHoa>();

            dt = HangHoaDAO.Instance.loadSPExcel();

            return dt;
        }
        public DataTable SP(string masp)
        {
            DataTable dt = new DataTable();

            dt = HangHoaDAO.Instance.searchIDHangHoaTable(masp);

            return dt;
        }
        public List<HangHoa> SPSearch(string masp)
        {
            List<HangHoa> dt = new List<HangHoa>();

            dt = HangHoaDAO.Instance.searchIDHangHoa(masp);

            return dt;
        }

        public DataTable loadNCC()
        {


            DataTable dt = new DataTable();

            dt = HangHoaDAO.Instance.loadNCC();

            return dt;
        }

        public void exportFileSP(List<HangHoa> list, string sheetname, string title)
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
            Excel.Range head = oSheet.get_Range("A1", "M1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Time New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao tieu de cot
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Sản Phẩm";
            cl1.ColumnWidth = 12;
            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã Loại Sản Phẩm";
            cl2.ColumnWidth = 15;
            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên Sản Phẩm";
            cl3.ColumnWidth = 30;
            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã Nhà Cung Cấp";
            cl4.ColumnWidth = 30;
            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Đơn vị tính";
            cl5.ColumnWidth = 36;
            Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Đơn giá";
            cl6.ColumnWidth = 15;
            Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giá Gốc";
            cl7.ColumnWidth = 30;
            Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Số Lượng";
            cl8.ColumnWidth = 40;
            Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Số Lượng Tồn";
            cl9.ColumnWidth = 15;
            Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Giảm Giá";
            cl10.ColumnWidth = 15;
            Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Ngày sản xuất";
            cl11.ColumnWidth = 20;
            Excel.Range cl12 = oSheet.get_Range("L3", "L3");
            cl12.Value2 = "Hạn Sử Dụng";
            cl12.ColumnWidth = 15;
            Excel.Range cl13 = oSheet.get_Range("M3", "M3");
            cl13.Value2 = "Trạng Thái";
            cl13.ColumnWidth = 15;

            Excel.Range rowhead = oSheet.get_Range("A3", "M3");
            rowhead.Font.Bold = true;
            //Ke vien
            rowhead.Borders.LineStyle = Excel.Constants.xlSolid;
            //Thiet lap mau nen
            rowhead.Interior.ColorIndex = 6;
            rowhead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao mang theo list
            object[,] arr = new object[list.Count, 13];
            //Chuyen du lieu tu list vào mang
            for (int row = 0; row < list.Count; row++)
            {
                arr[row, 0] = list[row].MaSP;
                arr[row, 1] = list[row].malsp;
                arr[row, 2] = list[row].TenSP;
                arr[row, 3] = list[row].Ncc.Mancc;
                arr[row, 4] = list[row].DvTinh;
                arr[row, 5] = list[row].DonGia;
                arr[row, 6] = list[row].GiaGoc;
                arr[row, 7] = list[row].SoLuong;
                arr[row, 8] = list[row].SoLuongTon;
                arr[row, 9] = list[row].GiamGia;
                arr[row, 10] = list[row].NgSanxuat.ToString();
                arr[row, 11] = list[row].HanSD.ToString();
                arr[row, 12] = list[row].TrangThai;

            }
            //Thiet lap vung truyen du lieu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + list.Count - 1;
            int columnEnd = 13;
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
        public void thongtinHangHoaTheoID(DataGridView dtgv, string masp)
        {
            dtgv.DataSource = HangHoaDAO.Instance.searchIDHangHoa(masp);
        }

        public void thongtinHangHoaTheoTen(DataGridView dtgv, string tensp)
        {
            dtgv.DataSource = HangHoaDAO.Instance.searchTenHangHoa(tensp);
        }

        public void thongtinHangHoaTheoTenLSP(DataGridView dtgv, string tenlsp)
        {
            dtgv.DataSource = HangHoaDAO.Instance.searchTenLSP(tenlsp);


        }
        public bool themSanPham(object[] array)
        {
            return HangHoaDAO.Instance.CreateSanPham(array);
        }
        public bool suaSanPham(object[] array)
        {
            return HangHoaDAO.Instance.SuaSanPham(array);
        }
        public bool suaLoaiSanPham(object[] array)
        {
            return HangHoaDAO.Instance.SuaLoaiSanPham(array);
        }
        public bool xoaHanghoa(string MASP)
        {
            bool Check = HangHoaDAO.Instance.deleteHangHoa(MASP);
            return Check;
        }
        public bool xoaLSP(string MALSP)
        {
            bool Check = HangHoaDAO.Instance.XoaLSP(MALSP);
            return Check;
        }
        public bool xoaNCC(string MANCC)
        {
            bool Check = HangHoaDAO.Instance.XoaNCC(MANCC);
            return Check;
        }
        public bool checkMASP(string masp)
        {
            DataTable dt = HangHoaDAO.Instance.checkMSP(masp);
            if (dt.Rows.Count == 0) return true;
            string chk = dt.Rows[0].ItemArray[0].ToString();
            if (masp == chk) return false;

            return false;
        }
        public bool checkMALSP(string malsp)
        {
            DataTable dt =  HangHoaDAO.Instance.CheckMALSP(malsp);
            if (dt.Rows.Count == 0) return true;
            string chk = dt.Rows[0].ItemArray[0].ToString();
            if (malsp == chk) return false;
            return false;

        }
        public DataTable searchLSPtheoID(string malsp)
        {
            DataTable dt = new DataTable();
            HangHoaDAO.Instance.checkMSP(malsp);
            return dt;
        }
        public bool sosanhLSP(string malsp)
        {
            DataTable dt = HangHoaDAO.Instance.CheckMALSP(malsp);
            string ss = "";
            string[] str = null;
            foreach (DataRow i in dt.Rows)
            {
                ss = i.ItemArray[0].ToString();
                str = ss.Split('-');
                if (malsp == str[0]) return true;
                 ss = "";
                 str = null;
            }

            return false;
        }
        public bool sosanhNCC(string mancc)
        {
            DataTable dt = HangHoaDAO.Instance.CheckMANCC(mancc);
            string ss = "";
            string[] str = null;
            foreach (DataRow i in dt.Rows)
            {
                ss = i.ItemArray[0].ToString();
                str = ss.Split('-');
                if (mancc == str[0]) return true;
                ss = "";
                str = null;
            }

            return false;
        }
        public bool findLSP(string malsp)
        {
            DataTable dt = HangHoaDAO.Instance.CheckMALSP(malsp);
            if (dt.Rows.Count == 0) return false;
            string chk = dt.Rows[0].ItemArray[0].ToString();
            if (malsp == chk) return true;

            return false;
        }
        public bool findNCC(string mancc)
        {
            DataTable dt = HangHoaDAO.Instance.CheckMANCC(mancc);
            if (dt.Rows.Count == 0) return false;
            string chk = dt.Rows[0].ItemArray[0].ToString();
            if (mancc == chk) return true;
            return false;
        }

       
        public DataTable MA_TENLSP()
        {
            
            DataTable dt = new DataTable();

            dt = HangHoaDAO.Instance.MALSP_TENLSP();

            return dt;
        }
        public DataTable MA_TENNCC()
        {

            DataTable dt = new DataTable();

            dt = HangHoaDAO.Instance.MANCC_TENNCC();

            return dt;
        }
        public void upLSP(string tenlsp , string malsp)
        {
         
            HangHoaDAO.Instance.CreateLSP(tenlsp, malsp);
        }
        public void upNCC(string mancc, string tenncc,string diachi)
        {

            HangHoaDAO.Instance.CreateNCC(tenncc, mancc,diachi);
        }
        public void loadHangHoaTon(ref DataGridView dtgv, string str1, string str2)
        {           
                dtgv.DataSource = HangHoaDAO.Instance.SanPhamTon(str1, str2);
        }



        public bool updateNCC(string mancc, string tenncc, string diachi)
        {

            int count = HangHoaDAO.Instance.CreateNCC(tenncc, mancc, diachi);
            if (count > 0) return true;
            return false;
        }
        public void loadlistNCC(DataGridView dtgv, int status)
        {
            dtgv.DataSource = HangHoaDAO.Instance.loadNCC(status);
        }
        public bool updateNCC(string mancc, string tenncc, string diachi, int status)
        {
            int count = HangHoaDAO.Instance.updateNCC(mancc, tenncc, diachi, status);
            if (count > 0) return true;
            return false;
        }
        public void searchNCC(DataGridView dtgv, string strSeach, int status)
        {
            string query = string.Format("Select * from NhaCungCap where (Ma_NCC Like '%{0}%' OR TenNCC Like N'%{0}%' OR DiaChi Like N'{0}') And TrangThaiNCC={1}", strSeach, status);
            dtgv.DataSource = HangHoaDAO.Instance.searchNCC(query);






        }
        }
}

