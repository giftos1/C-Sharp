using System.Transactions;

namespace AreaOfTriangleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the base length of your triangle: ");
            //int baseLength = Convert.ToInt32(Console.ReadLine());
            int baseLength = ReadInt("Enter the base length of your triangle: ");
            Console.WriteLine();
            int height = ReadInt("Enter the height of your triangle: ");

            //Console.Write("Enter the height of your triangle: ");
            //int height = Convert.ToInt32(Console.ReadLine());

            //int area = CalculateAreaOfTriangle(height: height, baseLength: baseLength); // reference parameter
            int area = CalculateAreaOfTriangle(baseLength, height); // reference parameter

            Console.WriteLine($"The area of your triangle is: {area}");

        }

        static int CalculateAreaOfTriangle(int baseLength, int height)
        {
            int area = (baseLength * height) / 2;
            return area;
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
