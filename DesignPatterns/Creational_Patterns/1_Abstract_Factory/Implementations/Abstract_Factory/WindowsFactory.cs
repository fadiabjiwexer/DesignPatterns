using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Products;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces.Abstract_Factory;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Abstract_Factory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
