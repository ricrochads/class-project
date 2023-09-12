namespace Queues;

public class Queue
{
    public void DemonstrateQueue()
    {
        Console.WriteLine("\nExample 01");
        var femaleNamesQueue = new Queue<string>();
        femaleNamesQueue.Enqueue("Amelia");
        femaleNamesQueue.Enqueue("Harper");
        femaleNamesQueue.Enqueue("Emma");

        Console.WriteLine("Female Names:");
        foreach(var femaleName in femaleNamesQueue)
        {
            Console.WriteLine(femaleName);
        }
 
        Console.WriteLine("\nExample 02");
        var maleNamesQueue = new Queue<string>();
        maleNamesQueue.Enqueue("Noah");
        maleNamesQueue.Enqueue("James");
        maleNamesQueue.Enqueue("Ethan");

        var maleName1 = maleNamesQueue.Peek();
        var maleName2 = maleNamesQueue.Peek();
        
        Console.WriteLine("Male Names:");
        Console.WriteLine(maleName1);
        Console.WriteLine(maleName2);

        Console.WriteLine("\nExample 03");
        var nicknamesQueue = new Queue<string>();
        nicknamesQueue.Enqueue("Andy");
        nicknamesQueue.Enqueue("Ben");
        nicknamesQueue.Enqueue("Ellie");
        nicknamesQueue.Enqueue("Kate");

        var nickname1 = nicknamesQueue.Dequeue();
        var nickname2 = nicknamesQueue.Dequeue();

        Console.WriteLine("Nicknames:");
        Console.WriteLine(nickname1);
        Console.WriteLine(nickname2);
        Console.WriteLine("\n");
    }
}