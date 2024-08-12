
namespace QLST
{
    partial class fDangNhap
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
            this.lblusername = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(53, 91);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(71, 17);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Tài khoản";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txttaikhoan.Location = new System.Drawing.Point(130, 91);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(256, 22);
            this.txttaikhoan.TabIndex = 1;
            this.txttaikhoan.Text = "Username";
            this.txttaikhoan.TextChanged += new System.EventHandler(this.txttaikhoan_TextChanged);
            this.txttaikhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txttaikhoan.Leave += new System.EventHandler(this.txttaikhoan_Leave);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(53, 133);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(68, 17);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Mật Khẩu";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtmatkhau.Location = new System.Drawing.Point(130, 133);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(256, 22);
            this.txtmatkhau.TabIndex = 2;
            this.txtmatkhau.Text = "Password";
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            this.txtmatkhau.Enter += new System.EventHandler(this.txtmatkhau_Enter);
            this.txtmatkhau.Leave += new System.EventHandler(this.txtmatkhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(146)))), ((int)(((byte)(24)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(130, 196);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(111, 40);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(146)))), ((int)(((byte)(24)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(276, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(146)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.lblDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 42);
            this.panel1.TabIndex = 4;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblDangNhap.Location = new System.Drawing.Point(4, 13);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(138, 25);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(127, 167);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 17);
            this.lblThongBao.TabIndex = 5;
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 270);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.lblusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblThongBao;
    }   
}