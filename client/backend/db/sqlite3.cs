using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GGSClient.client.backend.db
{
    internal class sqlite3
    {
        private static SQLiteConnection sqlite = new SQLiteConnection($"Data Source={GGSClient.client.defaultC.values.sqlite3_db}");

        public static DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                if (File.Exists("debug"))
                {
                    MessageBox.Show("ERROR: " + ex, "VPN Client by GGS-Network - GGSClient.client.backend.sqlite3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message, "VPN Client by GGS-Network - GGSClient.client.backend.sqlite3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            sqlite.Close();
            return dt;
        }

        // commands
        public static void importTableUser()
        {
            selectQuery($@"CREATE TABLE user ( id INTEGER PRIMARY KEY, username TEXT NOT NULL, email TEXT NOT NULL, session TEXT NOT NULL );");
        }
        public static void addUser(string username, string email, string session)
        {
            selectQuery($@"INSERT INTO user (username, email) VALUES ('{username}', '{email}', '{session}')");
        }
        public static void deleteUser(string username)
        {
            selectQuery($@"DELETE FROM user WHERE username = '{username}'");
        }
        public static void updateSession(string username, string session)
        {
            selectQuery($@"UPDATE user SET session = '{session}' WHERE username = '{username}'");
        }
    }
}
