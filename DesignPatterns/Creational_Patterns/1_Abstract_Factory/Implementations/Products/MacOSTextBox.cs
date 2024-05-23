using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Products
{
    // Concrete Product B2
    public class MacOSTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a textbox in MacOS style.");
        }
    }
}
