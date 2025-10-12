namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Gift";
            int ageInput = 35;
            string addressInput = "123 Main St";
            int number = 17;

            PrintDetails(
                age: ageInput,
                name: nameInput,
                address: addressInput); // named arguments

            bool success = Test(out int result); // out parameter
            Console.WriteLine($"Success: {success}, Result: {result}"); // success: True, Result: 42

            Assign(ref number);
            Console.WriteLine(number); // Output: 20

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            Console.WriteLine($"Old Name: {nameInput}");
            if (ChangeName(ref nameInput, newName))
            {
                nameInput = newName;
                Console.WriteLine($"Your new name is {newName}");
            } else
            {
                Console.WriteLine("Name change failed.");
            }
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address} ");
        }

        static bool Test(out int number)
        {
            /* out can have two return values from one function*/
            number = 42; // Assign a value to the out parameter
            return true; // Return a boolean value
        }

        static void Assign(ref int num) // ref parameter does not require initialization before passing
        {
            num = 20;
        }

        static bool ChangeName(ref string name, string newName)
        {
            if(!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }
    }
}

// One big difference between the ref and the out parameters is, with the out parameters you can initialize
// the out variable in the parameter but with the ref parameters, a variable needs to be initialized outside
// the parameter i.e ChangeName(ref name, newName) – name has to be initialized before and cannot be done inside the brackets

// Optional parameters – Use Optional keyword or assign parameter to a value or use default keyword
