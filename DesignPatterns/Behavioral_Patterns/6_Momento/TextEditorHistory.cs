namespace DesignPatterns.Behavioral_Patterns._6_Momento
{
    public class TextEditorHistory
    {
        private readonly List<Memento> history = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            history.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return history[index];
        }

        public List<Memento> GetHistory()
        {
            return history;
        }
    }
}
