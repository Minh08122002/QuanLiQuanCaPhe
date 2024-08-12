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
    public partial class fThongTinHoaDon : Form
    {
        int landau = 1;
        string manv = "";
        string makh = "";
        bool ktrakh = true;
        KhachHang kh = null;
        NhanVien nv = null;
        HoaDon hd;
        List<ChiTietHoaDon> list;
        public delegate void loadHoaDon();
        public loadHoaDon ld;
        public fThongTinHoaDon()
        {
            InitializeComponent();
        }
        private void EqualAdd(HangHoa h)
        {
            ChiTietHoaDonBUS.Instance.ThemHHVaoCTHD(hd, list, h);
            ChiTietHoaDonBUS.Instance.bindingInformationCTHD(hd, list, lsvDanhSachSP, imageListSp, cbMaNhanVien, txtMaHD, dtPNgayLap, txtTongTien, txtTienGiam, txtKhachTra, txtMaKH, txtTenKH);
        }
        public fThongTinHoaDon(List<ChiTietHoaDon> list,HoaDon hd)
        {

            InitializeComponent();
            this.list = new List<ChiTietHoaDon>();
            this.list = list;
            this.hd = null;
            this.hd = hd;

            ChiTietHoaDonBUS.Instance.bindingInformationCTHD(hd,list,lsvDanhSachSP,imageListSp,cbMaNhanVien , txtMaHD, dtPNgayLap, txtTongTien, txtTienGiam, txtKhachTra, txtMaKH, txtTenKH);
            
            
         
        }
       
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void floLPAllButton_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsvDanhSachSP.SelectedItems.Count == 1)
            {
                string masp = lsvDanhSachSP.SelectedItems[0].SubItems[1].Text;
                lsvDanhSachSP.Items.Remove(lsvDanhSachSP.SelectedItems[0]);
                for(int i = 0; i < list.Count; i++)
                {
                    if (masp == list[i].maHH)
                    {
                        
                        list.RemoveAt(i);
                        ChiTietHoaDonBUS.Instance.bindingInformationCTHD(hd,list, lsvDanhSachSP, imageListSp, cbMaNhanVien, txtMaHD, dtPNgayLap, txtTongTien, txtTienGiam, txtKhachTra, txtMaKH, txtTenKH);
                        break;
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvDanhSachSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachSP.SelectedItems.Count ==1)
            {
                ChiTietHoaDonBUS.Instance.bindingMoneyProduct(lsvDanhSachSP.SelectedItems[0],txtTenSP, txtSoLuong, txtGiamGia,txtDonGia, txtThanhTien);
            }
        }
        private void unlockInformation(bool b)
        {
            btnXacNhan.Enabled = b;
            btnThemSP.Enabled = btnXoa.Enabled = b;
            cbMaNhanVien.Enabled = txtMaKH.Enabled = b;
            txtSoLuong.Enabled = b;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            unlockInformation(true);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            bool ktrasoluong = true;
                            List<ChiTietHoaDon> listold = new List<ChiTietHoaDon>();
                            listold = ChiTietHoaDonBUS.Instance.searchCTHD(hd.Mahd);
                            for (int i = 0; i < list.Count; i++)
                            {
                                for (int j = 0; j < listold.Count; j++)
                                {
                                    if (list[i].maHH == listold[j].maHH)
                                    {
                                        MessageBox.Show(listold[j].Soluong.ToString());
                                        if (list[i].Soluong > list[i].Hh.SoLuong && list[i].Soluong > listold[j].Soluong && list[i].Soluong != listold[j].Soluong)
                                        {
                                            MessageBox.Show("Sản phẩm " + list[i].Hh.TenSP + " vượt quá số lượng: " + list[i].Hh.SoLuong, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            ktrasoluong = false;
                                        }
                                    }
                                }

                            }
                            if (ktrasoluong == false) return;
                            bool ktra = HoaDonBUS.Instance.updateHD(hd.Mahd.ToString(), this.makh, this.manv);
                            if (ktra == true)
                            {
                                ktra = ChiTietHoaDonBUS.Instance.updateChiTietHD(list, hd);
                                if (ktra == true)
                                {
                                    MessageBox.Show("Thay đổi thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ld();
                                    unlockInformation(false);
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } catch(Exception EE)
                        {
                            MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        


                    }
                    break;
                case DialogResult.No:
                    {

                    }break;
                default: break;
            }
            unlockInformation(false);

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            fSanPhamTimKiem f = new fSanPhamTimKiem();
            f.hanghoaAdd = new fSanPhamTimKiem.HanghoaAdd(EqualAdd);
            f.ShowDialog();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
            if (lsvDanhSachSP.SelectedItems.Count > 0)
            {
                if (txtSoLuong.Text == "")
                {
                    txtSoLuong.Text = "1";
                }
                if (RegularExpression.Instance.checkNumber(txtSoLuong.Text) == false)
                {
                    txtSoLuong.Text = txtSoLuong.Text.Remove(txtSoLuong.Text.Length - 1);
                    return;
                }
                string masp=lsvDanhSachSP.SelectedItems[0].SubItems[1].Text.ToString();
                int soluongnew =int.Parse(txtSoLuong.Text);
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].maHH == masp)
                    {
                        list[i].Soluong = soluongnew;
                        lsvDanhSachSP.SelectedItems[0].SubItems[3].Text = soluongnew.ToString();
                        break;
                    }
                }
               

            }
        }

        private void fThongTinHoaDon_Load(object sender, EventArgs e)
        {
            ChiTietHoaDonBUS.Instance.getListNhanVien(cbMaNhanVien);
            ChiTietHoaDonBUS.Instance.bindingInformationCTHD(hd, list, lsvDanhSachSP, imageListSp, cbMaNhanVien, txtMaHD, dtPNgayLap, txtTongTien, txtTienGiam, txtKhachTra, txtMaKH, txtTenKH);
        }

        private void cbMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string manv = cbMaNhanVien.Text;
            if (landau == 1)
            {
                landau++;
            }
            else
            {
                txtTenNV.Text = ChiTietHoaDonBUS.Instance.getTenNV(manv);
                nv = NhanVienBUS.Instance.getNhanVien(manv);
                this.manv = nv.Manv;
            }
                
            
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            if (txtMaKH.Text == "")
            {
                kh = null;
                this.makh = "";
                lblWarningKH.Visible = false;
                return;
            }
            string makh = txtMaKH.Text;
            bool ktrakh = KhachHangBUS.Instance.exsitKH(makh);
            if (ktrakh == true)
            {
                kh = ChiTietHoaDonBUS.Instance.getKH(makh);
                txtTenKH.Text = kh.Tenkh;
                lblWarningKH.Visible = false;
                this.makh = kh.Makh;
            }
            else
            {
                lblWarningKH.Visible = true;
                kh = null;
                this.makh = "";
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            f.ShowDialog();
        }
    }
}
