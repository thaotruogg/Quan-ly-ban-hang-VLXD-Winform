﻿using QLBHVatLieuXayDung.DAO;
using System;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormChonKhachHang : Form
    {
        public FormChonKhachHang()
        {
            InitializeComponent();
            LoadChonKH();
        }

        void LoadChonKH()
        {
            LoadListChonKH();
        }

        void LoadListChonKH()
        {
            dgvChonKH.DataSource = KhachHangAC.Instance.LoadListChonKH();
        }

        private void btnBackChonKH_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvChonKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
