namespace DesignPatterns.Behavioral_Patterns._1_Chain_of_Responsibility
{
    // Concrete Handler 2
    class RefundHandler : IHandler
    {
        public void HandleRequest(Request request)
        {
            if (request.Type == "Refund")
            {
                Console.WriteLine("Handling request for refund.");
                // Logic to handle refund request
            }
            else
            {
                Console.WriteLine("Passing request to the next handler.");
            }
        }
    }
}
