namespace Functions;

public class Function
{
    public void DemonstrateFunctions()
    {
        WriteName();

        void WriteName()
        {
            var name = FullName();
            var subtract = Subtract();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {subtract}\n");
        }

        string FullName()
        {
            string firstName = "Leonardo"; 
            string lastName = "di Ser Piero da Vinci";
            
            return firstName + " " + lastName;
        }

        int Subtract()
        {
            return 1519 - 1452; 
        }
    }
}
