using StrategyPattern.Behaviors.Imps;

namespace StrategyPattern.Base
{
    public class DigitalOrder : Order
    {
        public DigitalOrder(float amount, string clientName, int orderID)
        {
            this.Amout = amount;
            this.ClientName = clientName;
            this.OrderID = orderID;
            _paymentBehavior = new PaypalPayment();
        }

        public DigitalOrder()
        {
            _paymentBehavior = new PaypalPayment();
        }

        public override void DisplayBill()
        {
            HandlePayment();
            Console.WriteLine(String.Format("Digital order has been paid" +
                $"\n FullName: {this.ClientName}  " +
                $"\n Amout: {this.Amout}  ") +
                $"\n Expense: {this.Expense}  " +
                $"\n");
        }
    }
}
