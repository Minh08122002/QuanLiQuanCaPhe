
namespace QLST
{
    partial class fThongTinNhanVienTemp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblCMNDorCCCD = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.grBThongtin = new System.Windows.Forms.GroupBox();
            this.dtPNgayvaolam = new System.Windows.Forms.DateTimePicker();
            this.lblNgayvaolam = new System.Windows.Forms.Label();
            this.pictBHinhAnhNhanVien = new System.Windows.Forms.PictureBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWarningTK = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.dtPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMNDorCCCD = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.grBThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBHinhAnhNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel1.Controls.Add(this.lblInformation);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 59);
            this.panel1.TabIndex = 1;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInformation.Location = new System.Drawing.Point(3, 16);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblInformation.Size = new System.Drawing.Size(242, 25);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "THÔNG TIN CHI TIẾT";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(1052, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 56);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(58, 140);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(59, 20);
            this.lblHoten.TabIndex = 2;
            this.lblHoten.Text = "Họ tên";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(58, 438);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(81, 20);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblCMNDorCCCD
            // 
            this.lblCMNDorCCCD.AutoSize = true;
            this.lblCMNDorCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNDorCCCD.Location = new System.Drawing.Point(58, 212);
            this.lblCMNDorCCCD.Name = "lblCMNDorCCCD";
            this.lblCMNDorCCCD.Size = new System.Drawing.Size(126, 20);
            this.lblCMNDorCCCD.TabIndex = 2;
            this.lblCMNDorCCCD.Text = "CMND/CCCCD";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(58, 274);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 20);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(58, 389);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(106, 20);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(58, 494);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(61, 20);
            this.lblDiachi.TabIndex = 2;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.Location = new System.Drawing.Point(58, 560);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(70, 20);
            this.lblChucvu.TabIndex = 2;
            this.lblChucvu.Text = "Chức vụ";
            // 
            // grBThongtin
            // 
            this.grBThongtin.Controls.Add(this.dtPNgayvaolam);
            this.grBThongtin.Controls.Add(this.lblNgayvaolam);
            this.grBThongtin.Controls.Add(this.pictBHinhAnhNhanVien);
            this.grBThongtin.Controls.Add(this.lblHinhAnh);
            this.grBThongtin.Controls.Add(this.panel6);
            this.grBThongtin.Controls.Add(this.panel5);
            this.grBThongtin.Controls.Add(this.panel4);
            this.grBThongtin.Controls.Add(this.txtMaNV);
            this.grBThongtin.Controls.Add(this.txtHoTen);
            this.grBThongtin.Controls.Add(this.panel7);
            this.grBThongtin.Controls.Add(this.panel3);
            this.grBThongtin.Controls.Add(this.panel2);
            this.grBThongtin.Controls.Add(this.lblWarningTK);
            this.grBThongtin.Controls.Add(this.cbGioiTinh);
            this.grBThongtin.Controls.Add(this.cbChucvu);
            this.grBThongtin.Controls.Add(this.dtPNgaySinh);
            this.grBThongtin.Controls.Add(this.txtSDT);
            this.grBThongtin.Controls.Add(this.txtCMNDorCCCD);
            this.grBThongtin.Controls.Add(this.txtDiachi);
            this.grBThongtin.Controls.Add(this.txtTaiKhoan);
            this.grBThongtin.Controls.Add(this.lblMaNV);
            this.grBThongtin.Controls.Add(this.lblHoten);
            this.grBThongtin.Controls.Add(this.lblGioiTinh);
            this.grBThongtin.Controls.Add(this.lblChucvu);
            this.grBThongtin.Controls.Add(this.lblTaiKhoan);
            this.grBThongtin.Controls.Add(this.lblDiachi);
            this.grBThongtin.Controls.Add(this.lblCMNDorCCCD);
            this.grBThongtin.Controls.Add(this.lblSDT);
            this.grBThongtin.Controls.Add(this.lblNgaySinh);
            this.grBThongtin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBThongtin.Location = new System.Drawing.Point(24, 80);
            this.grBThongtin.Name = "grBThongtin";
            this.grBThongtin.Size = new System.Drawing.Size(1063, 726);
            this.grBThongtin.TabIndex = 3;
            this.grBThongtin.TabStop = false;
            this.grBThongtin.Text = "Thông tin nhân viên";
            // 
            // dtPNgayvaolam
            // 
            this.dtPNgayvaolam.Enabled = false;
            this.dtPNgayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgayvaolam.Location = new System.Drawing.Point(185, 623);
            this.dtPNgayvaolam.Name = "dtPNgayvaolam";
            this.dtPNgayvaolam.Size = new System.Drawing.Size(200, 30);
            this.dtPNgayvaolam.TabIndex = 17;
            // 
            // lblNgayvaolam
            // 
            this.lblNgayvaolam.AutoSize = true;
            this.lblNgayvaolam.Location = new System.Drawing.Point(58, 627);
            this.lblNgayvaolam.Name = "lblNgayvaolam";
            this.lblNgayvaolam.Size = new System.Drawing.Size(122, 23);
            this.lblNgayvaolam.TabIndex = 16;
            this.lblNgayvaolam.Text = "Ngày vào làm";
            // 
            // pictBHinhAnhNhanVien
            // 
            this.pictBHinhAnhNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBHinhAnhNhanVien.Image = global::QLST.Properties.Resources.noimage;
            this.pictBHinhAnhNhanVien.Location = new System.Drawing.Point(753, 113);
            this.pictBHinhAnhNhanVien.Name = "pictBHinhAnhNhanVien";
            this.pictBHinhAnhNhanVien.Size = new System.Drawing.Size(249, 249);
            this.pictBHinhAnhNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBHinhAnhNhanVien.TabIndex = 14;
            this.pictBHinhAnhNhanVien.TabStop = false;
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(684, 78);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(82, 23);
            this.lblHinhAnh.TabIndex = 13;
            this.lblHinhAnh.Text = "Hình ảnh";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(194, 513);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 2);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(193, 457);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 2);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(193, 405);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 2);
            this.panel4.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(193, 79);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(207, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(193, 133);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(193, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 2);
            this.panel7.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(193, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 2);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(193, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 2);
            this.panel2.TabIndex = 7;
            // 
            // lblWarningTK
            // 
            this.lblWarningTK.AutoSize = true;
            this.lblWarningTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningTK.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTK.Location = new System.Drawing.Point(205, 457);
            this.lblWarningTK.Name = "lblWarningTK";
            this.lblWarningTK.Size = new System.Drawing.Size(0, 20);
            this.lblWarningTK.TabIndex = 6;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.cbGioiTinh.Enabled = false;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(193, 334);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 28);
            this.cbGioiTinh.TabIndex = 7;
            // 
            // cbChucvu
            // 
            this.cbChucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.cbChucvu.Enabled = false;
            this.cbChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(185, 560);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(121, 28);
            this.cbChucvu.TabIndex = 7;
            // 
            // dtPNgaySinh
            // 
            this.dtPNgaySinh.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtPNgaySinh.Enabled = false;
            this.dtPNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgaySinh.Location = new System.Drawing.Point(193, 267);
            this.dtPNgaySinh.Name = "dtPNgaySinh";
            this.dtPNgaySinh.Size = new System.Drawing.Size(207, 27);
            this.dtPNgaySinh.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Enabled = false;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(193, 382);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(207, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // txtCMNDorCCCD
            // 
            this.txtCMNDorCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtCMNDorCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMNDorCCCD.Enabled = false;
            this.txtCMNDorCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDorCCCD.Location = new System.Drawing.Point(193, 205);
            this.txtCMNDorCCCD.Name = "txtCMNDorCCCD";
            this.txtCMNDorCCCD.Size = new System.Drawing.Size(207, 20);
            this.txtCMNDorCCCD.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiachi.Enabled = false;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(193, 490);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(207, 20);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(193, 435);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(207, 20);
            this.txtTaiKhoan.TabIndex = 5;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(58, 78);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(108, 20);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(58, 334);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 2;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(28, 813);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 53);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(930, 812);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(157, 54);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Khôi phục";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fThongTinNhanVienTemp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1113, 906);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grBThongtin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "fThongTinNhanVienTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fThongTinNhanVienTemp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grBThongtin.ResumeLayout(false);
            this.grBThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBHinhAnhNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblCMNDorCCCD;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.GroupBox grBThongtin;
        private System.Windows.Forms.DateTimePicker dtPNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMNDorCCCD;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblWarningTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblGioiTinh;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.Label lblHinhAnh;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.PictureBox pictBHinhAnhNhanVien;
        private System.Windows.Forms.DateTimePicker dtPNgayvaolam;
        private System.Windows.Forms.Label lblNgayvaolam;
        private System.Windows.Forms.Label lblInformation;
    }
}