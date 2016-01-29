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

		
	}
}
