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

namespace QLST
{
    public partial class fNhanVienTemp : Form
    {
      
        private int pageNumber;
        private int page = 1;
        public fNhanVienTemp()
        {
            InitializeComponent();
            loadPageNumber();
            numericUpDown1.Maximum = pageNumber;
            DataTable data = NhanVienBUS.Instance.binDingNamSinh(0);
            cbNamsinh.ValueMember = "NAMSINH";
            cbNamsinh.DisplayMember = "YEAR";
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cbNamsinh.Items.Add(data.Rows[i].ItemArray[0].ToString());
            }
        }

        private void fNhanVienTemp_Load(object sender, EventArgs e)
        {
            //NhanVienBUS.Instance.Xem(dtGVDanhSachNV);
            if (pageNumber == 0)
            {
                btnHienThi.BackColor = btnKhoiPhuc.BackColor = Color.FromArgb(225, 225, 225);
                btnKhoiPhuc.Enabled = btnHienThi.Enabled = false;
                numericUpDown1.Maximum = 1;
                return;
            }
            loadRecord(1);
            numericUpDown1.Maximum = pageNumber;
            
        }
        private void loadPageNumber()
        {
            pageNumber = NhanVienBUS.Instance.loadPageNumber(0);
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
            string[] str = { "CMND_CCCD", "NGAYSINH", "GIOITINH", "DIACHI", "NGAYVAOLAM", "TRANGTHAI","HINHANH"};
            NhanVienBUS.Instance.loadRecord(dtGVDanhSachNV, page,0,str);
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
            //NhanVienBUS.Instance.searchNhanvien(dtGVDanhSachNV, txtTimkiem.Text.ToString(), "MANV",0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadRecord(1);
            floPpage.Controls.Clear();
            btnKhoiPhuc.Enabled = btnHienThi.Enabled = true;
            loadPageNumber();
            if(pageNumber==0)
            numericUpDown1.Maximum =1 ;
            this.page = 1;
            floLPAllButton.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            fThemNhanVien f = new fThemNhanVien();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            string manvsearch = dtGVDanhSachNV.SelectedRows[0].Cells[0].Value.ToString();
            dt = ThongTinNhanVienBUS.Instance.ThongTinNhanVien(manvsearch);
            string manv = dt.Rows[0].ItemArray[0].ToString();
            string tentk = dt.Rows[0].ItemArray[1].ToString();
            string tennv = dt.Rows[0].ItemArray[2].ToString();
            string cmnd_cccd = dt.Rows[0].ItemArray[3].ToString();
            string ngaysinh = dt.Rows[0].ItemArray[4].ToString();
            string gioitinh = dt.Rows[0].ItemArray[5].ToString();
            string sdt = dt.Rows[0].ItemArray[6].ToString();
            string diachi = dt.Rows[0].ItemArray[7].ToString();
            string chucvu = dt.Rows[0].ItemArray[8].ToString();
            string ngayvaolam = dt.Rows[0].ItemArray[10].ToString();
            bool trangthai =Boolean.Parse( dt.Rows[0].ItemArray[11].ToString());
            Image hinhanh = null;
            if (dt.Rows[0].ItemArray[9].ToString() != "")
            {
                ImageToByte convert = new ImageToByte();
                byte[] array = (byte[])dt.Rows[0].ItemArray[9];
                convert.byteArrayToImage(array, ref hinhanh);
               
            }
            fThongTinNhanVienTemp f = new fThongTinNhanVienTemp(manv, tentk, tennv, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, chucvu, ngayvaolam, trangthai, hinhanh);
            f.Show();

        }

        

        

        private void cbNamsinh_TextChanged(object sender, EventArgs e)
        {
            string strText = cbDKSearch.Text;
            string type = "";
            switch (strText)
            {
                case "Theo tên":
                    type = "TENNV"; break;
                case "Theo mã":
                    type = "MANV"; break;
                case "Theo CMND":
                    type = "CMND_CCCD"; break;
                case "Theo địa chỉ":
                    type = "DIACHI"; break;
                case "Theo SĐT":
                    type = "SDT"; break;
            }
            string[] str = { "CMND_CCCD", "NGAYSINH", "GIOITINH", "DIACHI", "NGAYVAOLAM", "TRANGTHAINV", "HINHANH" };
            NhanVienBUS.Instance.searchNhanvien(dtGVDanhSachNV, txtTimkiem.Text, type, cbChucvu, cbNamsinh, 0, str);
            foreach (string c in str)
            {
                dtGVDanhSachNV.Columns[c].Visible = false;
            }
            floLPAllButton.Enabled = false;
        }

      

        private void cbChucvu_TextChanged(object sender, EventArgs e)
        {
            string strText = cbDKSearch.Text;
            string type = "";
            switch (strText)
            {
                case "Theo tên":
                    type = "TENNV"; break;
                case "Theo mã":
                    type = "MANV"; break;
                case "Theo CMND":
                    type = "CMND_CCCD"; break;
                case "Theo địa chỉ":
                    type = "DIACHI"; break;
                case "Theo SĐT":
                    type = "SDT"; break;
            }
            string[] str = { "CMND_CCCD", "NGAYSINH", "GIOITINH", "DIACHI", "NGAYVAOLAM", "TRANGTHAINV", "HINHANH" };
            NhanVienBUS.Instance.searchNhanvien(dtGVDanhSachNV, txtTimkiem.Text, type, cbChucvu, cbNamsinh, 0, str);
            foreach (string c in str)
            {
                dtGVDanhSachNV.Columns[c].Visible = false;
            }

        }


        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text) == true)
            {
                loadRecord(1);
                floLPAllButton.Enabled = true;
                return;
            }
            //Theo tên
            //Theo mã
            //Theo CMND
            //Theo địa chỉ
            //Theo SĐT
            string strText = cbDKSearch.Text;
            string type = "";
            switch (strText)
            {
                case "Theo tên":
                    type = "TENNV"; break;
                case "Theo mã":
                    type = "MANV"; break;
                case "Theo CMND":
                    type = "CMND_CCCD"; break;
                case "Theo địa chỉ":
                    type = "DIACHI"; break;
                case "Theo SĐT":
                    type = "SDT"; break;
            }
            string[] array = { "CMND_CCCD", "NGAYSINH", "GIOITINH", "DIACHI", "NGAYVAOLAM", "TRANGTHAINV", "HINHANH" };
            NhanVienBUS.Instance.searchNhanvien(dtGVDanhSachNV, txtTimkiem.Text.ToString(), type, cbChucvu, cbNamsinh, 0, array);
            floLPAllButton.Enabled = false;

        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ KHÔI PHỤC LẠI NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string manv = dtGVDanhSachNV.SelectedRows[0].Cells[0].Value.ToString();
                        object[] array = new object[] { manv, true };
                        bool restore = ThongTinNhanVienBUS.Instance.changeStatusNhanVien(array);
                        if (restore == true)
                        {
                            MessageBox.Show("Khôi phục thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Fail", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case DialogResult.No:
                    {

                    }
                    break;
            }
        }

    }
}
