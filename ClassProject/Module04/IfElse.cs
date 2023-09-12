namespace IfElseIfElse;

public class IfElse
{
    public void DemonstrateIfElse()
    {
        var dayOfTheWeek = 0;
        var workday = false;

        Console.WriteLine("\nExample 01");
        if(dayOfTheWeek == 0 && workday)
        {
            Console.WriteLine("Today is Sunday.");
        }
        else if(dayOfTheWeek == 0 && workday == false)
        {
            Console.WriteLine("Today is Sunday, but it's not a workday.");
        }
        else
        {
            Console.WriteLine("Today is not Sunday.");
        }

        Console.WriteLine("\nExample 02");
        dayOfTheWeek = 10;
        if(dayOfTheWeek == 0)
        {
            Console.WriteLine("Today is Sunday.");
        }
        else if(dayOfTheWeek == 1)
        {
            Console.WriteLine("Today is Monday.");
        }
        else if(dayOfTheWeek == 2)
        {
            Console.WriteLine("Today is Tuesday.");
        }
        else if(dayOfTheWeek == 3)
        {
            Console.WriteLine("Today is Wednesday.");
        }
        else if(dayOfTheWeek == 4)
        {
            Console.WriteLine("Today is Thursday.");
        }
        else if(dayOfTheWeek == 5)
        {
            Console.WriteLine("Today is Friday.");
        }
        else if(dayOfTheWeek == 6)
        {
            Console.WriteLine("Today is Saturday.");
        }
        else
        {
            Console.WriteLine("The day of the week is not valid.");
        }
        Console.WriteLine("\n");
    }
}