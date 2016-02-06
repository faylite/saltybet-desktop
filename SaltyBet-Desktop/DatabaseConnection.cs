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

			// Open db connection. 
			dbConnection = new SQLiteConnection(String.Format("Data Source={0};Version=3;", dbPath));
			dbConnection.Open();

			// Create new db tables if they do not exist
			InitDB();
		}
		
		public void InsertMatchData(string timeStamp, string redName, int redPot, double redOdds, string blueName, int bluePot, double blueOdds, string winner, string matchTime)
		{
			// SQL string
			string sql = string.Format(@"
				INSERT INTO matches(TimeStamp, RedName, RedPot, RedOdds, BlueName, BluePot, BlueOdds, Winner, MatchTime) 
				VALUES (@timeStamp, @redName, @redPot, @redOdds, @blueName, @bluePot, @blueOdds, @winner, @matchTime)
			", timeStamp, redName, redPot, redOdds, blueName, bluePot, blueOdds, winner, matchTime);
			// Create the command and execute the query
			SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

			// Add escaped paramaters
			command.Parameters.AddWithValue("timeStamp", timeStamp);
			command.Parameters.AddWithValue("redName", redName);
			command.Parameters.AddWithValue("redPot", redPot);
			command.Parameters.AddWithValue("redOdds", redOdds);
			command.Parameters.AddWithValue("blueName", blueName);
			command.Parameters.AddWithValue("bluePot", bluePot);
			command.Parameters.AddWithValue("blueOdds", blueOdds);
			command.Parameters.AddWithValue("winner", winner);
			command.Parameters.AddWithValue("matchTime", matchTime);

			// Execute query
			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Fills the passed DataGridView with the rows in the database
		/// </summary>
		/// <param name="dgw"></param>
		public void FillDataGridView(System.Windows.Forms.DataGridView dgw)
		{
			// Select all rows from matches table
			SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM matches", dbConnection);
			// Execute the query and read it into the DataGridView
			using (SQLiteDataReader read = cmd.ExecuteReader())
			{
				while (read.Read())
				{
					dgw.Rows.Add(new object[]
					{
						read.GetValue(read.GetOrdinal("timeStamp")),
						read.GetValue(read.GetOrdinal("redName")),
						read.GetValue(read.GetOrdinal("redPot")),
						read.GetValue(read.GetOrdinal("redOdds")),
						read.GetValue(read.GetOrdinal("blueName")),
						read.GetValue(read.GetOrdinal("bluePot")),
						read.GetValue(read.GetOrdinal("blueOdds")),
						read.GetValue(read.GetOrdinal("winner")),
						read.GetValue(read.GetOrdinal("matchTime"))
					});
				}
			}
		}

		private void InitDB()
		{
			// TimeStamp | RedName | RedPot | Red Odds | BlueName | BluePot | BlueOdds | Winner | Match Time
			// SQL query
			string sql = @"
				CREATE TABLE IF NOT EXISTS matches(
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
			command.ExecuteNonQuery();
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
