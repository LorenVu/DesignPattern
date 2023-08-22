using StrategyPattern.Behaviors.Imps;

namespace StrategyPattern.Base
{
    public class MarketOrder : Order
    {
        public MarketOrder()
        {
            _paymentBehavior = new CodPayment();
        }

        public MarketOrder(float amount, string clientName, int orderID)
        {
            this.Amout = amount; 
            this.ClientName = clientName;
            this.OrderID = orderID;
            _paymentBehavior = new CodPayment();
        }

        public override void DisplayBill()
        {
            HandlerOrder();
            HandlePayment();
            Console.WriteLine(String.Format("Ur order has been paid, please check the information " +
                $"\n FullName: {this.ClientName}   " +
                $"\n Amout: {this.Amout}  ") +
                $"\n Expense: {this.Expense}  " +
                $"\n");
        }
    }
}
