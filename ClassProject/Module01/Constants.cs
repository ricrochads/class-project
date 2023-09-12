namespace Constants;

public class Constant
{
   public void DemonstrateConstants()
   {
        const string description = "CSharp Course";
        //description = "Course";
        Console.WriteLine("Const string: " + description);

        const int year = 2023;
        //year = 2022;
        Console.WriteLine("Const int: " + year);
   }
}