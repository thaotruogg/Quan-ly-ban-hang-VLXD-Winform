using QLBHVatLieuXayDung.ACTION;
using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormThanhToan_List : Form
    {
        private BindingSource list = new BindingSource();
        public FormThanhToan_List()
        {
            InitializeComponent();
            LoadThanhToan();
        }
        #region Methods
        void LoadListThanhToan()
        {
            list.DataSource = ThanhToan.Instance.LoadListThanhToan();
        }
        void LoadThanhToan()
        {
            dgvThanhToan.DataSource = list;
            LoadCbxMaKhachHang(cbxThanhToan_maKH);
            LoadListThanhToan();
            SetBtnLock(false);
            SetLock(false);
        }
        void LoadCbxMaKhachHang(ComboBox box)
        {
            box.DataSource = KhachHangAC.Instance.LoadListKhachHang();
            box.DisplayMember = "Tên khách hàng";
            box.ValueMember = "Mã khách hàng";
        }
        void SetBtnLock(bool a)
        {
            btnThanhToan_save.Enabled = a;
            btnThanhToan_clear.Enabled = a;
            btnThanhToan_add.Enabled = !a;
            btnThanhToan_edit.Enabled = !a;
            btnThanhToan_delete.Enabled = !a;
        }
        void SetLock(bool a)
        {
            txbThanhToan_soPhieu.ReadOnly = !a;
            cbxThanhToan_maKH.Enabled = a;
            txbThanhToan_soTien.ReadOnly = !a;
        }
        void SetNULL()
        {
            txbThanhToan_soPhieu.Text = string.Empty;
            txbThanhToan_soTien.Text = string.Empty;
            dtpThanhToan_ngayPhieu.Value = DateTime.Today;
        }
        #endregion

        #region Events
        private void btnBackThanhToan_list_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvThanhToan.SelectedRows.Count > 0)
                {
                    txbThanhToan_soPhieu.Text = dgvThanhToan.SelectedRows[0].Cells[0].Value.ToString();
                    cbxThanhToan_maKH.SelectedValue = dgvThanhToan.SelectedRows[0].Cells[1].Value.ToString();
                    dtpThanhToan_ngayPhieu.Value = DateTime.Parse(dgvThanhToan.SelectedRows[0].Cells[2].Value.ToString());
                    txbThanhToan_soTien.Text = dgvThanhToan.SelectedRows[0].Cells[3].Value.ToString();
                }
                else if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvThanhToan.Rows[e.RowIndex];
                    txbThanhToan_soPhieu.Text = row.Cells[0].Value.ToString();
                    cbxThanhToan_maKH.SelectedValue = row.Cells[1].Value.ToString();
                    dtpThanhToan_ngayPhieu.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                    txbThanhToan_soTien.Text = row.Cells[3].Value.ToString();
                }
            }
            catch (NullReferenceException) { }
            catch (FormatException) { }
        }
        #endregion
        
    }
}
