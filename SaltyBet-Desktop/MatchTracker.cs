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
		private string lastPlayer2;
		private int lastPotPlayer1;
		private int lastPotPlayer2;
		private string player1;
		private string player2;

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
				if (player1.Contains("Team"))
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
