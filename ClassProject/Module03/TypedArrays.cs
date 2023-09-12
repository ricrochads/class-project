namespace TypedArrays;

public class TypedArray
{
    public void DemonstrateTypedArray()
    {
        Console.WriteLine("Numbers");

        Console.WriteLine("\nExample 01");
        var typedArrayNumber1 = new int[3] {1, 2, 3};

        foreach(var item in typedArrayNumber1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nExample 02");
        var typedArrayNumber2 = new int[3];
        typedArrayNumber2[0] = 2;
        typedArrayNumber2[1] = 4;
        typedArrayNumber2[2] = 6;

        foreach(var item in typedArrayNumber2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nExample 03");
        var typedArrayNumber3 = new int[3];
        typedArrayNumber3[0] = 3;
        typedArrayNumber3[1] = 6;
        typedArrayNumber3[2] = 9;

        Array.Resize(ref typedArrayNumber3, 10);

        typedArrayNumber3[5] = 18;

        foreach(var item in typedArrayNumber3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n");
    }
}