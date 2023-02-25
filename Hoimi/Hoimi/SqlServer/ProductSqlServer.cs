using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Hoimi.SqlServer
{
    public static class ProductSqlServer
    {
        static ProductSqlServer()
        {
        }

        public static DataTable GetDataTable()
        {
            var sql = @"
select * from Product
";

            return SqlServerHelper.GetDataTable(sql);
        }

        public static List<ProductEntity> GetDataReader()
        {
            var sql = @"
select ProductId,
       ProductName,
       Price
from Product
";
            var result = new List<ProductEntity>();
            SqlServerHelper.Query(sql,
                reader =>
                {
                    result.Add(new ProductEntity(
                          Convert.ToInt32(reader["ProductId"]),
                          Convert.ToString(reader["ProductName"]),
                          Convert.ToInt32(reader["Price"])));
                });

            return result;
        }

        public static void Insert(ProductEntity product)
        {
            string sql = @"
insert into Product
(ProductId,
 ProductName,
 Price)
values
(
 @ProductId,
 @ProductName,
 @Price
)
";
            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", product.ProductId));
            p.Add(new SqlParameter("@ProductName", product.ProductName));
            p.Add(new SqlParameter("@Price", product.Price));
            SqlServerHelper.Execute(sql, p);
        }

        public static void Update(ProductEntity product)
        {
            string sql = @"
update Product
set ProductName = @ProductName,
    Price = @Price
where ProductId = @ProductId
";

            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", product.ProductId));
            p.Add(new SqlParameter("@ProductName", product.ProductName));
            p.Add(new SqlParameter("@Price", product.Price));
            var updateCount = SqlServerHelper.Execute(sql, p);
            if (updateCount < 1)
            {
                Insert(product);
            }
        }

        public static void Delete(int productId)
        {
            string sql = @"
delete Product
where ProductId = @ProductId
";

            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", productId));
            SqlServerHelper.Execute(sql, p);
        }

        public static List<ProductEntity> GetDapper()
        {
            var sql = @"
select ProductId,
       ProductName,
       Price
from Product
";
            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                return connection.Query<ProductEntity>(sql).ToList();
            }
        }


        public static void DapperInsert(ProductEntity product)
        {
            string sql = @"
insert into Product
(ProductId,
 ProductName,
 Price)
values
(
 @AAA,
 @ProductName,
 @Price
)
";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                connection.Execute(sql,
                    new
                    {
                        AAA = product.ProductId,
                        ProductName  = product.ProductName,
                        Price = product.Price,
                    });
            }
        }
    }
}


//bigint→C# long ToInt64;
//int→C# long ToInt32;
//smallint→C# long ToInt18;
//tinyint→C# long ToByte;

//real →C# float ToSingle()
//float →C# double

//varchar →C# string