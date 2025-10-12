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
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address} ");
        }
    }
}
