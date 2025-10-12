

namespace ArrayMultiplesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num = 5;
            int length = 10;
            int[] result = new int[length]; // Initialize an array of the specified length

            for (int i = 0; i < length; i++)
            {
                result[i] = num * (i + 1);
            }

            foreach (int val in result)
            {
                Console.Write($"{val} ");
            }
        }
    }
}
