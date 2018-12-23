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
            LoadButtonDesign();
        }
        void LoadButtonDesign()
        {
            btnLoaiSP_add.TabStop = false;
            btnLoaiSP_edit.TabStop = false;
            btnLoaiSP_delete.TabStop = false;
            btnLoaiSP_save.TabStop = false;
            btnLoaiSP_clear.TabStop = false;
            btnLoaiSP_add.FlatAppearance.BorderSize = 0;
            btnLoaiSP_edit.FlatAppearance.BorderSize = 0;
            btnLoaiSP_delete.FlatAppearance.BorderSize = 0;
            btnLoaiSP_save.FlatAppearance.BorderSize = 0;
            btnLoaiSP_clear.FlatAppearance.BorderSize = 0;
        }

        #region Method
        void LoaiSanPhamDataBinding()
        {
            txbLoaiSP_maLoai.DataBindings.Add(new Binding("Text", dgvLoaiSP.DataSource, "Mã loại sản phẩm", true, DataSourceUpdateMode.Never));
            txbLoaiSP_tenLoai.DataBindings.Add(new Binding("Text", dgvLoaiSP.DataSource, "Tên loại sản phẩm", true, DataSourceUpdateMode.Never));
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
            txbLoaiSP_maLoai.Enabled = a;
            txbLoaiSP_tenLoai.ReadOnly = !a;
        }
        void SetBtnLock(bool a)
        {
            btnLoaiSP_add.Enabled = a;
            btnLoaiSP_edit.Enabled = a;
            btnLoaiSP_delete.Enabled = a;
            btnLoaiSP_save.Enabled = !a;
            btnLoaiSP_clear.Enabled = !a;
        }
        void SetNULL()
        {
            txbLoaiSP_maLoai.Text = string.Empty;
            txbLoaiSP_tenLoai.Text = string.Empty;
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
            txbLoaiSP_maLoai.Text = "VL";
            SetLock(true);
            SetBtnLock(false);
            coThem = true;
        }

        private void btnSaveLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoaiSP = txbLoaiSP_maLoai.Text;
            string tenLoaiSP = txbLoaiSP_tenLoai.Text;
            if(coThem == true)
            {
                try
                {
                    if (txbLoaiSP_tenLoai.Text == string.Empty || txbLoaiSP_maLoai.Text == string.Empty || txbLoaiSP_maLoai.Text == "VL")
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
                if (txbLoaiSP_tenLoai.Text == string.Empty)
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
                    txbLoaiSP_maLoai.ReadOnly = false;
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
            txbLoaiSP_maLoai.ReadOnly = true;
            coThem = false;
        }

        private void btnDeleteLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoai = txbLoaiSP_maLoai.Text;
            DialogResult delete = MessageBox.Show("\tBạn có muốn xóa [" + txbLoaiSP_tenLoai.Text + "] không?\n\n<\\ Dữ liệu [SẢN PHẨM] cũng sẽ bị ảnh hưởng >", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
