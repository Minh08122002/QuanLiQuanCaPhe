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
    public partial class Form1 : Form
    {
        NhanVien nv = null;
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        public Form1(NhanVien nv)
        {
            InitializeComponent();
            customizeDesing();
            this.nv = nv;
            if(this.nv.Chucvu!="Quản trị viên")
            {
                btnKhachHang.Enabled = btnNhanVien.Enabled = btnKhoHang.Enabled = btnThongKe.Enabled = btnHoaDon.Enabled=btnSanPham.Enabled = false;
                btnKhachHang.BackColor = btnNhanVien.BackColor = btnKhoHang.BackColor = btnThongKe.BackColor = btnHoaDon.BackColor =btnSanPham.BackColor= Color.FromArgb(222, 222, 222);
                btnKhachHang.IconColor = btnNhanVien.IconColor = btnKhoHang.IconColor = btnThongKe.IconColor = btnHoaDon.IconColor = btnSanPham.IconColor=Color.FromArgb(74, 74, 74);

            }

        }
        
        private void loadform(object Form)
        {
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(f);
            this.panelContent.Tag = f;
            f.Show();
           
        }

        private void customizeDesing()
        {
            panelSubitemSanPham.Visible = false;
            panelSubitemKhoHang.Visible = false;

        }
        private void hideSubitem()
        {
            if (panelSubitemSanPham.Visible == true)
            {
                panelSubitemSanPham.Visible = false;
            }
            if (panelSubitemKhoHang.Visible == true)
            {
                panelSubitemKhoHang.Visible = false;
            }
        }
        private void hideSubitem(Panel panelSubitemhide)
        {
            panelSubitemhide.Visible = false;
        }
        private void showSubitem(Panel panelSubitem)
        {
            if (panelSubitem.Visible == false)
            {
                panelSubitem.Visible = true;
            }
            else panelSubitem.Visible = false;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            btnNhanVien.ImageAlign = ContentAlignment.MiddleRight;
            btnNhanVien.BackColor= Color.FromArgb(74, 115, 70);
            btnLapHoaDon.ImageAlign = btnKhachHang.ImageAlign = btnHoaDon.ImageAlign = btnKhoHang.ImageAlign = btnSanPham.ImageAlign = btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.BackColor =btnKhoHang.BackColor = btnThongKe.BackColor = btnHoaDon.BackColor = btnSanPham.BackColor=btnLapHoaDon.BackColor = Color.FromArgb(128, 189, 158);
            loadform(new fNhanVien());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            btnSanPham.ImageAlign = ContentAlignment.MiddleRight;
            btnSanPham.BackColor= Color.FromArgb(74, 115, 70);
            btnLapHoaDon.ImageAlign = btnKhachHang.ImageAlign = btnNhanVien.ImageAlign = btnKhoHang.ImageAlign = btnHoaDon.ImageAlign = btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.BackColor = btnNhanVien.BackColor = btnKhoHang.BackColor = btnThongKe.BackColor = btnHoaDon.BackColor = btnLapHoaDon.BackColor= Color.FromArgb(128, 189, 158);
            showSubitem(panelSubitemSanPham);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            btnKhoHang.ImageAlign = ContentAlignment.MiddleRight;
            btnKhoHang.BackColor = Color.FromArgb(74, 115, 70);
            btnLapHoaDon.ImageAlign = btnKhachHang.ImageAlign = btnNhanVien.ImageAlign = btnHoaDon.ImageAlign = btnSanPham.ImageAlign = btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.BackColor = btnNhanVien.BackColor = btnSanPham.BackColor = btnThongKe.BackColor = btnHoaDon.BackColor = btnLapHoaDon.BackColor = Color.FromArgb(128, 189, 158);
            showSubitem(panelSubitemKhoHang);
        }

        private void panelLoGo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            btnLapHoaDon.ImageAlign = ContentAlignment.MiddleRight;
            btnLapHoaDon.BackColor = Color.FromArgb(74, 115, 70);
            btnHoaDon.ImageAlign = btnKhachHang.ImageAlign = btnNhanVien.ImageAlign = btnKhoHang.ImageAlign = btnSanPham.ImageAlign = btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.BackColor = btnNhanVien.BackColor = btnKhoHang.BackColor = btnThongKe.BackColor = btnHoaDon.BackColor = btnSanPham.BackColor = Color.FromArgb(128, 189, 158);
            loadform(new fHoaDon(this.nv));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            btnHoaDon.ImageAlign = ContentAlignment.MiddleRight;
            btnHoaDon.BackColor = Color.FromArgb(74, 115, 70);
            btnLapHoaDon.ImageAlign = btnKhachHang.ImageAlign=btnNhanVien.ImageAlign=btnKhoHang.ImageAlign=btnSanPham.ImageAlign=btnThongKe.ImageAlign=ContentAlignment.MiddleLeft;
            btnKhachHang.BackColor = btnNhanVien.BackColor = btnKhoHang.BackColor = btnThongKe.BackColor = btnSanPham.BackColor = btnLapHoaDon.BackColor = Color.FromArgb(128, 189, 158);
            fQuanLyHoaDon f = new fQuanLyHoaDon();
            f.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            btnKhachHang.ImageAlign = ContentAlignment.MiddleRight;
            btnKhachHang.BackColor= Color.FromArgb(74, 115, 70);
            btnLapHoaDon.ImageAlign = btnHoaDon.ImageAlign = btnNhanVien.ImageAlign = btnKhoHang.ImageAlign = btnSanPham.ImageAlign = btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.BackColor = btnNhanVien.BackColor = btnKhoHang.BackColor = btnThongKe.BackColor = btnHoaDon.BackColor = btnLapHoaDon.BackColor = Color.FromArgb(128, 189, 158);
            loadform(new fKhachHang());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubitemXuatKho_Click(object sender, EventArgs e)
        {

        }

        private void panelSubitemKhoHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubitemLoaiSanPham_Click(object sender, EventArgs e)
        {
            loadform(new fLoaiSanPhamMoi());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void panelSubitemSanPham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubitemSanPham_Click(object sender, EventArgs e)
        {
            loadform(new fHangHoa());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubitemNhaCC_Click(object sender, EventArgs e)
        {
            loadform(new fNhaCC());
        }

        private void btnSubitemKho_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubitemNhapKho_Click(object sender, EventArgs e)
        {

        }
    }
}
