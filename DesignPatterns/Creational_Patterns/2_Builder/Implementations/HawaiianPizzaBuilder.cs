using DesignPatterns.Creational_Patterns._2_Builder.Interfaces;
using DesignPatterns.Creational_Patterns._2_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._2_Builder.Implementations
{
    // Concrete builder
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough()
        {
            _pizza.Dough = "Thin crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Tomato sauce";
        }

        public void BuildTopping()
        {
            _pizza.Topping = "Ham and pineapple";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }

}
