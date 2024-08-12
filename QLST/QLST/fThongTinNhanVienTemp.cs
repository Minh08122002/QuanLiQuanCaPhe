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
    public partial class fThongTinNhanVienTemp : Form
    {
        bool trangthai = true;

        public fThongTinNhanVienTemp()
        {
            InitializeComponent();
        }
        public fThongTinNhanVienTemp(string manv, string tentk, string tennv, string cmnd_cccd, string ngaysinh, string gioitinh, string sdt, string diachi, string chucvu, string ngayvaolam, bool trangthai, Image hinhanh)
        {
            InitializeComponent();
            txtMaNV.Text = manv;
            txtHoTen.Text = tennv;
            txtTaiKhoan.Text = tentk;
            txtDiachi.Text = diachi;
            cbGioiTinh.Text = gioitinh;
            cbChucvu.Text = chucvu;
            dtPNgaySinh.Value = DateTime.Parse(ngaysinh);
            txtCMNDorCCCD.Text = cmnd_cccd;
            txtSDT.Text = sdt;
            if (hinhanh != null)
            {
                pictBHinhAnhNhanVien.Image = hinhanh;
            }
            dtPNgayvaolam.Value = DateTime.Parse(ngayvaolam);
            this.trangthai = trangthai;

            //////
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThongTinNhanVienTemp_Load(object sender, EventArgs e)
        {
           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ KHÔI PHỤC LẠI NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string manv = txtMaNV.Text;
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
