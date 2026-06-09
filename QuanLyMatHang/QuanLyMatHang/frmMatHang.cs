using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyMatHang
{
    public partial class frmMatHang : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        public frmMatHang()
        {
            InitializeComponent();
        }

        private void HienChiTiet(bool hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        private void XoaTrangChiTiet()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNgaySX.Value = DateTime.Today;
            dtpNgayHH.Value = DateTime.Today;
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = dtbase.DataReader("Select * from tblMatHang");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(false);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TÌM KIẾM MẶT HÀNG";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            string sql = "SELECT * FROM tblMatHang WHERE MaSP IS NOT NULL ";
            if (txtTKMaSP.Text.Trim() != "")
                sql += " AND MaSP LIKE N'%" + txtTKMaSP.Text + "%'";
            if (txtTKTenSP.Text.Trim() != "")
                sql += " AND TenSP LIKE N'%" + txtTKTenSP.Text + "%'";
            if (txtTKDonGia.Text.Trim() != "")
                sql += " AND DonGia = " + txtTKDonGia.Text.Trim();

            dgvKetQua.DataSource = dtbase.DataReader(sql);
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            try
            {
                txtMaSP.Text = dgvKetQua.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvKetQua.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySX.Value = (DateTime)dgvKetQua.CurrentRow.Cells[2].Value;
                dtpNgayHH.Value = (DateTime)dgvKetQua.CurrentRow.Cells[3].Value;
                txtDonVi.Text = dgvKetQua.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dgvKetQua.CurrentRow.Cells[5].Value.ToString();
                txtGhiChu.Text = dgvKetQua.CurrentRow.Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG";
            XoaTrangChiTiet();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "CẬP NHẬT MẶT HÀNG";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txtMaSP.Text +
                " không? Nếu có ấn nút Lưu, không thì ấn nút Hủy",
                "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTieuDe.Text = "XÓA MẶT HÀNG";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                HienChiTiet(true);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (txtTenSP.Text.Trim() == "")
            { errChiTiet.SetError(txtTenSP, "Bạn không để trống tên sản phẩm!"); return; }
            else errChiTiet.Clear();

            if (dtpNgaySX.Value > DateTime.Now)
            { errChiTiet.SetError(dtpNgaySX, "Ngày sản xuất không hợp lệ!"); return; }
            else errChiTiet.Clear();

            if (dtpNgayHH.Value < dtpNgaySX.Value)
            { errChiTiet.SetError(dtpNgayHH, "Ngày hết hạn nhỏ hơn ngày sản xuất!"); return; }
            else errChiTiet.Clear();

            if (txtDonVi.Text.Trim() == "")
            { errChiTiet.SetError(txtDonVi, "Bạn không để trống đơn vị!"); return; }
            else errChiTiet.Clear();

            if (txtDonGia.Text.Trim() == "")
            { errChiTiet.SetError(txtDonGia, "Bạn không để trống đơn giá!"); return; }
            else errChiTiet.Clear();

            string ngaySX = dtpNgaySX.Value.ToString("yyyy-MM-dd");
            string ngayHH = dtpNgayHH.Value.ToString("yyyy-MM-dd");

            // THÊM MỚI
            if (btnThem.Enabled == true)
            {
                if (txtMaSP.Text.Trim() == "")
                { errChiTiet.SetError(txtMaSP, "Bạn không để trống mã sản phẩm!"); return; }

                sql = "Select * From tblMatHang Where MaSP = N'" + txtMaSP.Text + "'";
                DataTable dtSP = dtbase.DataReader(sql);
                if (dtSP.Rows.Count > 0)
                { errChiTiet.SetError(txtMaSP, "Mã sản phẩm trùng trong cơ sở dữ liệu"); return; }
                errChiTiet.Clear();

                sql = "INSERT INTO tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) VALUES(";
                sql += "N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + ngaySX + "','" +
                       ngayHH + "',N'" + txtDonVi.Text + "','" + txtDonGia.Text + "',N'" + txtGhiChu.Text + "')";
            }

            // SỬA
            if (btnSua.Enabled == true)
            {
                sql = "Update tblMatHang SET ";
                sql += "TenSP = N'" + txtTenSP.Text + "',";
                sql += "NgaySX = '" + ngaySX + "',";
                sql += "NgayHH = '" + ngayHH + "',";
                sql += "DonVi = N'" + txtDonVi.Text + "',";
                sql += "DonGia = '" + txtDonGia.Text + "',";
                sql += "GhiChu = N'" + txtGhiChu.Text + "' ";
                sql += "Where MaSP = N'" + txtMaSP.Text + "'";
            }

            // XÓA
            if (btnXoa.Enabled == true)
            {
                sql = "Delete From tblMatHang Where MaSP = N'" + txtMaSP.Text + "'";
            }

            dtbase.DataChange(sql);

            dgvKetQua.DataSource = dtbase.DataReader("Select * from tblMatHang");

            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            XoaTrangChiTiet();
            HienChiTiet(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}