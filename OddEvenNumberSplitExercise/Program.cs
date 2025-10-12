namespace OddEvenNumberSplitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> evenNumbers = [];
            List<int> oddNumbers = [];

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                } else
                {
                    oddNumbers.Add(i);
                }
            }

            foreach (var evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}, ");
            }
            Console.WriteLine();
            foreach (var oddNumber in oddNumbers)
            {
                Console.Write($"{oddNumber}, ");
            }
        }
    }
}
