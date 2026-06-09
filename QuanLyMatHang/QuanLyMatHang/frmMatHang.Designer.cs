namespace QuanLyMatHang
{
    partial class frmMatHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ===== Khai báo control =====
            this.errChiTiet = new System.Windows.Forms.ErrorProvider(this.components);

            // (1) Panel tiêu đề
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();

            // (2) Panel nút lệnh
            this.pnlNutLenh = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            // (3) GroupBox Chi tiết
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblNgaySX = new System.Windows.Forms.Label();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHH = new System.Windows.Forms.Label();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.splitChiTiet = new System.Windows.Forms.Splitter();

            // (4) GroupBox Tìm kiếm
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTKMaSP = new System.Windows.Forms.Label();
            this.txtTKMaSP = new System.Windows.Forms.TextBox();
            this.lblTKTenSP = new System.Windows.Forms.Label();
            this.txtTKTenSP = new System.Windows.Forms.TextBox();
            this.lblTKDonGia = new System.Windows.Forms.Label();
            this.txtTKDonGia = new System.Windows.Forms.TextBox();
            this.splitTimKiem = new System.Windows.Forms.Splitter();

            // (5) GroupBox Kết quả
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.pnlNutLenh.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();

            // ========== (1) Panel tiêu đề ==========
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(784, 40);
            this.pnlTieuDe.TabIndex = 0;

            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F,
                System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(784, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ========== (2) Panel nút lệnh ==========
            this.pnlNutLenh.Controls.Add(this.btnTimKiem);
            this.pnlNutLenh.Controls.Add(this.btnThem);
            this.pnlNutLenh.Controls.Add(this.btnSua);
            this.pnlNutLenh.Controls.Add(this.btnXoa);
            this.pnlNutLenh.Controls.Add(this.btnThoat);
            this.pnlNutLenh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNutLenh.Location = new System.Drawing.Point(0, 521);
            this.pnlNutLenh.Name = "pnlNutLenh";
            this.pnlNutLenh.Size = new System.Drawing.Size(784, 50);
            this.pnlNutLenh.TabIndex = 5;

            this.btnTimKiem.Location = new System.Drawing.Point(30, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 27);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            this.btnThem.Location = new System.Drawing.Point(140, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 27);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "T&hêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(250, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(360, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 27);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.Location = new System.Drawing.Point(470, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 27);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // ========== (3) GroupBox Chi tiết ==========
            this.grbChiTiet.Controls.Add(this.lblMaSP);
            this.grbChiTiet.Controls.Add(this.txtMaSP);
            this.grbChiTiet.Controls.Add(this.lblTenSP);
            this.grbChiTiet.Controls.Add(this.txtTenSP);
            this.grbChiTiet.Controls.Add(this.lblNgaySX);
            this.grbChiTiet.Controls.Add(this.dtpNgaySX);
            this.grbChiTiet.Controls.Add(this.lblNgayHH);
            this.grbChiTiet.Controls.Add(this.dtpNgayHH);
            this.grbChiTiet.Controls.Add(this.lblDonVi);
            this.grbChiTiet.Controls.Add(this.txtDonVi);
            this.grbChiTiet.Controls.Add(this.lblDonGia);
            this.grbChiTiet.Controls.Add(this.txtDonGia);
            this.grbChiTiet.Controls.Add(this.lblGhiChu);
            this.grbChiTiet.Controls.Add(this.txtGhiChu);
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.btnHuy);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbChiTiet.Location = new System.Drawing.Point(484, 40);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(300, 481);
            this.grbChiTiet.TabIndex = 4;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết";

            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(15, 35);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(48, 13);
            this.lblMaSP.Text = "Mã SP:";

            this.txtMaSP.Location = new System.Drawing.Point(110, 32);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(170, 20);
            this.txtMaSP.TabIndex = 0;

            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(15, 68);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(45, 13);
            this.lblTenSP.Text = "Tên SP:";

            this.txtTenSP.Location = new System.Drawing.Point(110, 65);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(170, 20);
            this.txtTenSP.TabIndex = 1;

            this.lblNgaySX.AutoSize = true;
            this.lblNgaySX.Location = new System.Drawing.Point(15, 101);
            this.lblNgaySX.Name = "lblNgaySX";
            this.lblNgaySX.Size = new System.Drawing.Size(52, 13);
            this.lblNgaySX.Text = "Ngày SX:";

            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySX.Location = new System.Drawing.Point(110, 98);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(170, 20);
            this.dtpNgaySX.TabIndex = 2;

            this.lblNgayHH.AutoSize = true;
            this.lblNgayHH.Location = new System.Drawing.Point(15, 134);
            this.lblNgayHH.Name = "lblNgayHH";
            this.lblNgayHH.Size = new System.Drawing.Size(53, 13);
            this.lblNgayHH.Text = "Ngày HH:";

            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(110, 131);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(170, 20);
            this.dtpNgayHH.TabIndex = 3;

            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(15, 167);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(40, 13);
            this.lblDonVi.Text = "Đơn vị:";

            this.txtDonVi.Location = new System.Drawing.Point(110, 164);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(170, 20);
            this.txtDonVi.TabIndex = 4;

            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(15, 200);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(48, 13);
            this.lblDonGia.Text = "Đơn giá:";

            this.txtDonGia.Location = new System.Drawing.Point(110, 197);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(170, 20);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);

            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(15, 233);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(45, 13);
            this.lblGhiChu.Text = "Ghi chú:";

            this.txtGhiChu.Location = new System.Drawing.Point(110, 230);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(170, 60);
            this.txtGhiChu.TabIndex = 6;

            this.btnLuu.Location = new System.Drawing.Point(60, 320);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 27);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(170, 320);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 27);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // ----- Splitter giữa (3) và phần còn lại -----
            this.splitChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitChiTiet.Location = new System.Drawing.Point(481, 40);
            this.splitChiTiet.Name = "splitChiTiet";
            this.splitChiTiet.Size = new System.Drawing.Size(3, 481);
            this.splitChiTiet.TabStop = false;

            // ========== (4) GroupBox Tìm kiếm ==========
            this.grbTimKiem.Controls.Add(this.lblTKMaSP);
            this.grbTimKiem.Controls.Add(this.txtTKMaSP);
            this.grbTimKiem.Controls.Add(this.lblTKTenSP);
            this.grbTimKiem.Controls.Add(this.txtTKTenSP);
            this.grbTimKiem.Controls.Add(this.lblTKDonGia);
            this.grbTimKiem.Controls.Add(this.txtTKDonGia);
            this.grbTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTimKiem.Location = new System.Drawing.Point(0, 40);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(481, 100);
            this.grbTimKiem.TabIndex = 1;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";

            this.lblTKMaSP.AutoSize = true;
            this.lblTKMaSP.Location = new System.Drawing.Point(20, 30);
            this.lblTKMaSP.Name = "lblTKMaSP";
            this.lblTKMaSP.Size = new System.Drawing.Size(48, 13);
            this.lblTKMaSP.Text = "Mã SP:";

            this.txtTKMaSP.Location = new System.Drawing.Point(75, 27);
            this.txtTKMaSP.Name = "txtTKMaSP";
            this.txtTKMaSP.Size = new System.Drawing.Size(140, 20);
            this.txtTKMaSP.TabIndex = 0;

            this.lblTKTenSP.AutoSize = true;
            this.lblTKTenSP.Location = new System.Drawing.Point(240, 30);
            this.lblTKTenSP.Name = "lblTKTenSP";
            this.lblTKTenSP.Size = new System.Drawing.Size(45, 13);
            this.lblTKTenSP.Text = "Tên SP:";

            this.txtTKTenSP.Location = new System.Drawing.Point(295, 27);
            this.txtTKTenSP.Name = "txtTKTenSP";
            this.txtTKTenSP.Size = new System.Drawing.Size(140, 20);
            this.txtTKTenSP.TabIndex = 1;

            this.lblTKDonGia.AutoSize = true;
            this.lblTKDonGia.Location = new System.Drawing.Point(20, 63);
            this.lblTKDonGia.Name = "lblTKDonGia";
            this.lblTKDonGia.Size = new System.Drawing.Size(50, 13);
            this.lblTKDonGia.Text = "Đơn giá:";

            this.txtTKDonGia.Location = new System.Drawing.Point(75, 60);
            this.txtTKDonGia.Name = "txtTKDonGia";
            this.txtTKDonGia.Size = new System.Drawing.Size(140, 20);
            this.txtTKDonGia.TabIndex = 2;
            this.txtTKDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);

            // ----- Splitter giữa (4) và (5) -----
            this.splitTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitTimKiem.Location = new System.Drawing.Point(0, 140);
            this.splitTimKiem.Name = "splitTimKiem";
            this.splitTimKiem.Size = new System.Drawing.Size(481, 3);
            this.splitTimKiem.TabStop = false;

            // ========== (5) GroupBox Kết quả ==========
            this.grbKetQua.Controls.Add(this.dgvKetQua);
            this.grbKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbKetQua.Location = new System.Drawing.Point(0, 143);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(481, 408);
            this.grbKetQua.TabIndex = 2;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả";

            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(3, 16);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(475, 389);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellClick);

            // ========== Form ==========
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 571);

            // CHÚ Ý THỨ TỰ ADD: ngược với thứ tự Dock để layout đúng
            this.Controls.Add(this.grbKetQua);     // Fill (thêm trước)
            this.Controls.Add(this.splitTimKiem);  // Top splitter
            this.Controls.Add(this.grbTimKiem);    // Top
            this.Controls.Add(this.splitChiTiet);  // Right splitter
            this.Controls.Add(this.grbChiTiet);    // Right
            this.Controls.Add(this.pnlNutLenh);    // Bottom
            this.Controls.Add(this.pnlTieuDe);     // Top (thêm cuối)

            this.Name = "frmMatHang";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmMatHang_Load);

            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlNutLenh.ResumeLayout(false);
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ===== Khai báo field cho các control =====
        private System.Windows.Forms.ErrorProvider errChiTiet;

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.Panel pnlNutLenh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblNgaySX;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Label lblNgayHH;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Splitter splitChiTiet;

        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Label lblTKMaSP;
        private System.Windows.Forms.TextBox txtTKMaSP;
        private System.Windows.Forms.Label lblTKTenSP;
        private System.Windows.Forms.TextBox txtTKTenSP;
        private System.Windows.Forms.Label lblTKDonGia;
        private System.Windows.Forms.TextBox txtTKDonGia;
        private System.Windows.Forms.Splitter splitTimKiem;

        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridView dgvKetQua;
    }
}