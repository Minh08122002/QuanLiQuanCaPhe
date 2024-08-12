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
    public partial class fLoading : Form
    {
        NhanVien nv = null;
        public fLoading()
        {
            InitializeComponent();
        }
        public fLoading(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width +=3;
            if (panel2.Width >= 746)
            {
                timer1.Stop();
                Form1 f = new Form1(nv);
                f.Show();
                this.Hide();
            }
        }

        private void fLoading_Load(object sender, EventArgs e)
        {

        }

    }
}
