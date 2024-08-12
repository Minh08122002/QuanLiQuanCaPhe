using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;

        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonBUS();

                }
                return instance;
            }
        }
        public int tongTienHoaDon(List<ChiTietHoaDon> list)
        {
            int tongtien = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int thanhtien = list[i].Soluong * list[i].Dongia;
                tongtien += thanhtien;
            }
            return tongtien;
        }
        public int tongTienGiamHoaDon(List<ChiTietHoaDon> list)
        {
            int tongtien = 0;
            
            for (int i = 0; i < list.Count; i++)
            {
                int tiengiam = (int)(list[i].Soluong * list[i].Dongia * list[i].Giamgia);
                tongtien += tiengiam;
            }
            return tongtien;
        }
        public void addSPinList(List<ChiTietHoaDon> list, ListView lsvDanhSachSP,ImageList imglist)
        {
            lsvDanhSachSP.Items.Clear();
            for(int i = 1; i < imglist.Images.Count; i++)
            {
                imglist.Images.RemoveAt(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem(list[i].Hh.TenSP);
                item.SubItems.Add(list[i].maHH.ToString());
                item.SubItems.Add(list[i].Giamgia.ToString());
                item.SubItems.Add(list[i].Soluong.ToString());
                item.SubItems.Add(list[i].Dongia.ToString());
                Image img = null;
                if (list[i].Hh.HinhAnh!=null)
                {
                    ImageToByte convert = new ImageToByte();
                    convert.byteArrayToImage(list[i].Hh.HinhAnh, ref img);
                    imglist.Images.Add(img);
                    item.ImageIndex = imglist.Images.Count-1;
                }
                else
                {
                    item.ImageIndex = 0;
                }
                lsvDanhSachSP.Items.Add(item);
            }
        }
        public void bindingDuLieu(HoaDon hd,List<ChiTietHoaDon> list,object obj, string type)
        {
            switch (type)
            {
                
                case "manhanvien":
                    {
                        ComboBox cb = obj as ComboBox;
                        cb.Text = hd.Nv.Manv;
                    }
                    break;
                case "mahoadon":
                    {
                        TextBox txt = obj as TextBox;
                        txt.Text = hd.Mahd.ToString();
                    }break;
                case "ngaylaphd":
                    {
                        DateTimePicker dtp = obj as DateTimePicker;
                        dtp.Value = hd.Ngaylap;
                    }break;
                case "tongtien":
                    {
                        TextBox txt = obj as TextBox;
                        int tongtien = tongTienHoaDon(list);
                        txt.Text = tongtien.ToString();
                    }break;
                case "tongtiengiam":
                    {
                        TextBox txt = obj as TextBox;
                        int tongtiengiam = tongTienGiamHoaDon(list);
                        txt.Text = tongtiengiam.ToString();
                    }break;
                case "khachtra":
                    {
                        TextBox txt = obj as TextBox;
                        int tongtien = tongTienHoaDon(list);
                        int tongtiengiam = tongTienGiamHoaDon(list);

                        txt.Text = (tongtien - tongtiengiam).ToString();
                    }
                    break;
                case "makhachhang":
                    {
                        TextBox txt = obj as TextBox;
                        if(hd.Kh!=null)
                        txt.Text = hd.Kh.Makh;
                    }break;
                case "tenkhachhang":
                    {
                        TextBox txt = obj as TextBox;
                        if (hd.Kh != null)
                            txt.Text = hd.Kh.Tenkh;
                    }break;
                default: break;
            }
        }
        public void bindingInformationCTHD(HoaDon hd,List<ChiTietHoaDon> list, ListView lsv,ImageList imglist,ComboBox cbMaNV,TextBox txtMaHD,DateTimePicker dtPNgayLapHD,TextBox txtTongTien,TextBox txtTienGiam, TextBox txtKhachTra,TextBox txtMaKhachHang,TextBox txtTenKhachHang)
        {
            addSPinList(list, lsv, imglist);
            bindingDuLieu(hd,list, cbMaNV, "manhanvien");
            bindingDuLieu(hd,list, txtMaHD, "mahoadon");
            bindingDuLieu(hd,list, dtPNgayLapHD, "ngaylaphd");
            bindingDuLieu(hd,list, txtTongTien, "tongtien");
            bindingDuLieu(hd,list, txtTienGiam, "tongtiengiam");
            bindingDuLieu(hd,list, txtKhachTra, "khachtra");
            bindingDuLieu(hd,list, txtMaKhachHang, "makhachhang");
            bindingDuLieu(hd,list, txtTenKhachHang, "tenkhachhang");

        }
        public List<ChiTietHoaDon> searchCTHD(int mahd)
        {
            string query = string.Format("select * from CT_HoaDon where Ma_HD={0}", mahd);
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            list = ChiTietHoaDonDAO.Instance.Xem(query);
            return list;

        }
        public bool updateChiTietHD(List<ChiTietHoaDon> list,HoaDon hd)
        {
            try
            {
                List<ChiTietHoaDon> data = new List<ChiTietHoaDon>();
                List<ChiTietHoaDon> listold = searchCTHD(hd.Mahd);
                bool ktracapnhat = false;
                foreach (ChiTietHoaDon cthd in listold)
                {
                    ktracapnhat = ChiTietHoaDonDAO.Instance.updateSLSPcuaCTHD(cthd.maHH, cthd.Soluong);
                    if (ktracapnhat == false) break;
                }
                if (ktracapnhat == true)
                {
                    bool ktraxoa = ChiTietHoaDonDAO.Instance.deleteCTHD(hd.Mahd);
                    if (ktraxoa == true)
                    {
                        bool ktrathem = false;
                        foreach (ChiTietHoaDon item in list)
                        {
                            ktrathem = ChiTietHoaDonDAO.Instance.insertCTHD(item);
                        }
                        return ktrathem;

                    }

                }
                return false;
            }
            catch (Exception EE)
            {
                return false;
            }
            
            return false;
        }
        public void bindingMoneyProduct(ListViewItem item,TextBox txtTenSP,TextBox txtSoLuong,TextBox txtGiamGia,TextBox txtDonGia,TextBox txtThanhTien)
        {
            txtTenSP.Text = item.SubItems[0].Text.ToString();
            txtSoLuong.Text = item.SubItems[3].Text.ToString();
            txtDonGia.Text = item.SubItems[4].Text.ToString();
            txtGiamGia.Text = item.SubItems[2].Text.ToString();
            string thanhtien = (int.Parse(item.SubItems[3].Text)*int.Parse(item.SubItems[4].Text)-(int)(float.Parse(item.SubItems[2].Text)* int.Parse(item.SubItems[3].Text) * int.Parse(item.SubItems[4].Text))).ToString();
            txtThanhTien.Text = thanhtien;
        }
        public void ThemHHVaoCTHD(HoaDon hd,List<ChiTietHoaDon> list,HangHoa h)
        {
            bool spgiongnhau = false;
            ChiTietHoaDon cthd = new ChiTietHoaDon(hd, h, 1, h.DonGia, h.GiamGia, true);
            foreach (ChiTietHoaDon item in list)
            {
                if (item.Hh.MaSP == h.MaSP)
                {
                    item.Soluong += 1;
                    spgiongnhau = true;
                    break;
                }
            }
            if (spgiongnhau == false)
                list.Add(cthd);
        }
        public void getListNhanVien(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.Xem("select * from NhanVien where TrangThaiNV=1");
            cb.DisplayMember = "MaNV";
            cb.ValueMember = "TenNV";
        }
        public string getTenNV(string manv)
        {
            List<NhanVien> data = new List<NhanVien>();
            data = NhanVienDAO.Instance.Xem(string.Format("select * from NhanVien where Manv='{0}'",manv));
            return data[0].Tennv;
        }
        public KhachHang getKH(string makh)
        {
            List<KhachHang> data = new List<KhachHang>();
            data = KhachHangDAO.Instance.Xem(string.Format("select * from KhachHang where MaKH='{0}'", makh));
            if (data.Count > 0)
            {
                return data[0];
            }
            return null;
            
        }
    }
}
