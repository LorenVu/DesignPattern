using StrategyPattern.Base;
using StrategyPattern.Behaviors.Imps;

var marketOrder = new MarketOrder(55.23F, "Loren", 1);
marketOrder.DisplayBill();

var digitalOrder = new DigitalOrder(500, "Lord", 2);
digitalOrder.DisplayBill();

//Change payment method
digitalOrder.SetPaymentBehavior(new BankingPayment());
digitalOrder.DisplayBill();



