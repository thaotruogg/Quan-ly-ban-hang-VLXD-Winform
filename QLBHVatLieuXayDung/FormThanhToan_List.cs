using QLBHVatLieuXayDung.ACTION;
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
            LoadListThanhToan();
        }

        #endregion

        #region Events
        private void btnBackThanhToan_list_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
