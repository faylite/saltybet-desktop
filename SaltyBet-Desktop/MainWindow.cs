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
using CefSharp.OffScreen;

namespace SaltyBet_Desktop
{
	public partial class MainWindow : Form
	{
		private ChromiumWebBrowser browser;

		private DataExtractor dataExtractor;
		private MatchTracker matchTracker;

		private Thread refreshThread;

		public MainWindow()
		{
			InitializeComponent();

			var settings = new CefSettings();

			settings.WindowlessRenderingEnabled = true;

			Cef.Initialize(settings);
			browser = new ChromiumWebBrowser("http://saltybet.com");
			// this.pMain.Controls.Add(browser);
			// browser.Dock = DockStyle.Fill;

			dataExtractor = new DataExtractor(browser);
			matchTracker = new MatchTracker();

			refreshThread = new Thread(refreshLoop);
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

			string redName = dataExtractor.GetRedName();
			string blueName = dataExtractor.GetBlueName();

			int redPot = dataExtractor.GetRedPotNum();
			int bluePot = dataExtractor.GetBluePotNum();

			double redOdds = dataExtractor.GetRedOdds();
			double blueOdds = dataExtractor.GetBlueOdds();

			// Update database
			if (matchTracker.IsNewMatch(redName, blueName))
			{
				// If 
				if (!matchTracker.IsTeamMatch())
				{
					// row layout
					// RedName | RedPot | Red Odds | BlueName | BluePot | BlueOdds | Winner | Match Time
					dgwMatchHistory.Rows.Add(
						matchTracker.LastPlayer1, matchTracker.LastPotPlayer1, redOdds, 
						matchTracker.LastPlayer2, matchTracker.LastPotPlayer2, blueOdds, 
						"n/a", "n/a"
					);
				}
			}
			
			// Update Red Side
			this.tbRedName.Text = redName;
			this.tbRedPot.Text = redPot.ToString();
			this.tbRedOdds.Text = redOdds.ToString();

			// Update Blue Side
			this.tbBlueName.Text = blueName;
			this.tbBluePot.Text = bluePot.ToString();
			this.tbBlueOdds.Text = blueOdds.ToString();

			// Update info
			this.tbSaltBalance.Text = dataExtractor.GetSaltBalanceNum().ToString();
			this.tbBetStatus.Text = dataExtractor.GetBetStatus();

		}

		/// <summary>
		/// A loop for the refresh thread, calls refresh() every second.
		/// </summary>
		private void refreshLoop()
		{
			while (true)
			{
				try
				{
					Thread.Sleep(1 * 1000);
					BeginInvoke(new MethodInvoker(refresh));
				}
				catch (InvalidOperationException)
				{
					break;
				}
				catch (ThreadInterruptedException)
				{
					break;
				}
			}
		}

		private void btnOpenDevTools_Click(object sender, EventArgs e)
		{
			browser.ShowDevTools();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Dispose of the browser window. 
			browser.Dispose();
			// Shutdown the embedded framework
			Cef.Shutdown();
		}
	}
}
