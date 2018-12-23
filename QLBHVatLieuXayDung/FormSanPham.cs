using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormSanPham : Form
    {
        private BindingSource list = new BindingSource();
        private bool coThem;
        public FormSanPham()
        {
            InitializeComponent();
            LoadSanPham();
            LoadButtonDesign();
        }
        void LoadButtonDesign()
        {
            btnSanPham_add.TabStop = false;
            btnSanPham_edit.TabStop = false;
            btnSanPham_delete.TabStop = false;
            btnSanPham_save.TabStop = false;
            btnSanPham_clear.TabStop = false;
            btnSanPham_add.FlatAppearance.BorderSize = 0;
            btnSanPham_edit.FlatAppearance.BorderSize = 0;
            btnSanPham_delete.FlatAppearance.BorderSize = 0;
            btnSanPham_save.FlatAppearance.BorderSize = 0;
            btnSanPham_clear.FlatAppearance.BorderSize = 0;
        }
        #region Methods
        void SetNULL()
        {
            txbSanPham_maSP.Text = string.Empty;
            txbSanPham_nSX.Text = string.Empty;
            txtSanPham_tenSP.Text = string.Empty;
        }
        void SetBtnLock(bool a)
        {
            btnSanPham_save.Enabled = a;
            btnSanPham_clear.Enabled = a;
            btnSanPham_add.Enabled = !a;
            btnSanPham_edit.Enabled = !a;
            btnSanPham_delete.Enabled = !a;
        }
        void SetLock(bool a)
        {
            txbSanPham_maSP.Enabled = a;
            txtSanPham_tenSP.ReadOnly = !a;
            txbSanPham_nSX.ReadOnly = !a;
            cbxSanPham_loaiSP.Enabled = a;
        }
        void LoadLoaiSPIntoCombobox(ComboBox bx)
        {
            bx.DataSource = LoaiSPAC.Instance.LoadListLoaiSP();
            bx.DisplayMember = "Tên loại sản phẩm";
            bx.ValueMember = "Mã loại sản phẩm";
        }
        void LoadSanPham()
        {
            dgvSanPham.DataSource = list;
            LoadListSanPham();
            LoadLoaiSPIntoCombobox(cbxSanPham_loaiSP);
            SetNULL();
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
            SetBtnLock(false);
            SetLock(false);
        }
        void LoadListSanPham()
        {
            list.DataSource = SanPhamAC.Instance.LoadListSanPham();
        }
        #endregion

        #region Events
        private void FormSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnBackHoaDon_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClearSP_Click(object sender, EventArgs e)
        {
            SetNULL();
            lbThemTC.Text = string.Empty;
            lbThemTB.Text = string.Empty;
            SetBtnLock(false);
            SetLock(false);
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            SetNULL();
            txbSanPham_maSP.Text = "SP";
            SetBtnLock(true);
            SetLock(true);
            coThem = true;
        }

        private void btnEditSP_Click(object sender, EventArgs e)
        {
            SetBtnLock(true);
            SetLock(true);
            txbSanPham_maSP.ReadOnly = true;
            coThem = false;
        }
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  MessageBox.Show("aa");
            //txtTenSPofSP.Text = dgvSanPham.SelectedRows[1].ToString();
            //txtNhaSXofSP.Text = dgvSanPham.SelectedRows[2].ToString();

        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSanPham.SelectedRows.Count > 0)
                {
                    txbSanPham_maSP.Text = dgvSanPham.SelectedRows[0].Cells[0].Value.ToString();
                    txtSanPham_tenSP.Text = dgvSanPham.SelectedRows[0].Cells[1].Value.ToString();
                    txbSanPham_nSX.Text = dgvSanPham.SelectedRows[0].Cells[2].Value.ToString();
                    cbxSanPham_loaiSP.SelectedValue = dgvSanPham.SelectedRows[0].Cells[3].Value.ToString();
                }
                else if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                    txbSanPham_maSP.Text = row.Cells[0].Value.ToString();
                    txtSanPham_tenSP.Text = row.Cells[1].Value.ToString();
                    txbSanPham_nSX.Text = row.Cells[2].Value.ToString();
                    cbxSanPham_loaiSP.SelectedValue = row.Cells[3].Value.ToString();
                }
            }
            catch (NullReferenceException) { }
        }
        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            string maSanPham = txbSanPham_maSP.Text;
            string tenSanPham = txtSanPham_tenSP.Text;
            string nhaSanXuat = txbSanPham_nSX.Text;
            string maLoaiSP = cbxSanPham_loaiSP.SelectedValue.ToString();
            if (coThem == true)
            {
                try
                {
                    if (txbSanPham_maSP.Text == string.Empty || txtSanPham_tenSP.Text == string.Empty || txbSanPham_nSX.Text == string.Empty || txbSanPham_maSP.Text == "SP")
                    {
                        lbThemTC.Text = string.Empty;
                        lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                    }
                    else
                    if (SanPhamAC.Instance.ThemSanPham(maSanPham, tenSanPham, nhaSanXuat, maLoaiSP))
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTC.Text = "<\\ Thêm sản phẩm thành công >";
                        LoadListSanPham();
                        SetLock(false);
                        SetBtnLock(false);
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Mã sản phẩm đã tồn tại >";
                }
            }
            else if (coThem == false)
            {
                if (txbSanPham_maSP.Text == string.Empty || txtSanPham_tenSP.Text == string.Empty || txbSanPham_nSX.Text == string.Empty || txbSanPham_maSP.Text == "SP")
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                }
                else
                    if (SanPhamAC.Instance.SuaSanPham(maSanPham, tenSanPham, nhaSanXuat, maLoaiSP))
                {
                    lbThemTB.Text = string.Empty;
                    lbThemTC.Text = "<\\ Sửa sản phẩm thành công >";
                    LoadListSanPham();
                    txbSanPham_maSP.ReadOnly = false;
                    SetLock(false);
                    SetBtnLock(false);
                }
            }
        }
        private void btnRefreshSP_Click(object sender, EventArgs e)
        {
            LoadListSanPham();
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            string maSanPham = txbSanPham_maSP.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm [" + txtSanPham_tenSP.Text + "] không?", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (SanPhamAC.Instance.XoaSanPham(maSanPham))
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTC.Text = "<\\ Xóa sản phẩm thành công >";
                    LoadListSanPham();
                    SetLock(false);
                    SetBtnLock(false);
                }
                else
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Xóa sản phẩm thất bại! >";
                }
            }
        }
        #endregion
        
    }
}
