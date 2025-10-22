namespace CustomTryParse
{
    internal class Program
    {
        /* Create a custom Try Parse. Catch all exceptions. Try and convert different strings and catch errors. */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string num = "123";
            string threeBillion = "3000000000";
            string name = "Dove";
            string blank = null;

            CustomTryParse(num);
            CustomTryParse(blank);
            CustomTryParse(threeBillion);
            CustomTryParse(name);
            Console.ReadLine();
        }

        static void CustomTryParse(string s)
        {
            try
            {
                int.Parse(s);
                Console.WriteLine("Success");
            }
            catch (FormatException)
            {
                Console.WriteLine($"The string {s} is in the wrong format");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The string {s} is outside the range of int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("String cannot be null");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}
