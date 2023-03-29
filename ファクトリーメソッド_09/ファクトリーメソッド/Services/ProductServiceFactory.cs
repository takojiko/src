using ファクトリーメソッド.Data;

namespace ファクトリーメソッド.Services
{
  //今作ったクリエイターのサブクラス
  internal sealed class ProductServiceFactory : ProductService
  {
    //ファクトリーメソッドだけを書く
    protected override IProduct FactoryMethod(int kind)
    {
      if (kind == 0)
      {
        return new ProductFake();
      }
      else if (kind == 1)
      {
        return new ProductSqlServer();
      }

      throw new ArgumentException("kindがおかしいよ");
    }
  }
}
