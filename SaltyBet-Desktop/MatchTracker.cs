using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltyBet_Desktop
{
	class MatchTracker
	{
		// Variables last match
		private string lastPlayer1;
		public string LastPlayer1 { get; set; }

		private string lastPlayer2;
		public string LastPlayer2 { get; set; }

		private int lastPotPlayer1;
		public int LastPotPlayer1 { get; set; }

		private int lastPotPlayer2;
		public int LastPotPlayer2 { get; set; }

		private double lastOddsPlayer1;
		public double LastOddsPlayer1 { get; set; }

		private double lastOddsPlayer2;
		public double LastOddsPlayer2 { get; set; }

		// Variables current match
		private string player1;
		public string Player1 { get; set; }

		private string player2;
		public string Player2 { get; set; }

		private int potPlayer1;
		public int PotPlayer1 { get; set; }

		private int potPlayer2;
		public int PotPlayer2 { get; set; }

		private double oddsPlayer1;
		public double OddsPlayer1 { get; set; }

		private double oddsPlayer2;
		public double OddsPlayer2 { get; set; }

		public MatchTracker()
		{
			lastPlayer1 = "";
			lastPlayer2 = "";
			lastPotPlayer1 = 0;
			lastPotPlayer2 = 0;
			lastOddsPlayer1 = 0.0;
			lastOddsPlayer2 = 0.0;

			player1 = "";
			player2 = "";
			potPlayer1 = 0;
			potPlayer2 = 0;
			oddsPlayer1 = 0.0;
			oddsPlayer2 = 0.0;
		}

		/// <summary>
		/// Returns true if there is a new match, this is checked by checking if the last player name matches the new one. 
		/// </summary>
		/// <returns></returns>
		public bool IsNewMatch()
		{
			// If there was no last player, this is probably the first match, return false. 
			if (lastPlayer1 == "" && lastPlayer2 == "")
				return false;

			// If there is a new player name, it's probably a new match
			if (lastPlayer1 != player1 && lastPlayer2 != player2)
			{
				return true;
			}

			// If all else fails, return false
			return false;
		}

		/// <summary>
		/// Updates all the match stats with data from the browser window. 
		/// </summary>
		/// <param name="dataExtractor"></param>
		public void Update(DataExtractor dataExtractor)
		{
			// Set call's stats to the last
			lastPlayer1 = player1;
			lastPlayer2 = player2;
			lastPotPlayer1 = potPlayer1;
			lastPotPlayer2 = potPlayer2;
			lastOddsPlayer1 = oddsPlayer1;
			lastOddsPlayer2 = oddsPlayer2;
			
			// Get new player names, if applicable. 
			player1 = dataExtractor.GetRedName();
			player2 = dataExtractor.GetBlueName();
			// Get new pots
			potPlayer1 = dataExtractor.GetRedPotNum();
			potPlayer2 = dataExtractor.GetBluePotNum();
			// Get new odds
			oddsPlayer1 = dataExtractor.GetRedOdds();
			oddsPlayer2 = dataExtractor.GetBlueOdds();
		}

		/// <summary>
		/// Returns true if the current match is a team fight
		/// </summary>
		/// <returns></returns>
		public bool IsTeamMatch()
		{
			if (player1.Contains("Team") || player2.Contains("Team"))
				return true;
			else
				return false;
		}

		/// <summary>
		/// Returns true if last match was a team match
		/// </summary>
		/// <returns></returns>
		public bool WasTeamMatch()
		{
			if (lastPlayer1.Contains("Team") || lastPlayer2.Contains("Team"))
				return true;
			else
				return false;
		}
	}
}
