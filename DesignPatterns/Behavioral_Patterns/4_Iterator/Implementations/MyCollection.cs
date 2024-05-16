using System.Collections;

namespace DesignPatterns.Behavioral_Patterns._4_Iterator.Interfaces
{
    // Concrete aggregate class
    public class MyCollection : IAggregate
    {
        private ArrayList _items = new ArrayList();

        public void AddItem(string item)
        {
            _items.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new MyIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public string GetItem(int index)
        {
            return (string)_items[index];
        }
    }
}
