
namespace QLST
{
    partial class fThongTinTaiKhoan
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
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblWarningMatKhau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.grBThongtin = new System.Windows.Forms.GroupBox();
            this.chkChoPhepLogon = new System.Windows.Forms.CheckBox();
            this.btnXemThongTinNV = new CustomControls.RJControls.RJButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnChinhSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.grBThongtin.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(953, 59);
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
            this.iconButton1.Location = new System.Drawing.Point(875, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 56);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.ClientSizeChanged += new System.EventHandler(this.iconButton1_ClientSizeChanged);
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(52, 126);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(77, 20);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(187, 119);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(207, 20);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // lblWarningMatKhau
            // 
            this.lblWarningMatKhau.AutoSize = true;
            this.lblWarningMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMatKhau.Location = new System.Drawing.Point(187, 149);
            this.lblWarningMatKhau.Name = "lblWarningMatKhau";
            this.lblWarningMatKhau.Size = new System.Drawing.Size(350, 17);
            this.lblWarningMatKhau.TabIndex = 6;
            this.lblWarningMatKhau.Text = "*Mật khẩu phải là những kí tự từ a-z, từ A-Z, từ 0 đến 9";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(187, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 2);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(187, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 2);
            this.panel3.TabIndex = 8;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTaiKhoan.Enabled = false;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(187, 47);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(207, 20);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // grBThongtin
            // 
            this.grBThongtin.Controls.Add(this.chkChoPhepLogon);
            this.grBThongtin.Controls.Add(this.btnXemThongTinNV);
            this.grBThongtin.Controls.Add(this.txtMaNV);
            this.grBThongtin.Controls.Add(this.lblMaNV);
            this.grBThongtin.Controls.Add(this.txtTenTaiKhoan);
            this.grBThongtin.Controls.Add(this.panel3);
            this.grBThongtin.Controls.Add(this.panel2);
            this.grBThongtin.Controls.Add(this.lblWarningMatKhau);
            this.grBThongtin.Controls.Add(this.txtMatKhau);
            this.grBThongtin.Controls.Add(this.lblHoten);
            this.grBThongtin.Controls.Add(this.lblMatKhau);
            this.grBThongtin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBThongtin.Location = new System.Drawing.Point(24, 80);
            this.grBThongtin.Name = "grBThongtin";
            this.grBThongtin.Size = new System.Drawing.Size(911, 334);
            this.grBThongtin.TabIndex = 3;
            this.grBThongtin.TabStop = false;
            this.grBThongtin.Text = "Thông tin tài khoản";
            // 
            // chkChoPhepLogon
            // 
            this.chkChoPhepLogon.AutoSize = true;
            this.chkChoPhepLogon.Checked = true;
            this.chkChoPhepLogon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChoPhepLogon.Location = new System.Drawing.Point(56, 197);
            this.chkChoPhepLogon.Name = "chkChoPhepLogon";
            this.chkChoPhepLogon.Size = new System.Drawing.Size(164, 27);
            this.chkChoPhepLogon.TabIndex = 13;
            this.chkChoPhepLogon.Text = "Cho phép logon";
            this.chkChoPhepLogon.UseVisualStyleBackColor = true;
            // 
            // btnXemThongTinNV
            // 
            this.btnXemThongTinNV.BackColor = System.Drawing.Color.Orange;
            this.btnXemThongTinNV.BackgroundColor = System.Drawing.Color.Orange;
            this.btnXemThongTinNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemThongTinNV.BorderRadius = 0;
            this.btnXemThongTinNV.BorderSize = 0;
            this.btnXemThongTinNV.FlatAppearance.BorderSize = 0;
            this.btnXemThongTinNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTinNV.ForeColor = System.Drawing.Color.White;
            this.btnXemThongTinNV.Location = new System.Drawing.Point(327, 257);
            this.btnXemThongTinNV.Name = "btnXemThongTinNV";
            this.btnXemThongTinNV.Size = new System.Drawing.Size(271, 40);
            this.btnXemThongTinNV.TabIndex = 11;
            this.btnXemThongTinNV.Text = "Xem thông tin nhân viên";
            this.btnXemThongTinNV.TextColor = System.Drawing.Color.White;
            this.btnXemThongTinNV.UseVisualStyleBackColor = false;
            this.btnXemThongTinNV.Click += new System.EventHandler(this.btnXemThongTinNV_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(187, 263);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 30);
            this.txtMaNV.TabIndex = 10;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(49, 263);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(119, 23);
            this.lblMaNV.TabIndex = 9;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(52, 54);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(109, 20);
            this.lblHoten.TabIndex = 2;
            this.lblHoten.Text = "Tên tài khoản";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.BorderSize = 2;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXacNhan.IconColor = System.Drawing.Color.Black;
            this.btnXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacNhan.Location = new System.Drawing.Point(21, 420);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(137, 53);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(190, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 53);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnChinhSua.IconColor = System.Drawing.Color.White;
            this.btnChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChinhSua.IconSize = 35;
            this.btnChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSua.Location = new System.Drawing.Point(536, 420);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(157, 54);
            this.btnChinhSua.TabIndex = 5;
            this.btnChinhSua.Text = "Sửa thông tin";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(721, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(157, 54);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fThongTinTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(953, 515);
            this.ControlBox = false;
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grBThongtin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grBThongtin.ResumeLayout(false);
            this.grBThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnXacNhan;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnChinhSua;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblWarningMatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.GroupBox grBThongtin;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private CustomControls.RJControls.RJButton btnXemThongTinNV;
        private System.Windows.Forms.CheckBox chkChoPhepLogon;
    }
}