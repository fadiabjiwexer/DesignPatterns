using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._2_Command
{
    // Receiver
    class ShoppingCart
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine(item + " added to the shopping cart.");
        }

        public void RemoveItem(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine(item + " removed from the shopping cart.");
            }
            else
            {
                Console.WriteLine(item + " is not in the shopping cart.");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Items in the shopping cart:");
            foreach (var item in items)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}
