namespace Foreach;

public class Foreach
{
    public void DemonstrateForeach()
    {
        
        var dwarfPlanetsList = new List<string>()
        {
            "Ceres",
            "Pluto",
            "Haumea",
            "Makemake",
            "Eris",
        };
        
        Console.WriteLine("\nExample 01");
        Console.WriteLine("Dwarf Planets:");
        foreach(string dwarfPlanet in dwarfPlanetsList)
        {
            Console.WriteLine(dwarfPlanet);
        }

        Console.WriteLine("\nExample 02");
        Console.WriteLine("Dwarf Planet:");
        foreach(var letter in "Ceres")
        {
            Console.WriteLine(letter);
        }
        Console.WriteLine("\n");
    }
}