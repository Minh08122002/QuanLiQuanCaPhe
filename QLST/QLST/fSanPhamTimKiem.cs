using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLST
{
    public partial class fSanPhamTimKiem : Form
    {
        public fSanPhamTimKiem()
        {
            InitializeComponent();
        }
        public fSanPhamTimKiem(string strSearch)
        {
            InitializeComponent();
            dtGVKetQuaTimKiem.DataSource = HoaDonBUS.Instance.searchHangHoa(strSearch);
            
            string[] array = { "HINHANH","GiaGoc","TrangThai","Lsp","malsp","trangthailsp","Ncc", "MaVaTen" };
            foreach(string i in array)
            {
                dtGVKetQuaTimKiem.Columns[i].Visible = false;
            }

        }
        public delegate void HanghoaAdd(HangHoa h);
        public HanghoaAdd hanghoaAdd;

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dtGVKetQuaTimKiem.SelectedRows.Count > 0)
            {
                string masp=dtGVKetQuaTimKiem.SelectedRows[0].Cells[0].Value.ToString();
                List<HangHoa> list = HoaDonBUS.Instance.searchHangHoa(masp, "MASP");
                hanghoaAdd(list[0]);
                this.Close();
            }
        }

        private void lblHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string strSearch = txtTimKiem.Text;
            string[] arrayType = { "TenSP","MaSP" };
            dtGVKetQuaTimKiem.DataSource = HoaDonBUS.Instance.searchHangHoa(strSearch, arrayType);
           
        }

        private void dtGVKetQuaTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGVKetQuaTimKiem.SelectedRows.Count > 0)
            {
                string masp = dtGVKetQuaTimKiem.SelectedRows[0].Cells[0].Value.ToString();
                List<HangHoa> list = HoaDonBUS.Instance.searchHangHoa(masp, "MASP");
                HangHoa hh = null;
                hh = list[0];
                ImageToByte convert = new ImageToByte();
                Image img = null;
                convert.byteArrayToImage(hh.HinhAnh, ref img);
                pictureBox1.Image = img;
            }
            //pictureBox1.Image

        }
        //public string settingQuery(string txt, string type, string query)
        //{
        //    string querynew = null ;
        //    switch (type)
        //    {
        //        case "Ten":
        //            {
        //                query+="TenTH Like '%"+txt+"%' ";
        //            }break;
        //        case "DiaChi":
        //            {
        //                query += "DiaChi Like '%" + txt + "%' ";
        //            }break;

        //    }
        //    querynew = query;
        //    return querynew;
        //}
        //public void abc()
        //{
        //    string query = "select * from ThuongHieu ";
        //    if (txtTimKiem.Text==""&&)
        //    {


        //    }
        //    else
        //    {
        //        query += " where ";
        //        if (txtTimKiem.Text != "")
        //        {
        //            query=settingQuery(txtTimKiem.Text, "Ten", query);
        //        }




        //    }




        //}
    }
}
