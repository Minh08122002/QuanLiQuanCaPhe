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
    public partial class fNhaCC : Form
    {
        public fNhaCC()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        public void upLoadDataNCC(string mancc, string tenncc, string diachi)
        {
            try
            {
                bool them = HangHoaBUS.Instance.updateNCC(mancc, tenncc, diachi);
                if (them == true)
                {
                    MessageBox.Show("Thêm thành công");
                    HangHoaBUS.Instance.loadlistNCC(dtgvNCC, 1);
                }
                else MessageBox.Show("Lỗi");
            }catch(Exception EE)
            {
                MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            fThemNcc f = new fThemNcc();

            f.LoadNCC = new fThemNcc.upLoadNCC(upLoadDataNCC);
            f.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            HangHoaBUS.Instance.xoaNCC(dtgvNCC.SelectedRows[0].Cells["colMaNCC"].Value.ToString());
            HangHoaBUS.Instance.loadlistNCC(dtgvNCC, 1);
        }

        private void fNhaCC_Load(object sender, EventArgs e)
        {
            HangHoaBUS.Instance.loadlistNCC(dtgvNCC, 1);
        }
        public void loaddata()
        {
            HangHoaBUS.Instance.loadlistNCC(dtgvNCC, 1);
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (dtgvNCC.SelectedRows.Count > 0)
            {
                string mancc = dtgvNCC.SelectedRows[0].Cells["colMaNCC"].Value.ToString();
                string tenncc = dtgvNCC.SelectedRows[0].Cells["colTenNCC"].Value.ToString();
                string diachi = dtgvNCC.SelectedRows[0].Cells["colDiaChi"].Value.ToString();
                bool trangthai = (bool)dtgvNCC.SelectedRows[0].Cells["colTrangThaiNCC"].Value;
                NhaCungCap ncc = new NhaCungCap(mancc, tenncc, diachi, trangthai);
                fSuaNhaCungCap f = new fSuaNhaCungCap(ncc);
                f.load = new fSuaNhaCungCap.loaddata(loaddata);
                f.ShowDialog();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                HangHoaBUS.Instance.loadlistNCC(dtgvNCC, 1);
                return;
            }
            string search = txtSearch.Text;
            HangHoaBUS.Instance.searchNCC(dtgvNCC, search, 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
