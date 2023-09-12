namespace WorkingWithFile;

public class WorkingWithFiles
{
    public void CreateFile()
    {
        Console.WriteLine("\nCreating Files");
        var write = new StreamWriter("D:\\temp\\Register.txt", true);
        Console.Write("Enter a name: ");
        var name = Console.ReadLine();
        write.WriteLine("ID...: " + Random.Shared.Next(1,100));
        write.WriteLine("Name.: " + name);
        write.WriteLine("-----------------------------------");
        write.Close();
    }

    public void ReadFile()
    {
        Console.WriteLine("\nReading Files");
        var read = File.ReadAllText("D:\\temp\\Register.txt");
        Console.WriteLine(read);
    }

    public void ReadFileByLine()
    {
        Console.WriteLine("\nReading File by Line");
        var read = new StreamReader("D:\\temp\\Register.txt");

        while(!read.EndOfStream)
        {
            var line = read.ReadLine();
            Console.WriteLine(line);
        }

        read.Close();
    }

    public void DeleteFile()
    {
        Console.WriteLine("\nDeleting File");
        if(File.Exists("D:\\temp\\Register.txt"))
        {
            File.Delete("D:\\temp\\Register.txt");
            Console.WriteLine("Deleted file!");
        }
    }
}