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
using DTO;
namespace QLST
{
    public partial class fThongTinTaiKhoan : Form
    {

        bool trangthai = true;
        bool ktramatkhau = false;
        NhanVien nv;
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public fThongTinTaiKhoan(TaiKhoan tk)
        {
            InitializeComponent();
            txtTenTaiKhoan.Text = tk.Tentk;
            txtMatKhau.Text = tk.Matkhau;
            nv = TaiKhoanBUS.Instance.searchNhanVienOfTaiKhoan(tk.Tentk);
            txtMaNV.Text = nv.Manv;
            if (txtMaNV.Text == "")
            {
                btnXemThongTinNV.Enabled = false;
                btnXemThongTinNV.BackColor = Color.FromArgb(225, 225, 225);
            }
            this.trangthai = tk.Trangthai;
            chkChoPhepLogon.Checked = tk.Chopheplogon;

            //////
        }


        public void unlockbtnXacNhan()
        {
            if (ktramatkhau == true)
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
                string tentaikhoan, matkhau;
                bool chopheplogon, trangthai;
                tentaikhoan = txtTenTaiKhoan.Text;
                matkhau = txtMatKhau.Text;
                chopheplogon = chkChoPhepLogon.Checked;
                trangthai = this.trangthai;
                bool update = TaiKhoanBUS.Instance.updateTaiKhoan(tentaikhoan, matkhau, chopheplogon, trangthai);
                if (update == true)
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


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





        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

            btnXacNhan.Enabled = false;
            btnXacNhan.BackColor = Color.FromArgb(228, 228, 228, 228);
            lblWarningMatKhau.Visible=chkChoPhepLogon.Enabled= false;

        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unlockInformation(bool b)
        {
            txtMatKhau.Enabled = chkChoPhepLogon.Enabled = b;
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
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN XÓA TÀI KHOẢN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string tentaikhoan = txtTenTaiKhoan.Text;
                        object[] array = new object[] { tentaikhoan, false };
                        bool delete = TaiKhoanBUS.Instance.changeStatusTaiKhoan(array);
                        if (delete == true)
                        {
                            MessageBox.Show("Xóa thành công, tài khoản đã được chuyển vào thùng rác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            bool ktramatkhau = RegularExpression.Instance.checkcharacterSpecial(txtMatKhau.Text);
            if (ktramatkhau == false)
            {
                lblWarningMatKhau.Visible = true;
                this.ktramatkhau = false;
                unlockbtnXacNhan();
            }
            else
            {
                lblWarningMatKhau.Visible = false;
                this.ktramatkhau = true;
                unlockbtnXacNhan();
            }
        }

        private void btnXemThongTinNV_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string manvsearch = txtMaNV.Text;
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
            bool trangthai = Boolean.Parse(dt.Rows[0].ItemArray[11].ToString());
            Image hinhanh = null;
            if (dt.Rows[0].ItemArray[9].ToString() != "")
            {
                byte[] array = (byte[])dt.Rows[0].ItemArray[9];
                ImageToByte convert = new ImageToByte();
                convert.byteArrayToImage(array, ref hinhanh);
            }






            fThongTinNhanVien f = new fThongTinNhanVien(manv, tentk, tennv, cmnd_cccd, ngaysinh, gioitinh, sdt, diachi, chucvu, ngayvaolam, trangthai, hinhanh);
            f.Show();
        }

        private void iconButton1_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }   
}
