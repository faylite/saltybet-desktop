using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.OffScreen;

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

        private void login()
        {
            
        }
    }
}
