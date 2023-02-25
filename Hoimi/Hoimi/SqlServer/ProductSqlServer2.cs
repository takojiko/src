//using Dapper;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;

//namespace Hoimi.SqlServer
//{
//    public static class ProductSqlServer
//    {
//        private static string _connectionString;
//        static ProductSqlServer()
//        {
//            var builder = new SqlConnectionStringBuilder();
//            builder.DataSource = @"ANDERSON-PC\SQLEXPRESS";
//            builder.InitialCatalog = "Hoimi";
//            builder.IntegratedSecurity = true;
//            _connectionString = builder.ToString();
//        }

//        public static DataTable GetDataTable()
//        {
//            var sql = @"
//select * from Product
//";

//            DataTable dt = new DataTable();
//            using (var connection = new SqlConnection(_connectionString))
//            using (var adapter = new SqlDataAdapter(sql, connection))
//            {
//                connection.Open();
//                adapter.Fill(dt);
//            }

//            return dt;
//        }

//        public static List<ProductEntity> GetDataReader()
//        {
//            var sql = @"
//select ProductId,
//       ProductName,
//       Price
//from Product
//";
//            var result = new List<ProductEntity>();
//            using (var connection = new SqlConnection(_connectionString))
//            using (var command = new SqlCommand(sql, connection))
//            {
//                connection.Open();
//                using (var reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        result.Add(new ProductEntity(
//                            Convert.ToInt32(reader["ProductId"]),
//                            Convert.ToString(reader["ProductName"]),
//                            Convert.ToInt32(reader["Price"])));
//                    }
//                } 
//            }

//            return result;
//        }

//        public static void Insert(ProductEntity product)
//        {
//            string sql = @"
//insert into Product
//(ProductId,
// ProductName,
// Price)
//values
//(
// @ProductId,
// @ProductName,
// @Price
//)
//";

//            using (var connection = new SqlConnection(_connectionString))
//            using (var command = new SqlCommand(sql, connection))
//            {
//                connection.Open();
//                command.Parameters.AddWithValue("@ProductId", product.ProductId);
//                command.Parameters.AddWithValue("@ProductName", product.ProductName);
//                command.Parameters.AddWithValue("@Price", product.Price);
//                command.ExecuteNonQuery();
//            }
//        }

//        public static void Update(ProductEntity product)
//        {
//            string sql = @"
//update Product
//set ProductName = @ProductName,
//    Price = @Price
//where ProductId = @ProductId
//";

//            using (var connection = new SqlConnection(_connectionString))
//            using (var command = new SqlCommand(sql, connection))
//            {
//                connection.Open();
//                command.Parameters.AddWithValue("@ProductId", product.ProductId);
//                command.Parameters.AddWithValue("@ProductName", product.ProductName);
//                command.Parameters.AddWithValue("@Price", product.Price);
//                var updateCount = command.ExecuteNonQuery();
//                if(updateCount < 1)
//                {
//                    Insert(product);
//                }
//            }
//        }

//        public static void Delete(int productId)
//        {
//            string sql = @"
//delete Product
//where ProductId = @ProductId
//";

//            using (var connection = new SqlConnection(_connectionString))
//            using (var command = new SqlCommand(sql, connection))
//            {
//                connection.Open();
//                command.Parameters.AddWithValue("@ProductId", productId);
//                command.ExecuteNonQuery();
//            }
//        }

//        public static List<ProductEntity> GetDapper()
//        {
//            var sql = @"
//select ProductId,
//       ProductName,
//       Price
//from Product
//";
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                return connection.Query<ProductEntity>(sql).ToList();
//            }
//        }


//        public static void DapperInsert(ProductEntity product)
//        {
//            string sql = @"
//insert into Product
//(ProductId,
// ProductName,
// Price)
//values
//(
// @AAA,
// @ProductName,
// @Price
//)
//";

//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Execute(sql,
//                    new
//                    {
//                        AAA = product.ProductId,
//                        ProductName  = product.ProductName,
//                        Price = product.Price,
//                    });
//            }
//        }
//    }
//}


////bigint→C# long ToInt64;
////int→C# long ToInt32;
////smallint→C# long ToInt18;
////tinyint→C# long ToByte;

////real →C# float ToSingle()
////float →C# double

////varchar →C# string