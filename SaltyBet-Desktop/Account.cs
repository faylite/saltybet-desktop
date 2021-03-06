﻿using CefSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using CefSharp.OffScreen;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SaltyBet_Desktop
{
    class Account
    {
        private ChromiumWebBrowser browser;

        public Account(ChromiumWebBrowser browser)
        {
            this.browser = browser;
        }

        public void Login()
        {
            
        }

        public void Login(string email, string password)
        {
            // Flush existing cookies
            Cef.GetGlobalCookieManager().DeleteCookiesAsync("http://www.saltybet.com/", "");

            CookieContainer cookies = SendLoginRequest(email, password);

            // Get the cookies for saltybet
            string[] cookieHeaders = cookies.GetCookieHeader(new Uri("http://www.saltybet.com")).Split(';');

            foreach (string i in cookieHeaders)
            {
                // Cookie name
                string name = i.Split('=')[0];
                // Value of cookie
                string value = i.Split('=')[1];

                CefSharp.Cookie cookie = new CefSharp.Cookie();
                cookie.Name = name;
                cookie.Domain = "www.saltybet.com";
                cookie.Creation = DateTime.Now;
                cookie.Value = value;
                Cef.GetGlobalCookieManager().SetCookieAsync("http://www.saltybet.com/", cookie);
            }

            browser.Reload();
        }
        
        private CookieContainer SendLoginRequest(string email, string password)
        {
            // Container for the cookies
            CookieContainer cookies = new CookieContainer();

            // Post data sent with request
            var postData = "email=" + email + "&pword=" + password + "&authenticate=signin";
            var data = Encoding.ASCII.GetBytes(postData);

            // Create a request using the POST data collected from saltybet
            var request = (HttpWebRequest)WebRequest.Create("http://www.saltybet.com/authenticate?signin=1");
            request.CookieContainer = cookies;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.AllowAutoRedirect = true;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.110 Safari/537.36";
            // Write the post data to the request stream
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
                stream.Close();
            }

            request.GetResponse();

            return cookies;
        }

        public void SaveLogin(string email, string password)
        {
            // TODO: Implement login saving
        }
    }
}
