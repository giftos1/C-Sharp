namespace IEnumerable;
using System.Collections;

public class CustomCollection : IEnumerable
{
    public List<string> Items { get; }

    public CustomCollection(List<string> items)
    {
        Items = items;
    }

    public IEnumerator GetEnumerator()
    {
        return new itemsEnumerator(Items);
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

class Program
{
    static void Main(string[] args)
    {
        var myCollection = new CustomCollection(new List<string> { "Apple", "Banana", "Cherry" });

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
