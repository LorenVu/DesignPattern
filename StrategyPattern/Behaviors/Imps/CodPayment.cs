using StrategyPattern.Base;

namespace StrategyPattern.Behaviors.Imps
{
    public class CodPayment : IPaymentBehavior
    {
        public object Order(object order)
        {
            if(order is MarketOrder orderMarket)
            {
                Console.WriteLine("Ur order" +
                                      "\n\tID: {0}" +
                                      "\n\tName: {1}" +
                                      "\n\tAmount: {2}", orderMarket.GetOrderID(), orderMarket.GetClientName(), orderMarket.GetAmout());
            }

            return order;
        }

        public float Payment(float amount)
            => amount + amount * 0.1F;
    }
}
