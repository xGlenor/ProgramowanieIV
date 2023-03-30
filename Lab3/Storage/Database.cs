using Lab3.Storage;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Lab3.Storage
{
    public class Database
    {
        private static Database instance;
        private RainbowDatabase RainbowDatabase;
        private DbConnection sql;
        private string sqlString;
        private string dbName;
        private string SrvName;

        public Database(string SrvName, string dbName)
        {
            instance = this;
            this.SrvName = SrvName;
            this.dbName = dbName;
            //this.sqlString = $"Data Source={SrvName};Initial Catalog={dbName};Integrated Security=True; MultipleActiveResultSets=True";
            this.sqlString = $"Data Source=GRZES-DESKTOP;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            this.sql = new SqlConnection(sqlString);

            RainbowDatabase = RainbowDatabase.Init(sql, commandTimeout: 2);

        }

        public RainbowDatabase GetRainbowDatabase()
        {
            return RainbowDatabase;
        }

        public DbConnection GetConn()
        {
            return sql;
        }

        public bool IsOpen()
        {
            return sql.State.Equals(ConnectionState.Open);
        }

        public void Open()
        {
            sql.Open();
        }

        public void Close()
        {
            sql.Close();
        }

        public void Dispose()
        {
            sql.Dispose();
        }

        public String getSqlString()
        {
            return sqlString;
        }

        public void setSqlString(string sqlString)
        {
            this.sqlString = sqlString;
        }

        public static Database GetDatabase()
        {
            return instance;
        }
    }
}
