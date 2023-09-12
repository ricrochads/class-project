using System.Collections;
namespace ArrayLists;

public class ArrayLists
{
    public void DemonstrateArrayList()
    {
        var arrayList = new ArrayList
        {
            1,   // 0
            "A", // 1
            true // 2
        };

        Console.WriteLine("\nExample 01");
        Console.WriteLine(arrayList[0]);
        Console.WriteLine(arrayList[1]);
        Console.WriteLine(arrayList[2]);

        Console.WriteLine("\nExample 02");
        arrayList.Add("Alpha");

        foreach(var item in arrayList)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("\nExample 03");
        arrayList.RemoveAt(2);

        foreach(var item in arrayList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nExample 04");
        arrayList.Clear();

        foreach(var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("All ArrayList elements removed.\n");
    }
}