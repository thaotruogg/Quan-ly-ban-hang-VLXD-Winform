using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormKhachHang : Form
    {
        public BindingSource list = new BindingSource();
        public bool coThem;
        public FormKhachHang()
        {
            InitializeComponent();
            LoadKH();
        }

        #region Methors

        public void LoadListKH()
        {
            list.DataSource = KhachHangAC.Instance.LoadListKhachHang();
        }

        private void LoadKH()
        {
            dgvKhachHang.DataSource = list;
            LoadListKH();
            SetLock(false);
            SetBtn(true);
            lbThemTC.Text = string.Empty;
            lbThemTB.Text = string.Empty;
            KhachHangBinding();
        }

        private void SetLock(bool a)
        {
            txbMaKHOfKH.Enabled = a;
            txbTenKHOfKH.ReadOnly = !a;
            txbDiaChiOfKH.ReadOnly = !a;
            txbSdtOfKH.ReadOnly = !a;
            txbNoCuoiKiOfKH.ReadOnly = !a;
            txbNoDauKiOfKH.ReadOnly = !a;
            
        }

        private void SetBtn(bool a)
        {
            btnAddKH.Enabled = a;
            btnEditKhachHang.Enabled = a;
            btnDeleteKhachHang.Enabled = a;
            btnSaveKH.Enabled = !a;
            btnClearKH.Enabled = !a;
        }

        private void SetNULL()
        {
            txbMaKHOfKH.Text = string.Empty;
            txbTenKHOfKH.Text = string.Empty;
            txbDiaChiOfKH.Text = string.Empty;
            txbSdtOfKH.Text = string.Empty;
            txbNoCuoiKiOfKH.Text = string.Empty;
            txbNoDauKiOfKH.Text = string.Empty;
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }

        private void KhachHangBinding()
        {
            txbMaKHOfKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never));
            txbTenKHOfKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Tên khách hàng", true, DataSourceUpdateMode.Never));
            txbDiaChiOfKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txbSdtOfKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            txbNoDauKiOfKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Nợ đầu kì", true, DataSourceUpdateMode.Never));
            txbNoCuoiKiOfKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Nợ hiện tại", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Events
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackKH_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            //dgvKhachHang.Enabled = false;
            SetNULL();
            txbMaKHOfKH.Text = "KH";
            txbNoCuoiKiOfKH.Text = "0";
            txbNoDauKiOfKH.Text = "0";
            SetLock(true);
            SetBtn(false);
            coThem = true;
        }

        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txbTenKHOfKH.Text;
                string maKH = txbMaKHOfKH.Text;
                string diaChi = txbDiaChiOfKH.Text;
                string soDienThoai = txbSdtOfKH.Text;
                float noDauKi = float.Parse(txbNoDauKiOfKH.Text);
                float noCuoiKi = float.Parse(txbNoCuoiKiOfKH.Text);
                if (coThem == true)
                {
                    try
                    {
                        if (KhachHangAC.Instance.ThemKhachHang(maKH, name, diaChi, soDienThoai, noDauKi, noCuoiKi))
                        {
                            lbThemTB.Text = string.Empty;
                            lbThemTC.Text = "<\\ Thêm khách hàng thành công >";
                            LoadListKH();
                            SetLock(false);
                            SetBtn(true);
                            //dgvKhachHang.Enabled = true;
                        }
                        else
                        {
                            lbThemTB.Text = "Thêm khách hàng thất bại!";
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {

                        if (txbTenKHOfKH.Text == string.Empty || txbSdtOfKH.Text == string.Empty || txbTenKHOfKH.Text == "KH")
                        {
                            lbThemTB.Text = string.Empty;
                            lbThemTB.Text = "<\\ Vui lòng nhập đầy đủ thông tin >";
                        }
                        else
                        {
                            lbThemTB.Text = string.Empty;
                            lbThemTB.Text = "<\\ Khách hàng đã tồn tại >";
                        }
                    }
                    catch (FormatException)
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTB.Text = "<\\ Lỗi nhập thông tin tiền nợ >";
                    }
                }
                else
                {
                    if (KhachHangAC.Instance.SuaKhachHang(maKH, name, diaChi, soDienThoai, noDauKi, noCuoiKi))
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTC.Text = "<\\ Sửa khách hàng thành công >";
                        LoadListKH();
                        txbMaKHOfKH.ReadOnly = false;
                        SetLock(false);
                        SetBtn(true);
                    }
                    else
                    {
                        lbThemTB.Text = string.Empty;
                        lbThemTB.Text = "<\\ Sửa khách hàng thất bại! >";
                    }
                }
            }
            catch (FormatException)
            {
                lbThemTB.Text = string.Empty;
                lbThemTB.Text = "<\\ Lỗi nhập thông tin tiền nợ >";
            }
        }
        
        private void btnEditKhachHang_Click(object sender, EventArgs e)
        {
            SetLock(true);
            SetBtn(false);
            txbMaKHOfKH.ReadOnly = true;
            coThem = false;
        }

        private void btnDeleteKhachHang_Click(object sender, EventArgs e)
        {
            string maKH = txbMaKHOfKH.Text;
            DialogResult delete = MessageBox.Show("\tBạn có muốn xóa " + txbTenKHOfKH.Text + " không?\n\n<\\ Dữ liệu khách hàng trong [HÓA ĐƠN] cũng sẽ bị xóa >", "Chời ơi tin được hong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                if (KhachHangAC.Instance.XoaKhachHang(maKH))
                {
                    lbThemTC.Text = "<\\ Xóa khách hàng thành công >";
                    LoadListKH();
                    SetLock(false);
                    SetBtn(true);
                }
                else
                {
                    lbThemTB.Text = "<\\ Xóa khách hàng thất bại! >";
                }
            }
        }
        
        private void btnClearKH_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bạn có muốn hủy?", "Chời ơi tin được hong");
            SetNULL();
            SetLock(false);
            SetBtn(true);
        }

        private void btnRefreshKH_Click(object sender, EventArgs e)
        {
            LoadListKH();
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        #endregion

    }
}
