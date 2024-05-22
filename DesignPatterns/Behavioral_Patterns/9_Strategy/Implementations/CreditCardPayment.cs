namespace DesignPatterns.Behavioral_Patterns._9_Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} using Credit Card.");
        }
    }
}
