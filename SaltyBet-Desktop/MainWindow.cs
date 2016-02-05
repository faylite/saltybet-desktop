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
		private Util util;
		private DatabaseConnection dbConn;

		private Thread refreshThread;

		public MainWindow()
		{
			InitializeComponent();

			dbConn = new DatabaseConnection();

			var settings = new CefSettings();

			settings.WindowlessRenderingEnabled = true;

			Cef.Initialize(settings);
			browser = new ChromiumWebBrowser("http://saltybet.com");
			// this.pMain.Controls.Add(browser);
			// browser.Dock = DockStyle.Fill;

			dataExtractor = new DataExtractor(browser);
			matchTracker = new MatchTracker();
			util = new Util();

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

			// Update match tracker with new info, if new info is available. 
			matchTracker.Update(dataExtractor);

			// Update database
			if (matchTracker.IsNewMatch())
			{
				// If last match wasn't a team match update add a new row
				if (!matchTracker.WasTeamMatch())
				{
					// row layout
					// TimeStamp | RedName | RedPot | Red Odds | BlueName | BluePot | BlueOdds | Winner | Match Time
					dgwMatchHistory.Rows.Add(
						util.GetLongDate(),
						matchTracker.LastPlayer1, matchTracker.LastPotPlayer1, matchTracker.LastOddsPlayer1,
						matchTracker.LastPlayer2, matchTracker.LastPotPlayer2, matchTracker.LastOddsPlayer2,
						matchTracker.LastWinner, "n/a"
					);
					// Add match data to database
					dbConn.InsertMatchData(
						util.GetLongDate(),
						matchTracker.LastPlayer1, matchTracker.LastPotPlayer1, matchTracker.LastOddsPlayer1,
						matchTracker.LastPlayer2, matchTracker.LastPotPlayer2, matchTracker.LastOddsPlayer2,
						matchTracker.LastWinner, "n/a"
					);
					// Update datagridview order after adding a new entry
					if (dgwMatchHistory.SortOrder == SortOrder.Ascending)
						dgwMatchHistory.Sort(dgwMatchHistory.SortedColumn, ListSortDirection.Ascending);
					if (dgwMatchHistory.SortOrder == SortOrder.Descending)
						dgwMatchHistory.Sort(dgwMatchHistory.SortedColumn, ListSortDirection.Descending);
				}
			}
			
			// Update Red Side
			this.tbRedName.Text = matchTracker.Player1;
			this.tbRedPot.Text = matchTracker.PotPlayer1.ToString();
			this.tbRedOdds.Text = matchTracker.OddsPlayer1.ToString();

			// Update Blue Side
			this.tbBlueName.Text = matchTracker.Player2;
			this.tbBluePot.Text = matchTracker.PotPlayer2.ToString();
			this.tbBlueOdds.Text = matchTracker.OddsPlayer2.ToString();

			// Update other general info
			this.tbSaltBalance.Text = dataExtractor.GetSaltBalanceNum().ToString();
			this.tbBetStatus.Text = dataExtractor.GetStatusText();
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
