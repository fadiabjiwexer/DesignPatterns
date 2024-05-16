namespace DesignPatterns.Behavioral_Patterns._1_Chain_of_Responsibility
{
    // Concrete Handler 3
    class SupportHandler : IHandler
    {
        public void HandleRequest(Request request)
        {
            if (request.Type == "Support")
            {
                Console.WriteLine("Handling request for customer support.");
                // Logic to handle support request
            }
            else
            {
                Console.WriteLine("Passing request to the next handler.");
            }
        }
    }
}
