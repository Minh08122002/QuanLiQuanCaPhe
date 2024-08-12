using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
namespace QLST
{
    public partial class fThongTinKhachHangTemp : Form
    {
        bool trangthai = true;

        public fThongTinKhachHangTemp()
        {
            InitializeComponent();
        }
        public fThongTinKhachHangTemp(string makh, string tenkh, string cmnd_cccd, string ngaysinh, string gioitinh, string sdt, string diachi, bool trangthai)
        {
            InitializeComponent();
            txtMaKH.Text = makh;
            txtHoTen.Text = tenkh;
            txtDiachi.Text = diachi;
            cbGioiTinh.Text = gioitinh;
            dtPNgaySinh.Value = DateTime.Parse(ngaysinh);
            txtCMNDorCCCD.Text = cmnd_cccd;
            txtSDT.Text = sdt;
            this.trangthai = trangthai;

            //////
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThongTinKhachHangTemp_Load(object sender, EventArgs e)
        {


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ KHÔI PHỤC LẠI KHÁCH HÀNG", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string manv = txtMaKH.Text;
                        object[] array = new object[] { manv, true };
                        bool restore = ThongTinKhachHangBUS.Instance.changeStatusKhachHang(array);
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


        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiachi_Click(object sender, EventArgs e)
        {

        }
    }
}
