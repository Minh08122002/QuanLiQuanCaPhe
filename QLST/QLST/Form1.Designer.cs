
namespace QLST
{
    partial class Form1
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnLapHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.panelSubitemKhoHang = new System.Windows.Forms.Panel();
            this.btnSubitemXuatKho = new FontAwesome.Sharp.IconButton();
            this.btnSubitemNhapKho = new FontAwesome.Sharp.IconButton();
            this.btnSubitemKho = new FontAwesome.Sharp.IconButton();
            this.btnKhoHang = new FontAwesome.Sharp.IconButton();
            this.panelSubitemSanPham = new System.Windows.Forms.Panel();
            this.btnSubitemNhaCC = new FontAwesome.Sharp.IconButton();
            this.btnSubitemLoaiSanPham = new FontAwesome.Sharp.IconButton();
            this.btnSubitemSanPham = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.panelLoGo = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubitemKhoHang.SuspendLayout();
            this.panelSubitemSanPham.SuspendLayout();
            this.panelLoGo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(277, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1473, 805);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelLoGo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(277, 805);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnLapHoaDon);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.panelSubitemKhoHang);
            this.panel1.Controls.Add(this.btnKhoHang);
            this.panel1.Controls.Add(this.panelSubitemSanPham);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 832);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 654);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(256, 67);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnLapHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDon.IconChar = FontAwesome.Sharp.IconChar.Opencart;
            this.btnLapHoaDon.IconColor = System.Drawing.Color.White;
            this.btnLapHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLapHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.Location = new System.Drawing.Point(0, 587);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLapHoaDon.Size = new System.Drawing.Size(256, 67);
            this.btnLapHoaDon.TabIndex = 11;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnHoaDon.IconColor = System.Drawing.Color.White;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 520);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(256, 67);
            this.btnHoaDon.TabIndex = 10;
            this.btnHoaDon.Text = "Hoá đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // panelSubitemKhoHang
            // 
            this.panelSubitemKhoHang.AutoSize = true;
            this.panelSubitemKhoHang.Controls.Add(this.btnSubitemXuatKho);
            this.panelSubitemKhoHang.Controls.Add(this.btnSubitemNhapKho);
            this.panelSubitemKhoHang.Controls.Add(this.btnSubitemKho);
            this.panelSubitemKhoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubitemKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSubitemKhoHang.ForeColor = System.Drawing.Color.White;
            this.panelSubitemKhoHang.Location = new System.Drawing.Point(0, 394);
            this.panelSubitemKhoHang.Name = "panelSubitemKhoHang";
            this.panelSubitemKhoHang.Size = new System.Drawing.Size(256, 126);
            this.panelSubitemKhoHang.TabIndex = 9;
            this.panelSubitemKhoHang.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubitemKhoHang_Paint);
            // 
            // btnSubitemXuatKho
            // 
            this.btnSubitemXuatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.btnSubitemXuatKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubitemXuatKho.FlatAppearance.BorderSize = 0;
            this.btnSubitemXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubitemXuatKho.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubitemXuatKho.IconColor = System.Drawing.Color.Black;
            this.btnSubitemXuatKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubitemXuatKho.Location = new System.Drawing.Point(0, 84);
            this.btnSubitemXuatKho.Name = "btnSubitemXuatKho";
            this.btnSubitemXuatKho.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubitemXuatKho.Size = new System.Drawing.Size(256, 42);
            this.btnSubitemXuatKho.TabIndex = 9;
            this.btnSubitemXuatKho.Text = "Xuất kho";
            this.btnSubitemXuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubitemXuatKho.UseVisualStyleBackColor = false;
            this.btnSubitemXuatKho.Click += new System.EventHandler(this.btnSubitemXuatKho_Click);
            // 
            // btnSubitemNhapKho
            // 
            this.btnSubitemNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.btnSubitemNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubitemNhapKho.FlatAppearance.BorderSize = 0;
            this.btnSubitemNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubitemNhapKho.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubitemNhapKho.IconColor = System.Drawing.Color.Black;
            this.btnSubitemNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubitemNhapKho.Location = new System.Drawing.Point(0, 42);
            this.btnSubitemNhapKho.Name = "btnSubitemNhapKho";
            this.btnSubitemNhapKho.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubitemNhapKho.Size = new System.Drawing.Size(256, 42);
            this.btnSubitemNhapKho.TabIndex = 8;
            this.btnSubitemNhapKho.Text = "Nhập kho";
            this.btnSubitemNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubitemNhapKho.UseVisualStyleBackColor = false;
            this.btnSubitemNhapKho.Click += new System.EventHandler(this.btnSubitemNhapKho_Click);
            // 
            // btnSubitemKho
            // 
            this.btnSubitemKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.btnSubitemKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubitemKho.FlatAppearance.BorderSize = 0;
            this.btnSubitemKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubitemKho.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubitemKho.IconColor = System.Drawing.Color.Black;
            this.btnSubitemKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubitemKho.Location = new System.Drawing.Point(0, 0);
            this.btnSubitemKho.Name = "btnSubitemKho";
            this.btnSubitemKho.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubitemKho.Size = new System.Drawing.Size(256, 42);
            this.btnSubitemKho.TabIndex = 6;
            this.btnSubitemKho.Text = "Kho";
            this.btnSubitemKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubitemKho.UseVisualStyleBackColor = false;
            this.btnSubitemKho.Click += new System.EventHandler(this.btnSubitemKho_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnKhoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.ForeColor = System.Drawing.Color.White;
            this.btnKhoHang.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnKhoHang.IconColor = System.Drawing.Color.White;
            this.btnKhoHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(0, 327);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhoHang.Size = new System.Drawing.Size(256, 67);
            this.btnKhoHang.TabIndex = 8;
            this.btnKhoHang.Text = "Kho hàng";
            this.btnKhoHang.UseVisualStyleBackColor = false;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // panelSubitemSanPham
            // 
            this.panelSubitemSanPham.AutoSize = true;
            this.panelSubitemSanPham.Controls.Add(this.btnSubitemNhaCC);
            this.panelSubitemSanPham.Controls.Add(this.btnSubitemLoaiSanPham);
            this.panelSubitemSanPham.Controls.Add(this.btnSubitemSanPham);
            this.panelSubitemSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubitemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSubitemSanPham.ForeColor = System.Drawing.Color.White;
            this.panelSubitemSanPham.Location = new System.Drawing.Point(0, 201);
            this.panelSubitemSanPham.Name = "panelSubitemSanPham";
            this.panelSubitemSanPham.Size = new System.Drawing.Size(256, 126);
            this.panelSubitemSanPham.TabIndex = 7;
            this.panelSubitemSanPham.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubitemSanPham_Paint);
            // 
            // btnSubitemNhaCC
            // 
            this.btnSubitemNhaCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.btnSubitemNhaCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubitemNhaCC.FlatAppearance.BorderSize = 0;
            this.btnSubitemNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubitemNhaCC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubitemNhaCC.IconColor = System.Drawing.Color.Black;
            this.btnSubitemNhaCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubitemNhaCC.Location = new System.Drawing.Point(0, 84);
            this.btnSubitemNhaCC.Name = "btnSubitemNhaCC";
            this.btnSubitemNhaCC.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubitemNhaCC.Size = new System.Drawing.Size(256, 42);
            this.btnSubitemNhaCC.TabIndex = 8;
            this.btnSubitemNhaCC.Text = "Nhà cung cấp";
            this.btnSubitemNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubitemNhaCC.UseVisualStyleBackColor = false;
            this.btnSubitemNhaCC.Click += new System.EventHandler(this.btnSubitemNhaCC_Click);
            // 
            // btnSubitemLoaiSanPham
            // 
            this.btnSubitemLoaiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.btnSubitemLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubitemLoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnSubitemLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubitemLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubitemLoaiSanPham.IconColor = System.Drawing.Color.Black;
            this.btnSubitemLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubitemLoaiSanPham.Location = new System.Drawing.Point(0, 42);
            this.btnSubitemLoaiSanPham.Name = "btnSubitemLoaiSanPham";
            this.btnSubitemLoaiSanPham.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubitemLoaiSanPham.Size = new System.Drawing.Size(256, 42);
            this.btnSubitemLoaiSanPham.TabIndex = 7;
            this.btnSubitemLoaiSanPham.Text = "Loại sản phẩm";
            this.btnSubitemLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubitemLoaiSanPham.UseVisualStyleBackColor = false;
            this.btnSubitemLoaiSanPham.Click += new System.EventHandler(this.btnSubitemLoaiSanPham_Click);
            // 
            // btnSubitemSanPham
            // 
            this.btnSubitemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.btnSubitemSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubitemSanPham.FlatAppearance.BorderSize = 0;
            this.btnSubitemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubitemSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubitemSanPham.IconColor = System.Drawing.Color.Black;
            this.btnSubitemSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubitemSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnSubitemSanPham.Name = "btnSubitemSanPham";
            this.btnSubitemSanPham.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubitemSanPham.Size = new System.Drawing.Size(256, 42);
            this.btnSubitemSanPham.TabIndex = 6;
            this.btnSubitemSanPham.Text = "Sản phẩm";
            this.btnSubitemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubitemSanPham.UseVisualStyleBackColor = false;
            this.btnSubitemSanPham.Click += new System.EventHandler(this.btnSubitemSanPham_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Lemon;
            this.btnSanPham.IconColor = System.Drawing.Color.White;
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 134);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(256, 67);
            this.btnSanPham.TabIndex = 5;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnKhachHang.IconColor = System.Drawing.Color.White;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 67);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(256, 67);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(256, 67);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panelLoGo
            // 
            this.panelLoGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panelLoGo.Controls.Add(this.label1);
            this.panelLoGo.Controls.Add(this.iconButton2);
            this.panelLoGo.Controls.Add(this.pictureBox1);
            this.panelLoGo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoGo.Location = new System.Drawing.Point(0, 0);
            this.panelLoGo.Name = "panelLoGo";
            this.panelLoGo.Size = new System.Drawing.Size(256, 136);
            this.panelLoGo.TabIndex = 0;
            this.panelLoGo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoGo_Paint);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 50;
            this.iconButton2.Location = new System.Drawing.Point(0, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(83, 59);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "SupperTeen";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1750, 805);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SIÊU THỊ";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubitemKhoHang.ResumeLayout(false);
            this.panelSubitemSanPham.ResumeLayout(false);
            this.panelLoGo.ResumeLayout(false);
            this.panelLoGo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnLapHoaDon;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private System.Windows.Forms.Panel panelSubitemKhoHang;
        private FontAwesome.Sharp.IconButton btnSubitemXuatKho;
        private FontAwesome.Sharp.IconButton btnSubitemNhapKho;
        private FontAwesome.Sharp.IconButton btnSubitemKho;
        private FontAwesome.Sharp.IconButton btnKhoHang;
        private System.Windows.Forms.Panel panelSubitemSanPham;
        private FontAwesome.Sharp.IconButton btnSubitemNhaCC;
        private FontAwesome.Sharp.IconButton btnSubitemLoaiSanPham;
        private FontAwesome.Sharp.IconButton btnSubitemSanPham;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private System.Windows.Forms.Panel panelLoGo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

