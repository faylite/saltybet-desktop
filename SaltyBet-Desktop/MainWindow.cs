using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace SaltyBet_Desktop
{
	public partial class MainWindow : Form
	{
		private ChromiumWebBrowser browser;
		private DataWindow dataWindow;

		public MainWindow()
		{
			InitializeComponent();

			var settings = new CefSettings();

			Cef.Initialize();
			browser = new ChromiumWebBrowser("http://saltybet.com");
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;
			
			dataWindow = new DataWindow(browser);
			dataWindow.Show();
		}

		public void Test()
		{
			
		}
	}
}
