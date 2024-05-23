using DesignPatterns.Creational_Patterns._1_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._1_Abstract_Factory.Implementations.Products
{
    // Concrete Product A1
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in Windows style.");
        }
    }
}
