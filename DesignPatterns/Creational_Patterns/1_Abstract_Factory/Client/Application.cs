using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces.Abstract_Factory;
using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Client
{
    public class Application
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _textBox = factory.CreateTextBox();
        }

        public void Run()
        {
            _button.Paint();
            _textBox.Render();
        }
    }
}
