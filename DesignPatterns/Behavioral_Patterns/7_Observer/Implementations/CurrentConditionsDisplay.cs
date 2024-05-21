using DesignPatterns.Behavioral_Patterns._7_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._7_Observer.Implementations
{
    public class CurrentConditionsDisplay : IObserver
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Current conditions: {temp}F degrees, {humidity}% humidity, {pressure} pressure");
        }
    }
}
