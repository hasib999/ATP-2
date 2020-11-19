using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Inventory_Management_System_with_ADO.Net.Models
{
    public class DataAccess:IDisposable
    {
        SqlConnection connection;
        SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString);
            this.connection.Open();
        }

        //ExecuteReader()
        //ExecuteNonQuery()
        //ExecuteScalar()
        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql,connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}