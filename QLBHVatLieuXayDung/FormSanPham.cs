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
        }
        #region Methods
        void SetNULL()
        {
            txtMaSPofSP.Text = string.Empty;
            txtNhaSXofSP.Text = string.Empty;
            txtTenSPofSP.Text = string.Empty;
        }
        void SetBtnLock(bool a)
        {
            btnSaveSP.Enabled = a;
            btnClearSP.Enabled = a;
            btnAddSP.Enabled = !a;
            btnEditSP.Enabled = !a;
            btnDeleteSP.Enabled = !a;
        }
        void SetLock(bool a)
        {
            txtMaSPofSP.Enabled = a;
            txtTenSPofSP.ReadOnly = !a;
            txtNhaSXofSP.ReadOnly = !a;
            cbxMaLoaiSP.Enabled = a;
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
            LoadLoaiSPIntoCombobox(cbxMaLoaiSP);
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
            txtMaSPofSP.Text = "SP";
            SetBtnLock(true);
            SetLock(true);
            coThem = true;
        }

        private void btnEditSP_Click(object sender, EventArgs e)
        {
            SetBtnLock(true);
            SetLock(true);
            txtMaSPofSP.ReadOnly = true;
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
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                txtMaSPofSP.Text = dgvSanPham.SelectedRows[0].Cells[0].Value.ToString();
                txtTenSPofSP.Text = dgvSanPham.SelectedRows[0].Cells[1].Value.ToString();
                txtNhaSXofSP.Text = dgvSanPham.SelectedRows[0].Cells[2].Value.ToString();
                cbxMaLoaiSP.SelectedValue = dgvSanPham.SelectedRows[0].Cells[3].Value.ToString();
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSPofSP.Text = row.Cells[0].Value.ToString();
                txtTenSPofSP.Text = row.Cells[1].Value.ToString();
                txtNhaSXofSP.Text = row.Cells[2].Value.ToString();
                cbxMaLoaiSP.SelectedValue = row.Cells[3].Value.ToString();
            }
        }
        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            string maSanPham = txtMaSPofSP.Text;
            string tenSanPham = txtTenSPofSP.Text;
            string nhaSanXuat = txtNhaSXofSP.Text;
            string maLoaiSP = cbxMaLoaiSP.SelectedValue.ToString();
            if (coThem == true)
            {
                try
                {
                    if (txtMaSPofSP.Text == string.Empty || txtTenSPofSP.Text == string.Empty || txtNhaSXofSP.Text == string.Empty || txtMaSPofSP.Text == "SP")
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
                if (txtMaSPofSP.Text == string.Empty || txtTenSPofSP.Text == string.Empty || txtNhaSXofSP.Text == string.Empty || txtMaSPofSP.Text == "SP")
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
            string maSanPham = txtMaSPofSP.Text;
            DialogResult result = MessageBox.Show("\tBạn có muốn xóa [" + txtTenSPofSP.Text + "] không?\n\n<\\ Dữ liệu [SẢN PHẨM] cũng sẽ bị ảnh hưởng >", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
