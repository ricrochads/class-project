namespace ExceptionHandling;

public class ExceptionHandling
{
    public void GenerateException()
    {
        while(true)
        {
            Console.WriteLine("\nGenerate Exception");
            Console.Write("Enter a number: ");
            var number = Console.ReadLine();
            var result = 500 / int.Parse(number);
            Console.WriteLine($"500 / {number} = {result}");
        }
    }

    public void HandleException()
    {
        Console.WriteLine("\nHandle Exception");
        while(true)
        {
            try
            {
                Console.Write("Enter a number: ");
                var number = Console.ReadLine();
                var result = 500 / int.Parse(number);
                Console.WriteLine($"500 / {number} = {result}");            
            }
            catch(DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("A division error has occurred. " + divideByZeroException.Message);
                Console.WriteLine("Stack: " + divideByZeroException.StackTrace);
            }
            catch(Exception exception)
            {
                Console.WriteLine("An error has occurred: " + exception.Message);
                Console.WriteLine("Stack: " + exception.StackTrace);
            }
        }
    }
}