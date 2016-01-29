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
		private DataExtractor dataExtractor;

		public MainWindow()
		{
			InitializeComponent();

			var settings = new CefSettings();
			Cef.Initialize();
			browser = new ChromiumWebBrowser("http://saltybet.com");
			this.pMain.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;

			dataExtractor = new DataExtractor(this.browser);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}
	}
}
