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
    public partial class fTaiKhoan : Form
    {
      
        private int pageNumber;
        private int page = 1;
        public fTaiKhoan()
        {
            InitializeComponent();
            loadPageNumber();
            numericUpDown1.Maximum = pageNumber;
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            //TaiKhoanBUS.Instance.Xem(dtGVDanhSachNV);
            if (pageNumber == 0)
            {
                btnHienThi.Enabled = false;
                numericUpDown1.Maximum = 1;
                return;
            }
            loadRecord(1);
           
            
        }
        private void loadPageNumber()
        {
            pageNumber = TaiKhoanBUS.Instance.loadPageNumber(1);
            for(int i = 1; i <= pageNumber; i++)
            {
                FontAwesome.Sharp.IconButton iconButton = new FontAwesome.Sharp.IconButton();
                iconButton.IconColor = Color.FromArgb(242, 135, 5);
                iconButton.ImageAlign = ContentAlignment.TopCenter;
                iconButton.Width = 43;
                iconButton.Height = 52;
               
                iconButton.IconChar = FontAwesome.Sharp.IconChar.Square;
                iconButton.TextAlign = ContentAlignment.MiddleCenter;
                iconButton.Text = i.ToString();
                iconButton.ForeColor= Color.FromArgb(242, 135, 5);
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
            string[] str = { "CHOPHEPLOGON","TRANGTHAI"};
            TaiKhoanBUS.Instance.loadRecord(dtGVDanhSachTK, page,1,str);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
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
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS.Instance.searchTaiKhoan(dtGVDanhSachTK, txtTimkiem.Text.ToString(),"TEN_TAIKHOAN",1);
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

            fThemTaiKhoan f = new fThemTaiKhoan();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void rjButton1_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
            
        //    string manvsearch = dtGVDanhSachTK.SelectedRows[0].Cells[0].Value.ToString();
        //    dt = ThongTinTaiKhoanBUS.Instance.ThongTinNhanVien(manvsearch);
        //    string manv = dt.Rows[0].ItemArray[0].ToString();
        //    string tentk = dt.Rows[0].ItemArray[1].ToString();
        //    string tennv = dt.Rows[0].ItemArray[2].ToString();
        //    string cmnd_cccd = dt.Rows[0].ItemArray[3].ToString();
        //    string ngaysinh = dt.Rows[0].ItemArray[4].ToString();
        //    string gioitinh = dt.Rows[0].ItemArray[5].ToString();
        //    string sdt = dt.Rows[0].ItemArray[6].ToString();
        //    string diachi = dt.Rows[0].ItemArray[7].ToString();
        //    string chucvu = dt.Rows[0].ItemArray[8].ToString();
        //    string ngayvaolam = dt.Rows[0].ItemArray[10].ToString();
        //    bool trangthai =Boolean.Parse( dt.Rows[0].ItemArray[11].ToString());
        //    byte[] array = (byte[])dt.Rows[0].ItemArray[9];
        //    ImageToByte convert = new ImageToByte();

        //    Image hinhanh = null;
        //    convert.byteArrayToImage(array, ref hinhanh);

        //    fThongTinTaiKhoan f = new fThongTinTaiKhoan(manv, tentk, tennv, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, chucvu, ngayvaolam, trangthai, hinhanh);
        //    f.Show();

        //}

        

        

        

        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text) == true)
            {
                loadRecord(1);
                floLPAllButton.Enabled = true;
                return;
            }
            string[] array = { "CHOPHEP_LOGON", "TRANGTHAITK" };
            TaiKhoanBUS.Instance.searchTaiKhoan(dtGVDanhSachTK, txtTimkiem.Text.ToString(), "TEN_TAIKHOAN", 1, array);
            floLPAllButton.Enabled = false;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            fTaiKhoanTemp f = new fTaiKhoanTemp();
            f.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            string tentaikhoan = dtGVDanhSachTK.SelectedRows[0].Cells[0].Value.ToString();
            TaiKhoan tk = TaiKhoanBUS.Instance.bindingInformation(tentaikhoan);

            fThongTinTaiKhoan f = new fThongTinTaiKhoan(tk);
            f.Show();
        }
    }
}
