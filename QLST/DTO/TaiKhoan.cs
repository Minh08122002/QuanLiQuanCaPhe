using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        string tentk;
        string matkhau;
        bool trangthai;
        bool chopheplogon;

        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public bool Chopheplogon { get => chopheplogon; set => chopheplogon = value; }

        public TaiKhoan(string tentk,string matkhau,bool trangthai,bool chopheplogon)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
            this.chopheplogon = chopheplogon;
            this.trangthai = trangthai;
        }
    }
}
