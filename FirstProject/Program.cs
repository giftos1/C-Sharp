using System.Globalization;

namespace CoreFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // numbers
            int q = 10, 
                w = 20, 
                e = 30;

            int age = 23;
            Console.WriteLine(age);

            long distance = 12345678901234L;
            Console.WriteLine(distance);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // text

            string textAge = "-21";
            int newAge = Convert.ToInt32(textAge);
            Console.WriteLine($"This is my converted string int: {newAge}");
            Type ageType = newAge.GetType();
            Console.WriteLine($"This is my newAge type: {ageType}");


            bool value = true;
            bool isMale = true;

            Console.WriteLine($"{value} {isMale}");

            const int year = 2025;
            Console.WriteLine($"This is my const year: {year}");

            // Operations
            float a = 10; // just for the sake of division
            int b = 3;
            Console.WriteLine(a + b); //13
            Console.WriteLine(a - b); // 7
            Console.WriteLine(a / b);
            Console.WriteLine(a % b); // 1 = remainder

            string firstName = "John";
            firstName += " is hungry!";
            Console.WriteLine(firstName);

            //Console.ReadLine();
            
            NumericFormatting();
            UseConditional();
            ItineraryOperator();
            TimesTable();
            //LoopEach();  
        }

        // case statements

        static void UseConditional()
        {
            Console.WriteLine("Type in a number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber) {
                case 1:
                    Console.WriteLine($"{dayNumber} represents Monday.");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"{dayNumber} represents Tuesday");
                    break;
                case 4:
                    Console.WriteLine($"{dayNumber} represents Thursday");
                    break;
                case 5:
                    Console.WriteLine($"{dayNumber} represents Friday");
                    break;
                case 6:
                    Console.WriteLine($"{dayNumber} represents Saturday");
                    break;
                case 7:
                    Console.WriteLine($"{dayNumber} represents Sunday");
                    break;
                default:
                    Console.WriteLine("Please Type in a valid number");
                    break;

            }
        }

        static void ItineraryOperator() {
            int num = -10;

            string result = num >= 0 ? "Valid age" : "Invalid age";
            Console.WriteLine(result);
        
        }

        // numeric formatting
        static void NumericFormatting() {
            double value = -1000D / 12.34D;
            Console.WriteLine(value);

            Console.WriteLine(string.Format("{0:0.0}, {1}, {2}", value, 1000, "String Formatting"));
            Console.WriteLine(string.Format("{0:0.00}, {1}, {2}", value, 1000, "String Formatting"));
            Console.WriteLine(string.Format("{0:0.000}, {1}, {2}", value, 1000, "String Formatting"));
            Console.WriteLine(string.Format("{0:0.#}, {1}, {2}", value, 1000, "Trim trailing zeros")); // # trims trailing zeros
            Console.WriteLine(value.ToString("C")); // C = currency
            Console.WriteLine(value.ToString("C0")); // C = currency
            Console.WriteLine(value.ToString("C1")); // C = currency
            Console.WriteLine(value.ToString("C2")); // C = currency
            Console.WriteLine(value.ToString("C3")); // C = currency
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture)); // culture depends on system settings
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))); // UK
        }

        /*print the number of lines input by user. 
         * Check for invalid input*/
        static void TimesTable() {
          
            bool success = false;
            while (!success)
            {
                Console.Write("Enter a number:");
                string tableNumber = Console.ReadLine();
                bool trueTableNumber = int.TryParse(tableNumber, out _);

                if (!trueTableNumber)
                {
                    Console.WriteLine("Invalid Input!");
                    continue;
                }

                success = true;
                for (int i = 1; i <= Convert.ToInt32(tableNumber); i++)
                {
                    Console.WriteLine($"{i} times table");
                }
            }
        }
    }
}
