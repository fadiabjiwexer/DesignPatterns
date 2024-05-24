using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._2_Builder.Models
{
    // Product class
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public void Display()
        {
            Console.WriteLine($"Dough: {Dough}");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine($"Topping: {Topping}");
        }
    }
}
