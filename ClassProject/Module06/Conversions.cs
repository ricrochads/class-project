namespace Conversions;
public class Conversion
{
    public void ConvertAndParse()
    {
        Console.WriteLine("\nConvert");
        int example1Convert = Convert.ToInt32("2023");
        Console.WriteLine("Example 01: " + example1Convert);

        Console.WriteLine("\nParse");
        int example1Parse = int.Parse("2023");
        Console.WriteLine("Example 01: " + example1Parse);

        bool example2Parse = bool.Parse("true");
        Console.WriteLine("Example 02: " + example2Parse);
    }

    public void TryParse()
    {
        Console.WriteLine("\nTryParse");
        Console.WriteLine("Example 01");
        var number = "1234567890";

        if(int.TryParse(number, out int numberConverted))
        {
            Console.WriteLine("The number has been successfully converted!");
        }
        Console.WriteLine($"Result: {numberConverted}");

        Console.WriteLine("Example 02");
        var letters = "abcdef";

        if(int.TryParse(letters, out int lettersConverted))
        {
            Console.WriteLine("The number has been successfully converted!");
        }
        Console.WriteLine($"Result: {lettersConverted}\n");
    }
}