namespace ArithmeticOperators;

public class ArithmeticOperator
{
    public void DemonstrateArithmeticOperators()
    {
        int number1 = 1;
        var number2 = 2;

        Console.WriteLine("Addition");
        int addition = number1 + number2;
        Console.WriteLine($"{number1} + {number2}");
        Console.WriteLine($"Result: {addition}\n");

        Console.WriteLine("Subtraction");
        int subtraction = number1 - number2;
        Console.WriteLine($"{number1} - {number2}");
        Console.WriteLine($"Result: {subtraction}\n");

        Console.WriteLine("Multiplication");
        int multiplication = number1 * number2 * 10;
        Console.WriteLine($"{number1} * {number2} * 10");
        Console.WriteLine($"Result: {multiplication}\n");

        Console.WriteLine("Division");
        int division = number2 / number1;
        Console.WriteLine($"{number2} / {number1}");
        Console.WriteLine($"Result: {division}\n");
    }
}