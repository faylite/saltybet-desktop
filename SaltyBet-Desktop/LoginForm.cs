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

        private CookieContainer SendLoginRequest(string email, string password)
        {
            // Container for the cookies
            CookieContainer cookies = new CookieContainer();

            // Post data sent with request
            var postData = "email=" + email + "&pword=" + password;
            var data = Encoding.ASCII.GetBytes(postData);

            // Create a request using the POST data collected from saltybet
            var request = (HttpWebRequest) WebRequest.Create("http://www.saltybet.com/authenticate?signin=1");
            request.CookieContainer = cookies;
            request.Method = "POST";
            request.Referer = "http://www.saltybet.com/authenticate?signin=1";
            request.KeepAlive = true;
            request.ContentType = "application/x-www-form-urlencoded";
            // Write the post data to the request stream
            using (var stream = request.GetRequestStream())
                stream.Write(data, 0, data.Length);

            request.GetResponse();

            return cookies;
        }

        private void login(object sender, EventArgs e)
        {
            // Flush existing cookies
            Cef.GetGlobalCookieManager().DeleteCookiesAsync("http://www.saltybet.com/", "");

            CookieContainer cookies = SendLoginRequest(tbUsername.Text, tbPassword.Text);

            // Get the cookies for saltybet
            string[] cookieHeaders = cookies.GetCookieHeader(new Uri("http://www.saltybet.com")).Split(';');

            foreach (string i in cookieHeaders)
            {
                // Cookie name
                string name = i.Split('=')[0];
                // Value of cookie
                string value = i.Split('=')[1];

                Cookie cookie = new Cookie();
                cookie.Name = name;
                cookie.Domain = "www.saltybet.com";
                cookie.Creation = DateTime.Now;
                cookie.Value = value;
                Cef.GetGlobalCookieManager().SetCookieAsync("http://www.saltybet.com/", cookie);
            }
            
            browser.Reload();
        }
    }
}
