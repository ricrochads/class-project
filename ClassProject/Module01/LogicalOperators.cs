namespace LogicalOperators;

public class LogicalOperator
{
    public void DemonstrateLogicalOperator()
    {
        int number1 = 1;
        var number2 = 2;

        Console.WriteLine("Logical AND Operator &&");
        var result1 = number2 > number1 && 6 < 7;
        Console.WriteLine($"{number2} > {number1} && 6 < 7");
        Console.WriteLine($"Result: {result1}\n");

        Console.WriteLine("Logical OR Operator ||");
        var result2 = number2 > number1 || 8 > 10;
        Console.WriteLine($"{number2} > {number1} || 8 > 10");
        Console.WriteLine($"Result: {result2}\n");

        Console.WriteLine("Logical NOT Operator !");
        var result3 = !(number2 > 3);
        Console.WriteLine($"!({number2} > 3)");
        Console.WriteLine($"Result: {result3}\n");
    }
}


