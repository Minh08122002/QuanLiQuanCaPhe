using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;



namespace QLST
{
    public partial class fThemLoaiSP : Form
    {
        public delegate void LSPADD(LoaiSanPham lsp);

        public LSPADD lspAdd;
        public fThemLoaiSP()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public delegate void newButton(string s, string s1);
        public newButton newbtn;
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenLSPmoi.Text == "" || txtMalSP.Text == "")
            {
                MessageBox.Show("Trường đang trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                newbtn(txtTenLSPmoi.Text, txtMalSP.Text);


            this.Close();
        }


    }
}
