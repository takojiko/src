using ファクトリーメソッド.Data;

namespace ファクトリーメソッド.Services
{
  //Creatorにあたるクラス
  public abstract class ProductService
  {
    public IProduct Create()
    {
      //サブクラスが生成するインスタンスに対するロジックを書く
      //このプロダクトが何かは知らない
      var product = FactoryMethod(Program.Kind);

      //インスタンスを使って共通の処理を書くことができる
      if (product.GetValidDate() < DateTime.Now)
      {
        throw new Exception("無効な製品です");
      }

      return product;
    }

    protected abstract IProduct FactoryMethod(int kind);
  }
}
