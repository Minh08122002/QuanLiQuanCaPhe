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
    public partial class fThemKhachHang : Form
    {
        bool ktrahoten = true, ktracmnd = true, ktrasdt = true;
        public fThemKhachHang()
        {
            InitializeComponent();
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

            //byte[] b = convert.ImageToByteArray(pictBHinhAnhKhachHang.Image);
            //Xử lí thay đổi thông tin khách hàng

            string makh, hoten, cmnd, diachi, sdt, gioitinh;
            DateTime? ngaysinh;
            makh = txtMaKH.Text;
            hoten = txtHoTen.Text;
            cmnd = txtCMNDorCCCD.Text;
            ngaysinh = dtPNgaySinh.Value;
            diachi = txtDiachi.Text;
            sdt = txtSDT.Text;
            gioitinh = cbGioiTinh.Text;
            bool trangthai = true;
            object[] o = new object[] { makh, hoten, cmnd, ngaysinh, gioitinh, sdt, diachi, trangthai };
            bool them = ThemKhachHangBUS.Instance.insertKhachHang(o);
            if (them == true)
            {
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnXacNhan.Enabled = false;
            btnXacNhan.BackColor = Color.FromArgb(228, 228, 228);
            unlockInformation(false);


        }



        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unlockInformation(bool b)
        {
            txtHoTen.Enabled = txtCMNDorCCCD.Enabled = txtCMNDorCCCD.Enabled = txtDiachi.Enabled = cbGioiTinh.Enabled = dtPNgaySinh.Enabled = txtSDT.Enabled = b;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN XÓA NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string makh = txtMaKH.Text;
                        object[] array = new object[] { makh, false };
                        bool delete = ThongTinKhachHangBUS.Instance.changeStatusKhachHang(array);
                        if (delete == true)
                        {
                            MessageBox.Show("Xóa thành công,khách hàng đã được chuyển vào thùng rác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void fThemKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = "KH" + ThemKhachHangBUS.Instance.getMaKhachHangMoi("KH");
            cbGioiTinh.SelectedItem = cbGioiTinh.Items[0];

            lblWarningHoTen.Visible = lblWarningSDT.Visible = lblWarningCMND_CCCD.Visible = false;


        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiachi_Click(object sender, EventArgs e)
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
