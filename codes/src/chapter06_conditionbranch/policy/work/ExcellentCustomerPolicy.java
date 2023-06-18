package chapter06_conditionbranch.policy.work;

import chapter06_conditionbranch.policy.PurchaseHistory;

import java.util.HashSet;
import java.util.Set;

class ExcellentCustomerPolycy {
  private final Set<ExcellentCustomerRule> rules;

  ExcellentCustomerPolycy() {
    rules = new HashSet();
  }

  /**
   * ルールを追加する
   * 
   * @param rule ルール
   */
  void add(final ExcellentCustomerRule rule) {
    rules.add(rule);
  }

  /**
   * @param history 購入履歴
   * @return ルールを全て満たす場合true
   */
  boolean complyWithAll(final PurchaseHistory history) {
    for (ExcellentCustomerRule each : rules) {
      if (!each.ok(history)) return false;
    }
    return true;
  }
}