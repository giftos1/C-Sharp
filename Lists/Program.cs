namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listNumbers = new List<int>()
            {
                1,2,3,4,5
            };
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }
            int lastElement = listNumbers.Count;
            listNumbers.Remove(lastElement); // removes the last element
            foreach (var number in listNumbers)
            {
                Console.Write(number);
            }
        }
    }
}
