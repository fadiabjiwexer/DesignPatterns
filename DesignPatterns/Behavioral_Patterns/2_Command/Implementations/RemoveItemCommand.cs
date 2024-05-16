namespace DesignPatterns.Behavioral_Patterns._2_Command
{
    // Concrete Command for removing an item
    class RemoveItemCommand : ICommand
    {
        private readonly ShoppingCart shoppingCart;
        private readonly string item;

        public RemoveItemCommand(ShoppingCart cart, string item)
        {
            shoppingCart = cart;
            this.item = item;
        }

        public void Execute()
        {
            shoppingCart.RemoveItem(item);
        }
    }
}
