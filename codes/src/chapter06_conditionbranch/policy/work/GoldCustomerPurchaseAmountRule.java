package chapter06_conditionbranch.policy.work;

import chapter06_conditionbranch.policy.PurchaseHistory;

class GoldCustomerPurchaseAmountRule implements ExcellentCustomerRule {
  public boolean ok(final PurchaseHistory history) {
    return 100000 <= history.totalAmount;
  }
}