namespace Stacks;

public class Stack
{
    public void DemonstrateStacks()
    {
        Console.WriteLine("\nExample 01");
        var petNamesStack = new Stack<string>();
        petNamesStack.Push("Bella");
        petNamesStack.Push("Daisy");
        petNamesStack.Push("Rocky");
        petNamesStack.Push("Buddy");

        Console.WriteLine("Pet names:");
        foreach(var petName in petNamesStack)
        {
            Console.WriteLine(petName);
        }

        Console.WriteLine("\nExample 02");
        var countriesStack = new Stack<string>();
        countriesStack.Push("India");
        countriesStack.Push("United States");
        countriesStack.Push("China");
        countriesStack.Push("Russia");
        countriesStack.Push("Brazil");
        
        var country = countriesStack.Pop();

        Console.WriteLine($"Country: {country}\n");
    }
}