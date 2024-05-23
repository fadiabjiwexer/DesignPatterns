using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Products
{
    // Concrete Product A2
    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in MacOS style.");
        }
    }
}
