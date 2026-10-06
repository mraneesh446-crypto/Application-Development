namespace TASK_4;

class Program
{
    static void Main(string[] args)
    {
        int[] favoriteNumbers = { 7, 3, 42, 11, 5 };

        Array.Sort(favoriteNumbers);
        Console.WriteLine("Sorted in ascending order:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        Array.Reverse(favoriteNumbers);
        Console.WriteLine("Reversed order:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        int numberToFind = 11;
        int index = Array.IndexOf(favoriteNumbers, numberToFind);
        Console.WriteLine($"Index of {numberToFind}: {3}");
    }
}
