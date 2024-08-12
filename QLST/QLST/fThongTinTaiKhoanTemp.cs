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
    public partial class fThongTinTaiKhoanTemp : Form
    {

        bool trangthai = true;
        bool ktramatkhau = false;
        NhanVien nv;
        public fThongTinTaiKhoanTemp()
        {
            InitializeComponent();
        }
        public fThongTinTaiKhoanTemp(TaiKhoan tk)
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


        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        




        private void fThongTinTaiKhoanTemp_Load(object sender, EventArgs e)
        {

            

        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unlockInformation(bool b)
        {
            txtMatKhau.Enabled = chkChoPhepLogon.Enabled = b;
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ KHÔI PHỤC LẠI TÀI KHOẢN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string tentk = txtTenTaiKhoan.Text;
                        object[] array = new object[] { tentk, true };
                        bool restore = TaiKhoanBUS.Instance.changeStatusTaiKhoan(array);
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
