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
    public partial class fThemSanPham: Form
    {

        string imgPath = "";
        bool loadImage = false;
        bool checkmasp = false, checkmalsp = false, checkmancc = false;
        bool checkdvt = false, checkdongia = false, checkgiagoc = false, checksl = false, checkslt = false, checkgiamgia = false;
        bool KT = false;
        public fThemSanPham()   
        {
            InitializeComponent();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (HangHoaBUS.Instance.checkMASP(txtMSP.Text) == false)
            {
                MessageBox.Show("Đã tồn tại mã sản phẩm này");
                checkmasp = false;
            }
            else checkmasp = true;

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
        public bool themSP()
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
            dongia = txtDongia.Text;
            giagoc = txtGiagoc.Text;
            soluong = txtSoluong.Text;
            soluongton = txtSoluongton.Text;
            giamgia = txtGiamgia.Text;
            trangthai = true;
            ngaysx = dTPNgSX.Value;
            hansd = dtPHanSD.Value;

            if (loadImage == false)
            {
                ImageToByte convert = new ImageToByte();
                hinhanh = convert.ImageToByteArray(picBoxSanPham.Image);
            }
            else hinhanh = System.IO.File.ReadAllBytes(imgPath);
            object[] HangThem = new object[] { masp, malsp, tensp, mancc, donvitinh, dongia, giagoc, soluong, soluongton, giamgia, ngaysx, hansd, hinhanh, trangthai };
            return HangHoaBUS.Instance.themSanPham(HangThem);

        }

        public void checkALL()
        {
            if (checkmasp == true && checkdvt == true && checkdongia == true && checkgiagoc == true && checksl == true && checkslt == true && checkgiamgia == true && txtMSP.Text != "" && txtTenSP.Text != "" && checkmalsp == true && checkmancc == true && loadImage == true)
            {
                KT = true;
            }
        }
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            try 
            {
                checkdata();
                checkALL();
                if (KT)
                {
                    if (themSP() == true)
                    {
                        MessageBox.Show("Thêm Sản Phẩm Thành Công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                }
                else
                    MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception EE){
                MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }             
            
            
        }
        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

            checkdvt = checkchangetxt(txtDVT, lblWarningDVT, "w");

        }
        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            checkdongia = checkchangetxt(txtDongia, lblWarningDongia, "d");
        }

        private void txtGiagoc_TextChanged(object sender, EventArgs e)
        {
            checkgiagoc = checkchangetxt(txtGiagoc, lblWarningGiagoc, "d");
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
            loadLSP();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void upLoadDataNCC(string tenncc, string mancc, string diachi)
        {
            HangHoaBUS.Instance.upNCC(tenncc, mancc, diachi);
            loadNCC();


        }
        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            fThemLSP_Data f = new fThemLSP_Data();
            f.LoadLSP = new fThemLSP_Data.upLoadLSP(upLoadDataLSP);
            f.ShowDialog();
           


        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            fThemNcc f = new fThemNcc();

            f.LoadNCC = new fThemNcc.upLoadNCC(upLoadDataNCC);
            
            f.ShowDialog();


        }
        public void loadLSP()
        {
            cBMLSP.DataSource = HangHoaBUS.Instance.MA_TENLSP();
            cBMLSP.DisplayMember = "MA_TENLSP";
            cBMLSP.ValueMember = "MA_LOAI_SP";
        }
        public void loadNCC()
        {
            cBMNCC.DataSource = HangHoaBUS.Instance.MA_TENNCC();
            cBMNCC.DisplayMember = "MA_TENNCC";
            cBMNCC.ValueMember = "MA_NCC";
        }
        private void fSanphammoi_Load(object sender, EventArgs e)
        {
            loadLSP();
            loadNCC();
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


    }
}
