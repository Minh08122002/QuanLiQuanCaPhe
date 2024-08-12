using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "Username")
            {
                txttaikhoan.Text = "";
                txttaikhoan.ForeColor = Color.Black;
            }
        }

        private void txttaikhoan_Leave(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "")
            {
                txttaikhoan.Text = "Username";
                txttaikhoan.ForeColor = Color.FromArgb(210,200,200);
            }
        }

        private void txtmatkhau_Enter(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "Password")
            {
                txtmatkhau.Text = "";
                txtmatkhau.UseSystemPasswordChar = true;
                txtmatkhau.ForeColor = Color.Black;
            }
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "")
            {
                txtmatkhau.Text = "Password";
                txtmatkhau.UseSystemPasswordChar = false;
                txtmatkhau.ForeColor = Color.FromArgb(210, 200, 200);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "Username" || txtmatkhau.Text == "Password")
            {
                lblThongBao.Text = "Chưa nhập tài khoản hoặc mật khẩu";
                return;
            }
            if (txttaikhoan.Text == "Admin" && txtmatkhau.Text == "123")
            {
                fChuongTrinhChinh f = new fChuongTrinhChinh();
                f.Show();
                this.Hide();
               ;
            }
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        
    }
}
