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
    public partial class fKhachHang : Form
    {

        private int pageNumber;
        private int page = 1;
        public fKhachHang()
        {
            InitializeComponent();
            loadPageNumber();
            numericUpDown1.Maximum = pageNumber;
            DataTable data = KhachHangBUS.Instance.binDingNamSinh(1);

        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            //KhachHangBUS.Instance.Xem(dtGVDanhSachNV);
            if (pageNumber == 0)
            {
                btnHienThi.Enabled = false;
                numericUpDown1.Maximum = pageNumber;
                return;
            }
            loadRecord(1);


        }
        private void loadPageNumber()
        {
            pageNumber = KhachHangBUS.Instance.loadPageNumber(1);
            for (int i = 1; i <= pageNumber; i++)
            {
                FontAwesome.Sharp.IconButton iconButton = new FontAwesome.Sharp.IconButton();
                iconButton.IconColor = Color.FromArgb(242, 135, 5);
                iconButton.ImageAlign = ContentAlignment.TopCenter;
                iconButton.Width = 43;
                iconButton.Height = 52;

                iconButton.IconChar = FontAwesome.Sharp.IconChar.Square;
                iconButton.TextAlign = ContentAlignment.MiddleCenter;
                iconButton.Text = i.ToString();
                iconButton.ForeColor = Color.FromArgb(242, 135, 5);
                iconButton.FlatAppearance.BorderSize = 0;
                iconButton.FlatStyle = FlatStyle.Flat;
                iconButton.Click += IconButton_Click;

                floPpage.Controls.Add(iconButton);
            }
        }

        private void IconButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int page = int.Parse(btn.Text);
            this.page = int.Parse(btn.Text);
            loadRecord(page);
        }
        private void loadRecord(int page)
        {
            string[] str = { "GIOITINH", "DIACHI", "TRANGTHAI" };
            KhachHangBUS.Instance.loadRecord(dtGVDanhSachKH, page, 1, str);
        }
        private void dtGVDanhSachNV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            page--;
            if (page == 0)
            {
                page++;
                return;
            }

            loadRecord(page);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            page++;
            if (page > pageNumber)
            {
                page--;
                return;
            }

            loadRecord(page);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            loadRecord((int)numericUpDown1.Value);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            KhachHangBUS.Instance.searchKhachHang(dtGVDanhSachKH, txtTimkiem.Text.ToString(), "MAKh", 1);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            loadRecord(1);
            floPpage.Controls.Clear();
            loadPageNumber();
            numericUpDown1.Maximum = pageNumber;
            if (pageNumber > 0)
            {
                btnHienThi.Enabled = true;
            }
            this.page = 1;
            floLPAllButton.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            fThemKhachHang f = new fThemKhachHang();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string makhsearch = dtGVDanhSachKH.SelectedRows[0].Cells[0].Value.ToString();
            dt = ThongTinKhachHangBUS.Instance.ThongTinKhachHang(makhsearch);
            string makh = dt.Rows[0].ItemArray[0].ToString();
            string tenkh = dt.Rows[0].ItemArray[1].ToString();
            string cmnd_cccd = dt.Rows[0].ItemArray[2].ToString();
            string ngaysinh = dt.Rows[0].ItemArray[3].ToString();
            string gioitinh = dt.Rows[0].ItemArray[4].ToString();
            string sdt = dt.Rows[0].ItemArray[5].ToString();
            string diachi = dt.Rows[0].ItemArray[6].ToString();
            bool trangthai = Boolean.Parse(dt.Rows[0].ItemArray[7].ToString());
            fThongTinKhachHang f = new fThongTinKhachHang(makh, tenkh, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, trangthai);
            f.Show();

        }


        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text) == true)
            {
                loadRecord(1);
                floLPAllButton.Enabled = true;
                return;
            }
            
            string[] array = { "GIOITINH", "DIACHI", "TRANGTHAI" };
            KhachHangBUS.Instance.searchKhachHang(dtGVDanhSachKH, txtTimkiem.Text.ToString(),1,array);
            floLPAllButton.Enabled = false;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            fKhachHangTemp f = new fKhachHangTemp();
            f.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            f.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            List<KhachHang> list = new List<KhachHang>();
            list = KhachHangBUS.Instance.getListKH();
            KhachHangBUS.Instance.exportFile(list, "Danh sách khách hàng", "Danh sách khách hàng");
        }
    }
}
