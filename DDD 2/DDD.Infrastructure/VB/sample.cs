using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.SQLite
{
    internal class SQLiteHelper
    {
        internal const string ConnectionString = @"Data Source=C:\Users\anderson\Desktop\DDD.db;Version=3";
        
        internal static IReadOnlyList<T> Query<T>(
            string sql,
            Func<SQLiteDataReader, T> createEntity)
        {
            return Query<T>(sql, null, createEntity);
        }
        
        internal static IReadOnlyList<T> Query<T>(
            string sql,
            SQLiteParameter[] parameters,
            Func<SQLiteDataReader, T> createEntity)
        {
            var result = new List<T>();   
            using (var connection = 
                    new SQLiteConnection(SQLiteHelper.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(createEntity(reader));
                    }
                }
            }
            
            return result;
        }
    }
}
