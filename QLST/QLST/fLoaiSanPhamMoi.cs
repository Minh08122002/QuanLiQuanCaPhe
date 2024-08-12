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
    public partial class fLoaiSanPhamMoi : Form
    {
        public fLoaiSanPhamMoi()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void insertLSP(string tenlsp, string malsp)
        {
            try
            {
                bool ktra = LoaiSanPhamBUS.Instance.insertLSP(malsp, tenlsp);
                if (ktra == true)
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvLSP.DataSource = HangHoaBUS.Instance.loadLSP();
                }
                else MessageBox.Show("Lỗi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception EE)
            {
                MessageBox.Show("Lỗi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            fThemLSP_Data f = new fThemLSP_Data();
            f.LoadLSP = new fThemLSP_Data.upLoadLSP(insertLSP);
            f.ShowDialog();
        }
        private void getdata()
        {
            dtgvLSP.DataSource = HangHoaBUS.Instance.loadLSP();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvLSP.SelectedRows.Count > 0)
            {
                string malsp = dtgvLSP.SelectedRows[0].Cells["colMA_LSP"].Value.ToString();
                string tenlsp = dtgvLSP.SelectedRows[0].Cells["colTen_LSP"].Value.ToString();

                fSuaLoaiSanPham f = new fSuaLoaiSanPham(malsp, tenlsp, true);
                f.get = new fSuaLoaiSanPham.getdata(getdata);
                f.ShowDialog();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvLSP.SelectedRows.Count > 0)
            {
                HangHoaBUS.Instance.xoaLSP(dtgvLSP.SelectedRows[0].Cells["colMA_LSP"].Value.ToString());
                dtgvLSP.DataSource = HangHoaBUS.Instance.loadLSP();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void fLoaiSanPhamMoi_Load(object sender, EventArgs e)
        {
            dtgvLSP.DataSource = HangHoaBUS.Instance.loadLSP();
        }

        private void txtMaLSp_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {

                dtgvLSP.DataSource = HangHoaBUS.Instance.loadLSP();
                return;
            }
            string strSearch = txtSearch.Text;
            LoaiSanPhamBUS.Instance.TimKiemLoaiSP(dtgvLSP, strSearch);

        }
    }
}
