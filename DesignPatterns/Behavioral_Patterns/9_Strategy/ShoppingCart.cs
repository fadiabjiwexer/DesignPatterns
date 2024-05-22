namespace DesignPatterns.Behavioral_Patterns._9_Strategy
{
    public class ShoppingCart
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public ShoppingCart(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout(double amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
