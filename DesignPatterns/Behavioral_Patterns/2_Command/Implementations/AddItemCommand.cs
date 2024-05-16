namespace DesignPatterns.Behavioral_Patterns._2_Command
{
    // Concrete Command for adding an item
    class AddItemCommand : ICommand
    {
        private readonly ShoppingCart shoppingCart;
        private readonly string item;

        public AddItemCommand(ShoppingCart cart, string item)
        {
            shoppingCart = cart;
            this.item = item;
        }

        public void Execute()
        {
            shoppingCart.AddItem(item);
        }
    }
}
