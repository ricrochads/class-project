namespace Switch;

public class Switch
{
    public void DemonstrateSwitch()
    {
        Console.WriteLine("\nExample 01");
        var dayOfTheWeek = 3;

        switch(dayOfTheWeek)
        {
            case 0:
                Console.WriteLine("Today is Sunday.");
                break;
            case 1:
                Console.WriteLine("Today is Monday.");
                break;
            case 2:
                Console.WriteLine("Today is Tuesday.");
                break;
            case 3:
                Console.WriteLine("Today is Wednesday.");
                break;
            case 4:
                Console.WriteLine("Today is Thursday.");
                break;
            case 5:
                Console.WriteLine("Today is Friday.");
                break;
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            default:
                Console.WriteLine("The day of the week is not valid.");
                break;
        }

        Console.WriteLine("\nExample 02");
        dayOfTheWeek = 0;

        switch(dayOfTheWeek < 1)
        {
            case true:
                Console.WriteLine("Today is Saturday.");
                break;
            case false:
                Console.WriteLine("The day of the week is not valid.");
                break;
        }
        Console.WriteLine("\n");
    }
}