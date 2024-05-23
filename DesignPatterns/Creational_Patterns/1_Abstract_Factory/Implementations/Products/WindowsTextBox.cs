using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Products
{
    // Concrete Product B1
    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a textbox in Windows style.");
        }
    }
}
