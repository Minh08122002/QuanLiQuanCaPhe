
namespace QLST
{
    partial class fSanPhamTimKiem
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
            this.dtGVKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVKetQuaTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVKetQuaTimKiem
            // 
            this.dtGVKetQuaTimKiem.AllowUserToAddRows = false;
            this.dtGVKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dtGVKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVKetQuaTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP,
            this.colDonViTinh,
            this.colSoLuong,
            this.colDonGia,
            this.colGiamGia,
            this.colSoLuongTon,
            this.colNgaySX,
            this.colHanSD});
            this.dtGVKetQuaTimKiem.Location = new System.Drawing.Point(12, 12);
            this.dtGVKetQuaTimKiem.MultiSelect = false;
            this.dtGVKetQuaTimKiem.Name = "dtGVKetQuaTimKiem";
            this.dtGVKetQuaTimKiem.ReadOnly = true;
            this.dtGVKetQuaTimKiem.RowHeadersWidth = 51;
            this.dtGVKetQuaTimKiem.RowTemplate.Height = 24;
            this.dtGVKetQuaTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVKetQuaTimKiem.Size = new System.Drawing.Size(1085, 304);
            this.dtGVKetQuaTimKiem.TabIndex = 0;
            this.dtGVKetQuaTimKiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVKetQuaTimKiem_CellContentClick);
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "maSP";
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            this.colMaSP.Width = 70;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "tensp";
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            this.colTenSP.Width = 125;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.DataPropertyName = "tenlsp";
            this.colLoaiSP.HeaderText = "Loại SP";
            this.colLoaiSP.MinimumWidth = 6;
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.ReadOnly = true;
            this.colLoaiSP.Width = 125;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.DataPropertyName = "dvTinh";
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.MinimumWidth = 6;
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            this.colDonViTinh.Width = 70;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "soLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 50;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "donGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 125;
            // 
            // colGiamGia
            // 
            this.colGiamGia.DataPropertyName = "giamGia";
            this.colGiamGia.HeaderText = "Giảm giá";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.ReadOnly = true;
            this.colGiamGia.Width = 80;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.MinimumWidth = 6;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Width = 125;
            // 
            // colNgaySX
            // 
            this.colNgaySX.DataPropertyName = "ngSanxuat";
            this.colNgaySX.HeaderText = "Ngày sản xuất";
            this.colNgaySX.MinimumWidth = 6;
            this.colNgaySX.Name = "colNgaySX";
            this.colNgaySX.ReadOnly = true;
            this.colNgaySX.Width = 125;
            // 
            // colHanSD
            // 
            this.colHanSD.DataPropertyName = "hanSD";
            this.colHanSD.HeaderText = "Hạn sử dụng";
            this.colHanSD.MinimumWidth = 6;
            this.colHanSD.Name = "colHanSD";
            this.colHanSD.ReadOnly = true;
            this.colHanSD.Width = 125;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(13, 336);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhAnh.Location = new System.Drawing.Point(1103, 9);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(84, 20);
            this.lblHinhAnh.TabIndex = 3;
            this.lblHinhAnh.Text = "Hình ảnh";
            this.lblHinhAnh.Click += new System.EventHandler(this.lblHinhAnh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(785, 337);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(312, 22);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(690, 340);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(68, 17);
            this.lblTimKiem.TabIndex = 5;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1107, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fSanPhamTimKiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1422, 380);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGVKetQuaTimKiem);
            this.Name = "fSanPhamTimKiem";
            this.Text = "Tìm kiếm sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVKetQuaTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVKetQuaTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanSD;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}