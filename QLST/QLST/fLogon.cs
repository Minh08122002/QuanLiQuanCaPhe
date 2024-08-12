using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLST
{
    public partial class fLogon : Form
    {
        public fLogon()
        {
            InitializeComponent();
        }
        int count = 2;
        
        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }

        private void fLogon_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            string query = "select * from TaiKhoan where TrangThaiTK=1";
            List<TaiKhoan> list = new List<TaiKhoan>();
            
            list = TaiKhoanBUS.Instance.dsTaiKhoan(query);
            
            TaiKhoan tk = null;
            bool ktratontai = false;
            foreach (TaiKhoan item in list)
            {
                if (item.Tentk == txtAccount.Texts && item.Matkhau == txtPassword.Texts)
                {
                    
                    tk = item;
                    ktratontai = true;
                    if (item.Chopheplogon == false)
                    {
                        MessageBox.Show("TÀI KHOẢN KHÔNG ĐƯỢC PHÉP ĐĂNG NHẬP", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                }
            }

            if (ktratontai == true)
            {
                NhanVien nv = null;
                nv = NhanVienBUS.Instance.searchNhanvienTheoTenTaiKhoan(tk.Tentk);
                if (nv == null)
                {
                    MessageBox.Show("TÀI KHOẢN CHƯA CÓ NHÂN VIÊN SỬ DỤNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                fLoading f = new fLoading(nv);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("THÔNG TIN TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG CHÍNH XÁC", "THÔNG BÁO",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
