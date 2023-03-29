using アブストラクトファクトリー.Data;

namespace アブストラクトファクトリー.Factory
{
  public abstract class AbstractFactory
  {
    public abstract IProduct CreateProduct();
    public abstract IStock CreateStock();

    public static AbstractFactory Create(int kind)
    {
      if (kind == 0)
      {
        //リリースモードなら例外
#if DEBUG
#else
        throw new ArgumentException(
          "リリースモードでFakeは使えません");
#endif

        return new FakeFactory();
      }

      if(kind == 1)
      {
        return new SqlServerFactory();
      }

      throw new ArgumentException("kindがおかしい");
    }
  }
}
