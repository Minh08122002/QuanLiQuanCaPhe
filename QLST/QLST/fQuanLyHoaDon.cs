using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLST
{
    public partial class fQuanLyHoaDon : Form
    {
        public fQuanLyHoaDon()
        {
            InitializeComponent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGVDanhSachHD_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void fQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        public void loadHoaDon()
        {
            string query = "select * from HoaDon where TrangThaiHD=1";
            HoaDonBUS.Instance.addListHD(dtGVDanhSachHD,query);
            HoaDonBUS.Instance.bindingYearBill(cbNam);
        }
  

        private void dtGVDanhSachHD_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int mahd = int.Parse(dtGVDanhSachHD.Rows[e.RowIndex].Cells["colMaHD"].Value.ToString());
            List<ChiTietHoaDon> listcthd = new List<ChiTietHoaDon>();
            listcthd = ChiTietHoaDonBUS.Instance.searchCTHD(mahd);
            HoaDon hd = HoaDonBUS.Instance.searchHoaDon(mahd);
            fThongTinHoaDon f = new fThongTinHoaDon(listcthd,hd);
            f.ld = new fThongTinHoaDon.loadHoaDon(loadHoaDon);
            f.ShowDialog();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbNam_TextChanged(object sender, EventArgs e)
        {
            string query = HoaDonBUS.Instance.settingquery(cbNam, cbThang);
            if (txtSearch.Text != "" )
            {
                query+=string.Format(" and MAHD LIKE '%{0}%'",txtSearch.Text);
            }
            
            HoaDonBUS.Instance.addListHD(dtGVDanhSachHD, query);
        }

        private void cbThang_TextChanged(object sender, EventArgs e)
        {
            string query = HoaDonBUS.Instance.settingquery(cbNam, cbThang);
            if (txtSearch.Text != "")
            {
                query += string.Format(" and MAHD LIKE '%{0}%'", txtSearch.Text);
            }
           
            HoaDonBUS.Instance.addListHD(dtGVDanhSachHD, query);
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            string query = HoaDonBUS.Instance.settingquery(cbNam, cbThang);
            if (txtSearch.Text != "" )
            {
                query += string.Format(" and MAHD LIKE '%{0}%'", txtSearch.Text);
            }
          
            HoaDonBUS.Instance.addListHD(dtGVDanhSachHD, query);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dtGVDanhSachHD.SelectedRows.Count > 0)
            {
               
                DialogResult result = MessageBox.Show("Chắc chưa?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result) 
                {
                    case DialogResult.Yes:
                        {
                            string mahd = dtGVDanhSachHD.SelectedRows[0].Cells["colMaHD"].Value.ToString();
                            bool ktra = HoaDonBUS.Instance.updateStatusHD(mahd, false);
                            if (ktra == true)
                            {
                                MessageBox.Show("Đã xóa hóa đơn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string query = "select * from HoaDon where TrangThaiHD=1";
                                HoaDonBUS.Instance.addListHD(dtGVDanhSachHD, query);

                            }
                            else { MessageBox.Show("Lỗi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        break;
                    case DialogResult.No:
                        {

                        }break;
                    default: break;
                }

               

            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
