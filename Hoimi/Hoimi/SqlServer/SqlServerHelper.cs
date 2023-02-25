using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoimi.SqlServer
{
    public static class SqlServerHelper
    {
        internal static string ConnectionString { get; }
        static SqlServerHelper()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"ANDERSON-PC\SQLEXPRESS";
            builder.InitialCatalog = "Hoimi";
            builder.IntegratedSecurity = true;
            ConnectionString = builder.ToString();
        }

        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(ConnectionString))
            using (var adapter = new SqlDataAdapter(sql, connection))
            {
                connection.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static void Query(string sql,Action<SqlDataReader> action)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        action(reader);
                    }
                }
            }
        }

        public static int Execute(string sql,List<SqlParameter> sqlParameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                if (sqlParameters != null)
                {
                    command.Parameters.AddRange(sqlParameters.ToArray());
                }
                
                return command.ExecuteNonQuery();
            }
        }
    }
}
