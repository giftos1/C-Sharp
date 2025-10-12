namespace HandleExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.OverflowException
            // System.FormatException:
            bool isNumber = false;

            while (!isNumber)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{num}");
                    Console.WriteLine("Goodbye!");
                    isNumber = true;
                }
                //catch (FormatException)
                //{
                //    Console.WriteLine("Enter only numbers!");
                //    //throw new FormatException();
                //}
                //catch (OverflowException)
                //{
                //    Console.WriteLine("Enter a number less than 2 billion!");
                //    //throw new OverflowException();
                //}
                //catch (Exception)
                //{
                //    Console.WriteLine("Something has went wrong!");
                //    //throw new Exception();
                //}
                catch (Exception e) // use catch all at the end
                {
                    Console.WriteLine($"Error: {e.Message}");
                    //throw new Exception();
                }
            }

            //Console.WriteLine(num);
        }
    }
}
