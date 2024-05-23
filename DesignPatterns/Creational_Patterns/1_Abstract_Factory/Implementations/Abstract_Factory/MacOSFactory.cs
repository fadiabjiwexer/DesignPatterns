using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Products;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces.Abstract_Factory;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Abstract_Factory
{
    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }
}
