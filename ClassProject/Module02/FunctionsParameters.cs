namespace FunctionsParameters;

public class FunctionsParameter
{
    public void DemonstrateFunctionsParameters()
    {
        var name = NameAndAge("Jade", 18);
        Console.WriteLine(name);

        var result = Addition(1, 2);
        Console.WriteLine($"She has {result} siblings.\n");

        string NameAndAge(string name, int age)
        {
            return name + " is " + age + " years old.";
        }

        int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
