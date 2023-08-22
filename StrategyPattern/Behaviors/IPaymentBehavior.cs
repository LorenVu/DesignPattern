namespace StrategyPattern.Behaviors
{
    public interface IPaymentBehavior
    {
        float Payment(float amount);
        object Order(object order);
    }
}
