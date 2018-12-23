using QLBHVatLieuXayDung.ACTION;
using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
            LoadThanhToan();
        }

        #region Methods
        void LoadListKH(ComboBox box)
        {
            box.DataSource = KhachHangAC.Instance.LoadListKhachHang();
            box.DisplayMember = "Tên khách hàng";
            box.ValueMember = "Mã khách hàng";
        }
        void LoadThanhToan()
        {
            LoadListKH(cbxTT_maKH);
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        #endregion

        private void btnBackThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTT_save_Click(object sender, EventArgs e)
        {
            string maKhachHang = cbxTT_maKH.SelectedValue.ToString();
            string ngayPhieu = string.Format("{0:MM/dd/yyyy}", dtpTT_ngayPhieu.Value);
            double soTien = double.Parse(txbTT_soTien.Text);
            try
            {
                if (txbTT_soTien.Text == string.Empty)
                {

                }
                else if (ThanhToan.Instance.ThemThanhToan(maKhachHang, ngayPhieu, soTien))
                {
                    lbThemTB.Text = string.Empty;
                    lbThemTC.Text = "<\\ Thêm thành công >";
                }
                else
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "<\\ Xóa thất bại! >";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                lbThemTC.Text = string.Empty;
                lbThemTB.Text = "<\\ Ngày không hợp lệ >";
            }
        }
        
    }
}
