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
    public partial class fThongTinKhachHang : Form
    {
        string imgPath = null;
        bool trangthai = true;
        bool ktrahoten = false, ktracmnd = false, ktrasdt = false;
        bool checkUploadImage = false;
        public fThongTinKhachHang()
        {
            InitializeComponent();
        }
        public fThongTinKhachHang(string makh, string tenkh, string cmnd_cccd, string ngaysinh, string gioitinh, string sdt, string diachi, bool trangthai)
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


        public void unlockbtnXacNhan()
        {
            if (ktrahoten == true && ktracmnd == true && ktrasdt == true)
            {
                btnXacNhan.Enabled = true;
                btnXacNhan.BackColor = Color.FromArgb(242, 135, 5);
            }
            else
            {
                btnXacNhan.BackColor = Color.FromArgb(228, 228, 228);
                btnXacNhan.Enabled = false;

            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            //byte[] b = convert.ImageToByteArray(pictBHinhAnhNhanVien.Image);
            //Xử lí thay đổi thông tin nhân viên
            try
            {
                string makh, hoten, cmnd, diachi, sdt, gioitinh;
                DateTime? ngaysinh;
                makh = txtMaKH.Text;
                hoten = txtHoTen.Text;
                cmnd = txtCMNDorCCCD.Text;
                ngaysinh = dtPNgaySinh.Value;
                diachi = txtDiachi.Text;
                sdt = txtSDT.Text;
                gioitinh = cbGioiTinh.Text;
                bool trangthai = this.trangthai;
                object[] o = new object[] { makh, hoten, cmnd, ngaysinh, gioitinh, sdt, diachi, trangthai };
                bool them = ThongTinKhachHangBUS.Instance.updateThongTinKhachHang(o);
                if (them == true)
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnChinhSua.Enabled = true;
                btnChinhSua.BackColor = Color.FromArgb(242, 135, 5);
                btnXacNhan.Enabled = false;
                btnXacNhan.BackColor = Color.FromArgb(228, 228, 228);
                unlockInformation(false);
            }catch(Exception EE)
            {
                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }



        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void fThongTinKhachHang_Load(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = false;
            btnXacNhan.BackColor = Color.FromArgb(228, 228, 228, 228);
            lblWarningHoTen.Visible = lblWarningSDT.Visible = lblWarningCMND_CCCD.Visible = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unlockInformation(bool b)
        {
            txtHoTen.Enabled = txtCMNDorCCCD.Enabled = txtCMNDorCCCD.Enabled = txtDiachi.Enabled = cbGioiTinh.Enabled = dtPNgaySinh.Enabled = txtSDT.Enabled = b;
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
            btnXacNhan.BackColor = Color.FromArgb(242, 135, 5);
            btnChinhSua.BackColor = Color.FromArgb(228, 228, 228, 228);
            unlockInformation(true);
            btnChinhSua.Enabled = false;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN XÓA KHÁCH HÀNG", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string makh = txtMaKH.Text;
                        object[] array = new object[] { makh, false };
                        bool delete = ThongTinKhachHangBUS.Instance.changeStatusKhachHang(array);
                        if (delete == true)
                        {
                            MessageBox.Show("Xóa thành công, Khách Hàng đã được chuyển vào thùng rác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            bool ktraHoTen = RegularExpression.Instance.checkUnicode(txtHoTen.Text);
            if (ktraHoTen == false)
            {
                lblWarningHoTen.Visible = true;
                ktrahoten = false;
                unlockbtnXacNhan();

            }
            else
            {
                lblWarningHoTen.Visible = false;
                ktrahoten = true;
                unlockbtnXacNhan();
            }
        }

 

        private void txtCMNDorCCCD_TextChanged(object sender, EventArgs e)
        {
            bool ktraCMND = RegularExpression.Instance.checkNumber(txtCMNDorCCCD.Text);
            if (ktraCMND == false)
            {
                lblWarningCMND_CCCD.Visible = true;
                ktracmnd = false;
                unlockbtnXacNhan();
            }
            else
            {
                lblWarningCMND_CCCD.Visible = false;
                ktracmnd = true;
                unlockbtnXacNhan();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            bool ktraSDT = RegularExpression.Instance.checkNumber(txtSDT.Text);
            if (ktraSDT == false)
            {
                lblWarningSDT.Visible = true;
                ktrasdt = false;
                unlockbtnXacNhan();
            }
            else
            {
                lblWarningSDT.Visible = false;
                ktrasdt = true;
                unlockbtnXacNhan();
            }
        }
    }
}
