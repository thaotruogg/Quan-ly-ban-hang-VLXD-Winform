using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormAddKhachHang : Form
    {
        public FormAddKhachHang()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            txbAddKH_maKH.Text = "KH";
            txbAddKH_noDauKi.Text = "0";
            txbAddKH_noHienTai.Text = "0";
            lbThemTB.Text = string.Empty;
            lbThemTC.Text = string.Empty;
        }
        
        #region Events
        private void btnAddKH_save_Click(object sender, EventArgs e)
        {
            string name = txbAddKH_tenKH.Text;
            string maKH = txbAddKH_maKH.Text;
            string diaChi = txbAddKH_diaChi.Text;
            string soDienThoai = txbAddKH_sdt.Text;
            float noDauKi = float.Parse(txbAddKH_noDauKi.Text);
            float noCuoiKi = float.Parse(txbAddKH_noHienTai.Text);
            FormKhachHang f = new FormKhachHang();
            try
            {
                if (KhachHangAC.Instance.ThemKhachHang(maKH, name, diaChi, soDienThoai, noDauKi, noCuoiKi))
                {

                    lbThemTB.Text = string.Empty;
                    lbThemTC.Text = "<\\ Thêm khách hàng thành công >";
                    f.LoadListKH();
                    //Close();
                }
                else
                {
                    lbThemTC.Text = string.Empty;
                    lbThemTB.Text = "Thêm khách hàng thất bại!";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {

                if (txbAddKH_tenKH.Text == string.Empty || txbAddKH_sdt.Text == string.Empty || txbAddKH_tenKH.Text == "KH")
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

        private void btnAddKH_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }


}
