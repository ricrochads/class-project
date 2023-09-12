namespace Lists;

public class List
{
    public void DemonstrateList()
    {
        Console.WriteLine("\nExample 01");
        var listA = new List<string>(5) {"Apple", "Banana", "Coconut", "Dewberries", "Elderberry"};

        var listAFruit = listA[1];
        Console.WriteLine("Fruit: " + listAFruit);

        Console.WriteLine("\nExample 02");
        var listB = new List<string>(5);
        listB.Add("Fascell Mango"); // 0
        listB.Add("Guava");         // 1
        listB.Add("Honeydew");      // 2
        listB.Add("Incaberry");     // 3
        listB.Add("Jambolan");      // 4

        var listBFruit = listB[2];
        Console.WriteLine("Fruit: " + listBFruit);

        Console.WriteLine("\nExample 03");
        var listC = new List<string>(3)
        {
            "Kiwi",
            "Lingonberries",
            "Maracuya"
        };

        Console.WriteLine("Fruit List:");
        foreach(var item in listC)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nExample 04");
        listC.RemoveAt(1);

        foreach(var item in listC)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n");
    }
}