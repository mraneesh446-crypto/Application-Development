namespace TASK_6;

class Program
{
    static void Main(string[] args)
    {
        List<string> favoriteFruits = new List<string> { "Kiwi", "Avocado", "Pomegranate" };
        favoriteFruits.Add("Pineapple");
        favoriteFruits.Remove("Apple");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in favoriteFruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitsById = new Dictionary<int, string>
        {
            { 1, "Kiwi" },
            { 2, "Avocado" },
            { 3, "Pomegranate" },
        };
        fruitsById.Add(4, "Pineapple");

        Console.WriteLine("Fruit dictionary:");
        foreach (KeyValuePair<int, string> entry in fruitsById)
        {
            Console.WriteLine($"ID {entry.Key}: {entry.Value}");
        }
    }
}
