
namespace QLST
{
    partial class fLoaiSanPhamMoi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvLSP = new System.Windows.Forms.DataGridView();
            this.colMa_LSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen_LSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLSPMoi = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.dtgvLSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 444);
            this.panel2.TabIndex = 25;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(363, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtMaLSp_TextChanged);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(53, 68);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(120, 53);
            this.iconButton4.TabIndex = 26;
            this.iconButton4.Text = "Thêm mới";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(49, 143);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 53);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(158)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(47, 219);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 53);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel3.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(279, 68);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(615, 42);
            this.flowLayoutPanel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "     ";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(47, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã LSP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(146, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(161, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên LSP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(307, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(283, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Trạng thái";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgvLSP
            // 
            this.dtgvLSP.AllowUserToAddRows = false;
            this.dtgvLSP.AllowUserToDeleteRows = false;
            this.dtgvLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa_LSP,
            this.colTen_LSP,
            this.colTrangThai});
            this.dtgvLSP.Location = new System.Drawing.Point(279, 116);
            this.dtgvLSP.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvLSP.MultiSelect = false;
            this.dtgvLSP.Name = "dtgvLSP";
            this.dtgvLSP.ReadOnly = true;
            this.dtgvLSP.RowHeadersWidth = 51;
            this.dtgvLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLSP.Size = new System.Drawing.Size(615, 284);
            this.dtgvLSP.TabIndex = 0;
            // 
            // colMa_LSP
            // 
            this.colMa_LSP.DataPropertyName = "MA_LOAI_SP";
            this.colMa_LSP.HeaderText = "Mã loại SP";
            this.colMa_LSP.MinimumWidth = 6;
            this.colMa_LSP.Name = "colMa_LSP";
            this.colMa_LSP.ReadOnly = true;
            this.colMa_LSP.Width = 99;
            // 
            // colTen_LSP
            // 
            this.colTen_LSP.DataPropertyName = "TEN_LOAI_SP";
            this.colTen_LSP.HeaderText = "Tên loại SP";
            this.colTen_LSP.MinimumWidth = 6;
            this.colTen_LSP.Name = "colTen_LSP";
            this.colTen_LSP.ReadOnly = true;
            this.colTen_LSP.Width = 161;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAILSP";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 283;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWhite.Location = new System.Drawing.Point(0, 50);
            this.panelWhite.Margin = new System.Windows.Forms.Padding(4);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(1097, 26);
            this.panelWhite.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel1.Controls.Add(this.lblLSPMoi);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 50);
            this.panel1.TabIndex = 23;
            // 
            // lblLSPMoi
            // 
            this.lblLSPMoi.AutoSize = true;
            this.lblLSPMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLSPMoi.ForeColor = System.Drawing.Color.White;
            this.lblLSPMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLSPMoi.Location = new System.Drawing.Point(3, 16);
            this.lblLSPMoi.Name = "lblLSPMoi";
            this.lblLSPMoi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblLSPMoi.Size = new System.Drawing.Size(174, 25);
            this.lblLSPMoi.TabIndex = 1;
            this.lblLSPMoi.Text = "Loại Sản Phẩm";
            this.lblLSPMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.iconButton1.Location = new System.Drawing.Point(989, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 57);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // fLoaiSanPhamMoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1097, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLoaiSanPhamMoi";
            this.Text = "fLoaiSanPhamMoi";
            this.Load += new System.EventHandler(this.fLoaiSanPhamMoi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvLSP;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLSPMoi;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_LSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen_LSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}