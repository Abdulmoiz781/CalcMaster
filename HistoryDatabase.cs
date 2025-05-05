/*
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;



namespace CalcMaster
{
    public static class HistoryDatabase
    {
        private static readonly string dbFile = "calc_history.db";
        private static readonly string ConnectionString = $"Data Source={dbFile};Version=3;";

        static HistoryDatabase()
        {
            InitializeDatabase();
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS History (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Expression TEXT NOT NULL,
                        Result TEXT NOT NULL,
                        Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                    );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void SaveCalculation(string expression, string result)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO History (Expression, Result) VALUES (@Expression, @Result)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Expression", expression);
                    command.Parameters.AddWithValue("@Result", result);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<CalculationEntry> GetRecentHistory(int count = 10)
        {
            var history = new List<CalculationEntry>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = @"
                    SELECT Expression, Result, Timestamp
                    FROM History
                    ORDER BY Timestamp DESC
                    LIMIT @Count";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            history.Add(new CalculationEntry
                            {
                                Expression = reader["Expression"].ToString(),
                                Result = reader["Result"].ToString(),
                                Timestamp = DateTime.Parse(reader["Timestamp"].ToString())
                            });
                        }
                    }
                }
            }

            return history;
        }

        public static List<(string Expression, string Result)> GetHistory()
        {
            var history = new List<(string, string)>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Expression, Result FROM History ORDER BY Timestamp DESC";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string expression = reader.GetString(0);
                        string result = reader.GetString(1);
                        history.Add((expression, result));
                    }
                }
            }

            return history;
        }

        public static void ClearAllHistory()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM History", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }



    }

    public class CalculationEntry
    {
        public string Expression { get; set; }
        public string Result { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace CalcMaster
{
    public static class HistoryDatabase
    {
        private static readonly string dbFile = "calc_history.db";
        private static readonly string ConnectionString = $"Data Source={dbFile};Version=3;";

        static HistoryDatabase()
        {
            InitializeDatabase();
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS History (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Expression TEXT NOT NULL,
                        Result TEXT NOT NULL,
                        Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                    );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void SaveCalculation(string expression, string result)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO History (Expression, Result) VALUES (@Expression, @Result)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Expression", expression);
                    command.Parameters.AddWithValue("@Result", result);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<CalculationEntry> GetRecentHistory(int count = 10)
        {
            var history = new List<CalculationEntry>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = @"
                    SELECT Expression, Result, Timestamp
                    FROM History
                    ORDER BY Timestamp DESC
                    LIMIT @Count";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            history.Add(new CalculationEntry
                            {
                                Expression = reader["Expression"].ToString(),
                                Result = reader["Result"].ToString(),
                                Timestamp = DateTime.Parse(reader["Timestamp"].ToString())
                            });
                        }
                    }
                }
            }

            return history;
        }

        public static List<(string Expression, string Result)> GetHistory()
        {
            var history = new List<(string, string)>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Expression, Result FROM History ORDER BY Timestamp DESC";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string expression = reader.GetString(0);
                        string result = reader.GetString(1);
                        history.Add((expression, result));
                    }
                }
            }

            return history;
        }

        public static void ClearAllHistory()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM History";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }

    public class CalculationEntry
    {
        public string Expression { get; set; }
        public string Result { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
