namespace ファクトリーメソッド.Data
{
  internal sealed class ProductSqlServer : IProduct
  {
    public string GetData()
    {
      return "sql server xxxxx";
    }

    public DateTime GetValidDate()
    {
      return Convert.ToDateTime("2024/01/01");
    }
  }
}