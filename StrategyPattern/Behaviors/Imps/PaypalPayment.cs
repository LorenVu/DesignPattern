using StrategyPattern.Base;

namespace StrategyPattern.Behaviors.Imps
{
    public class PaypalPayment : IPaymentBehavior
    {
        public object Order(object order)
        {
            throw new NotImplementedException();
        }

        public float Payment(float amount)
            => amount + (amount + 2) * 0.1F;
    }
}
