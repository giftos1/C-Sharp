using System.Collections;

namespace IEnumerableTApp
{

    /*
     * Backward compatibility is a property of code or technology that allows it to work with older legacy systems or technologies.
     */
    public class CustomCollection : IEnumerable<string>
    {
        public List<string> Items { get; }

        public CustomCollection(List<string> items)
        {
            Items = items;
        }

        // Explicit interface implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Implicit interface implementation
        public IEnumerator<string> GetEnumerator()
        {
            return new itemsEnumerator(Items);

        }

        public override string ToString()
        {
            return string.Join(", ", Items);

        }
    }

    public class itemsEnumerator : IEnumerator<string>
    {
        private int _currentIndex = -1;

        private readonly List<string> _items;

        public itemsEnumerator(List<string> items)
        {
            _items = items;
        }

        object IEnumerator.Current => Current;
        public string Current
        {
            get
            {
                try
                {
                    return _items[_currentIndex];
                }
                catch (IndexOutOfRangeException ex)
                {

                    throw new IndexOutOfRangeException($"{nameof(CustomCollection)}'s end reached.", ex);
                }
            }
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _items.Count;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }

        public void Dispose()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var myCollection = new CustomCollection(new List<string> { "Apple", "Banana", "Cherry" });
            //Console.WriteLine(myCollection); // ToString override demonstration
            //IEnumerable fruits = new CustomCollection(new List<string> { "Apple", "Banana", "Cherry" });

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }

            object currentItem;
            IEnumerator itemsEnumerator = myCollection.GetEnumerator();
            while (itemsEnumerator.MoveNext())
            {
                currentItem = itemsEnumerator.Current;
                Console.WriteLine(currentItem);
            }

            Console.ReadLine();
        }
    }
}
