using DesignPatterns.Behavioral_Patterns._7_Observer.Interfaces;

namespace DesignPatterns.Behavioral_Patterns._7_Observer.Implementations
{
    public class StatisticsDisplay : IObserver
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Statistics display: Avg/Max/Min temperature = {temp}/{temp}/{temp}");
        }
    }
}
