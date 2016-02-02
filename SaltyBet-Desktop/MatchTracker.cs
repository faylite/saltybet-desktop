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
		public string LastPlayer1 { get; set; }
		public string LastPlayer2 { get; set; }
		public int LastPotPlayer1 { get; set; }
		public int LastPotPlayer2 { get; set; }
		public double LastOddsPlayer1 { get; set; }
		public double LastOddsPlayer2 { get; set; }

		// Variables current match
		public string Player1 { get; set; }
		public string Player2 { get; set; }
		public int PotPlayer1 { get; set; }
		public int PotPlayer2 { get; set; }
		public double OddsPlayer1 { get; set; }
		public double OddsPlayer2 { get; set; }

		public MatchTracker()
		{
			LastPlayer1 = "";
			LastPlayer2 = "";
			LastPotPlayer1 = 0;
			LastPotPlayer2 = 0;
			LastOddsPlayer1 = 0.0;
			LastOddsPlayer2 = 0.0;

			Player1 = "";
			Player2 = "";
			PotPlayer1 = 0;
			PotPlayer2 = 0;
			OddsPlayer1 = 0.0;
			OddsPlayer2 = 0.0;
		}

		/// <summary>
		/// Returns true if there is a new match, this is checked by checking if the last player name matches the new one. 
		/// </summary>
		/// <returns></returns>
		public bool IsNewMatch()
		{
			// If there was no last player, this is probably the first match, return false. 
			if (LastPlayer1 == "" && LastPlayer2 == "")
				return false;

			// If there is a new Player name, it's probably a new match
			if (LastPlayer1 != Player1 && LastPlayer2 != Player2)
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
			// Set call's stats to the Last
			LastPlayer1 = Player1;
			LastPlayer2 = Player2;
			LastPotPlayer1 = PotPlayer1;
			LastPotPlayer2 = PotPlayer2;
			LastOddsPlayer1 = OddsPlayer1;
			LastOddsPlayer2 = OddsPlayer2;
			
			// Get new player names, if applicable. 
			Player1 = dataExtractor.GetRedName();
			Player2 = dataExtractor.GetBlueName();
			// Get new pots
			PotPlayer1 = dataExtractor.GetRedPotNum();
			PotPlayer2 = dataExtractor.GetBluePotNum();
			// Get new odds
			OddsPlayer1 = dataExtractor.GetRedOdds();
			OddsPlayer2 = dataExtractor.GetBlueOdds();
		}

		/// <summary>
		/// Returns true if the current match is a team fight
		/// </summary>
		/// <returns></returns>
		public bool IsTeamMatch()
		{
			if (Player1.Contains("Team") || Player2.Contains("Team"))
				return true;
			else
				return false;
		}

		/// <summary>
		/// Returns true if Last match was a team match
		/// </summary>
		/// <returns></returns>
		public bool WasTeamMatch()
		{
			if (LastPlayer1.Contains("Team") || LastPlayer2.Contains("Team"))
				return true;
			else
				return false;
		}
	}
}
