using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int mahd;
        private NhanVien nv;
        private KhachHang kh;
        private DateTime ngaylap;
        private bool trangthai;

        public int Mahd { get => mahd; set => mahd = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public NhanVien Nv { get => nv; set => nv = value; }
        public KhachHang Kh { get => kh; set => kh = value; }
        public string tenNV { get => nv.Tennv; }
        public string tenKH
        {
            get
            {
                if (kh == null)
                    return "Khách lẻ";
                return kh.Tenkh;
            }
        }


        public HoaDon(int mahd, NhanVien nv, KhachHang kh, DateTime ngaylap,bool trangthai)
        {
            this.mahd = mahd;
            this.nv = nv;
            this.kh = kh;
            this.ngaylap = ngaylap;
            this.trangthai = trangthai;
        }
    }
}
