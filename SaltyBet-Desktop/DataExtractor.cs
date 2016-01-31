using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.OffScreen;

namespace SaltyBet_Desktop
{
	class DataExtractor
	{
		ChromiumWebBrowser browser;

		public DataExtractor(ChromiumWebBrowser browser)
		{
			this.browser = browser;
		}

		/// <summary>
		/// Returns the name of the red character/team
		/// </summary>
		public string GetRedName()
		{
			return executeJS("p1n");
		}

		/// <summary>
		/// Returns the current placed bets on the red side
		/// </summary>
		public string GetRedPot()
		{
			return executeJS("p1te");
		}

		/// <summary>
		/// Returns the current red pot as an integer, or returns 0 if the current pot could not be found
		/// </summary>
		/// <returns></returns>
		public int GetRedPotNum()
		{
			string redPot = executeJS("p1to");

			int x = 0;
			if (Int32.TryParse(redPot, out x))
				return x;
			else
				return 0;
		}

		/// <summary>
		/// Returns the odds based on pot for the red character
		/// </summary>
		public double GetRedOdds()
		{
			double redPot = GetRedPotNum();
			double bluePot = GetBluePotNum();

			if (bluePot >= redPot)
				return 1.0;
			else
				return redPot / bluePot;
		}

		/// <summary>
		/// Returns the name of the blue character/team
		/// </summary>
		public string GetBlueName()
		{
			return executeJS("p2n");
		}

		/// <summary>
		/// Returns the current placed bets on the blue side
		/// </summary>
		public string GetBluePot()
		{
			// p1te returns the amount betted on blue in a string
			return executeJS("p2te");
		}

		/// <summary>
		/// Returns the current blue pot as an integer, or returns 0 if the current pot could not be found
		/// </summary>
		/// <returns></returns>
		public int GetBluePotNum()
		{
			// Execute JavaScript and get the return
			// p2to returns the amount betted on blue side
			string bluePot = executeJS("p2to");
			
			// Parse the return into an integer
			int x = 0;
			if (Int32.TryParse(bluePot, out x))
				return x;
			else
				return 0;
		}

		/// <summary>
		/// Returns the odds based on pot for the blue character
		/// </summary>
		public double GetBlueOdds()
		{
			double redPot = GetRedPotNum();
			double bluePot = GetBluePotNum();

			if (redPot >= bluePot)
				return 1.0;
			else
				return bluePot / redPot;
		}

		/// <summary>
		/// Returns the current salt balance
		/// </summary>
		/// <returns></returns>
		public int GetSaltBalanceNum()
		{
			int x = 0;
			if (Int32.TryParse(executeJS("balance"), out x))
				return x;
			else
				return 0;
		}

		/// <summary>
		/// Returns the state of the bets
		/// </summary>
		/// <returns>Returns either "open" or "closed"</returns>
		public string GetBetStatus()
		{
			return executeJS("betstate");
		}

		/// <summary>
		/// Returns a message of how many matches are left until the next tournament
		/// </summary>
		/// <returns>Returns a sentence, not a number</returns>
		public string GetRemainingMatches()
		{
			return executeJS("remaining");
		}

		/// <summary>
		/// Executes js and returns the output as a string
		/// </summary>
		/// <param name="script">The JavaScript to execute</param>
		/// <returns>Output from JavaScript</returns>
		private string executeJS(string script)
		{
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1te returns the amount betted on blue in a formatted string with $
				var task = browser.EvaluateScriptAsync(script, null);

				// Run task
				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						// Return response from JS
						return response.Result.ToString();
					}
					return "0";
				}, TaskScheduler.FromCurrentSynchronizationContext());
				// If return is not null return the result from the task
				if (task.Result != null)
					return task.Result.Result.ToString();
			}
			return "";
		}
	}
}
