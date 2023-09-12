namespace BreakContinue;

public class BreakContinue
{
  public void DemonstrateBreakContinue()
  {
    var i = 0;
    while(i < 5)
    {
      if(i < 2)
      {
        Console.WriteLine("Continuing...");
        i++;
        continue;
      }

      Console.WriteLine("Var i = " + i);
      i++;

      if(i == 2)
      {
        Console.WriteLine("The value of i is equal to 2.");
        break;
      }
    }
    Console.WriteLine("\n"); 
  }
}