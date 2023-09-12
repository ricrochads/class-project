namespace WhileDoWhile;

public class WhileDoWhile
{
    public void DemonstrateWhileDoWhile()
    {
        Console.WriteLine("\nExample 01");
        var number = 0;
        while(number < 5)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine("\nExample 02");
        number = 0;
        do
        {
            Console.WriteLine(number);
            number++;
        } while(number < 5);
        Console.WriteLine("\n");
    }
}