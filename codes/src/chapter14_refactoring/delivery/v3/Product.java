package chapter14_refactoring.delivery.v3;

class Product {
  final int id;
  final String name;
  final int price;

  Product(final int id, final String name, final int price) {
    this.id = id;
    this.name = name;
    this.price = price;
  }
}
