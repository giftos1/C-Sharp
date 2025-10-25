using System.Collections;

namespace IEnumerableApp
{

    /*
     * Explicit interface implementation is used to resolve cases where two implemented interfaces declare 
      different members with the same name and parameters.
     * We must precede the method name with the interface name.
     * For Explicit interface, use the interface name before the variable name when declaring a variable and 
      calling the method. e.g., IEnumerable myCollection = new CustomCollection(...); and IEnumerable.GetEnumerator();
     * Do not use the public access modifier for the method implementing the interface. (explicit interface implementation)
     * For Implicit interface implementation, use the public access modifier for the method implementing the interface.
     * When declaring a variable using implicit interface, declare this way: CustomCollection myCollection = new CustomCollection(...);
     * 
     * Can be used when interfaces have methods with the same signature.
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
            return new itemsEnumerator(Items);
        }

        // Implicit interface implementation
        public IEnumerator<string> GetEnumerator()
        {
            //return new itemsEnumerator(Items);
            throw new NotImplementedException();
        }
    }

    public class itemsEnumerator : IEnumerator
    {
        private int _currentIndex = -1;

        private readonly List<string> _items;

        public itemsEnumerator(List<string> items)
        {
            _items = items;
        }

        public object Current
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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable myCollection = new CustomCollection(new List<string> { "Apple", "Banana", "Cherry" });

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
