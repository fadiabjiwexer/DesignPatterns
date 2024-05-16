namespace DesignPatterns.Behavioral_Patterns._4_Iterator.Interfaces
{
    // Concrete iterator class
    public class MyIterator : IIterator
    {
        private MyCollection _collection;
        private int _currentIndex = 0;

        public MyIterator(MyCollection collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        public object Next()
        {
            if (HasNext())
            {
                return _collection.GetItem(_currentIndex++);
            }
            else
            {
                return null;
            }
        }
    }
}
