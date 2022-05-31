using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace GoodGameDB
{
    internal class ConnectDB
    {
        public static SQLiteConnection conn;

        public static SQLiteDataReader Reader(string query)
        {
            conn = new SQLiteConnection(@"Data Source=data.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public static DataTable CreateDataTable(string query)
        {
            conn = new SQLiteConnection("Data source=data.db");
            conn.Open();
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = query;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static void Close()
        {
            conn.Close();
        }
    }
}
