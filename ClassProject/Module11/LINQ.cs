namespace LINQ;

public class WorkingWithLinq
{
    public void DemonstrateWhere()
    {
        Console.WriteLine("\nWhere");
        string fullName = "RICARDO ROCHA";

        Console.WriteLine("\nExample 01");
        Console.WriteLine($"Full Name: {fullName}");

        var letterResult1 = fullName.Where(v => v == 'I');
        
        Console.WriteLine("Letter 'I':");
        foreach(var letter in letterResult1)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nExample 02");
        Console.WriteLine($"Full Name: {fullName}");

        Func<char, bool> filter = v => v =='A';
        var letterResult2 = fullName.Where(filter);

        Console.WriteLine("Letter 'A':");
        foreach(var letter in letterResult2)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nExample 03");
        Console.WriteLine($"Full Name: {fullName}");

        var letterResult3 = from v in fullName where v == 'R' select v;

        Console.WriteLine("Letter 'R':");
        foreach(var letter in letterResult3)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nExample 04");
        var numbers = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultNumber = numbers.Where(v => v >= 10);

        Console.Write("Numbers: ");
        foreach(var number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.Write("\nNumbers >= 10: ");
        foreach(var number in resultNumber)
        {
            Console.Write($"{number} ");
        }
    }

    public void DemonstrateOrderBy()
    {
        Console.WriteLine("\n\nOrder By");
        Console.Write("\nNumbers");
        var numbers = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultNumber1 = numbers.OrderBy(w => w);
        var resultNumber2 = numbers.OrderByDescending(w => w);

        Console.Write("\nNumbers: ");
        foreach(var number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.Write("\nNumbers in ascending order: ");
        foreach(var number in resultNumber1)
        {
            Console.Write($"{number} ");
        }

        Console.Write("\nNumbers in descending order: ");
        foreach(var number in resultNumber2)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine("\nStrings");
        var names = new string[] {"Eduardo", "Rafael", "Bruno"};
        var resultName1 = names.OrderBy(w => w);
        var resultName2 = names.OrderByDescending(w => w);

        Console.Write("Names: ");
        foreach(var name in names)
        {
            Console.Write($"{name} ");
        }

        Console.Write("\nAscending order: ");
        foreach(var name in resultName1)
        {
            Console.Write($"{name} ");
        }

        Console.Write("\nDescending order: ");
        foreach(var name in resultName2)
        {
            Console.Write($"{name} ");
        }
    }

    public void DemonstrateTake()
    {
        Console.WriteLine("\n\nTake");
        var numbers = new int[] { 10, 6, 5, 50, 15, 2 };
        var result1 = numbers.Take(3);
        var result2 = numbers.Take(3).OrderBy(x => x);
        var result3 = numbers.Where(x => x > 5).Take(3).OrderBy(x => x);

        Console.Write("\nNumbers: ");
        foreach(var number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.Write("\nThe first three elements: ");
        foreach(var number in result1)
        {
            Console.Write($"{number} ");
        }

        Console.Write("\nThe first three elements in ascending order: ");
        foreach(var number in result2)
        {
            Console.Write($"{number} ");
        }

        Console.Write("\nThe first three elements greater than 5 in ascending order: ");
        foreach(var number in result3)
        {
            Console.Write($"{number} ");
        }
    }

    public void DemonstrateCount()
    {
        Console.WriteLine("\n\nCount");
        var numbers = new int[] { 10, 6, 5, 50, 15, 2 };
        var result1 = numbers.Count();
        var result2 = numbers.Count(y => y > 10);

        Console.Write("\nNumbers: ");
        foreach(var number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine($"\nTotal elements in the array: {result1}");
        Console.WriteLine($"Total elements in the array greater than 10: {result2}");
    }

    public void DemonstrateFirstAndFirstOrDefault()
    {
        Console.WriteLine("\nFirst And FirstOrDefault");
        var numbers = new int[] { 10, 6, 5, 50, 15, 2 };
        var result1 = numbers.First();
        var result2 = numbers.First(z => z > 10);
        var result3 = numbers.FirstOrDefault();
        var result4 = numbers.FirstOrDefault(z => z > 100, -99);

        Console.Write("\nNumbers: ");
        foreach(var number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine($"\nThe first element: {result1}");
        Console.WriteLine($"The first element greater than 10: {result2}");
        Console.WriteLine($"The first element or the default element: {result3}");
        Console.WriteLine($"The default element: {result4}");
    }
}