using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string manv;
        private string tentk;
        private string tennv;
        private DateTime? ngaysinh;
        private string cmnd_cccd;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private string chucvu;
        private DateTime? ngayvaolam;
        private byte[] hinhanh;
        private bool trangthai;

        public string Manv { get => manv; set => manv = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Cmnd_cccd { get => cmnd_cccd; set => cmnd_cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public DateTime? Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public byte[] Hinhanh { get => hinhanh; set => hinhanh = value; }

        public NhanVien()
        {

        }
        public NhanVien(string manv,string tentk,string tennv,string cmnd_cccd,DateTime? ngaysinh,string gioitinh,string sdt,string diachi,string chucvu, byte[] hinhanh,DateTime? ngayvaolam,bool trangthai)
        {
            this.manv = manv;
            this.tentk = tentk;
            this.tennv = tennv;
            this.cmnd_cccd = cmnd_cccd;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.chucvu = chucvu;
            this.ngayvaolam = ngayvaolam;
            this.trangthai = trangthai;
            this.Hinhanh = hinhanh;
        }
    }
}
