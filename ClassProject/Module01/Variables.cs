namespace Variables;

public class Variable
{
    public void DemonstrateVariables()
    {
        string name = "Ricardo Rocha";
        Console.WriteLine("String: " + name);

        int age = 18;
        Console.WriteLine("Int: " + age);

        var newAge = 26;
        Console.WriteLine("Var: " + newAge);

        decimal value = 209.99m;
        Console.WriteLine("Decimal: " + value);

        double valueDouble = 209.99;
        Console.WriteLine("Double: " + valueDouble);

        float valueFloat = 209.99f;
        Console.WriteLine("Float: " + valueFloat);

        char flag = 'Y';
        Console.WriteLine("Char: " + flag);

        bool active = true;
        active = false;
        Console.WriteLine("Bool: " + active);   
    }
}