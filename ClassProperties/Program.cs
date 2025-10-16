namespace ClassProperties
{

    class Person
    {
        //private string name;
        //private int age;
        public string Name { get; set; }
        public int Age { get; set; }
        // Auto-implemented properties with validation in the constructor or methods


        //public string Name
        //{
        //    get { 
        //        return name; 
        //    }
        //    set {
        //        name = !string.IsNullOrEmpty(value) ? value : "Invalid Name!";
        //    }
        //}
        //public int Age
        //{
        //    get { 
        //        return age; 
        //    }
        //    set {
        //        age = value >= 0 && value <= 150 ? value : -1; 
        //    }
        //}
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string ReturnDetails() => $"Name: {Name}, Age: {Age}";

        //public string GetName() => name;
        //public int GetAge() => age;

        //public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name!";
        //public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
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

            // person 2
            Person person2 = new Person("Alice", 50);
            Console.WriteLine($"Name not changed: {person2.Name}, Age not changed: {person2.Age}");
            person2.Age = 200; // invalid age;
            Console.WriteLine($"Age changed: {person2.Age}");
        }
    }
}
