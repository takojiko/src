namespace アブストラクトファクトリー.Data
{
  public static class Factories
  {
    public static IProduct CreateProduct(int kind)
    {
      if (kind == 0)
      {
        //リリースモードなら例外
#if DEBUG
#else
        throw new ArgumentException(
          "リリースモードでFakeは使えません");
#endif

        return new ProductFake();
      }

      if (kind == 1)
      {
        return new ProductSqlServer();
      }

      throw new ArgumentException("");
    }

    public static IStock CreateStock(int kind)
    {
      if (kind == 0)
      {
        //リリースモードなら例外
#if DEBUG
#else
        throw new ArgumentException(
          "リリースモードでFakeは使えません");
#endif

        return new StockFake();
      }

      if (kind == 1)
      {
        return new StockSqlServer();
      }

      throw new ArgumentException("");
    }
  }
}
