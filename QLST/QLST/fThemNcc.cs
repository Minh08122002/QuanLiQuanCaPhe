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
    public partial class fThemNcc : Form
    {
        public fThemNcc()
        {
            InitializeComponent();
        }

        public delegate void upLoadNCC(string mancc, string tencc, string diachi);
        public upLoadNCC LoadNCC;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiachi.Text == "")
                {
                    MessageBox.Show("Trường đang trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    LoadNCC(txtMaNCC.Text, txtTenNCC.Text, txtDiachi.Text);

                }
            }catch(Exception EE)
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
