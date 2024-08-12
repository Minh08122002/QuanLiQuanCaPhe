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
    public partial class fThemTaiKhoan : Form
    {

        bool ktrataikhoan = false, ktramatkhau=false;

        public fThemTaiKhoan()
        {
            InitializeComponent();
        }


        public void unlockbtnXacNhan()
        {
            if (ktramatkhau==true&&ktrataikhoan==true)
            {
                btnXacNhan.Enabled = true;
                btnXacNhan.BackColor = Color.FromArgb(242, 135, 5);
                btnXacNhan.ForeColor = Color.White;

            }
            else
            {
                btnXacNhan.BackColor=Color.FromArgb(228, 228, 228);
                btnXacNhan.Enabled = false;
                btnXacNhan.ForeColor = Color.Black;
            }
            }
            private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unlockInformation(bool b)
        {
            txtTaiKhoan.Enabled=txtMatKhau.Enabled= b;
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {


            try
            {
                string tentk, matkhau; ;
                tentk = txtTaiKhoan.Text;
                matkhau = txtMatKhau.Text;

                bool chopheplogon = chkChoPhepLogon.Checked;
                bool trangthai = true;
                object[] o = new object[] { tentk, matkhau, chopheplogon, trangthai };
                bool them = TaiKhoanBUS.Instance.insertTaiKhoan(o);
                if (them == true)
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


                btnXacNhan.Enabled = false;
                btnXacNhan.BackColor = Color.FromArgb(228, 228, 228);
                unlockInformation(false);


            }catch(Exception EE)
            {
                MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }



        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
           
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
                        string manv = txtTaiKhoan.Text;
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

        private void fThemTaiKhoan_Load(object sender, EventArgs e)
        {
            
            

            lblWarningMatKhau.Visible = lblWarningTaiKhoan.Visible = false;


        }

        

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            bool ktraTaiKhoan = TaiKhoanBUS.Instance.checkTaiKhoanExist(txtTaiKhoan.Text);
            bool ktraTaiKhoanHople = RegularExpression.Instance.checkcharacterSpecial(txtTaiKhoan.Text);
            if(ktraTaiKhoanHople == true&& ktraTaiKhoan == true)
            {
                ktrataikhoan = true;
            }
            if (ktraTaiKhoanHople == false)
            {
                lblWarningTaiKhoan.Visible = true;
                ktrataikhoan = false;
                unlockbtnXacNhan();
            }
            if (ktraTaiKhoan==false)
            {
                lblWarningDaTonTai.Visible = true;
                ktrataikhoan = false;
                unlockbtnXacNhan();
            }
            if (txtTaiKhoan.Text == "")
            {
                lblWarningTaiKhoan.Visible = lblWarningDaTonTai.Visible = false;
                ktrataikhoan = false;
                unlockbtnXacNhan();
            }
            if (ktrataikhoan == true&&txtTaiKhoan.Text!="")
            {
                lblWarningTaiKhoan.Visible = lblWarningDaTonTai.Visible = false;
                unlockbtnXacNhan();
            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
            bool ktraMatKhauHople = RegularExpression.Instance.checkcharacterSpecial(txtMatKhau.Text);

            if (ktraMatKhauHople == false)
            {
                lblWarningMatKhau.Visible = true;
                ktramatkhau = false;
                unlockbtnXacNhan();
            }
            if (txtMatKhau.Text == "")
            {
                lblWarningMatKhau.Visible = false;
                ktramatkhau = false;
                unlockbtnXacNhan();
            }
            if (ktraMatKhauHople == true&&txtMatKhau.Text!="")
            {
                ktramatkhau = true;
                lblWarningMatKhau.Visible= false;
                unlockbtnXacNhan();
            }
        }


        

        
    }
}
