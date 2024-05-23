using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces.Abstract_Factory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
