using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHVatLieuXayDung
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        #region MeMe
        void EnableLogin()
        {
            lbCheckLogin.Text = string.Empty;
            lbW.Text = string.Empty;
            txbPassword.Text = string.Empty;
            txbUserName.Text = string.Empty;
            chbxShowPass.Checked = false;
            //btnLogin.Enabled = false;
        }
        void CheckBtnLogin()
        {
            if (txbUserName.Text != string.Empty && txbPassword.Text != string.Empty)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;

            if (Login(userName, passWord))
            {
                FormQuanLy f = new FormQuanLy();
                this.Hide();
                EnableLogin();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                lbW.Text = "";
                lbCheckLogin.Text = "<\\ Sai tên tài khoản hoặc mật khẩu >";
            }
        }

        bool Login(string username, string password)
        {
            return LoginDAO.Instance.Login(username, password);
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Quên thì chịu đi ba... Tui hong biết làm cái này :))))", "Chời ơi tin được hông", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void FormStart_Load(object sender, EventArgs e)
        {
            lbCheckLogin.Text = string.Empty;
            lbW.Text = string.Empty;
            //btnLogin.Enabled = false;
        }

        private void chbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowPass.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else if (chbxShowPass.Checked == false)
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            CheckBtnLogin();
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            CheckBtnLogin();
        }
    }
}
