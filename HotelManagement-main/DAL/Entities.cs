using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public partial class Entities
    {
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true)
            : base(connectionString, contextOwnsConnection) { }
        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            //Doc file connect
            string filePath = connect.GetFilePath();
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Chua cau hinh ket noi. Vui long thiet lap ket noi truoc.", filePath);

            connect cp;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                cp = (connect)bf.Deserialize(fs);
            }

            //Decrypt noi dung
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);


            SqlConnectionStringBuilder sqlConnectBuiler = new SqlConnectionStringBuilder();
            sqlConnectBuiler.DataSource = servername;
            sqlConnectBuiler.InitialCatalog = database;
            sqlConnectBuiler.UserID = username;
            sqlConnectBuiler.Password = pass;

            string sqlConnectionString = sqlConnectBuiler.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectionString;

            entityBuilder.Metadata = @"res://*/HOTEL.csdl|res://*/HOTEL.ssdl|res://*/HOTEL.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            return new Entities(connection);
        }
    }
}
