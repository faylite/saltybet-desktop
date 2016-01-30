using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace SaltyBet_Desktop
{
	public partial class MainWindow : Form
	{
		private ChromiumWebBrowser browser;
		private DataExtractor dataExtractor;
		private System.Threading.Thread refreshThread;

		public MainWindow()
		{
			InitializeComponent();

			var settings = new CefSettings();
			Cef.Initialize();
			browser = new ChromiumWebBrowser("http://saltybet.com");
			this.pMain.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;

			dataExtractor = new DataExtractor(this.browser);

			refreshThread = new System.Threading.Thread(refreshLoop);
			refreshThread.Start();
		}

		/// <summary>
		/// Updates the textboxes with new data from saltybet site.
		/// </summary>
		private void refresh()
		{
			// Don't update if browser is on the wrong page. Or the browser isn't initialized. 
			if (!browser.IsBrowserInitialized || browser.Address != "http://www.saltybet.com/" || browser.IsLoading)
				return;
			// Update Red Side
			this.tbRedName.Text = dataExtractor.GetRedName();
			this.tbRedPot.Text = dataExtractor.GetRedPot().ToString();
			this.tbRedOdds.Text = dataExtractor.GetRedOdds().ToString();

			// Update Blue Side
			this.tbBlueName.Text = dataExtractor.GetBlueName();
			this.tbBluePot.Text = dataExtractor.GetBluePot().ToString();
			this.tbBlueOdds.Text = dataExtractor.GetBlueOdds().ToString();
		}

		/// <summary>
		/// A loop for the refresh thread, calls refresh() every second.
		/// </summary>
		private void refreshLoop()
		{
			while (true)
			{
				Thread.Sleep(1 * 1000);
				BeginInvoke(new MethodInvoker(refresh));
			}
		}
	}
}
