using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQlite
{
    public class DataBase
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public void CreateDB()
        {
            if (!File.Exists("Web.sqlite"))
            {
                SQLiteConnection.CreateFile("Web.sqlite");

                string sql = @"CREATE TABLE News(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT ,
                               Name           TEXT      NOT NULL,
                               Summary            TEXT       NOT NULL,
                               Date            TEXT       NOT NULL
                            );";
                con = new SQLiteConnection("Data Source=Web.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                con = new SQLiteConnection("Data Source=Web.sqlite;Version=3;");
            }
        }
        public void AddData(List<string> name, List<string> summary, List<string> time)
        {
            CreateDB();
            for (int i = 0; i < name.Count; i++)
            {
                cmd = new SQLiteCommand("Data Source=Web.sqlite;Version=3;",con);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into News(Name,Summary,Date) values ('" + name[i].ToString() + "','" + summary[i].ToString() + "','" + time[i].ToString() + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
