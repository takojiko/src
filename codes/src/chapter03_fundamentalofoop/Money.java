package chapter03_fundamentalofoop;

import java.util.Currency;

class Money {
  final int amount;
  final Currency currency;

  Money(final int amount, final Currency currency) {
    if (amount < 0) {
      throw new IllegalArgumentException("金額には0以上を指定してください。");
    }
    if (currency == null) {
      throw new NullPointerException("通貨単位を指定してください。");
    }

    this.amount = amount;
    this.currency = currency;
  }

  Money add(final Money other) {
    if (!currency.equals(other.currency)) {
      throw new IllegalArgumentException("通貨単位が違います。");
    }

    final int added = amount + other.amount;
    return new Money(added, currency);
  }
}
