namespace Structures
{
    internal class Program
    {
        // Struct is used to create lightweight objects that represent small pieces of data.
        struct Person(string name, int age, int birthMonth)
        {
            public string name = name;
            public int age = age;
            public int birthMonth = birthMonth;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //string name = "Gift";
            //int age = 40;
            //Person person;
            //person.name = "Gift";
            //person.age = 40;
            //person.birthMonth = 6;
            //Console.WriteLine($"Name: {person.name}, Age: {person.age}, BirthMonth: {person.birthMonth}");

            /*string newName = ReturnPerson(out int newAge);
            Console.WriteLine($"NewName: {newName}, NewAge: {newAge}");*/

            // another way of using ReturnPerson method

            /* string newName = "";
            int newAge = 0;
            ReturnPerson(ref newName, ref newAge);
            Console.WriteLine($"NewName: {newName}, NewAge: {newAge}"); */

            Person person = ReturnPerson();
            Console.WriteLine($"Name: {person.name}, Age: {person.age}, birthmonth: {person.birthMonth}");
        }

        /* static void ReturnPerson(ref string name, ref int age) {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

        }*/

        /* static string ReturnPerson(out int age)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            return name;
        }*/

        static Person ReturnPerson()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birthmonth: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            return new Person(name, age, birthMonth);
            //return person;
        }
    }
}
