using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

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
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1n simply returns red name
				var task = browser.EvaluateScriptAsync("p1n", null);

				// Run task
				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						// Return response from JS
						return response.Result.ToString();
					}
					return "";
				}, TaskScheduler.FromCurrentSynchronizationContext());
				// If return is not null return the result from the task
				if (task.Result != null)
					return task.Result.Result.ToString();
			}
			// Return empty string if all else fails
			return "";
		}

		/// <summary>
		/// Returns the current placed bets on the red side
		/// </summary>
		public string GetRedPot()
		{
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1te returns the amount betted on red in a formatted string with $
				var task = browser.EvaluateScriptAsync("p1te", null);

				// Run task
				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						// Return response from JS
						return response.Result.ToString();
					}
					return "";
				}, TaskScheduler.FromCurrentSynchronizationContext());
				// If return is not null return the result from the task
				if (task.Result != null)
					return task.Result.Result.ToString();
			}
			// Return empty string if all else fails
			return "";
		}

		/// <summary>
		/// Returns the current red pot as an integer, or returns 0 if the current pot could not be found
		/// </summary>
		/// <returns></returns>
		public int GetRedPotNum()
		{
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1te returns the amount betted on blue in a formatted string with $
				var task = browser.EvaluateScriptAsync("p1to", null);

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
				{
					int x = 0;
					if (Int32.TryParse(task.Result.Result.ToString(), out x))
					{
						return x;
					}
					else
						return 0;
				}
			}
			// Return empty string if all else fails
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
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1n simply returns red name
				var task = browser.EvaluateScriptAsync("p2n", null);

				// Run task
				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						// Return response from JS
						return response.Result.ToString();
					}
					return "";
				}, TaskScheduler.FromCurrentSynchronizationContext());
				// If return is not null return the result from the task
				if (task.Result != null)
					return task.Result.Result.ToString();
			}
			// Return empty string if all else fails
			return "";
		}

		/// <summary>
		/// Returns the current placed bets on the blue side
		/// </summary>
		public string GetBluePot()
		{
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1te returns the amount betted on blue in a formatted string with $
				var task = browser.EvaluateScriptAsync("p2te", null);

				// Run task
				task.ContinueWith(t =>
				{
					if (!t.IsFaulted)
					{
						var response = t.Result;
						// Return response from JS
						return response.Result.ToString();
					}
					return "";
				}, TaskScheduler.FromCurrentSynchronizationContext());
				// If return is not null return the result from the task
				if (task.Result != null)
					return task.Result.Result.ToString();
			}
			// Return empty string if all else fails
			return "";
		}

		/// <summary>
		/// Returns the current blue pot as an integer, or returns 0 if the current pot could not be found
		/// </summary>
		/// <returns></returns>
		public int GetBluePotNum()
		{
			// If browser is initialized
			if (browser.IsBrowserInitialized)
			{
				// Run script in a task, p1te returns the amount betted on blue in a formatted string with $
				var task = browser.EvaluateScriptAsync("p2to", null);

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
				{
					int x = 0;
					if (Int32.TryParse(task.Result.Result.ToString(), out x))
					{
						return x;
					}
					else
						return 0;
				}
			}
			// Return empty string if all else fails
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
	}
}
