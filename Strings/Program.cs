
namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordChecker();
            ReverseString();
            DemonstrateStrings();
            StringEmpty();  
            StringEquals(); 
            StringLooping();  
            StringIsNullOrEmpty();
        }


        static void PasswordChecker()
        {

            bool isMatch = false;

            while (!isMatch)
            {
                Console.WriteLine("Enter a password:");
                string password = Console.ReadLine();

                if (password == string.Empty)
                {
                    Console.WriteLine("Password cannot be empty");
                    continue;
                }

                Console.WriteLine("Enter the password again:");
                string password2 = Console.ReadLine();

                if (password2 == string.Empty)
                {
                    Console.WriteLine("Confirmation password cannot be empty!");
                    continue;
                }

                if (password.Equals(password2))
                {
                    Console.WriteLine("Passwords match!");
                    isMatch = true;
                }
                else
                {
                    Console.WriteLine("Passwords do not match");
                    continue;
                }
            }
            Console.WriteLine();
        }

        static void ReverseString()
        {
            Console.WriteLine("# ReverseString");
            Console.WriteLine("Enter your message:");

            string message = Console.ReadLine();
            int lastIndex = message.Length - 1;

            for (int i = lastIndex; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            //Console.WriteLine(message[lastIndex]);
            Console.WriteLine();
        }

        static void DemonstrateStrings() {
            // use double backslash to escape a backslash
            // \t is a tab
            // \n is a new line
            Console.WriteLine("# DemonstrateStrings");
            string path = "C:\\Users\\gifts\\C# Projects";

            string speech = "He said \"Hello There. Whats your name?\"";
            // string interpolation with $
            Console.WriteLine($"my path is {path}");
            Console.WriteLine($"My speech: {speech}");

            // use @ to ignore escape sequences
            path = @"C:\\Users\\gifts\\C# Projects";
            Console.WriteLine($"my @path is {path}");

            // use + and \n to concatenate strings and add a new line when using @
            path = @"C:\\Users\\gifts\\C# Projects" + "\nThe above path";
            Console.WriteLine(path);

            // use double quotes to escape double quotes when using @
            string name = @"Hello ""The OG""";
            Console.WriteLine(name);

            name = "Hello 'The OG'";
            Console.WriteLine(name);

            // string concatenation using string.Concat
            string colour = "red";
            string hair = "black";
            string test = string.Concat("Your colour is ", colour, " and your hair is ", hair);
            Console.WriteLine(test);
            Console.WriteLine();
        }

        static void StringEmpty()
        {
            Console.WriteLine("# StringEmpty");
            Console.WriteLine("Enter a name of a book:");
            string book = Console.ReadLine();

            if (book != string.Empty) // can also use book != ""
            {
                Console.WriteLine($"Your book is {book}");
            } else
            {
                Console.WriteLine("Name is empty!");
            }
            Console.WriteLine();
        }

        static void StringEquals()
        {
            Console.WriteLine("# StringEquals");
            string message = "Hello";
            string message2 = "Hello";

            if (message.Equals(message2)) // can also use message == message2
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are different");
            }

            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();

            if (!name.Equals(string.Empty))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

            // == compares values by checking references in memory
            // Equals compares values by checking the actual content

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine(chars);

            object newCompare = new string(chars);

            if (message.Equals(newCompare)) {
                Console.WriteLine("They are the same");
            } else {
                Console.WriteLine("They are different");
            }
            Console.WriteLine();
        }

        static void StringLooping() {
            Console.WriteLine("# String Looping");
            string message = "My looping message";

            //Console.WriteLine(message[0]); // M

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                
                //Console.WriteLine(message[i]);
                Thread.Sleep(100); // sleep for 100 milliseconds
            }
            Console.WriteLine();
            

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('e'))
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);
            Console.WriteLine();
        }

        static void StringIsNullOrEmpty() {
            Console.WriteLine("# StringIsNullOrEmpty");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine("Name is not empty(using \"\")");
            }

            if (!name.Equals(""))
            {
                Console.WriteLine("Name is not empty(using Equals)");
            }

            // use for variables that can be null
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Name is IsNullOrEmpty");
            }
            Console.WriteLine();
        }
    }
}
