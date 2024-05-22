namespace DesignPatterns.Behavioral_Patterns._9_Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} using PayPal.");
        }
    }
}
