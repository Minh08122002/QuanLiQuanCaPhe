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
    public partial class fThongTinNhanVien : Form
    {
        string imgPath = null;
        bool trangthai = true;
        bool ktrahoten = false, ktracmnd = false, ktrataikhoan = false, ktrasdt = false;
        bool checkUploadImage = false;
        public fThongTinNhanVien()
        {
            InitializeComponent();
        }
        public fThongTinNhanVien(string manv,string tentk,string tennv, string cmnd_cccd,string ngaysinh,string gioitinh, string sdt,string diachi,string chucvu,string ngayvaolam,bool trangthai,Image hinhanh)
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


        public void unlockbtnXacNhan()
        {
            if (ktrahoten == true && ktracmnd == true && ktrasdt == true)
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
            try
            {
                byte[] hinh = null;
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
                    if (pictBHinhAnhNhanVien.Image != null)
                    {
                        ImageToByte convert = new ImageToByte();
                        hinh = convert.ImageToByteArray(pictBHinhAnhNhanVien.Image);
                    }
                }
                else hinh = System.IO.File.ReadAllBytes(imgPath);
                bool trangthai = this.trangthai;
                string ngayvaolam = dtPNgayvaolam.Value.ToString();
                object[] o = new object[] { manv, taikhoan, hoten, cmnd, ngaysinh, gioitinh, sdt, diachi, chucvu, hinh, ngayvaolam, trangthai };
                bool them = ThongTinNhanVienBUS.Instance.updateThongTinNhanVien(o);
                if (them == true)
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnUploadImage.Enabled = false;
                btnChinhSua.Enabled = true;
                btnChinhSua.BackColor = Color.FromArgb(242, 135, 5);
                btnXacNhan.Enabled = false;
                btnXacNhan.BackColor = Color.FromArgb(228, 228, 228);
                unlockInformation(false);
            }
            catch (Exception EE)
            {
                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                


        }



        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void fThongTinNhanVien_Load(object sender, EventArgs e)
        {
            btnUploadImage.Enabled = false;
            btnXacNhan.Enabled = false;
            btnXacNhan.BackColor = Color.FromArgb(228, 228, 228, 228);
            lblWarningHoTen.Visible = lblWarningSDT.Visible = lblWarningCMND_CCCD.Visible=lblWarningTaiKhoan.Visible = false;

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
            btnUploadImage.Enabled = true;
            btnXacNhan.Enabled = true;
            btnXacNhan.BackColor = Color.FromArgb(242, 135, 5);
            btnChinhSua.BackColor = Color.FromArgb(228, 228, 228,228);
            unlockInformation(true);
            btnChinhSua.Enabled = false;
            

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

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

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
        if (ktraCMND == false||txtCMNDorCCCD.Text.Length<9||txtCMNDorCCCD.Text.Length>13)
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
            if (ktraSDT == false||txtSDT.Text.Length<10)
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
