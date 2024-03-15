namespace DictionaryCollection;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> foodDictionary = new Dictionary<string, string>();

        foodDictionary.Add("Apple", "Fruit");
        foodDictionary.Add("Banana", "Fruit");
        foodDictionary.Add("Pizza", "Italian");
        foodDictionary.Add("Sushi", "Japanese");
        foodDictionary.Add("Taco", "Mexican");

        Console.WriteLine("Keys:");
        foreach (string key in foodDictionary.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues:");
        foreach (string value in foodDictionary.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("\nKeys and Values:");
        foreach (KeyValuePair<string, string> kvp in foodDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        foodDictionary.Remove("Pizza");

        Console.WriteLine($"\nCount of items in the dictionary: {foodDictionary.Count}");
    }
}

