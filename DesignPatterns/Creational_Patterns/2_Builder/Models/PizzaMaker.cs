using DesignPatterns.Creational_Patterns._2_Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._2_Builder.Models
{
    // Director class
    public class PizzaMaker
    {
        private IPizzaBuilder _pizzaBuilder;

        public PizzaMaker(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void MakePizza()
        {
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}
