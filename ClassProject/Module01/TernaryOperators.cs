namespace TernaryOperators;

public class TernaryOperator
{
    public void DemonstrateTernaryOperators()
    {
        bool active = false;
        string status = active ? "Active Register" : "Inactive Register";
        Console.WriteLine("Active: false");
        Console.WriteLine("Status = Active ? Active Register : Inactive Register");
        Console.WriteLine($"Status: {status}\n");
    }
}

