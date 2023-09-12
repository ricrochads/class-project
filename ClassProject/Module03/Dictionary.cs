namespace Dictionaries;

public class Dictionary
{
    public void DemonstrateDictionaries()
    {
        Console.WriteLine("\nExample 01");
        var seaAnimalDictionary = new Dictionary<int, string>();
        seaAnimalDictionary.Add(101, "Clownfish");
        seaAnimalDictionary.Add(102, "Dolphin");
        seaAnimalDictionary.Add(103, "Eel");

        seaAnimalDictionary[117] = "Turtle";

        var seaAnimal = seaAnimalDictionary[102];
        Console.WriteLine("Sea Animal: " + seaAnimal);

        Console.WriteLine("\nExample 02");
        var aerialAnimalDictionary = new Dictionary<int, string>()
        {
            {201, "Eagle"},
            {202, "Hawk"},
            {203, "Sparrow"}
        };

        aerialAnimalDictionary.Add(204, "Hummingbird");
        aerialAnimalDictionary[205] = "Pigeon";

        Console.WriteLine("Aerial Animal: ");
        foreach(var item in aerialAnimalDictionary)
        {
             Console.WriteLine(item.Value);
        }

        Console.WriteLine("\nExample 03");
        var terrestrialAnimalDictionary = new Dictionary<string, string>()
        {
            {"AAA", "Ant"},
            {"AAB", "Bear"},
            {"AAC", "Cheetah"},
            {"AAD", "Deer"}
        };
        
        terrestrialAnimalDictionary.Add("AAE", "Elephant");
        terrestrialAnimalDictionary["AAF"] = "Fox";

        Console.WriteLine("Terrestrial Animal: ");
        foreach(var item in terrestrialAnimalDictionary)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        };
        Console.WriteLine("\n");
    }
}