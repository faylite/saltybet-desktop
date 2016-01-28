using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaltyBet_Desktop
{
	public partial class DataWindow : Form
	{
		public DataWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Updates the character name and the current amount placed on a character for the red side
		/// </summary>
		/// <param name="characterName"></param>
		/// <param name="pot"></param>
		public void UpdateRed(string characterName, int pot)
		{
			if (characterName != null)
				this.tbCharRed.Text = characterName;
			else
				this.tbCharRed.Text = "";

			this.tbPotRed.Text = pot.ToString();
		}

		/// <summary>
		/// Updates the character name and the current amount placed on a character for the blue side
		/// </summary>
		/// <param name="characterName"></param>
		/// <param name="pot"></param>
		public void UpdateBlue(string characterName, int pot)
		{
			if (characterName != null)
				this.tbCharBlue.Text = characterName;
			else
				this.tbCharBlue.Text = "";

			this.tbPotBlue.Text = pot.ToString();
		}
	}
}
