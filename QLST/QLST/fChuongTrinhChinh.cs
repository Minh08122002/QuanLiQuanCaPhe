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

    public partial class fChuongTrinhChinh : Form
    {
        

        public fChuongTrinhChinh()
        {
            InitializeComponent();
        }

       

        private void fChuongTrinhChinh_Load(object sender, EventArgs e)
        {
           
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fChuongTrinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void fChuongTrinhChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSanpham f = new fSanpham();
            f.MdiParent = this;
            f.Show();
        }
    }
}
