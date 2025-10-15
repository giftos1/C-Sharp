namespace Classes
{

    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
            //this.age = 0;
        }

        public Person(int age)
        {
            this.name = string.Empty;
            this.age = age;
        }

        public Person()
        {
            if (string.IsNullOrEmpty(name))
            {
                this.name = string.Empty; // can change value for readability
            }
            //this.age = 0;
        }

        /*public string GetName()
        {
            return name;
        }*/
        public string GetName() => name;

        /*public int GetAge()
        {
            return age;
        }*/
        public int GetAge() => age;

        /*public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                this.name = string.Empty; // can change value for readability
            } 
            //this.name = !string.IsNullOrEmpty(name) ? name : string.Empty;
        }*/
        public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name: string.Empty;

        /*public void SetAge(int age)
        {
            if (age >= 0 && age <= 150)
            {
                this.age = age;
            } else
            {
                this.age = -1;
            } 
            //this.age = age >= 0 && age <= 150 ? age : -1;
        } */
        public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;

        public string ReturnDetails()
        {
            if (string.IsNullOrEmpty(name) && age == 0)
            {
                return $"No values have been passed for name and age";
            }
            else if (!string.IsNullOrEmpty(name) && age != 0)
            {
                return $"Name: {name}, Age: {age}";
            }
            else if (!string.IsNullOrEmpty(name))
            {
                return $"Name: {name}";
            }
            else
            {
                return $"Age: {age}";
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", 20);
            Person person2 = new Person(30);
            Person person3 = new Person("James");
            Person person4 = new Person();

            Console.WriteLine(person1.ReturnDetails());
            Console.WriteLine(person2.ReturnDetails());
            Console.WriteLine(person3.ReturnDetails());
            Console.WriteLine(person4.ReturnDetails());

            //set name for person1
            person1.SetName("Paul");
            person1.SetAge(77);
            Console.WriteLine(person1.ReturnDetails());
            Console.WriteLine(person1.GetName());
            Console.WriteLine(person1.GetAge());
        }
    }
}
