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
		public ChromiumWebBrowser browser;
		public DataWindow dataWindow;

		public MainWindow()
		{
			InitializeComponent();

			Cef.Initialize();
			browser = new ChromiumWebBrowser("http://saltybet.com");
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;

			dataWindow = new DataWindow();
			dataWindow.Show();
		}
	}
}
