namespace DesignPatterns.Behavioral_Patterns._6_Momento
{
    public class Memento
    {
        private readonly string savedContent;

        public Memento(string content)
        {
            savedContent = content;
        }

        public string GetSavedContent()
        {
            return savedContent;
        }
    }
}
