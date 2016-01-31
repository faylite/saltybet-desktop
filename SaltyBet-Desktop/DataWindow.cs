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
	public partial class DataWindow : Form
	{
		private ChromiumWebBrowser browser;
		private DataExtractor dataExtractor;

		public DataWindow()
		{
			InitializeComponent();

			UpdateRed(null, "0");
			UpdateBlue(null, "0");
		}

		public DataWindow(ChromiumWebBrowser browser) : this()
		{
			this.browser = browser;
			this.dataExtractor = new DataExtractor(this.browser);
		}

		public void UpdateData()
		{
			UpdateRed(dataExtractor.GetRedName(), dataExtractor.GetRedPot());
			UpdateBlue(dataExtractor.GetBlueName(), dataExtractor.GetBluePot());
		}

		/// <summary>
		/// Updates the character name and the current amount placed on a character for the red side
		/// </summary>
		/// <param name="characterName"></param>
		/// <param name="pot"></param>
		public void UpdateRed(string characterName, string pot)
		{
			if (characterName != null)
				this.tbCharRed.Text = characterName;
			else
				this.tbCharRed.Text = "";

			this.tbPotRed.Text = pot;
		}

		/// <summary>
		/// Updates the character name and the current amount placed on a character for the blue side
		/// </summary>
		/// <param name="characterName"></param>
		/// <param name="pot"></param>
		public void UpdateBlue(string characterName, string pot)
		{
			if (characterName != null)
				this.tbCharBlue.Text = characterName;
			else
				this.tbCharBlue.Text = "";

			this.tbPotBlue.Text = pot;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UpdateData();
		}
	}
}
