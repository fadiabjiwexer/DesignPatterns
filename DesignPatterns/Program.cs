using DesignPatterns.Behavioral_Patterns._1_Chain_of_Responsibility;
using DesignPatterns.Behavioral_Patterns._2_Command;
using DesignPatterns.Behavioral_Patterns._3_Interpreter.Implementations;
using DesignPatterns.Behavioral_Patterns._3_Interpreter.Interfaces;
using DesignPatterns.Behavioral_Patterns.State.Wrong;
using System.Linq.Expressions;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Behaviour Patterns
            // 1- Chanin of responsibility Pattern 
            // Client ...............................
            // Create handlers
            //IHandler discountHandler = new DiscountHandler();
            //IHandler refundHandler = new RefundHandler();
            //IHandler supportHandler = new SupportHandler();

            //// Set the chain of responsibility
            //discountHandler.HandleRequest(new Request("Discount"));
            //refundHandler.HandleRequest(new Request("Refund"));
            //supportHandler.HandleRequest(new Request("Support"));

            //Console.ReadKey();


            // 8- State Pattern right using
                // Client ...............................
                //Canvas canvas = new Canvas();
                //canvas.SetCurrentTool(new SelectionTool());
                //canvas.mouseDown();
                //canvas.mouseUp();

                //State Pattern wrong using
                //StopWatch stopwatch = new StopWatch();
                //stopwatch.Click();
                //stopwatch.Click();

            // 2- Command Desing pattern
            // Client ...............................
                //ShoppingCart cart = new ShoppingCart();
                //User user = new User();
                //// Adding items to the cart
                //ICommand addItemCommand1 = new AddItemCommand(cart, "Product A");
                //ICommand addItemCommand2 = new AddItemCommand(cart, "Product B");
                //user.ExecuteCommand(addItemCommand1);
                //user.ExecuteCommand(addItemCommand2);
                //// Removing an item from the cart
                //ICommand removeItemCommand = new RemoveItemCommand(cart, "Product A");
                //user.ExecuteCommand(removeItemCommand);
                //// Displaying the cart
                //cart.DisplayCart();
                //Console.ReadKey();

            //3_ Interpret Design pattern
            // Client ..................
                //IExpression expression = new AdditionExpression(
                //new NumberExpression(5),
                //new AdditionExpression(
                //    new NumberExpression(3),
                //    new NumberExpression(7)
                //        )
                //    );
                //int result = expression.Interpret();
                //Console.WriteLine("Result: " + result);
                //Console.ReadKey();
        }
    }
}
