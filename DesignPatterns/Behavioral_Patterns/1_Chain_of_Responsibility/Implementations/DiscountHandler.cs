namespace DesignPatterns.Behavioral_Patterns._1_Chain_of_Responsibility
{
    // Concrete Handler 1
    class DiscountHandler : IHandler
    {
        public void HandleRequest(Request request)
        {
            if (request.Type == "Discount")
            {
                Console.WriteLine("Handling request for discount.");
                // Logic to handle discount request
            }
            else
            {
                Console.WriteLine("Passing request to the next handler.");
            }
        }
    }
}
