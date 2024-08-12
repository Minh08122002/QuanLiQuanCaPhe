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
    public partial class fXemSanPham : Form
    {
        public fXemSanPham()
        {
            InitializeComponent();
        }
        string imgPath = "";
        bool loadImage = false;
        bool trangthai = true;
        bool checkmalsp = false, checkmancc = false;
        bool checkdvt = false, checkdongia = false, checkgiagoc = false, checksl = false, checkslt = false, checkgiamgia = false;
        bool KT = true;
        string mancc = "";
        string malsp = "";
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public fXemSanPham(string masp, string malsp, string tensp, string mancc, string donvitinh, string dongia, string giagoc, string soluong, string soluongton, string giamgia, string ngaysx, string hansd, Image hinhanh, bool trangthai)
        {
            InitializeComponent();
            txtMSP.Text = masp;

            this.mancc = mancc;
            this.malsp = malsp;
            txtTenSP.Text = tensp;
            txtDVT.Text = donvitinh;
            txtDongia.Text = dongia;
            txtGiagoc.Text = giagoc;
            txtSoluong.Text = soluong;
            txtSoluongton.Text = soluongton;
            txtGiamgia.Text = giamgia;
            dtpNgaySX.Value = DateTime.Parse(ngaysx);
            dtPHanSD.Value = DateTime.Parse(hansd);
            picBoxSanPham.Image = hinhanh;
            this.trangthai = trangthai;

        }
        public void DisableControl()
        {
            txtMSP.Enabled = false;
            cBMLSP.Enabled = false;
            cBMNCC.Enabled = false;
            txtTenSP.Enabled = false;
            txtDVT.Enabled = false;
            txtDongia.Enabled = false;
            txtGiagoc.Enabled = false;
            txtSoluong.Enabled = false;
            txtSoluongton.Enabled = false;
            txtGiamgia.Enabled = false;
            dtpNgaySX.Enabled = false;
            dtPHanSD.Enabled = false;
            btnThemLSP.Visible = false;
            btnThemLSP.Enabled = false;
            btnThemNCC.Visible = false;
            btnThemNCC.Enabled = false;
            btnCapnhat.Enabled = false;
            btnCapnhat.Visible = false;
            btnHuy.Visible = false;
            btnHuy.Enabled = false;
        }
        private void fXemSanPham_Load(object sender, EventArgs e)
        {
            DisableControl();
            DataTable dt1 = new DataTable();
            dt1 = HangHoaBUS.Instance.loadSP();
            loadLSP();
            loadNCC();
            DataTable dt = new DataTable();
            string ss = "";
            string[] str = null;
            if (HangHoaBUS.Instance.sosanhLSP(malsp))
            {
                dt = HangHoaBUS.Instance.loadLSP();
                foreach (DataRow i in dt.Rows)
                {
                    ss = i.ItemArray[0].ToString();
                    str = ss.Split('-');
                    if (malsp == str[0])
                    {

                        cBMLSP.Text = i.ItemArray[0].ToString() + "-" + i.ItemArray[1].ToString();
                        break;
                    }

                }
            }
            if (HangHoaBUS.Instance.sosanhNCC(mancc))
            {
                dt = HangHoaBUS.Instance.loadNCC();
                foreach (DataRow i in dt.Rows)
                {
                    ss = i.ItemArray[0].ToString();
                    str = ss.Split('-');
                    if (mancc == str[0])
                    {

                        cBMNCC.Text = i.ItemArray[0].ToString() + "-" + i.ItemArray[1].ToString();
                        break;
                    }
                }
            }

        }
        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //
        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            fThemLSP_Data f = new fThemLSP_Data();
            f.ShowDialog();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            fThemNcc f = new fThemNcc();
            f.ShowDialog();
        }
        public bool suaSP()
        {
            string masp, malsp, tensp, mancc, donvitinh, dongia, giagoc, soluong, soluongton, giamgia;
            bool trangthai;
            byte[] hinhanh;
            DateTime? ngaysx, hansd;
            masp = txtMSP.Text;
            string[] ma_lsp = cBMLSP.Text.Split('-');
            malsp = ma_lsp[0];
            tensp = txtTenSP.Text;
            string[] man_cc = cBMNCC.Text.Split('-');
            mancc = man_cc[0];
            donvitinh = txtDVT.Text;
            string[] adongia = txtDongia.Text.Split('.');
            dongia = adongia[0];
            string[] agiagoc = txtGiagoc.Text.Split('.');
            giagoc = agiagoc[0];
            soluong = txtSoluong.Text;
            soluongton = txtSoluongton.Text;
            giamgia = txtGiamgia.Text;
            trangthai = true;
            ngaysx = dtpNgaySX.Value;
            hansd = dtPHanSD.Value;
            if (loadImage == false)
            {
                ImageToByte convert = new ImageToByte();
                hinhanh = convert.ImageToByteArray(picBoxSanPham.Image);
            }
            else hinhanh = System.IO.File.ReadAllBytes(imgPath);
            object[] HangThem = new object[] { masp, malsp, tensp, mancc, donvitinh, dongia, giagoc, soluong, soluongton, giamgia, ngaysx, hansd, hinhanh, trangthai };
            return HangHoaBUS.Instance.suaSanPham(HangThem);

        }
        private void btnSuaSP_Click(object sender, EventArgs e)

        {

            cBMLSP.Enabled = true;
            cBMNCC.Enabled = true;
            txtTenSP.Enabled = true;
            txtDVT.Enabled = true;
            txtDongia.Enabled = true;
            txtGiagoc.Enabled = true;
            txtSoluong.Enabled = true;
            txtSoluongton.Enabled = true;
            txtGiamgia.Enabled = true;
            dtpNgaySX.Enabled = true;
            dtPHanSD.Enabled = true;
            btnThemLSP.Visible = true;
            btnThemLSP.Enabled = true;
            btnThemNCC.Visible = true;
            btnThemNCC.Enabled = true;
            btnCapnhat.Enabled = true;
            btnCapnhat.Visible = true;
            btnHuy.Visible = true;
            btnHuy.Enabled = true;
            btnSuaSP.Visible = false;
        }
        public void checkALL()
        {
            checkdvt = checkchangetxt(txtDVT, lblWarningDVT, "w");
            checkdongia = checkchangetxt(txtDongia, lblWarningDongia, "d");
            checkgiagoc = checkchangetxt(txtGiagoc, lblWarningGiagoc, "d");
            checkgiamgia = checkchangetxt(txtGiamgia, lblWarningGiamgia, "d");
            checksl = checkchangetxt(txtSoluong, lblWarningSoluong, "d");
            checkslt = checkchangetxt(txtSoluongton, lblWarningSoluongton, "d");
            if (checkdvt == true && checkdongia == true && checkgiagoc == true && checksl == true && checkslt == true && checkgiamgia == true && txtMSP.Text != "" && txtTenSP.Text != "" && checkmalsp == true && checkmancc == true && loadImage == true)
            {
                KT = true;
            }
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
          

            try
            {
                DisableControl();
                btnSuaSP.Visible = true;
                checkALL();
                if (KT)
                {
                    if (suaSP() == true)
                    {
                        MessageBox.Show("Sửa Sản Phẩm Thành Công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }

                }
                else
                    MessageBox.Show("Sửa Sản Phẩm Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception EE)
            {
                MessageBox.Show("Sửa Sản Phẩm Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }
        private bool checkchangetxt(TextBox txt, Label lbl, string type)
        {

            switch (type)
            {
                case "w":
                    {
                        if (txt.Text == "")
                        {
                            lbl.Visible = false;
                            return false;
                        }
                        else
                        {
                            if (RegularExpression.Instance.checkUnicode(txt.Text) == true)
                            {
                                lbl.Visible = false;
                                return true;
                            }
                            else
                            {
                                lbl.Visible = true;
                                return false;

                            }
                        }

                    }
                case "d":
                    {
                        if (txt.Text == "")
                        {
                            lbl.Visible = false;
                            return false;
                        }
                        else
                        {

                            if (RegularExpression.Instance.checkNumber(txt.Text) == true)
                            {
                                lbl.Visible = false;
                                return true;
                            }
                            else
                            {
                                lbl.Visible = true;
                                return false;

                            }
                        }


                    }
                case "ch":
                    {
                        if (txt.Text == "")
                        {
                            lbl.Visible = false;
                            return false;
                        }
                        else
                        {

                            if (RegularExpression.Instance.checkcharacterSpecial(txt.Text) == true)
                            {
                                lbl.Visible = false;
                                return true;
                            }
                            else
                            {
                                lbl.Visible = true;
                                return false;

                            }
                        }

                    }





            }
            return false;
        }
        public void checkdata()
        {


            string[] str1 = cBMLSP.Text.Split('-');
            if (HangHoaBUS.Instance.findLSP(str1[0]) == false)
            {
                MessageBox.Show("Không tồn tại mã loại sản phẩm này");
                checkmalsp = false;
            }
            else checkmalsp = true;
            string[] str2 = cBMLSP.Text.Split('-');
            if (HangHoaBUS.Instance.findLSP(str2[0]) == false)
            {
                MessageBox.Show("Không tồn tại mã nhà cung cấp này");
                checkmancc = false;
            }
            else checkmancc = true;

        }
        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

            checkdvt = checkchangetxt(txtDVT, lblWarningDVT, "w");

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();//Mo File

            OD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";//Loc ra duoi file 
            if (OD.ShowDialog() == DialogResult.OK)//Mo chon file hinh
            {
                picBoxSanPham.Image = Image.FromFile(OD.FileName);//gan Hinh vao picturebox
                imgPath = OD.FileName;
                loadImage = true;
            }
            else
            {
                loadImage = false;
                MessageBox.Show("Lỗi tải ảnh!!");
            }
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            checkdongia = checkchangetxt(txtDongia, lblWarningDongia, "d");
        }

        private void txtGiagoc_TextChanged(object sender, EventArgs e)
        {
            checkgiagoc = checkchangetxt(txtGiagoc, lblWarningGiagoc, "d");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            checksl = checkchangetxt(txtSoluong, lblWarningSoluong, "d");
        }

        private void txtSoluongton_TextChanged(object sender, EventArgs e)
        {
            checkslt = checkchangetxt(txtSoluongton, lblWarningSoluongton, "d");
        }

        private void txtGiamgia_TextChanged_1(object sender, EventArgs e)
        {
            checkgiamgia = checkchangetxt(txtGiamgia, lblWarningGiamgia, "d");
        }


        public void upLoadDataLSP(string tenlsp, string malsp)
        {
            HangHoaBUS.Instance.upLSP(tenlsp, malsp);

        }
        public void upLoadDataNCC(string tenncc, string mancc, string diachi)
        {
            HangHoaBUS.Instance.upNCC(tenncc, mancc, diachi);

        }
        public void loadLSP()
        {
            cBMLSP.DataSource = HangHoaBUS.Instance.MA_TENLSP();


            cBMLSP.DisplayMember = "MA_TENLSP";
            cBMLSP.ValueMember = "MA_LOAI_SP";
            cBMLSP.Text = "";

        }
        public void loadNCC()
        {
            cBMNCC.DataSource = HangHoaBUS.Instance.MA_TENNCC();
            cBMNCC.DisplayMember = "MA_TENNCC";
            cBMNCC.ValueMember = "MA_NCC";
            cBMNCC.Text = "";

        }


    }
}
