using System.Threading.Channels;

namespace SumIntArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            if (numbers.Length == 0)
            {
                Console.WriteLine("There are no numbers in the array");
                return;
            }
            int sum = SumArray(numbers);
            Console.WriteLine($"The sum of integers in array is {sum}");
        }

        static int SumArray(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
