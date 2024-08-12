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
    public partial class fSuaNhaCungCap : Form
    {
        public fSuaNhaCungCap()
        {
            InitializeComponent();
        }
        public fSuaNhaCungCap(NhaCungCap ncc)
        {
            InitializeComponent();
            txtMaNCC.Text = ncc.Mancc;
            txtTenNCC.Text = ncc.Tenncc;
            txtDiaChi.Text = ncc.Diachi;
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = true;
            btnCapnhat.BackColor = Color.FromArgb(242, 135, 5);
            btnCapnhat.ForeColor = Color.White;
            txtDiaChi.Enabled = txtTenNCC.Enabled = true;

        }
        public delegate void loaddata();
        public loaddata load;
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string tenncc = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string mancc = txtMaNCC.Text;
            bool ktra = HangHoaBUS.Instance.updateNCC(mancc, tenncc, diachi, 1);
            if (ktra == true)
            {
                MessageBox.Show("Sửa thành công", "THÔNG BÁO");
                load();
                btnCapnhat.BackColor = Color.Silver;
                btnCapnhat.ForeColor = Color.Black;
                txtDiaChi.Enabled = txtTenNCC.Enabled = false;
            }
            else MessageBox.Show("Lỗi", "THÔNG BÁO");

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
