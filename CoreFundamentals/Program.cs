// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

GetName();
VariousStringMethods();
FizzBuzz();
static void GetName()
{
    Console.WriteLine("What is your First Name?");

    string firstName = Console.ReadLine();

    Console.WriteLine("What is your Last Name?");

    string lastName = Console.ReadLine();

    Console.WriteLine($"Thank you {firstName} {lastName}!");

}

static void VariousStringMethods()
{
    string sample = "Hello, World!";
    // Length
    int length = sample.Length;
    Console.WriteLine($"Length: {length}");
    // ToUpper
    string upper = sample.ToUpper();
    Console.WriteLine($"ToUpper: {upper}");
    // ToLower
    string lower = sample.ToLower();
    Console.WriteLine($"ToLower: {lower}");
    // Contains
    bool containsWorld = sample.Contains("World");
    Console.WriteLine($"Contains 'World': {containsWorld}");
    // Replace
    string replaced = sample.Replace("World", "C#");
    Console.WriteLine($"Replace 'World' with 'C#': {replaced}");
    // Substring
    string substring = sample.Substring(7, 5);
    Console.WriteLine($"Substring (7,5): {substring}");
    // Split
    string[] parts = sample.Split(',');
    Console.WriteLine($"Split by ',': {string.Join(" | ", parts)}");
    // Trim
    string trimmed = "   Hello, Trim!   ".Trim();
    Console.WriteLine($"Trimmed: '{trimmed}'");
    // IndexOf
    int index = sample.IndexOf("World");
    Console.WriteLine($"IndexOf 'World': {index}");
}

static void FizzBuzz() {
    int n = int.Parse(Console.ReadLine());

    if (n % 3 == 0 && n % 5 == 0) {
        Console.WriteLine("FizzBuzz");
    } else if (n % 3 == 0)
    {
        Console.WriteLine("Fizz");
    } else if (n % 5 == 0) {
        Console.WriteLine("Buzz");
    } else {
        Console.WriteLine(n);
    }
}

// generate a random number between 10 and 20
int random = new Random().Next(10, 20);
Console.WriteLine(random);


// test for loop
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine($"This is my for count {i}");   
}

// test while loop
int count = 0;

while (count <= 5)
{
    Console.WriteLine($"This is my while {count}");
    count++;
}

// test do while loop
int doCount = 0;
do
{
    Console.WriteLine($"This is my do while count - {doCount}");
    doCount++;
} while (doCount <= 5);

// test if else
while (true)
{
    int randomNumber = new Random().Next(0, 10);

    Console.WriteLine("Please enter a random number:");
    string numberInput = Console.ReadLine();

    if (!int.TryParse(numberInput, out _))
    {
        Console.WriteLine("This is not a number! Try again");
        continue;
    }
    else if (int.Parse(numberInput) > 10 | int.Parse(numberInput) < 0)
    {
        Console.WriteLine("Number must be between 0 and 10 (inclusive)");
        continue;
    }
    else if (int.Parse(numberInput) != randomNumber)
    {
        Console.WriteLine($"{numberInput} is not the random number.");
        continue;
    }
    else
    {
        Console.WriteLine($"The random number is {randomNumber}");
        Console.WriteLine($"{numberInput} is the correct number!");
        return;
    }
}


