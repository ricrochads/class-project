namespace StringArrays;

public class StringArray
{
    public void DemonstrateStringArray()
    {
        Console.WriteLine("Strings");

        Console.WriteLine("\nExample 01");
        var typedArrayStringA = new string[2] {"A", "B"};

        foreach(var item in typedArrayStringA)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nExample 02");
        var typedArrayStringB = new string[2];
        typedArrayStringB[0] = "C";
        typedArrayStringB[1] = "D";

        foreach(var item in typedArrayStringB)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n");
    }
}