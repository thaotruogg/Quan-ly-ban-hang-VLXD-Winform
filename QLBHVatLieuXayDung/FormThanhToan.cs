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
            ChangeBtn();
        }

        #region Methods
        void ChangeBtn()
        {
            btnTT_save.TabStop = false;
            btnTT_save.FlatAppearance.BorderSize = 0;
        }
        public void LoadListKH(ComboBox box)
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
            Close();
        }

        private void btnTT_save_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = cbxTT_maKH.SelectedValue.ToString();
                string ngayPhieu = string.Format("{0:MM/dd/yyyy}", dtpTT_ngayPhieu.Value);
                double soTien = double.Parse(txbTT_soTien.Text);
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
            catch (FormatException)
            {
                lbThemTC.Text = string.Empty;
                lbThemTB.Text = "<\\ Thanh toán không hợp lệ >";
            }
        }

        private void btnThanhToan_chonKH_Click(object sender, EventArgs e)
        {
            FormAddKhachHang f = new FormAddKhachHang();
            f.Show();
        }

        private void btnThanhToan_reload_Click(object sender, EventArgs e)
        {
            LoadListKH(cbxTT_maKH);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
    }
}
