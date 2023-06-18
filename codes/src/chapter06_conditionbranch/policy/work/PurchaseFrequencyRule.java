package chapter06_conditionbranch.policy.work;

import chapter06_conditionbranch.policy.PurchaseHistory;

class PurchaseFrequencyRule implements ExcellentCustomerRule {
  public boolean ok(final PurchaseHistory history) {
    return 10 <= history.purchaseFrequencyPerMonth;
  }
}