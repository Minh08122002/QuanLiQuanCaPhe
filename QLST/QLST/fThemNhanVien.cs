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
    public partial class fThemNhanVien : Form
    {
        string imgPath = null;
        bool ktrahoten = true, ktracmnd = true, ktrataikhoan = true, ktrasdt = true;
        bool checkUploadImage = false;
        public fThemNhanVien()
        {
            InitializeComponent();
        }


        public void unlockbtnXacNhan()
        {
            if (ktrahoten == true && ktracmnd == true && ktrasdt == true&&ktrataikhoan==true)
            {
                btnXacNhan.Enabled = true;
                btnXacNhan.BackColor = Color.FromArgb(242, 135, 5);
            }
            else
            {
                btnXacNhan.BackColor=Color.FromArgb(228, 228, 228);
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
            try {
                byte[] hinh;
                string manv, hoten, cmnd, diachi, sdt, chucvu, gioitinh, taikhoan;
                DateTime? ngaysinh;
                manv = txtMaNV.Text;
                hoten = txtHoTen.Text;
                cmnd = txtCMNDorCCCD.Text;
                ngaysinh = dtPNgaySinh.Value;
                diachi = txtDiachi.Text;
                sdt = txtSDT.Text;
                chucvu = cbChucvu.Text;
                gioitinh = cbGioiTinh.Text;
                taikhoan = txtTaiKhoan.Text;
                if (checkUploadImage == false)
                {
                    ImageToByte convert = new ImageToByte();

                    hinh = convert.ImageToByteArray(pictBHinhAnhNhanVien.Image);
                }
                else hinh = System.IO.File.ReadAllBytes(imgPath);
                bool trangthai = true;
                DateTime? ngayvaolam = dtPNgayvaolam.Value;
                object[] o = new object[] { manv, taikhoan, hoten, cmnd, ngaysinh, gioitinh, sdt, diachi, chucvu, hinh, ngayvaolam, trangthai };
                bool them = ThemNhanVienBUS.Instance.insertNhanVien(o);
                if (them == true)
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnUploadImage.Enabled = false;

                btnXacNhan.Enabled = false;
                btnXacNhan.BackColor = Color.FromArgb(228, 228, 228);
                unlockInformation(false);
                this.Close();
            }
            catch (Exception EE)
            {
                MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }



        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }



        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();

            OD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                pictBHinhAnhNhanVien.Image = Image.FromFile(OD.FileName);
                imgPath = OD.FileName;
                checkUploadImage = true;

            }

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unlockInformation(bool b)
        {
            txtHoTen.Enabled = txtCMNDorCCCD.Enabled = txtCMNDorCCCD.Enabled = txtDiachi.Enabled = cbChucvu.Enabled = cbGioiTinh.Enabled = txtTaiKhoan.Enabled = dtPNgaySinh.Enabled=txtSDT.Enabled=dtPNgayvaolam.Enabled = b;
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnXemDSTK.Enabled = btnThemTaiKhoan.Enabled = true;
            btnUploadImage.Enabled = true;
            btnXacNhan.Enabled = true;
            btnXacNhan.BackColor = Color.FromArgb(242, 135, 5);

            unlockInformation(true);

            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("BẠN CÓ MUỐN XÓA NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result) {
                case DialogResult.Yes:
                    {
                        string manv = txtMaNV.Text;
                        object[] array = new object[] { manv, false };
                        bool delete = ThongTinNhanVienBUS.Instance.changeStatusNhanVien(array);
                        if (delete == true)
                        {
                            MessageBox.Show("Xóa thành công, nhân viên đã được chuyển vào thùng rác","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Fail", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }break;
                case DialogResult.No:
                    {

                    }break;
            }
        }

        private void fThemNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text ="NV"+ ThemNhanVienBUS.Instance.getMaNhanVienMoi("NV");
            cbChucvu.SelectedItem = cbChucvu.Items[1];
            cbGioiTinh.SelectedItem = cbGioiTinh.Items[0];

            lblWarningHoTen.Visible = lblWarningSDT.Visible = lblWarningCMND_CCCD.Visible=lblWarningTaiKhoan.Visible = false;


        }

        private void cbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucvu.SelectedItem.ToString() == "Quản trị viên")
                txtMaNV.Text = "AD" + ThemNhanVienBUS.Instance.getMaNhanVienMoi("AD");
            else
                txtMaNV.Text = "NV" + ThemNhanVienBUS.Instance.getMaNhanVienMoi("NV");

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            bool ktraTaiKhoan = ThemNhanVienBUS.Instance.checkTaiKhoan(txtTaiKhoan.Text);
            if (txtTaiKhoan.Text == "")
            {
                lblWarningTaiKhoan.Visible = false;
                ktrataikhoan = true;
                unlockbtnXacNhan();
            }
            else
            {
                if (ktraTaiKhoan == false)
                {
                    lblWarningTaiKhoan.Visible = true;
                    ktrataikhoan = false;
                    unlockbtnXacNhan();

                }
                else
                {
                    lblWarningTaiKhoan.Visible = false;
                    ktrataikhoan = true;
                    unlockbtnXacNhan();
                }
            }
            
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f = new fThemTaiKhoan();
            f.Show();
        }

        private void btnXemDSTK_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            f.Show();
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
