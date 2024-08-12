using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string mancc;
        private string tenncc;
        private string diachi;
        private bool trangthai;

        public string Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }

        public NhaCungCap(string mancc, string tenncc, string diachi, bool trangthai)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.diachi = diachi;
            this.trangthai = trangthai;
        }
    }
}
