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

		public bool IsNewMatch(string player1, string player2)
		{
			this.player1 = player1;
			this.player2 = player2;

			// If there is a new player name, it's a new match
			if (lastPlayer1 != player1)
			{
				// Filters out team matches
				// Also returns false if this was the first players
				if (player1.Contains("Team") || (player1 == "" && player2 == ""))
					return false;
				return true;
			}
			else
			{
				lastPlayer1 = player1;
				lastPlayer2 = player2;
				return false;
			}
		}
	}
}
