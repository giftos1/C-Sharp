namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "John" },
                { 2, "Jane" },
                { 3, "Jack" }
            };

            // Keys have to be unique
            foreach (var name in names)
            {
                Console.WriteLine($"Key: {name.Key}, Value: {name.Value}");
            }

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
                //pair.Key;
                //pair.Value;
                //Console.WriteLine(names.ElementAt(i));
            }


            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                {"TR", "Turkey" },
                {"US", "United States" },
                {"DE", "Germany" }
            };
            //Console.WriteLine(countries["TR"]);

           
            countries.Remove("TR"); // Remove Turkey

            if (countries.TryGetValue("TR", out string country))
            {
                Console.WriteLine(country);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

            Console.WriteLine("Remove key value pair using ContainsKey method:");
            if (countries.ContainsKey("US"))
            {
                countries.Remove("US");
            } else
            {
                Console.WriteLine("US not found");
            }
            foreach (var countryItem in countries)
            {
                Console.WriteLine($"{countryItem.Key} - {countryItem.Value}");
            }

            Console.ReadLine();
        }
    }
}
