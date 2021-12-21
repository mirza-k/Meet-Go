﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MeetAndGo.WinUI.Login
{
    public partial class frmLogin : Form
    {
        ApiService _serviceUserAccounts = new ApiService("UserAccount");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _serviceUserAccounts.GetAll<List<Model.UserAccount>>();
                Model.UserAccount user = result?.FirstOrDefault(x => x.Username == txt_Username.Text);
                //var uloga = zaposlenik.ZaposleniciUloges.Where(x => x.ZaposlenikId == zaposlenik.Id).FirstOrDefault();
                if (user != null /*&& uloga.Uloge.Naziv == Uloge.Administrator.ToString()*/)
                {
                    this.Hide();
                    MDIHome frm = new MDIHome();
                    frm.Owner = this;
                    frm.Show();
                }
                //if (user != null /*&& uloga.Uloge.Naziv == Uloge.SuperAdmin.ToString()*/)
                //{
                //    this.Hide();
                //    MDIParentSuperAdmin frm = new MDIParentSuperAdmin(zaposlenik);
                //    frm.Owner = this;
                //    frm.Show();
                //}
            }
            catch
            {
                MessageBox.Show("Pogrešan username ili password");
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

    }
}
