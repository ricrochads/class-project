namespace Strings;

public class String
{
    public void ConvertToLowercase()
    {
        Console.WriteLine("\nToLower");
        Console.Write("Please enter some information: ");
        var userInput = Console.ReadLine();
        Console.WriteLine(userInput.ToLower());
    }

    public void ConvertToUppercase()
    {
        Console.WriteLine("\nToUpper");
        Console.Write("Please enter some information: ");
        var userInput = Console.ReadLine();
        Console.WriteLine(userInput.ToUpper());
    }

    public void ExtractSubstring()
    {
        Console.WriteLine("\nSubstring");
        Console.Write("Please enter some information: ");
        var userInput = Console.ReadLine();
        Console.WriteLine(userInput.Substring(6,3));
    }

    public void ExtractStringWithRange()
    {
        Console.WriteLine("\nRange");
        string fileName =  "2023_12_01_backup.bak";

        string year = fileName[..4];
        Console.WriteLine(year);

        string extension = fileName[^3..];
        Console.WriteLine(extension);

        string name = fileName[11..^4];
        Console.WriteLine(name);

        string fullFileName = fileName[..^4];
        Console.WriteLine(fullFileName);
    }

    public void CheckIfContains()
    {
        Console.WriteLine("\nContains");
        string fileName =  "2023_12_01_backup.bak";
        Console.WriteLine($"File Name: {fileName}");


        Console.Write("Contain backup name: ");
        if(fileName.Contains("backup"))
            Console.WriteLine("Word found!");
        else
            Console.WriteLine("Word not found!");
        
        Console.WriteLine("Contains .bak extension: " + fileName.Contains(".bak"));
    }

    public void TrimString()
    {
        Console.WriteLine("\nTrim, TrimStart and TrimEnd");
        string word = "**Ricardo Rocha**";
        Console.WriteLine(word);

        Console.WriteLine("Trim: " + word.Trim('*'));
        Console.WriteLine("TrimStart: " + word.TrimStart('*'));
        Console.WriteLine("TrimEnd: " + word.TrimEnd('*'));
    }

    public void CheckStartsWith()
    {
        Console.WriteLine("\nStartsWith");
        string words = "Csharp Course";
        
        Console.WriteLine($"Example: {words}");
        Console.WriteLine("Start with Csharp: " + words.StartsWith("Csharp"));
        Console.WriteLine("Start with Java: " + words.StartsWith("Java"));
    }

    public void CheckEndsWith()
    {
        Console.WriteLine("\nEndsWith");
        string words = "Csharp Course";

        Console.WriteLine($"Example: {words}");
        Console.WriteLine("End with Course: " + words.EndsWith("Course"));
        Console.WriteLine("End with Job: " + words.EndsWith("Job"));
    }

    public void ReplaceString()
    {
        Console.WriteLine("\nReplace");
        string words = "Csharp Course";

        Console.WriteLine(words);
        Console.WriteLine(words.Replace("Csharp", "C#"));
    }

    public void LengthString()
    {
        Console.WriteLine("\nLength");
        Console.Write("Please enter some information: ");
        string userInput = Console.ReadLine();
        Console.WriteLine($"Length: {userInput.Length}\n");
    }
}