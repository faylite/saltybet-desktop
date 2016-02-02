using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltyBet_Desktop
{
	class MatchTracker
	{
		private string lastPlayer1;
		public string LastPlayer1 { get; }

		private string lastPlayer2;
		public string LastPlayer2 { get; }

		private int lastPotPlayer1;
		public int LastPotPlayer1 { get; }

		private int lastPotPlayer2;
		public int LastPotPlayer2 { get; }

		private string player1;
		public string Player1 { get; }
		
		private string player2;
		public string Player2 { get; }

		public MatchTracker()
		{
			lastPlayer1 = "";
			lastPlayer2 = "";
			lastPotPlayer1 = 0;
			lastPotPlayer2 = 0;

			player1 = "";
			player2 = "";
		}

		/// <summary>
		/// Returns true if there is a new match, this is checked by checking if the last player name matches the new one. 
		/// </summary>
		/// <param name="player1"></param>
		/// <param name="player2"></param>
		/// <returns></returns>
		public bool IsNewMatch(string player1, string player2)
		{
			// Skip team matches
			if (player1.Contains("Team"))
				return false;

			// Set last cycle's players to last players. 
			this.lastPlayer1 = this.player1;
			this.lastPlayer2 = this.player2;

			// Get (potentially) new players
			this.player1 = player1;
			this.player2 = player2;

			// If there was no last player, this is probably the first match, return false. 
			if (lastPlayer1 == "")
				return false;

			// If there is a new player name, it's probably a new match
			if (lastPlayer1 != player1 && lastPlayer2 != player2)
			{
				return true;
			}

			// If all else fails, return false
			return false;
		}
	}
}
