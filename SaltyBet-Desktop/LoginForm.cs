using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.OffScreen;
using Cookie = CefSharp.Cookie;

namespace SaltyBet_Desktop
{
    public partial class LoginForm : Form
    {
        private ChromiumWebBrowser browser;

        public LoginForm(ChromiumWebBrowser browser)
        {
            this.browser = browser;
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            Account account = new Account(browser);

            // Save login info if rememberlogin is checked
            if (cbRememberLogin.Checked == true)
                account.SaveLogin(this.tbUsername.Text, this.tbPassword.Text);

            account.Login(this.tbUsername.Text, this.tbPassword.Text);
            MessageBox.Show("You should be logged in now, wait a couple of seconds and if you don't see your salt balance change from 0 you might have used a wrong username/password.");
            this.Close();
        }
    }
}
