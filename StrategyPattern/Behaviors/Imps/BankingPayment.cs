using StrategyPattern.Base;

namespace StrategyPattern.Behaviors.Imps
{
    public class BankingPayment : IPaymentBehavior
    {
        public object Order(object order)
        {
            throw new NotImplementedException();
        }

        public float Payment(float amount)
            => amount + amount * 0.1F;
    }
}
