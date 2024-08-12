using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        private string malsp;
        private string tenlsp;
        private bool trangthai;

        public string Malsp { get => malsp; set => malsp = value; }
        public string Tenlsp { get => tenlsp; set => tenlsp = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public LoaiSanPham(string malsp,string tenlsp,bool trangthai)
        {
            this.malsp = malsp;
            this.tenlsp = tenlsp;
            this.trangthai = trangthai;
        }
    }
}
