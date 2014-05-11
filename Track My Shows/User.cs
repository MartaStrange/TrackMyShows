using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_My_Shows
{
    public class User
    {

        public string username { get; set; }
        public int gender { get; set; }
        public string dateRegistered { get; set; }

        public int CountTotal()
        {
            string sql = "select count(*) as num from movies";
            SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();
            return (int)(long)reader["num"];
        }

        public int CountUnwatched()
        {
            string sql = "select count(*) as num from movies where watchedDate is null";
            SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();
            return (int)(long)reader["num"];
        }

    }
}
