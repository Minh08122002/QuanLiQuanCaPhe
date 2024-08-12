
namespace QLST
{
    partial class fThemLoaiSP
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
            this.txtMalSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLSPmoi = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.paneLSP = new System.Windows.Forms.Panel();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.paneLSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMalSP
            // 
            this.txtMalSP.Location = new System.Drawing.Point(195, 110);
            this.txtMalSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMalSP.Name = "txtMalSP";
            this.txtMalSP.Size = new System.Drawing.Size(339, 22);
            this.txtMalSP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Loại Sản Phẩm: ";
            // 
            // txtTenLSPmoi
            // 
            this.txtTenLSPmoi.Location = new System.Drawing.Point(195, 59);
            this.txtTenLSPmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLSPmoi.Name = "txtTenLSPmoi";
            this.txtTenLSPmoi.Size = new System.Drawing.Size(339, 22);
            this.txtTenLSPmoi.TabIndex = 4;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTen.Location = new System.Drawing.Point(44, 63);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(141, 17);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên Loại Sản Phẩm: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(25, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Thêm Loại Sản Phẩm ";
            // 
            // paneLSP
            // 
            this.paneLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.paneLSP.Controls.Add(this.txtMalSP);
            this.paneLSP.Controls.Add(this.label1);
            this.paneLSP.Controls.Add(this.btnThem);
            this.paneLSP.Controls.Add(this.btnExit);
            this.paneLSP.Controls.Add(this.txtTenLSPmoi);
            this.paneLSP.Controls.Add(this.lblTen);
            this.paneLSP.Controls.Add(this.lblTitle);
            this.paneLSP.Location = new System.Drawing.Point(26, 24);
            this.paneLSP.Margin = new System.Windows.Forms.Padding(4);
            this.paneLSP.Name = "paneLSP";
            this.paneLSP.Size = new System.Drawing.Size(640, 156);
            this.paneLSP.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Khaki;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnThem.IconSize = 30;
            this.btnThem.Location = new System.Drawing.Point(548, 80);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 31);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(568, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fThemLoaiSP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 202);
            this.Controls.Add(this.paneLSP);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemLoaiSP";
            this.Text = "fThemLoaiSP";
            this.paneLSP.ResumeLayout(false);
            this.paneLSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMalSP;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.TextBox txtTenLSPmoi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel paneLSP;
    }
}