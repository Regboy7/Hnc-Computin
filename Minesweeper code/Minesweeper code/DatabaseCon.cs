using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Minesweeper_code
{
    static class DatabaseCon
    {
        const string provider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:/Projects/Minesweeper military/Minesweeper code.accdb";
        public static List<string> Datalist(string req, string DB, string req2, string req3)
        {
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                List<string> retrievedResults = new List<string>();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [" + req + "] FROM " + DB + " WHERE " + req2 + "='" + req3 + "';";
                cmd.Connection = dbCon;
                dbCon.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    retrievedResults.Add(dr[req].ToString());
                }
                return retrievedResults;
            }
        }
        public static string Datalist(string req, string DB, string UID)
        {
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                List<string> retrievedResults = new List<string>();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [" + req + "] FROM " + DB + " WHERE  UID = " + UID + ";";
                cmd.Connection = dbCon;
                dbCon.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    retrievedResults.Add(dr[req].ToString());
                }
                return retrievedResults[0];
            }
        }

        public static List<string> Datalist(string req, string DB)
        {
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                List<string> retrievedResults = new List<string>();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [" + req + "] FROM " + DB + ";";
                cmd.Connection = dbCon;
                dbCon.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    retrievedResults.Add(dr[req].ToString());
                }
                return retrievedResults;
            }
        }
        public static DataTable DataLIKElist(string req, string DB, string req2, string req3)
        {
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                dbCon.Open();
                List<string> retrievedResults = new List<string>();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = req != "*" ? ("SELECT [" + req + "] FROM " + DB + " WHERE " + req2 + " LIKE '%" + req3 + "%';") : ("SELECT " + req + " FROM " + DB + " WHERE " + req2 + " LIKE '%" + req3 + "%';");
                cmd.Connection = dbCon;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dbCon.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetTable(string table)
        {
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                dbCon.Open();

                string command = $"SELECT * FROM {table}";

                OleDbDataAdapter da = new OleDbDataAdapter(command, dbCon);
                dbCon.Close();
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
