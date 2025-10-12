namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Gift";
            int ageInput = 35;
            string addressInput = "123 Main St";

            PrintDetails(
                age: ageInput,
                name: nameInput,
                address: addressInput); // named arguments

            bool success = Test(out int result); // out parameter
            Console.WriteLine($"Success: {success}, Result: {result}"); // success: True, Result: 42
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
    }
}
