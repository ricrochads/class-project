namespace RelationalOperators;

public class RelationalOperator
{
    public void DemonstrateRelationalOperators()
    {
        int number1 = 1;
        var number2 = 2;

        Console.WriteLine("Equality (Equal to)");
        bool equal = number2 == number1;
        Console.WriteLine($"{number2} == {number1}");
        Console.WriteLine($"Result: {equal}\n");

        Console.WriteLine("Greater than");
        bool greater = number2 > number1;
        Console.WriteLine($"{number2} > {number1}");
        Console.WriteLine($"Result: {greater}\n");

        Console.WriteLine("Less than");
        bool less = number2 < number1;
        Console.WriteLine($"{number2} < {number1}");
        Console.WriteLine($"Result: {less}\n");

        Console.WriteLine("Greater than or Equal to");
        bool greaterOrEqual = number2 >= number1;
        Console.WriteLine($"{number2} >= {number1}");
        Console.WriteLine($"Result: {greaterOrEqual}\n");

        Console.WriteLine("Less than or Equal to");
        bool lessOrEqual = number2 <= number1;
        Console.WriteLine($"{number2} <= {number1}");
        Console.WriteLine($"Result: {lessOrEqual}\n");

        Console.WriteLine("Inequality (Not Equal to)");
        bool notEqual = number2 != number1;
        Console.WriteLine($"{number2} != {number1}");
        Console.WriteLine($"Result: {notEqual}\n");
    }
}