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




    public partial class fHangHoa : Form
    {

        public fHangHoa()
        {
            InitializeComponent();
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void fHangHoa_Load(object sender, EventArgs e)
        {
            loadData(1);
            loadRad();



        }
        private void loadData(int page)
        {
            string[] str = { "GIAGOC", "SOLUONG", "GIAMGIA", "ngSanxuat", "HANSD", "HINHANH", "lsp", "tenlsp", "TRANGTHAILSP", "ncc" , "MaVaTen"  };
            HangHoaBUS.Instance.loadData(dtGVDanhSachSP, page, str);
        }

        private void loadRad()
        {
            DataTable dt = HangHoaBUS.Instance.loadLSP();


            foreach (DataRow i in dt.Rows)
            {
                CreateRad(i.ItemArray[1].ToString(), i.ItemArray[0].ToString());
            }
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            HangHoaBUS.Instance.thongtinHangHoaTheoID(dtGVDanhSachSP, txtSearchID.Text);
            if (txtSearchID.Text == "") loadData(1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            HangHoaBUS.Instance.thongtinHangHoaTheoTen(dtGVDanhSachSP, txtSearchName.Text);
            if (txtSearchName.Text == "") loadData(1);
        }
        public void testCheckedChanged(RadioButton rd)
        {
            if (rd.Checked == true)
            {

                HangHoaBUS.Instance.thongtinHangHoaTheoTenLSP(dtGVDanhSachSP, rd.Text);
            }

        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;

            if (rd.Checked == true)
            {

                HangHoaBUS.Instance.thongtinHangHoaTheoTenLSP(dtGVDanhSachSP, rd.Text);
                
            }
        }
        public void CreateRad(string tenlsp, string malsp)
        {
            RadioButton rd = new RadioButton();
            DataGridView dtgv = new DataGridView();
            rd.Text = tenlsp;
            rd.Checked = false;
            rd.AutoSize = true;
            rd.Size = new System.Drawing.Size(97, 17);
            rd.TabStop = true;
            rd.UseVisualStyleBackColor = true;
            rd.CheckedChanged += new System.EventHandler(rd_CheckedChanged);
            flpLSP.Controls.Add(rd);

        }
        public void NewRadioButton(string tenlsp, string malsp)
        {

            if (HangHoaBUS.Instance.checkMALSP(malsp) == true)
            {
                RadioButton rd = new RadioButton();
                DataGridView dtgv = new DataGridView();
                rd.Text = tenlsp;
                rd.Checked = false;
                rd.AutoSize = true;
                rd.Size = new System.Drawing.Size(97, 17);
                rd.TabStop = true;
                rd.UseVisualStyleBackColor = true;
                rd.CheckedChanged += new System.EventHandler(rd_CheckedChanged);
                HangHoaBUS.Instance.upLSP(tenlsp, malsp);
                flpLSP.Controls.Add(rd);
            }
            else
                MessageBox.Show("Mã Loại Sản Phẩm Đã Tồn Tại!");



        }
        private void btnThemLSP_Click(object sender, EventArgs e)
        {

            fThemLoaiSP f = new fThemLoaiSP();
            f.Show();
            f.newbtn = new fThemLoaiSP.newButton(NewRadioButton);
        }





        private void radLSP_CheckedChanged(object sender, EventArgs e)
        {

            testCheckedChanged((RadioButton)sender);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            fThemSanPham f = new fThemSanPham();
            f.ShowDialog();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtlsp = new DataTable();
            string maspsearch = dtGVDanhSachSP.SelectedRows[0].Cells["colMaSP"].Value.ToString();
            dt = HangHoaBUS.Instance.SP(maspsearch);

            string masp, malsp, tensp, mancc, donvitinh, dongia, giagoc, soluong, soluongton, giamgia, ngaysx, hansd;
            bool trangthai;
            Image hinhanh = null;
            masp = dt.Rows[0].ItemArray[0].ToString();
            malsp = dt.Rows[0].ItemArray[1].ToString();

            tensp = dt.Rows[0].ItemArray[2].ToString();
            mancc = dt.Rows[0].ItemArray[3].ToString();
            donvitinh = dt.Rows[0].ItemArray[4].ToString();
            dongia = dt.Rows[0].ItemArray[5].ToString();
            string[] Ardongia = dongia.Split('.');
            dongia = Ardongia[0];
            giagoc = dt.Rows[0].ItemArray[6].ToString();
            string[] Argiagoc = giagoc.Split('.');
            giagoc = Ardongia[0];
            soluong = dt.Rows[0].ItemArray[7].ToString();
            soluongton = dt.Rows[0].ItemArray[8].ToString();
            giamgia = dt.Rows[0].ItemArray[9].ToString();
            ngaysx = dt.Rows[0].ItemArray[10].ToString();
            hansd = dt.Rows[0].ItemArray[11].ToString();
            if (dt.Rows[0].ItemArray[12].ToString() != "")
            {
                byte[] array = (byte[])dt.Rows[0].ItemArray[12];
                ImageToByte convert = new ImageToByte();
                convert.byteArrayToImage(array, ref hinhanh);
            }

            trangthai = Boolean.Parse(dt.Rows[0].ItemArray[13].ToString());

            fXemSanPham f = new fXemSanPham(masp, malsp, tensp, mancc, donvitinh, dongia, giagoc, soluong, soluongton, giamgia, ngaysx, hansd, hinhanh, trangthai);
            f.ShowDialog();

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            HangHoaBUS.Instance.xoaHanghoa(dtGVDanhSachSP.SelectedRows[0].Cells["colMaSP"].Value.ToString());
            loadData(1);
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            loadData(1);
        }



        private void radDuoiton_CheckedChanged(object sender, EventArgs e)
        {
            string str1 = "<";
            string str2 = "100";
            HangHoaBUS.Instance.loadHangHoaTon(ref dtGVDanhSachSP, str1, str2);
        }

        private void radVuotton_CheckedChanged(object sender, EventArgs e)
        {

            string str1 = ">";
            string str2 = "100";
            HangHoaBUS.Instance.loadHangHoaTon(ref dtGVDanhSachSP, str1, str2);
        }

        private void radTonkho_CheckedChanged(object sender, EventArgs e)
        {
            string str1 = ">";
            string str2 = "0";
            HangHoaBUS.Instance.loadHangHoaTon(ref dtGVDanhSachSP, str1, str2);

        }

        private void radHethang_CheckedChanged(object sender, EventArgs e)
        {
            string str1 = "<";
            string str2 = "0";
            HangHoaBUS.Instance.loadHangHoaTon(ref dtGVDanhSachSP, str1, str2);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData(1);
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpLSP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void floPpage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void floLPAllButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dtGVDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemSP_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnXuatFile_Click_1(object sender, EventArgs e)
        {
            List<HangHoa> listhh = new List<HangHoa>();
            listhh = HangHoaBUS.Instance.loadSPExcel();
            HangHoaBUS.Instance.exportFileSP(listhh,"Danh Sách ","Danh Sách Sản Phẩm");
        }
    }
}
