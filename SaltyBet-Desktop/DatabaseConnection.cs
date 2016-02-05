using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SaltyBet_Desktop
{
	class DatabaseConnection
	{
		private SQLiteConnection dbConnection;

		// The folder in which data from SaltyBot is stored.
		private string dbFolder = System.IO.Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SaltyBot"
		);
		// The full path to the database file. 
		private string dbPath = System.IO.Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
			"SaltyBot", "recordings.dat"
		);

		public DatabaseConnection()
		{
			// Create new database if it does not exist
			CreateDatabase();
			InitDB();

			// Open db connection. 
			dbConnection = new SQLiteConnection(String.Format("Data Source={0};Version=3;", dbPath));
			dbConnection.Open();
		}
		
		public void InsertMatchData(string timeStamp, string redName, int redPot, double redOdds, string blueName, int bluePot, double blueOdds, string winner, string matchTime)
		{
			// SQL string
			string sql = string.Format(@"
				INSERT INTO matches(TimeStamp, RedName, RedPot, RedOdds, BlueName, BluePot, BlueOdds, Winner, MatchTime) 
				VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}')
			", timeStamp, redName, redPot, redOdds, blueName, bluePot, blueOdds, winner, matchTime);
			// Create the command and execute the query
			SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
			command.ExecuteNonQueryAsync();
		}

		private void InitDB()
		{
			// TimeStamp | RedName | RedPot | Red Odds | BlueName | BluePot | BlueOdds | Winner | Match Time
			// SQL query
			string sql = @"
				CREATE TABLE IF NOT EXISTS matches(
				ID INT PRIMARY KEY NOT NULL,
				TimeStamp TEXT NOT NULL, 

				RedName TEXT NOT NULL, 
				RedPot INT NOT NULL,
				RedOdds REAL NOT NULL,

				BlueName TEXT NOT NULL, 
				BluePot INT NOT NULL, 
				BlueOdds REAL NOT NULL, 

				Winner TEXT NOT NULL, 
				MatchTime TEXT
			);";
			// Create a command that will be executed on the dbConnection
			SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
			// Execute the query
			command.ExecuteNonQueryAsync();
		}

		/// <summary>
		/// Creates a new database in the my documents area if a database is not already created. 
		/// </summary>
		public void CreateDatabase()
		{
			// Check if the SaltyBot Documents folder exists, if not create it. 
			if (!System.IO.Directory.Exists(dbFolder))
				System.IO.Directory.CreateDirectory(dbFolder);
			// Check if the database has been created, if not create it. 
			if (!System.IO.File.Exists(dbPath))
				SQLiteConnection.CreateFile(dbPath);
		}
	}
}
