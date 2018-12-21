using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormLoaiSanPham : Form
    {
        private BindingSource list = new BindingSource();
        private bool coThem;
        public FormLoaiSanPham()
        {
            InitializeComponent();
            LoadLoaiSP();
        }
        #region Method
        void LoaiSanPhamDataBinding()
        {
            txtMaLoaiSP.DataBindings.Add(new Binding("Text", dgvLoaiSP.DataSource, "Mã loại sản phẩm", true, DataSourceUpdateMode.Never));
            txtTenLoaiSP.DataBindings.Add(new Binding("Text", dgvLoaiSP.DataSource, "Tên loại sản phẩm", true, DataSourceUpdateMode.Never));
        }
        void LoadListLoaiSP()
        {
            list.DataSource = LoaiSPAC.Instance.LoadListLoaiSP();
        }
        void LoadLoaiSP()
        {
            dgvLoaiSP.DataSource = list;
            LoadListLoaiSP();
            SetLock(false);
            SetBtnLock(true);
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
            LoaiSanPhamDataBinding();
        }
        void SetLock(bool a)
        {
            txtMaLoaiSP.Enabled = a;
            txtTenLoaiSP.ReadOnly = !a;
        }
        void SetBtnLock(bool a)
        {
            btnAddLoaiSP.Enabled = a;
            btnEditLoaiSP.Enabled = a;
            btnDeleteLoaiSP.Enabled = a;
            btnSaveLoaiSP.Enabled = !a;
            btnClearLoaiSP.Enabled = !a;
        }
        void SetNULL()
        {
            txtMaLoaiSP.Text = string.Empty;
            txtTenLoaiSP.Text = string.Empty;
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        #endregion

        #region Events
        private void btnBackLoaiSP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLoaiSanPham_Load(object sender, EventArgs e)
        {
            
        }
        private void btnRefreshLoaiSP_Click(object sender, EventArgs e)
        {
            LoadListLoaiSP();
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        #endregion

        private void btnAddLoaiSP_Click(object sender, EventArgs e)
        {
            SetNULL();
            txtMaLoaiSP.Text = "VL";
            SetLock(true);
            SetBtnLock(false);
            coThem = true;
        }

        private void btnSaveLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoaiSP = txtMaLoaiSP.Text;
            string tenLoaiSP = txtTenLoaiSP.Text;
            if(coThem == true)
            {
                try
                {
                    if (txtTenLoaiSP.Text == string.Empty || txtMaLoaiSP.Text == string.Empty || txtMaLoaiSP.Text == "VL")
                    {
                        lbThemTC.Text = string.Empty;
                        lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                    }
                    else
                    if (LoaiSPAC.Instance.ThemLoaiSP(maLoaiSP, tenLoaiSP))
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTC.Text = "<\\ Thêm sản phẩm thành công >";
                        LoadListLoaiSP();
                        SetLock(false);
                        SetBtnLock(true);
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Mã sản phẩm đã tồn tại >";
                }
                catch (FormatException)
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                }
            }
            else
            {
                if (txtTenLoaiSP.Text == string.Empty)
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                }
                else
                if (LoaiSPAC.Instance.SuaLoaiSP(maLoaiSP, tenLoaiSP))
                {
                    lbThemTB.Text = string.Empty;
                    lbThemTC.Text = "<\\ Sửa sản phẩm thành công >";
                    LoadListLoaiSP();
                    SetLock(false);
                    SetBtnLock(true);
                }
            }
        }

        private void btnClearLoaiSP_Click(object sender, EventArgs e)
        {
            SetNULL();
            SetLock(false);
            SetBtnLock(true);
        }

        private void btnEditLoaiSP_Click(object sender, EventArgs e)
        {
            SetLock(true);
            SetBtnLock(false);
            txtMaLoaiSP.ReadOnly = true;
            coThem = false;
        }

        private void btnDeleteLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiSP.Text;
            DialogResult delete = MessageBox.Show("\tBạn có muốn xóa [" + txtTenLoaiSP.Text + "] không?\n\n<\\ Dữ liệu [SẢN PHẨM] cũng sẽ bị ảnh hưởng >", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                try
                {
                    if (LoaiSPAC.Instance.XoaLoaiSP(maLoai))
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTC.Text = "<\\ Xóa sản phẩm thành công >";
                        LoadListLoaiSP();
                        SetLock(false);
                        SetBtnLock(true);
                    }
                    else
                    {
                        lbThemTC.Text = string.Empty;
                        lbThemTB.Text = "<\\ Xóa sản phẩm thất bại! >";
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Bạn không thể xóa sản phẩm này! >";
                }
            }
        }
    }
}
