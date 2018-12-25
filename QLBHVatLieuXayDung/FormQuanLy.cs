using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormQuanLy : Form
    {
        BindingSource listHoaDon = new BindingSource();
        BindingSource listCTHD = new BindingSource();
        private bool coThem;
        private bool coThemCTHD;
        public FormQuanLy()
        {
            InitializeComponent();
            LoadList();
            LoadButtonDesign();
        }

        void LoadButtonDesign()
        {
            btnShowKhachHang.TabStop = false;
            btnShowKhachHang.FlatAppearance.BorderSize = 0;
            btnShowSPQL.TabStop = false;
            btnShowSPQL.FlatAppearance.BorderSize = 0;
            btnShowLoaiSP.TabStop = false;
            btnShowLoaiSP.FlatAppearance.BorderSize = 0;
            btnShowThanhToan.TabStop = false;
            btnShowThanhToan.FlatAppearance.BorderSize = 0;
            btnFormThanhToan.TabStop = false;
            btnFormThanhToan.FlatAppearance.BorderSize = 0;
            btnAddHD.TabStop = false;
            btnAddHD.FlatAppearance.BorderSize = 0;
            btnEditHD.TabStop = false;
            btnEditHD.FlatAppearance.BorderSize = 0;
            btnDeleteHD.TabStop = false;
            btnDeleteHD.FlatAppearance.BorderSize = 0;
            btnSaveHoaDon.TabStop = false;
            btnClearHoaDon.TabStop = false;
            btnClearHoaDon.FlatAppearance.BorderSize = 0;
            btnSaveHoaDon.FlatAppearance.BorderSize = 0;
            btnCTHD_save.TabStop = false;
            btnCTHD_clear.TabStop = false;
            btnCTHD_add.TabStop = false;
            btnCTHD_edit.TabStop = false;
            btnCTHD_delete.TabStop = false;
            btnCTHD_save.FlatAppearance.BorderSize = 0;
            btnCTHD_clear.FlatAppearance.BorderSize = 0;
            btnCTHD_add.FlatAppearance.BorderSize = 0;
            btnCTHD_edit.FlatAppearance.BorderSize = 0;
            btnCTHD_delete.FlatAppearance.BorderSize = 0;
        }

        #region Methods
        void LoadMaKHIntoCombobox(ComboBox box)
        {
            box.DataSource = KhachHangAC.Instance.LoadListKhachHang();
            box.DisplayMember = "Tên khách hàng";
            box.ValueMember = "Mã khách hàng";
        }
        void LoadMaSPIntoCombobox(ComboBox box)
        {
            box.DataSource = SanPhamAC.Instance.LoadListSanPham();
            box.DisplayMember = "Tên sản phẩm";
            box.ValueMember = "Mã sản phẩm";
        }
        void HoaDonBinding()
        {
            txbMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "Số hóa đơn", true, DataSourceUpdateMode.Never));
            dtpNgayHD.DataBindings.Add(new Binding("Value", dgvHoaDon.DataSource, "Ngày hóa đơn", true, DataSourceUpdateMode.Never));
            //numUpDMaSPOfHD.DataBindings.Add(new Binding("Value", dgvCTHD.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            txbCTDH_donGia.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            //txbSoLuongCTHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            //txbMaCTHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Mã hóa đơn", true, DataSourceUpdateMode.Never));
        }

        void LoadList()
        {
            dgvCTHD.DataSource = listCTHD;
            dgvHoaDon.DataSource = listHoaDon;
            LoadListHoaDon();
            LoadListCTHD();
            LoadSoHoaDon(cbxCTHD_maHoaDon);
            LoadMaKHIntoCombobox(cbxMaKHOfHD);
            LoadMaSPIntoCombobox(cbxCTHD_maSP);
            SetLockHoaDon(false);
            SetBtnLockHoaDon(false);
            SetLockCTHD(false);
            SetBtnLockCTHD(false);
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
            LableThem();
            //HoaDonBinding();
        }
        #endregion

        #region Methods Hóa đơn
        void SetBtnLockHoaDon(bool a)
        {
            btnSaveHoaDon.Enabled = a;
            btnClearHoaDon.Enabled = a;
            btnAddHD.Enabled = !a;
            btnEditHD.Enabled = !a;
            btnDeleteHD.Enabled = !a;
        }
        void SetNULLHoaDon()
        {
            txbMaHD.Text = string.Empty;
            dtpNgayHD.Value = DateTime.Today;
        }
        void SetLockHoaDon(bool a)
        {
            txbMaHD.ReadOnly = !a;
            cbxMaKHOfHD.Enabled = a;
            dtpNgayHD.Enabled = a;
        }
        void LoadListHoaDon()
        {
            listHoaDon.DataSource = QuanLyAC.Instance.LoadListHoaDon();
        }
        #endregion

        #region Methods Chi tiết hóa đơn
        void LoadSoHoaDon(ComboBox box)
        {
            box.DataSource = QuanLyAC.Instance.LoadListHoaDon();
            box.DisplayMember = "Số hóa đơn";
            box.ValueMember = "Số hóa đơn";
        }
        void SetBtnLockCTHD(bool a)
        {
            btnCTHD_save.Enabled = a;
            btnCTHD_clear.Enabled = a;
            btnCTHD_add.Enabled = !a;
            //btnEditCTHD.Enabled = !a;
            btnCTHD_delete.Enabled = !a;
        }
        void SetNULLCTHD()
        {
            //txbMaCTHD.Text = string.Empty;
            txbCTDH_donGia.Text = string.Empty;
            numupdCTHD_soLuong.Value = 0;
        }
        void SetLockCTHD(bool a)
        {
            //txbMaCTHD.ReadOnly = !a;
            cbxCTHD_maHoaDon.Enabled = a;
            cbxCTHD_maSP.Enabled = a;
            numupdCTHD_soLuong.Enabled = a;
            txbCTDH_donGia.ReadOnly = !a;
        }
        void LoadListCTHD()
        {
            listCTHD.DataSource = QuanLyAC.Instance.LoadListCTHD();
        }
        void LableThem()
        {
            lbThemTBCTHD.Text = string.Empty;
            lbThemTCCTHD.Text = string.Empty;
        }
        #endregion

        #region events
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnShowHoaDon_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void btnShowSPQL_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn đăng xuất hông?", "Chời ơi tin được hông", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void btnShowThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan_List f = new FormThanhToan_List();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void btnCTHD_thanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan f = new FormThanhToan();
            f.ShowDialog();
        }
        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            //LoadList();
            //LoadList();
        }

        private void btnShowSanPhamQL_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            f.Show();
        }

        private void btnShowKHQL_Click(object sender, EventArgs e)
        {
            FormChonKhachHang f = new FormChonKhachHang();
            f.Show();
        }

        private void btnFormThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan f = new FormThanhToan();
            f.ShowDialog();
        }

        private void btnRefreshHD_Click(object sender, EventArgs e)
        {
            LoadListHoaDon();
            LoadMaKHIntoCombobox(cbxMaKHOfHD);
            
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
            //HoaDonBinding();
        }

        private void btnShowLoaiSP_Click(object sender, EventArgs e)
        {
            FormLoaiSanPham f = new FormLoaiSanPham();
            Hide();
            f.ShowDialog();
            Show();
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //HoaDonBinding();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count > 0)
                {
                    txbMaHD.Text = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                    cbxMaKHOfHD.SelectedValue = dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString();
                    dtpNgayHD.Value = Convert.ToDateTime(dgvHoaDon.SelectedRows[0].Cells[2].Value);
                }
                else if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                    txbMaHD.Text = row.Cells[0].Value.ToString();
                    cbxMaKHOfHD.SelectedValue = row.Cells[1].Value.ToString();
                    dtpNgayHD.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (FormatException)
            {

            }
        }

        private void tabPageHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCTHD.SelectedRows.Count > 0)
                {
                    //txbMaCTHD.Text = dgvCTHD.SelectedRows[0].Cells[0].Value.ToString();
                    cbxCTHD_maSP.SelectedValue = dgvCTHD.SelectedRows[0].Cells[1].Value.ToString();
                    numupdCTHD_soLuong.Value = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells[2].Value);
                    txbCTDH_donGia.Text = dgvCTHD.SelectedRows[0].Cells[3].Value.ToString();
                    cbxCTHD_maHoaDon.SelectedValue = dgvCTHD.SelectedRows[0].Cells[0].Value.ToString();
                }
                else if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCTHD.Rows[e.RowIndex];
                    //txbMaCTHD.Text = row.Cells[0].Value.ToString();
                    cbxCTHD_maSP.SelectedValue = row.Cells[1].Value.ToString();
                    numupdCTHD_soLuong.Value = Convert.ToInt32(row.Cells[2].Value);
                    txbCTDH_donGia.Text = row.Cells[3].Value.ToString();
                    cbxCTHD_maHoaDon.SelectedValue = row.Cells[0].Value.ToString();
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (FormatException)
            {

            }
            catch (InvalidCastException)
            {

            }
        }

        private void btnRefreshCTHD_Click(object sender, EventArgs e)
        {
            LoadListCTHD();
            LoadMaSPIntoCombobox(cbxCTHD_maSP);
            LoadSoHoaDon(cbxCTHD_maHoaDon);
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        #endregion

        #region Events HoaDon
        private void btnAddHD_Click(object sender, EventArgs e)
        {
            SetBtnLockHoaDon(true);
            SetLockHoaDon(true);
            SetNULLHoaDon();
            txbMaHD.Text = "HD";
            coThem = true;
        }

        private void btnClearHoaDon_Click(object sender, EventArgs e)
        {
            SetBtnLockHoaDon(false);
            SetLockHoaDon(false);
            SetNULLHoaDon();
        }

        private void btnEditHD_Click(object sender, EventArgs e)
        {
            txbMaHD.ReadOnly = true;
            SetBtnLockHoaDon(true);
            SetLockHoaDon(true);
            coThem = false;
        }

        private void btnSaveHoaDon_Click(object sender, EventArgs e)
        {
            string soHoaDon = txbMaHD.Text;
            string maKH = cbxMaKHOfHD.SelectedValue.ToString();
            string ngayHoaDon = string.Format("{0:MM/dd/yyyy}", dtpNgayHD.Value);
            if (coThem == true)
            {
                try
                {
                    if (txbMaHD.Text == string.Empty || txbMaHD.Text == "HD")
                    {
                        lbThemTC.Text = string.Empty;
                        lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                    }
                    else
                    if (QuanLyAC.Instance.ThemHoaDon(soHoaDon, maKH, ngayHoaDon))
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTC.Text = "<\\ Thêm hóa đơn thành công >";
                        LoadListHoaDon();
                        SetBtnLockHoaDon(false);
                        SetLockHoaDon(false);
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    
                    if(dtpNgayHD.Value > DateTime.Today)
                    {
                        lbThemTC.Text = string.Empty;
                        lbThemTB.Text = "<\\ Ngày không hợp lệ >";
                    }
                    else
                    {
                        lbThemTC.Text = string.Empty;
                        lbThemTB.Text = "<\\ Mã hóa đơn đã tồn tại >";
                    }
                }
            }
            else if (coThem == false)
            {
                if (txbMaHD.Text == string.Empty || txbMaHD.Text == "HD")
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                }
                else
                if (QuanLyAC.Instance.SuaHoaDon(soHoaDon, maKH, ngayHoaDon))
                {
                    lbThemTB.Text = string.Empty;
                    lbThemTC.Text = "<\\ Sửa hóa đơn thành công >";
                    LoadListHoaDon();
                    SetBtnLockHoaDon(false);
                    SetLockHoaDon(false);
                }
            }
        }

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            string soHoaDon = txbMaHD.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hoá đơn [" + txbMaHD.Text + "] không?", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (QuanLyAC.Instance.XoaHoaDon(soHoaDon))
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTC.Text = "<\\ Xóa hóa đơn thành công >";
                    LoadListHoaDon();
                    LoadListCTHD();
                    SetBtnLockHoaDon(false);
                    SetLockHoaDon(false);
                }
                else
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Xóa hóa đơn thất bại! >";
                }
            }
        }

        #endregion

        #region Events Chi tiết hóa đơn
        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            SetBtnLockCTHD(true);
            SetLockCTHD(true);
            SetNULLCTHD();
            //txbMaCTHD.Text = "HD";
            txbCTDH_donGia.Text = "0";
            coThemCTHD = true;
        }

        private void btnClearCTHD_Click(object sender, EventArgs e)
        {
            LoadListCTHD();
            SetBtnLockCTHD(false);
            SetLockCTHD(false);
            SetNULLCTHD();
            LableThem();
        }

        private void btnEditCTHD_Click(object sender, EventArgs e)
        {
            //txbMaCTHD.ReadOnly = true;
            SetBtnLockCTHD(true);
            SetLockCTHD(true);
            coThemCTHD = false;
        }

        private void btnSaveCTHD_Click(object sender, EventArgs e)
        {
            string maHoaDon = cbxCTHD_maHoaDon.SelectedValue.ToString();
            //string maHoaDon = txbMaCTHD.Text;
            string maSanPham = cbxCTHD_maSP.SelectedValue.ToString();
            int soLuong = Convert.ToInt32(numupdCTHD_soLuong.Value);
            double donGia = double.Parse(txbCTDH_donGia.Text);
            if (coThemCTHD == true)
            {
                try
                {
                    if (txbCTDH_donGia.Text == string.Empty)
                    {
                        lbThemTCCTHD.Text = string.Empty;
                        lbThemTBCTHD.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                    }
                    else
                    if (QuanLyAC.Instance.ThemChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia))
                    {
                        lbThemTBCTHD.Text = string.Empty;
                        lbThemTCCTHD.Text = "<\\ Thêm chi tiết hóa đơn thành công >";
                        LoadListCTHD();
                        SetBtnLockCTHD(false);
                        SetLockCTHD(false);
                    }
                    else
                    {
                        lbThemTCCTHD.Text = string.Empty;
                        lbThemTBCTHD.Text = "<\\ Thêm chi tiết hóa đơn thất bại >";
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lbThemTCCTHD.Text = string.Empty;
                    lbThemTBCTHD.Text = "<\\ Mã hóa đơn không tồn tại >";
                }
                catch (FormatException)
                {
                    lbThemTCCTHD.Text = string.Empty;
                    lbThemTBCTHD.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                }
            }
            /**
            else if(coThemCTHD == false)
            {
                if (txbMaCTHD.Text == string.Empty || txbDonGiaOfHD.Text == string.Empty || txbMaCTHD.Text == "HD")
                {
                    lbThemTCCTHD.Text = string.Empty;
                    lbThemTBCTHD.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                }
                else
                    if (QuanLyAC.Instance.SuaChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia))
                {
                    lbThemTBCTHD.Text = string.Empty;
                    lbThemTCCTHD.Text = "<\\ Sửa chi tiết thành công >";
                    LoadListCTHD();
                    SetBtnLockCTHD(false);
                    SetLockCTHD(false);
                }
            }
            **/
        }

        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            string maHoaDon = cbxCTHD_maHoaDon.SelectedValue.ToString();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hoá đơn [" + cbxCTHD_maHoaDon.SelectedValue.ToString() + "] không?", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (QuanLyAC.Instance.XoaChiTietHoaDon(maHoaDon))
                {
                    lbThemTCCTHD.Text = string.Empty;
                    lbThemTCCTHD.Text = "<\\ Xóa chi tiết hóa đơn thành công >";
                    LoadListHoaDon();
                    LoadListCTHD();
                    SetBtnLockHoaDon(false);
                    SetLockHoaDon(false);
                }
                else
                {
                    lbThemTCCTHD.Text = string.Empty;
                    lbThemTBCTHD.Text = "<\\ Xóa chi tiết hóa đơn thất bại! >";
                }
            }
        }

        #endregion

    }
}
