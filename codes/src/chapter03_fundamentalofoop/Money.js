function Money(amount, currency) {
  if (amount < 0) {
    throw new Error('金額には0以上を指定してください。');
  }
  if (!currency) {
    throw new Error('通貨単位を指定してください。');
  }
  this.amount = amount;
  this.currency = currency;
  Object.freeze(this);  // 不変にする
}

Money.prototype.add = function(other) {
  if (this.currency !== other.currency) {
    throw new Error('通貨単位が違います。');
  }
  const added = this.amount + other.amount;
  return new Money(added, this.currency);
}
