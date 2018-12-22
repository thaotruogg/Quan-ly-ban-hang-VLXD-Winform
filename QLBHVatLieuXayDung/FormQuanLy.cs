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
        public FormQuanLy()
        {
            InitializeComponent();
            LoadList();
        }

        #region Methods
        void SetBtnLock(bool a)
        {
            btnSaveHoaDon.Enabled = a;
            btnClearHoaDon.Enabled = a;
            btnAddHD.Enabled = !a;
            btnEditHD.Enabled = !a;
            btnDeleteHD.Enabled = !a;
        }
        void SetNULL(bool a)
        {

        }
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
        void LoadMaHDIntoCombobox(ComboBox box)
        {
            box.DataSource = QuanLyAC.Instance.LoadListHoaDon();
            box.DisplayMember = "Số hóa đơn";
            //box.ValueMember = "Số hóa đơn";
        }
        void HoaDonBinding()
        {
            txbMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "Số hóa đơn", true, DataSourceUpdateMode.Never));
            dtpNgayHD.DataBindings.Add(new Binding("Value", dgvHoaDon.DataSource, "Ngày hóa đơn", true, DataSourceUpdateMode.Never));
            numUpDMaSPOfHD.DataBindings.Add(new Binding("Value", dgvCTHD.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            txbDonGiaOfHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
        }

        void LoadList()
        {
            dgvCTHD.DataSource = listCTHD;
            dgvHoaDon.DataSource = listHoaDon;
            LoadListHoaDon();
            LoadListCTHD();
            LoadMaKHIntoCombobox(cbxMaKHOfHD);
            LoadMaSPIntoCombobox(cbxMaSPOfCTHD);
            //HoaDonBinding();
        }

        void LoadListHoaDon()
        {
            listHoaDon.DataSource = QuanLyAC.Instance.LoadListHoaDon();
        }
        void LoadListCTHD()
        {
            listCTHD.DataSource = QuanLyAC.Instance.LoadListCTHD();
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
            dgvHoaDon.DataSource = QuanLyAC.Instance.LoadListHoaDon();
            //HoaDonBinding();
        }

        private void btnShowLoaiSP_Click(object sender, EventArgs e)
        {
            FormLoaiSanPham f = new FormLoaiSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //HoaDonBinding();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                txbMaHD.Text = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                cbxMaKHOfHD.SelectedValue = dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString();
                dtpNgayHD.Value = Convert.ToDateTime(dgvHoaDon.SelectedRows[0].Cells[2].Value);
            }
            else if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txbMaHD.Text = row.Cells[0].Value.ToString();
                cbxMaKHOfHD.SelectedValue = row.Cells[1].Value.ToString();
                dtpNgayHD.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
            }
        }

        private void tabPageHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTHD.SelectedRows.Count > 0)
            {
                txbMaCTHD.Text = dgvCTHD.SelectedRows[0].Cells[0].Value.ToString();
                cbxMaSPOfCTHD.SelectedValue = dgvCTHD.SelectedRows[0].Cells[1].Value.ToString();
                numUpDMaSPOfHD.Value = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells[2].Value);
                txbDonGiaOfHD.Text = dgvCTHD.SelectedRows[0].Cells[3].Value.ToString();
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txbMaCTHD.Text = row.Cells[0].Value.ToString();
                cbxMaSPOfCTHD.SelectedValue = row.Cells[1].Value.ToString();
                numUpDMaSPOfHD.Value = Convert.ToInt32(row.Cells[2].Selected);
                txbDonGiaOfHD.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
