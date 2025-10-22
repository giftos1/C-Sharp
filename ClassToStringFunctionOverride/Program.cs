namespace ClassToStringFunctionOverride
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string ReturnDetails() => $"Name: {Name}, Age: {Age}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", 20);
            Console.WriteLine($"Name not changed: {person1.Name}, Age not changed: {person1.Age}");
            person1.Name = "Jane";
            person1.Age = 77;
            Console.WriteLine($"Name changed: {person1.Name}, Age changed: {person1.Age}");
            Console.WriteLine(person1.ReturnDetails());

            // person 2
            Person person2 = new Person("Alice", 50);
            Console.WriteLine($"Name not changed: {person2.Name}, Age not changed: {person2.Age}");
            person2.Age = 200; // invalid age;
            Console.WriteLine($"Age changed: {person2.Age}");
            person2.ReturnDetails();
        }
    }
}
