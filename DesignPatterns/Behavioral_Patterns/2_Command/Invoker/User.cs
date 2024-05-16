namespace DesignPatterns.Behavioral_Patterns._2_Command
{
    // Invoker
    class User
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            commands.Add(command);
            command.Execute();
        }
    }
}
