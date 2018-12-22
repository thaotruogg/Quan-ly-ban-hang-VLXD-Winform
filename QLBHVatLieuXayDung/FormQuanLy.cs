using QLBHVatLieuXayDung.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoadButton();
        }

        void LoadButton()
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
        }

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
        void SetBtnLockCTHD(bool a)
        {
            btnSaveCTHD.Enabled = a;
            btnClearCTHD.Enabled = a;
            btnAddCTHD.Enabled = !a;
            //btnEditCTHD.Enabled = !a;
            btnDeleteCTHD.Enabled = !a;
        }
        void SetNULLCTHD()
        {
            txbMaCTHD.Text = string.Empty;
            txbDonGiaOfHD.Text = string.Empty;
            numericUpDownSLCTHD.Value = 0;
        }
        void SetLockCTHD(bool a)
        {
            txbMaCTHD.ReadOnly = !a;
            cbxMaSPOfCTHD.Enabled = a;
            numericUpDownSLCTHD.Enabled = a;
            txbDonGiaOfHD.ReadOnly = !a;
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
            txbDonGiaOfHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            //txbSoLuongCTHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            txbMaCTHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Mã hóa đơn", true, DataSourceUpdateMode.Never));
        }

        void LoadList()
        {
            dgvCTHD.DataSource = listCTHD;
            dgvHoaDon.DataSource = listHoaDon;
            LoadListHoaDon();
            LoadListCTHD();
            LoadMaKHIntoCombobox(cbxMaKHOfHD);
            LoadMaSPIntoCombobox(cbxMaSPOfCTHD);
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

        #region events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowHoaDon_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnShowSPQL_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn đăng xuất hông?", "Chời ơi tin được hông", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
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
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
            //HoaDonBinding();
        }

        private void btnShowLoaiSP_Click(object sender, EventArgs e)
        {
            FormLoaiSanPham f = new FormLoaiSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
                    txbMaCTHD.Text = dgvCTHD.SelectedRows[0].Cells[0].Value.ToString();
                    cbxMaSPOfCTHD.SelectedValue = dgvCTHD.SelectedRows[0].Cells[1].Value.ToString();
                    numericUpDownSLCTHD.Value = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells[2].Value);
                    txbDonGiaOfHD.Text = dgvCTHD.SelectedRows[0].Cells[3].Value.ToString();
                }
                else if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCTHD.Rows[e.RowIndex];
                    txbMaCTHD.Text = row.Cells[0].Value.ToString();
                    cbxMaSPOfCTHD.SelectedValue = row.Cells[1].Value.ToString();
                    numericUpDownSLCTHD.Value = Convert.ToInt32(row.Cells[2].Value);
                    txbDonGiaOfHD.Text = row.Cells[3].Value.ToString();
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
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Mã hóa đơn đã tồn tại >";
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
            txbMaCTHD.Text = "HD";
            txbDonGiaOfHD.Text = "0";
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
            txbMaCTHD.ReadOnly = true;
            SetBtnLockCTHD(true);
            SetLockCTHD(true);
            coThemCTHD = false;
        }

        private void btnSaveCTHD_Click(object sender, EventArgs e)
        {
            string maHoaDon = txbMaCTHD.Text;
            string maSanPham = cbxMaSPOfCTHD.SelectedValue.ToString();
            int soLuong = Convert.ToInt32(numericUpDownSLCTHD.Value);
            double donGia = Double.Parse(txbDonGiaOfHD.Text);
            if (coThemCTHD == true)
            {
                try
                {
                    if (txbMaCTHD.Text == string.Empty || txbDonGiaOfHD.Text == string.Empty || txbMaCTHD.Text == "HD")
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
                catch (System.FormatException)
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
            string maHoaDon = txbMaCTHD.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hoá đơn [" + txbMaCTHD.Text + "] không?", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
