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
    public partial class fThemLSP_Data : Form
    {
        public fThemLSP_Data()
        {
            InitializeComponent();
        }

        public delegate void upLoadLSP(string tenlsp, string malsp);
        public upLoadLSP LoadLSP;


        private void btnThem_Click(object sender, EventArgs e)  
        {
            if (txtTenLSPmoi.Text == "" || txtMalSP.Text == "")
            {
                MessageBox.Show("Trường đang trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                LoadLSP(txtTenLSPmoi.Text, txtMalSP.Text);

            }


            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
