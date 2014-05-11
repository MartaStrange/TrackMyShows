using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_My_Shows
{
    class DatabaseConnector
    {

        private static SQLiteConnection connection = null;

        public static SQLiteConnection getConnection()
        {
            if (connection != null)
            {
                return connection;
            }

            string baseFolder = AppDomain.CurrentDomain.BaseDirectory;// +"..//..//..//..//";
            Console.WriteLine(baseFolder);

            connection = new SQLiteConnection("Data Source=" + Path.Combine(baseFolder, "tms.sqlite") + ";");
            connection.Open();

            return connection;
        }
            
    }
}