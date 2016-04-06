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

            account.Login(this.tbUsername.Text, this.tbPassword.Text);
            this.Close();
        }
    }
}
