namespace DesignPatterns.Behavioral_Patterns._9_Strategy
{
    public class BitcoinPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} using Bitcoin.");
        }
    }
}
