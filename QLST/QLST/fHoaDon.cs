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
    public partial class fHoaDon : Form
    {
        
        int loadSanPham = 0;
        int thanhtien = 0;
        List<HangHoa> list;
        HangHoa hhtemp;
        NhanVien nv = null;
        
        int soluongtemp = 0;
        public fHoaDon()
        {
            InitializeComponent();
            list = new List<HangHoa>();
            hhtemp = null;
        }
        public fHoaDon(NhanVien nv)
        {
            InitializeComponent();
            list = new List<HangHoa>();
            hhtemp = null;
            this.nv = nv;
        }

       

      

        
        private void EqualSearch(HangHoa h)
        {
            hhtemp = h;
            cbSearch.Text = h.MaSP +"  -  "+h.TenSP;
            nrUDSoLuong.Value = 1;
            txtDonViTinh.Text = h.DvTinh;
            txtTenSP.Text = h.TenSP;
            txtDonGia.Text = h.DonGia.ToString();
            
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text.Length > 0)
            {
                string search = cbSearch.Text;
                fSanPhamTimKiem f = new fSanPhamTimKiem(search);
                f.hanghoaAdd = new fSanPhamTimKiem.HanghoaAdd(EqualSearch);
                f.ShowDialog();
            }

        }

        
        

      

        private void btnTao_Click(object sender, EventArgs e)
        {
            
            if (dtgvSanPham.Rows.Count > 0)
            {
                try
                {
                    string manv = this.nv.Manv;

                    bool ktraAddHD = HoaDonBUS.Instance.AddHD(dtgvSanPham, int.Parse(txtMaHD.Text), txtMaKH.Text, manv, dtPNgaLap.Value);

                    if (ktraAddHD == true)
                    {
                        MessageBox.Show("Tạo hóa đơn thànhh công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //txtTenKH.Text = txtMaHD.Text = txtSDT.Text = txtKhachDua.Text = txtTienThua.Text = txtTongTienHD.Texts = cbSearch.Text = txtTenSP.Text = txtSoLuong.Text = txtDonGia.Text = txtDonGia.Text = "";
                        //dtgvSanPham.Rows.Clear();
                        //HoaDonBUS.Instance.binddingMaHD(txtMaHD);
                        //hhtemp = null;
                        btnRecord.Enabled = false;
                        txtSDT.Enabled = false;
                        nudKhachDua.Enabled = false;
                        btnTao.Enabled = false;
                        btnInHoadon.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception EE)
                {
                    MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
               
            }
            
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            //txtTenNV.Text = this.nv.Tennv;
            //txtMaNV.Text = this.nv.Manv;
            HoaDonBUS.Instance.binddingMaHD(txtMaHD);
            list = HoaDonBUS.Instance.takeListHangHoa();
            HoaDonBUS.Instance.addListHangHoa(cbSearch, list);

        }
        
        


        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            HoaDonBUS.Instance.addSDTAndTenKH(txtMaKH, txtTenKH, txtSDT.Text);
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
            if (dtgvSanPham.SelectedRows.Count > 0)
            {
                //for(int i = 0; i < dtgvSanPham.SelectedRows.Count; i++)
                //{
                //    dtgvSanPham.Rows.Remove(dtgvSanPham.SelectedRows[i]);
                //}
                foreach (DataGridViewRow row in dtgvSanPham.SelectedRows)
                {
                    thanhtien -= int.Parse(row.Cells["colThanhTien"].Value.ToString());
                    dtgvSanPham.Rows.Remove(row);

                }
                txtTongTienHD.Texts = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

       

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadSanPham == 1)
            {
                loadSanPham = 2;
                return;
            }
            if (cbSearch.SelectedIndex >= 0&&loadSanPham==2)
            {
                string[] split = cbSearch.Text.Split(new string[] { "  -  " }, StringSplitOptions.None);
                string masp = split[0];
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].MaSP == masp)
                    {
                        EqualSearch(list[i]);
                        return;
                    }
                }
            }
            else
            {
                loadSanPham = 1;
            }
        }

       

        private void btnRecord_Click(object sender, EventArgs e)
        {
           
            if (hhtemp == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm");
            }
            else
            {
                if (nrUDSoLuong.Value == 0)
                {
                    return;
                }
                int soluongsptrongdtgv = 0;
                for (int i = 0; i < dtgvSanPham.Rows.Count; i++)
                {
                    if (dtgvSanPham.Rows[i].Cells["colMaSP"].Value.ToString() == hhtemp.MaSP)
                    {
                        soluongsptrongdtgv = int.Parse(dtgvSanPham.Rows[i].Cells["colSoLuong"].Value.ToString());
                    }
                }

                int soluongtxt = (int)nrUDSoLuong.Value;
                int soluongall = soluongsptrongdtgv + soluongtxt;
                if (soluongall > hhtemp.SoLuong)
                {
                    MessageBox.Show("Vượt quá số lượng của cửa hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int soluong =(int) nrUDSoLuong.Value;

                HoaDonBUS.Instance.addRowInDataGridViewHoaDon(dtgvSanPham, hhtemp, soluong);
                thanhtien += hhtemp.DonGia * soluong - (int)(hhtemp.DonGia * soluong * hhtemp.GiamGia);
                //thanhtien=0;
                //for(int i = 0; i < dtgvSanPham.Rows.Count; i++)
                //{
                //    int dongia = int.Parse(dtgvSanPham.Rows[i].Cells["colDongia"].Value.ToString());
                //    int soluongsp = int.Parse(dtgvSanPham.Rows[i].Cells["colSoluong"].Value.ToString());
                //    float giamgiasp = float.Parse(dtgvSanPham.Rows[i].Cells["colGiamgia"].Value.ToString());
                //    thanhtien += dongia * soluongsp - (int)(dongia * soluongsp * giamgiasp);
                //}
                txtTongTienHD.Texts = thanhtien.ToString();
            }
        }

        private void cbSearch_TextChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = txtTenSP.Text=txtDonViTinh.Text= "";
            nrUDSoLuong.Value = 0;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void nrUDSoLuong_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInHoadon_Click(object sender, EventArgs e)
        {


            int mahd = int.Parse(txtMaHD.Text);
            HoaDon hd = HoaDonBUS.Instance.searchHoaDon(mahd);
            List<ChiTietHoaDon> listcthd = new List<ChiTietHoaDon>();
            listcthd = ChiTietHoaDonBUS.Instance.searchCTHD(mahd);
            string khachdua = nudKhachDua.Value.ToString();
            string tienthoi = txtTienThua.Text;
            string tongtien = txtTongTienHD.Texts;
            HoaDonBUS.Instance.exportFile(hd, listcthd, tongtien, khachdua, tienthoi);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnRecord.Enabled = true;
            txtSDT.Enabled = true;
            nudKhachDua.Enabled = true;
            btnTao.Enabled = true;
            txtMaKH.Text = txtSDT.Text = txtTenKH.Text = txtTienThua.Text   = "";
            nudKhachDua.Value = 0;
            txtTongTienHD.Texts = "0";

            btnInHoadon.Enabled = false;
        }

        private void nudKhachDua_ValueChanged(object sender, EventArgs e)
        {
            decimal tienkhachdua = nudKhachDua.Value;
            decimal tienthua = tienkhachdua - thanhtien;
            txtTienThua.Text = tienthua.ToString();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            fThemKhachHang f = new fThemKhachHang();
            f.Show();
        }

        private void dtgvSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSanPham.SelectedRows.Count > 0)
            {
               
                int rowindex = dtgvSanPham.CurrentCell.RowIndex;
                string strSoluong = dtgvSanPham.Rows[rowindex].Cells["colSoLuong"].Value.ToString();
                bool ktra = RegularExpression.Instance.checkNumber(strSoluong);
                if (ktra == true)
                {
                    int soluong = int.Parse(strSoluong);
                    string masp = dtgvSanPham.Rows[rowindex].Cells["colMaSP"].Value.ToString();
                    HangHoa hh = HoaDonBUS.Instance.searchHHtheoMa(masp);
                    if (soluong > hh.SoLuong)
                    {
                        MessageBox.Show("Số lượng vượt quá giới hạn: " + hh.SoLuong);
                        dtgvSanPham.Rows[rowindex].Cells["colSoLuong"].Value = soluongtemp;
                        dtgvSanPham.CurrentCell.Selected = false;
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Nhập không đúng định dạng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtgvSanPham.Rows[rowindex].Cells["colSoLuong"].Value = soluongtemp;
                    dtgvSanPham.CurrentCell.Selected = false;
                    return;
                }
            }
            
        }

        private void dtgvSanPham_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = dtgvSanPham.CurrentCell.RowIndex;
            soluongtemp =int.Parse(dtgvSanPham.Rows[rowindex].Cells["colSoLuong"].Value.ToString());

        }
    }
}
