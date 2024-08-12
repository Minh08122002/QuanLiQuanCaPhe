
namespace QLST
{
    partial class fThemTaiKhoan
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
            this.grBThongtin = new System.Windows.Forms.GroupBox();
            this.chkChoPhepLogon = new System.Windows.Forms.CheckBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWarningDaTonTai = new System.Windows.Forms.Label();
            this.lblWarningTaiKhoan = new System.Windows.Forms.Label();
            this.lblWarningMatKhau = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Size = new System.Drawing.Size(823, 59);
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
            this.lblInformation.Size = new System.Drawing.Size(145, 25);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "THÔNG TIN";
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
            this.iconButton1.Location = new System.Drawing.Point(1048, 3);
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
            this.lblHoten.Size = new System.Drawing.Size(77, 20);
            this.lblHoten.TabIndex = 2;
            this.lblHoten.Text = "Mật khẩu";
            // 
            // grBThongtin
            // 
            this.grBThongtin.Controls.Add(this.chkChoPhepLogon);
            this.grBThongtin.Controls.Add(this.txtTaiKhoan);
            this.grBThongtin.Controls.Add(this.txtMatKhau);
            this.grBThongtin.Controls.Add(this.panel7);
            this.grBThongtin.Controls.Add(this.panel2);
            this.grBThongtin.Controls.Add(this.lblWarningDaTonTai);
            this.grBThongtin.Controls.Add(this.lblWarningTaiKhoan);
            this.grBThongtin.Controls.Add(this.lblWarningMatKhau);
            this.grBThongtin.Controls.Add(this.lblMaNV);
            this.grBThongtin.Controls.Add(this.lblHoten);
            this.grBThongtin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBThongtin.Location = new System.Drawing.Point(24, 80);
            this.grBThongtin.Name = "grBThongtin";
            this.grBThongtin.Size = new System.Drawing.Size(780, 281);
            this.grBThongtin.TabIndex = 3;
            this.grBThongtin.TabStop = false;
            this.grBThongtin.Text = "Thông tin nhân viên";
            this.grBThongtin.Enter += new System.EventHandler(this.grBThongtin_Enter);
            // 
            // chkChoPhepLogon
            // 
            this.chkChoPhepLogon.AutoSize = true;
            this.chkChoPhepLogon.Checked = true;
            this.chkChoPhepLogon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChoPhepLogon.Location = new System.Drawing.Point(62, 206);
            this.chkChoPhepLogon.Name = "chkChoPhepLogon";
            this.chkChoPhepLogon.Size = new System.Drawing.Size(164, 27);
            this.chkChoPhepLogon.TabIndex = 8;
            this.chkChoPhepLogon.Text = "Cho phép logon";
            this.chkChoPhepLogon.UseVisualStyleBackColor = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(193, 79);
            this.txtTaiKhoan.MaxLength = 10;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(207, 20);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(193, 133);
            this.txtMatKhau.MaxLength = 15;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(207, 20);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(193, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 2);
            this.panel2.TabIndex = 7;
            // 
            // lblWarningDaTonTai
            // 
            this.lblWarningDaTonTai.AutoSize = true;
            this.lblWarningDaTonTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningDaTonTai.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDaTonTai.Location = new System.Drawing.Point(416, 87);
            this.lblWarningDaTonTai.Name = "lblWarningDaTonTai";
            this.lblWarningDaTonTai.Size = new System.Drawing.Size(139, 17);
            this.lblWarningDaTonTai.TabIndex = 6;
            this.lblWarningDaTonTai.Text = "*Tài khoản đã tồn tại";
            this.lblWarningDaTonTai.Visible = false;
            // 
            // lblWarningTaiKhoan
            // 
            this.lblWarningTaiKhoan.AutoSize = true;
            this.lblWarningTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTaiKhoan.Location = new System.Drawing.Point(190, 113);
            this.lblWarningTaiKhoan.Name = "lblWarningTaiKhoan";
            this.lblWarningTaiKhoan.Size = new System.Drawing.Size(538, 17);
            this.lblWarningTaiKhoan.TabIndex = 6;
            this.lblWarningTaiKhoan.Text = "*Tài khoản chỉ chứa giá trị từ a-z, từ A-Z, từ 0 đến 9 và có chiều dài tối đa là " +
    "10 kí tự ";
            this.lblWarningTaiKhoan.Visible = false;
            // 
            // lblWarningMatKhau
            // 
            this.lblWarningMatKhau.AutoSize = true;
            this.lblWarningMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblWarningMatKhau.Location = new System.Drawing.Point(193, 166);
            this.lblWarningMatKhau.Name = "lblWarningMatKhau";
            this.lblWarningMatKhau.Size = new System.Drawing.Size(533, 17);
            this.lblWarningMatKhau.TabIndex = 6;
            this.lblWarningMatKhau.Text = "*Mật khẩu chỉ chứa giá trị từ a-z, từ A-Z, từ 0 đến 9 và có chiều dài tối đa là 1" +
    "5 kí tự ";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(58, 78);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(109, 20);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Tên tài khoản";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.BorderSize = 2;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXacNhan.IconColor = System.Drawing.Color.Black;
            this.btnXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacNhan.Location = new System.Drawing.Point(24, 380);
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
            this.btnThoat.Location = new System.Drawing.Point(217, 381);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 53);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fThemTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(823, 447);
            this.ControlBox = false;
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grBThongtin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fThemTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grBThongtin.ResumeLayout(false);
            this.grBThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.GroupBox grBThongtin;
        private System.Windows.Forms.Label lblWarningMatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.CheckBox chkChoPhepLogon;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblWarningTaiKhoan;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblWarningDaTonTai;
        private FontAwesome.Sharp.IconButton btnXacNhan;
    }
}