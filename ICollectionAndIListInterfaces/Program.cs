// See https://aka.ms/new-console-template for more information

var numbers = new List<int> { 1, 2, 3, 4, 5 };
var array = new int[10];
numbers.CopyTo(array, 0);

//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}

var implementedInterfaces = array.GetType().GetInterfaces();

Array.ForEach(array, Console.WriteLine);

/*
 Interface Segregation Principle (ISP) states that no client should be forced to depend on methods it does not use.
 In other words, no class should be forced to implement methods from an interface when those methods do not fit in this class

Below shows the array class implementing ICollection<T> interface forcing it to implement Add method which is not applicable for array.

ICollection<int> arrayAsCollection = array;
arrayAsCollection.Add(4); // throws NotSupportedException
 */


//foreach (var item in arrayAsCollection)
//{
//    Console.WriteLine(item);
//}

Console.ReadKey();