using StrategyPattern.Behaviors;
using System.Reflection.Metadata.Ecma335;

namespace StrategyPattern.Base
{
    public abstract class Order
    {
        protected int OrderID { get; set; }
        protected string ClientName { get; set; } = String.Empty;
        protected float Amout { get; set; }
        protected float Expense { get; set; }
        protected IPaymentBehavior _paymentBehavior { get; set; }

        public int GetOrderID()
            => OrderID;

        public string GetClientName()
            => ClientName;

        public float GetAmout()
            => Amout;

        public void SetPaymentBehavior(IPaymentBehavior paymentBehavior)
        {
            this._paymentBehavior = paymentBehavior;
        }

        public abstract void DisplayBill();

        public void HandlePayment()
            => Expense = _paymentBehavior.Payment(this.Amout);

        public void HandlerOrder()
            => _paymentBehavior.Order(this);
    }
}
