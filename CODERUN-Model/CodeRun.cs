using System;

public interface ICodeRunModule
{
    public string Title { get; }
    public void Run();
}

public class CodeRunFramework
{
    public static void Run(ICodeRunModule code)
    {
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine($"{code.Title}");
        Console.WriteLine("*****************************************************************************");

        code.Run();
    }
}

