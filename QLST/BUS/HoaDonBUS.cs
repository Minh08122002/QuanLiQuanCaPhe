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
    public class HoaDonBUS
    { 
        private static HoaDonBUS instance;
      
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();

                }
                return instance;
            }
        }
        
        public void addListHangHoa(ComboBox cb, List<HangHoa> list)
        {
            cb.DataSource = list;
            cb.DisplayMember = "MaVaTen";
            cb.ValueMember = "MaSp";
            
            cb.Text = ""; 
        }
        public void loadListHD(DataGridView dtgv)
        {
            
        }
        public List<HangHoa> takeListHangHoa()
        {
            List<HangHoa> hh = new List<HangHoa>();
            string query = "select * from SanPham,LoaiSanPham,NhaCungCap where MALSP=MA_LOAI_SP AND MANCC=MA_NCC AND TrangThaiSP=1 AND TrangThaiLSP=1";
            
            hh = HoaDonDAO.Instance.Xem(query);
            return hh;
        }

        public List<HangHoa> searchHangHoa(string str, string[] arrayType)
        {
            string query = string.Format("select * from SanPham,LoaiSanPham,NhaCungCap where TRANGTHAISP=1 AND MALSP=MA_LOAI_SP AND MANCC=MA_NCC AND  (({0} LIKE '%{1}%') OR ({2} LIKE '%{3}%')) AND TRANGTHAILSP=1", arrayType[0],str,arrayType[1],str);
            List<HangHoa> list = new List<HangHoa>();
            list = HoaDonDAO.Instance.Xem(query);

            return list;
        }
        public List<HangHoa> searchHangHoa(string strSearch)
        {
            string query = "select * from SanPham,LoaiSanPham,NhaCungCap where (TRANGTHAISP=1 AND MALSP=MA_LOAI_SP AND MANCC=MA_NCC AND MASP LIKE '%" + strSearch + "%' AND TRANGTHAILSP=1) OR (MALSP=MA_LOAI_SP AND MANCC=MA_NCC AND TENSP LIKE N'%" + strSearch+"%'AND TRANGTHAISP=1 AND TRANGTHAILSP=1)";
            List<HangHoa> list = new List<HangHoa>();
            list = HoaDonDAO.Instance.Xem(query);

            return list;
        }
        public List<HangHoa> searchHangHoa(string strSearch,string type)
        {
            string query = "select * from SanPham,LoaiSanPham,NhaCungCap where TRANGTHAISP=1 AND MALSP=MA_LOAI_SP AND MANCC=MA_NCC AND " + type+" LIKE '%" + strSearch + "%' AND TRANGTHAISP=1 AND TRANGTHAILSP=1";
            List<HangHoa> list = new List<HangHoa>();
            list = HoaDonDAO.Instance.Xem(query);

            return list;
        }
        public DataTable convertListToDataTabel(List<HangHoa> list)
        {
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            return converter.ToDataTable(list);
        }
        public void addSDTAndTenKH(TextBox makh,TextBox tenkh,string sdt)
        {
            string[] str=HoaDonDAO.Instance.searchMaKHAndTenKh(sdt);
            makh.Text = str[0];
            tenkh.Text = str[1];
        }
        public void addRowInDataGridViewHoaDon(DataGridView dtgv,HangHoa hh,int soluong)
        {
            //string[] str = { "colMaSp", "colTenSP", "colTenlsp", "colSoluong", "colDonGia", "colGiamGia", "colThanhtien" };
            DataTable dt = new DataTable();
            //foreach (string s in str)
            //{
            //    dt.Columns.Add(s);
            //}
            
            int thanhtien = soluong * hh.DonGia - (int)(soluong * hh.DonGia * hh.GiamGia);
            object[] value = { hh.MaSP, hh.TenSP, hh.DvTinh, soluong, hh.DonGia,hh.GiamGia,thanhtien };
            //dt.Rows.Add(value);
            for (int i = 0; i < dtgv.Rows.Count; i++)
            {
                if (dtgv.Rows[i].Cells["colMaSp"].Value.ToString() == hh.MaSP)
                {
                    dtgv.Rows[i].Cells["colSoluong"].Value = int.Parse(dtgv.Rows[i].Cells["colSoluong"].Value.ToString()) + soluong;
                    int soluongghi = int.Parse(dtgv.Rows[i].Cells["colSoluong"].Value.ToString());
                    int dongia = int.Parse(dtgv.Rows[i].Cells["colDonGia"].Value.ToString());
                    float giamgia = float.Parse(dtgv.Rows[i].Cells["colGiamGia"].Value.ToString());
                    dtgv.Rows[i].Cells["colThanhtien"].Value = soluongghi * dongia - (soluongghi * dongia * giamgia);
                    return;
                }
            }
            dtgv.Rows.Add(value);
        }
        public void binddingMaHD(TextBox txt)
        {
            txt.Text = HoaDonDAO.Instance.takeMaHDNext().ToString();

        }
        public void bindingYearBill(ComboBox cb)
        {
           DataTable data= HoaDonDAO.Instance.year();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                cb.Items.Add(data.Rows[i].ItemArray[0].ToString());
            }
        }
        public string settingquery(ComboBox cbNam,ComboBox cbThang)
        {
            string query = null;
            if (cbNam.Text == "" && cbThang.Text != "")
            {
                query = "select * from HoaDon where TrangThaiHD=1 and Month(NGLAP)=" + cbThang.Text;
            }
            else
            {
                if (cbNam.Text != "" && cbThang.Text == "")
                {
                    query = "select * from HoaDon where TrangThaiHD=1 and YEAR(NGLAP)=" + cbNam.Text;

                }
                else
                {
                    if (cbNam.Text != "" && cbThang.Text != "")
                    {
                        query = string.Format("select * from HoaDon where TrangThaiHD=1 and YEAR(NGLAP)={0} AND MONTH(NGLAP)={1}", cbNam.Text, cbThang.Text);

                    }
                    else
                    {

                        query = "select * from HoaDon where TrangThaiHD=1";
                    }
                }
            }
            return query;
        }
        public bool AddHD(DataGridView dtgv,int mahd,string makh,string manv,DateTime ngaylap)
        {
            try
            {
                object[] inHD = null;
                bool checkAddHD = false;
                if (string.IsNullOrEmpty(makh) == true)
                {
                    inHD = new object[] { mahd, manv, ngaylap, true };
                    checkAddHD = HoaDonDAO.Instance.AddHoaDon(inHD, 4);
                }
                else
                {

                    inHD = new object[] { mahd, manv, makh, ngaylap, true };
                    checkAddHD = HoaDonDAO.Instance.AddHoaDon(inHD, 5);
                }

                if (checkAddHD == true)
                {
                    for (int i = 0; i < dtgv.Rows.Count; i++)
                    {
                        int soluong = int.Parse(dtgv.Rows[i].Cells["colSoLuong"].Value.ToString());
                        int dongia = int.Parse(dtgv.Rows[i].Cells["colDonGia"].Value.ToString());
                        string masp = dtgv.Rows[i].Cells["colMaSp"].Value.ToString();
                        float giamgia = float.Parse(dtgv.Rows[i].Cells["colGiamGia"].Value.ToString());
                        object[] inCTHD = { mahd, masp, soluong, dongia, giamgia, true };
                        bool checkAddCTHD = ChiTietHoaDonDAO.Instance.AddChiTietHoaDon(inCTHD);
                        if (checkAddCTHD == false)
                            return false;

                    }
                    return true;
                }
                return false;
            }catch(Exception EE)
            {
                return false;
            }
            
        }
        public List<HoaDon> lisHoaDon()
        {

            return HoaDonDAO.Instance.XemHD("select * from HoaDon where TrangThaiHD=1");
        }
        public DataTable TienHoaDon()
        {
            return DataProvider.Instance.ExecuteQuery("select MA_HD,SUM(SOLUONG * DONGIA), SUM(SOLUONG * DONGIA * GIAMGIA) from CT_HoaDon where trangthaicthd=1 group by MA_HD");
        }
      
        public void addListHD(DataGridView dtgv,string query)
        {
            
            dtgv.DataSource = HoaDonDAO.Instance.XemHD(query);
            string querycthd = "select MA_HD,SUM(SOLUONG * DONGIA), SUM(SOLUONG * DONGIA * GIAMGIA) from CT_HoaDon where trangthaicthd=1 group by MA_HD";
            DataTable datacthd = DataProvider.Instance.ExecuteQuery(querycthd);
            string[] array = { "NV", "KH", "TrangThai", "TenNV" };
            foreach (string str in array)
            {
                dtgv.Columns[str].Visible = false;
            }
            for (int i = 0; i < dtgv.Rows.Count; i++)
            {
                foreach(DataRow row in datacthd.Rows)
                {
                    if (dtgv.Rows[i].Cells["colMaHD"].Value.ToString() == row.ItemArray[0].ToString())
                    {
                        string[] split = row.ItemArray[1].ToString().Split('.');
                        dtgv.Rows[i].Cells["colTongTien"].Value = split[0];
                        split = row.ItemArray[2].ToString().Split('.');

                        dtgv.Rows[i].Cells["colGiamGia"].Value = split[0];

                        dtgv.Rows[i].Cells["colKhachTra"].Value = int.Parse(dtgv.Rows[i].Cells["colTongTien"].Value.ToString()) - int.Parse(dtgv.Rows[i].Cells["colGiamGia"].Value.ToString());

                        break;
                    }
                }
                //for(int j = 0; j < datacthd.Rows.Count; j++)
                //{
                //    if (dtgv.Rows[i].Cells["colMaHD"].Value.ToString() == datacthd.Rows[j].ItemArray[0].ToString())
                //    {
                //        string[] split = datacthd.Rows[j].ItemArray[1].ToString().Split('.');
                //        dtgv.Rows[i].Cells["colTongTien"].Value = split[0];
                //        split = datacthd.Rows[j].ItemArray[2].ToString().Split('.');

                //        dtgv.Rows[i].Cells["colGiamGia"].Value = split[0];

                //        dtgv.Rows[i].Cells["colKhachTra"].Value = int.Parse(dtgv.Rows[i].Cells["colTongTien"].Value.ToString()) - int.Parse(dtgv.Rows[i].Cells["colGiamGia"].Value.ToString());

                //        break;
                //    }
                //}
            }



        }
        public bool updateStatusHD(string mahd, bool trangthai)
        {
            object[] array = new object[] { mahd, trangthai };
            bool ktraxoa = HoaDonDAO.Instance.updateStatusHD(array);
            return ktraxoa;
        }
        public HoaDon searchHoaDon(int mahd)
        {
            List<HoaDon> hd = new List<HoaDon>();
            string query = string.Format("select * from HoaDon where MaHD={0} AND TRANGTHAIHD=1", mahd);
            hd = HoaDonDAO.Instance.XemHD(query);
            return hd[0];
        }
        public void exportFile(HoaDon hd, List<ChiTietHoaDon> list,string tongtien, string khachdua, string tienthoi)
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
            oSheet.Name = "Hóa đơn";
            //Tao phan tieu de
            //HEADER: PHIẾU TÍNH TIỀN
            Excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;
            head.Value2 = "PHIẾU TÍNH TIỀN";
            head.Font.Bold = true;
            head.Font.Name = "Time New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //HEADER: CHỈ CÓ GIÁ TRỊ XUẤT HÓA ĐƠN TRONG NGÀY
            Excel.Range head2 = oSheet.get_Range("A2", "D2");
            head2.MergeCells = true;
            head2.Value2 = "(Chỉ có giá trị xuất hóa đơn trong ngày)";
            head2.Font.Name = "Time New Roman";
            head2.Font.Size = "11";
            head2.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //HEADER: CỬA HÀNG BADO
            Excel.Range head3 = oSheet.get_Range("A3", "D3");
            head3.MergeCells = true;
            head3.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = 1;
            head3.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = 3;

            head3.Value2 = "CỬA HÀNG BADO";
            head3.Font.Bold = true;
            head3.Font.Name = "Time New Roman";
            head3.Font.Size = "14";
            head3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao tieu de cot
            Excel.Range cl1 = oSheet.get_Range("A4", "A4");
            cl1.Value2 = "Tên sản phẩm";
            cl1.ColumnWidth = 25;
            Excel.Range cl2 = oSheet.get_Range("B4", "B4");
            cl2.Value2 = "Số lượng";
            cl2.ColumnWidth = 15;
            Excel.Range cl3 = oSheet.get_Range("C4", "C4");
            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 20;
            Excel.Range cl4 = oSheet.get_Range("D4", "D4");
            cl4.Value2 = "Giảm giá";
            cl4.ColumnWidth = 20;
            

            Excel.Range rowhead = oSheet.get_Range("A4", "D4");
            //Ke vien
            //Thiet lap mau nen
            rowhead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //Tao mang theo list
            object[,] arr = new object[list.Count, 4];
            //Chuyen du lieu tu list vào mang
            for (int row = 0; row < list.Count; row++)
            {
                arr[row, 0] = list[row].Hh.TenSP;
                arr[row, 1] = list[row].Soluong;
                arr[row, 2] = list[row].Dongia;
                arr[row, 3] = list[row].Giamgia;
               
            }
            //Thiet lap vung truyen du lieu
            int rowStart = 5;
            int columnStart = 1;
            int rowEnd = rowStart + list.Count - 1;
            int columnEnd = 4;
            //O bat dau dien du lieu
            Excel.Range c1 = (Excel.Range)oSheet.Cells[rowStart, columnStart];
            //O ket thuc dien du lieu
            Excel.Range c2 = (Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // lay ve vung dien du lieu
            Excel.Range range = oSheet.get_Range(c1, c2);
            //Dien du lieu vao vùng thiet lap
            range.Value2 = arr;
            //Can trai ca ban
            oSheet.get_Range(c1, c2).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            int count = rowEnd + 1;
            /////////////
            object[,] array2 = new object[6, 2];
            array2[0, 0] = "Tổng cộng hóa đơn";
            array2[1, 0] = "Khách đưa";
            array2[2, 0] = "Tiền thối";
            array2[3, 0] = "Mã khách hàng";
            
            if (hd.Kh != null)
            {
                array2[3, 1] = hd.Kh.Makh;
            }
            else array2[3, 1] = "Khách lẻ";
            array2[4, 0] = "NV:";
            array2[5, 0] = "Số hóa đơn";
            array2[4, 1] = hd.Nv.Tennv;
            array2[5, 1] = hd.Mahd;
            int rowstartTT = rowEnd +3;
            int columnstartTT = 1;
            int rowendtt = rowstartTT + 6 - 1;
            int columnendtt = 2;
            //Tong tien;
            Excel.Range clTongTien = oSheet.get_Range("C"+rowstartTT, "D"+rowstartTT);
            clTongTien.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = -4119;
            clTongTien.MergeCells = true;
            clTongTien.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            clTongTien.Value2 = tongtien;
            //Khach dua

            Excel.Range clKhachDua = oSheet.get_Range("C" + (rowstartTT+1).ToString(), "D" + (rowstartTT+1).ToString());
            clKhachDua.MergeCells = true;
            clKhachDua.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            clKhachDua.Value2 = khachdua;
            //Tien thoi
            Excel.Range clTienThoi = oSheet.get_Range("C" + (rowstartTT + 2).ToString(), "D" + (rowstartTT + 2).ToString());
            clTienThoi.MergeCells = true;
            clTienThoi.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            clTienThoi.Value2 = tienthoi;
            

            Excel.Range c3 = (Excel.Range)oSheet.Cells[rowstartTT, columnstartTT];
            Excel.Range c4= (Excel.Range)oSheet.Cells[rowendtt, columnendtt];
            Excel.Range range2 = oSheet.get_Range(c3, c4);
            range2.Value2 = array2;
            oSheet.get_Range(c3, c4).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            Excel.Range clNhanVien=oSheet.get_Range("A"+(rowendtt-1).ToString(),"D"+(rowendtt-1).ToString());
            clNhanVien.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = 4;
            clNhanVien.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = 3;

        }
        public HangHoa searchHHtheoMa(string masp)
        {
            List<HangHoa> list = new List<HangHoa>();
            string query = "Select * from SanPham, LoaiSanPham,NhaCungCap where  MALSP = MA_LOAI_SP and  MANCC = MA_NCC and TRANGTHAISP = 1 and  MASP='" + masp+"'"+" AND TrangThaiSP=1";
            list = HangHoaDAO.Instance.Xem(query);
            return list[0];
        }
        public bool updateHD(string mahd, string makh,string manv)
        {
            string query = "";
            if (makh == ""&&manv!="")
            {
                query = string.Format("update HoaDon set MA_KHACHHANG = NULL, MA_NHANVIEN='{0}' where MaHD={1}", manv, mahd);
            }else
            query = string.Format("update HoaDon set MA_KHACHHANG='{0}', MA_NHANVIEN='{1}' where MaHD={2}", makh, manv, mahd);
            int count = HoaDonDAO.Instance.updateHD(query);
            if (count > 0)
                return true;
            else return false;
        }
    }
}
