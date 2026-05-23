using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BUS
{
    public class ConnectionBUS
    {
        private const string EncryptKey = "qwertyuiop";

        public bool TestConnection(string server, string username, string password, string database, out string error)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(BuildConnectionString(server, username, password, database)))
                {
                    conn.Open();
                }
                error = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public List<string> GetDatabases(string server, string username, string password, out string error)
        {
            var result = new List<string>();
            error = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(BuildConnectionString(server, username, password, null)))
                using (SqlCommand cmd = new SqlCommand("select name from sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result.Add(dr.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return result;
        }

        public void SaveConnection(string server, string username, string password, string database)
        {
            string enCryptServ = Encryptor.Encrypt(server, EncryptKey, true);
            string enCryptPass = Encryptor.Encrypt(password, EncryptKey, true);
            string enCryptData = Encryptor.Encrypt(database, EncryptKey, true);
            string enCryptUser = Encryptor.Encrypt(username, EncryptKey, true);
            connect cn = new connect(enCryptServ, enCryptUser, enCryptPass, enCryptData);
            cn.SaveFile();
        }

        private static string BuildConnectionString(string server, string username, string password, string database)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = server;
            if (!string.IsNullOrWhiteSpace(database))
                builder.InitialCatalog = database;
            builder.UserID = username;
            builder.Password = password;
            builder.IntegratedSecurity = false;
            builder.TrustServerCertificate = true;
            return builder.ConnectionString;
        }
    }
}
