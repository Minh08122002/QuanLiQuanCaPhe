using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private HoaDon hd;
        private HangHoa hh;
        private int soluong;
        private int dongia;
        private float giamgia;
        private bool trangthai;


        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public float Giamgia { get => giamgia; set => giamgia = value; }
        public HangHoa Hh { get => hh; set => hh = value; }
        public HoaDon Hd { get => hd; set => hd = value; }
        public int maHD { get => hd.Mahd;}
        public string maHH { get => hh.MaSP;}

        

        public ChiTietHoaDon(HoaDon hd,HangHoa hh,int soluong,int dongia,float giamgia,bool trangthai)
        {
            this.hd = hd;
            this.hh = hh;
            this.soluong = soluong;
            this.dongia = dongia;
            this.giamgia = giamgia;
            this.trangthai = trangthai;
        }
    }
}
