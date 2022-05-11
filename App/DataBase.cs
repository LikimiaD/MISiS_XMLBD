using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SQlite
{
    public partial class DataBase
    {
        public static RichTextBox txt = new RichTextBox();
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();
        public void Start ()
        {
            AllocConsole();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
        }
        public void Write(List<string> name, List<string> summary, List<string> date)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            for (int i = 0; i < name.Count; i++)
            {
                InsertData(sqlite_conn, name[i], summary[i], date[i]);
            }
            Console.WriteLine("SQLite: The table was imported from RSS");
        }
        public void Show()
        {
            SQLiteConnection sqlite_conn;
            using (sqlite_conn = CreateConnection())
            {
                ReadData(sqlite_conn);
            }
            Console.WriteLine("SQLite: RSS Table loaded in Web.cs");
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
           // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
            Console.WriteLine("SQLite: Connected");
        }

        static void CreateTable(SQLiteConnection conn)
        {
             SQLiteCommand sqlite_cmd;
            string Deletesql = "drop table if exists News";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Deletesql;
            sqlite_cmd.ExecuteNonQuery();
            string Createsql = "create table if not exists News(Name VARCHAR(1000), Summary VARCHAR(1000), Date VARCHAR(1000))";
             sqlite_cmd = conn.CreateCommand();
             sqlite_cmd.CommandText = Createsql;
             sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection conn, string name, string summary, string date)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO News(Name, Summary, Date) VALUES('{name}', '{summary}', '{date}'); ";
           sqlite_cmd.ExecuteNonQuery();
        }

        static void ReadData(SQLiteConnection conn)
        {
            AllocConsole();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM News";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                txt.Text += "Name: " + sqlite_datareader.GetString(0) + "\nSummary: " + sqlite_datareader.GetString(1) + "\nDate: " + sqlite_datareader.GetString(2) + "\n";
            }
            conn.Close();
        }
    }
}
