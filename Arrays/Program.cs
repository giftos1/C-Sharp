namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            //Console.WriteLine("Enter the first number:");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Angles();
            BetterArrays();
            ReverseNumbers();
            ClearArray();
            IndexOfArray();
        }

        static void Angles()
        {
            const int angleCount = 3;
            _ = new int[angleCount];

            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}: ");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");


            //int angleSum = 0;
            //foreach (int angle in angles)
            //{
            //    angleSum += angle;
            //}

            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
            //Console.WriteLine(angleSum);
        }

        static void BetterArrays()
        {
            int[] numbers = [15, 5, 3, 8, 2];
            Array.Sort(numbers); // Sorts the array in ascending order
            Array.Reverse(numbers); // Reverses the array to get descending order

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            
            //string test = "";
            //test.Replace(" ", "")

        }

        static void ReverseNumbers()
        {
            int[] numbers = [15, 5, 3, 8, 2];
            int[] sortedNumbers = new int[numbers.Length];
            int x = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            foreach (var number in sortedNumbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void ClearArray()
        {
            int[] numbers = [15, 5, 3, 8, 2];

            //Array.Clear(numbers, 0, numbers.Length); // assigns 0 to all elements in the array
            Array.Clear(numbers, 2, 2); // assigns 0 to 2 elements starting from index 2

            for (int i = numbers.Length - 1; i < numbers.Length; i++)
            {
                numbers[i] = default; // assigns default value (0) to elements starting from index 4
            }

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");

            }
            Console.WriteLine();
        }

        static void IndexOfArray()
        {
            int[] numbers = [10, 20, 30, 40, 50];

            Console.WriteLine("Enter a number to search:");
            int searchNumber = Convert.ToInt32(Console.ReadLine());
            //int position = Array.IndexOf(numbers, searchNumber); // searches for the number in the entire array
            //int position = Array.IndexOf(numbers, searchNumber, 1, 2); // searches for the number starting from index 1 and checks the next 2 elements
            //int position = Array.IndexOf(numbers, searchNumber, 2); // searches for the number starting from index 2 to the end of the array

            //if (position >= 0)
            //{
            //    Console.WriteLine($"Number {searchNumber} has been found at position: {position + 1}");
            //} else
            //{
            //    Console.WriteLine($"Number {searchNumber} has not been found.");
            //}
            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                Console.WriteLine($"Number {searchNumber} has been found at position: {position}");
            } else
            {
                Console.WriteLine($"{searchNumber} is not in the Array!");

            }

            Console.WriteLine();
        }
    }
}
