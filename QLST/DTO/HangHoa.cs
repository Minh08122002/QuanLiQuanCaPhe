using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa
    {
        private string maSP;
        private string tenSP;
        private LoaiSanPham lsp;

        private int donGia;
        private int giaGoc;
        private string dvTinh;
        private NhaCungCap ncc;
        private int soLuong;
        private int soLuongTon;
        private float giamGia;
        private DateTime? ngSanxuat;
        private DateTime? hanSD;
        private byte[] hinhAnh;
        private bool trangThai;

        public string MaSP { get => maSP; set => maSP = value; }

        public string TenSP { get => tenSP; set => tenSP = value; }
  
        public int DonGia { get => donGia; set => donGia = value; }
        public int GiaGoc { get => giaGoc; set => giaGoc = value; }
        public string DvTinh { get => dvTinh; set => dvTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public float GiamGia { get => giamGia; set => giamGia = value; }
        public DateTime? NgSanxuat { get => ngSanxuat; set => ngSanxuat = value; }
        public DateTime? HanSD { get => hanSD; set => hanSD = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string MaVaTen { get => maSP + "  -  " + tenSP; }
        public LoaiSanPham Lsp { get => lsp; set => lsp = value; }

        public string tenlsp { get => lsp.Tenlsp; }
        public string malsp { get => lsp.Malsp; }
        public bool trangthailsp { get => lsp.Trangthai; }
        public NhaCungCap Ncc { get => ncc; set => ncc = value; }


        public HangHoa(string masp, LoaiSanPham lsp, string tensp, NhaCungCap ncc, string dvt, int dongia, int giagoc, int soluong, int soluongton, float giamgia, DateTime? ngsx, DateTime? hsd, byte[] hinhanh, bool trangthai)
        {
            this.MaSP = masp;
            this.lsp = lsp;
            this.TenSP = tensp;
            this.ncc=ncc;
            this.DvTinh = dvt;
            this.DonGia = dongia;
            this.GiaGoc = giagoc;
            this.SoLuong = soluong;
            this.SoLuongTon = soluongton;
            this.GiamGia = giamgia;
            this.NgSanxuat = ngsx;
            this.HanSD = hsd;
            this.HinhAnh = hinhanh;
            this.TrangThai = trangthai;
        }


    }
}
