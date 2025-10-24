using System.Collections;

namespace IEnumeratorAndIEnumerable;


/*
IEnumerator and IEnumerable are interfaces in C# that facilitate iteration over collections.
IEnumerable is a read-only interface that defines a method GetEnumerator(), which returns an IEnumerator.
IEnumerator provides the ability to iterate through a collection using the MoveNext() method to advance to the next element, the Current property to access the current element, and the Reset() method to reset the enumerator to its initial position.
*/

public class CustomCollection //: IEnumerable
{
    public List<string> Names { get; }

    public CustomCollection(List<string> names)
    {
        Names = names;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var names = new List<string> { "Alice", "Bob", "Charlie" };
        object currentName;
        IEnumerator namesEnumerator = names.GetEnumerator();
        while (namesEnumerator.MoveNext())
        {
            currentName = namesEnumerator.Current;
            Console.WriteLine(currentName);
        }

        Console.ReadLine();
    }
}