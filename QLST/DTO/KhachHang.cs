using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string makh;
        private string tenkh;
        private string cmnd;
        private DateTime ngaysinh;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private bool trangthai;

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }

        public KhachHang(string makh,string tenkh,string cmnd,DateTime ngaysinh,string gioitinh,string sdt,string diachi,bool trangthai)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.cmnd = cmnd;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.trangthai = trangthai;
        }
    }
}
