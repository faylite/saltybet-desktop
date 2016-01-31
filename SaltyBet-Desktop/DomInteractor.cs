using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace SaltyBet_Desktop
{
	class DomInteractor
	{
		private ChromiumWebBrowser browser;

		public DomInteractor(ChromiumWebBrowser browser)
		{
			this.browser = browser;
		}

		/// <summary>
		/// Hides the element in the DOM with the id provided
		/// </summary>
		/// <param name="id">The id of the DOM element</param>
		public void HideElementById(string id)
		{
			string script = string.Format(
				"var tempElement = document.getElementById({0});" + 
				"tempElement.setAttribute(\"style\", \"display:none\");", id);
			browser.EvaluateScriptAsync(script);
		}

		public void DeleteElementById(string id)
		{
			string script = string.Format(
				"var tempElement = document.getElementById({0})" + 
				"tempElement.remove()", id);
		}
	}
}
