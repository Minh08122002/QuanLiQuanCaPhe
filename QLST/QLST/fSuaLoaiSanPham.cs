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

namespace QLST
{
    public partial class fSuaLoaiSanPham : Form
    {
        public fSuaLoaiSanPham()
        {
            InitializeComponent();
        }
        public delegate void getdata();
        public getdata get;
        bool trangthai = true;
        bool KT = true;
        private void fSuaLoaiSanPham_Load(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = false;
            btnCapnhat.Visible = false;
            btnHuy.Enabled = false;
            btnHuy.Visible = false;
        }
        public fSuaLoaiSanPham(string malsp, string tenlsp, bool trangthai)
        {
            InitializeComponent();
            txtMaLSP.Text = malsp;
            txtTenLSP.Text = tenlsp;
            this.trangthai = trangthai;
        }
        public bool sualsp()
        {
            string malsp, tenlsp;
            bool trangthai;
            malsp = txtMaLSP.Text;
            tenlsp = txtTenLSP.Text;
            trangthai = true;
            object[] LoaiSanPham = new object[] { malsp, tenlsp, trangthai };
            return HangHoaBUS.Instance.suaLoaiSanPham(LoaiSanPham);
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {

            btnCapnhat.Enabled = true;
            btnCapnhat.Visible = true;
            btnHuy.Enabled = true;
            btnHuy.Visible = true;

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (KT)
            {
                if (sualsp())
                {
                    MessageBox.Show("Sửa Sản Phẩm Thành Công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    get();
                }

            }
            else
                MessageBox.Show("Sửa Sản Phẩm Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSuaSP.Visible = true;
            btnCapnhat.Enabled = false;
            btnCapnhat.Visible = false;
            btnHuy.Enabled = false;
            btnHuy.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
