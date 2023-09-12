namespace For;

public class For
{
    public void DemonstrateFor()
    {
        Console.WriteLine("\nPlanets:");
        var planetsList = new List<string>()
        {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"
        };

        for(var i=0; i < planetsList.Count; i++)
        {
            var planet = planetsList[i];
            Console.WriteLine(planet);
        }
        Console.WriteLine("\n");
    }
}