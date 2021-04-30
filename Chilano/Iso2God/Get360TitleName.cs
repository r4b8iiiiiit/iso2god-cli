using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Threading;

namespace Chilano.Iso2God
{
    public class Get360TitleName
    {
        public static string getFromDB(string ID) {
            string table = @"URI=file:IDs.db";
            using var con = new SQLiteConnection(table);
            con.Open();
            var selectStatement = "Select Title FROM Tiltle_List WHERE TitleID = " + '"' + ID.ToLower() + '"';
            using var cmd = new SQLiteCommand(selectStatement, con);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            string gameTitle = "";
            List<string> gTitle = new List<string>();
            while (reader.Read())
            {
                gameTitle = reader.GetString(0);
            }
            //con.Close();
            return gameTitle;
        }
        public static string getTitleID(string ID)
        {
            return ID;
        }
    }
}
