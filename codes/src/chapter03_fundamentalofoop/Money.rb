class Money
  attr_reader :amount, :currency

  def initialize(amount, currency)
    if amount < 0
      raise ArgumentError.new('金額には0以上を指定してください。')
    end
    if currency.nil? || currency.empty?
      raise ArgumentError.new('通貨単位を指定してください。')
    end
    @amount = amount
    @currency = currency
    self.freeze  # 不変にする
  end

  def add(other)
    if @currency != other.currency
      raise ArgumentError.new('通貨単位が違います。')
    end
    added = @amount + other.amount
    Money.new(added, @currency)
  end
end
