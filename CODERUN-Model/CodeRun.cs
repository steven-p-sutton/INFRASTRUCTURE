using System;

public abstract class ICodeRunModule
{
    public void Msg (string txt)
    {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine($"{txt}");
    }
    public abstract string Title { get; }
    public abstract void Run();
}

public static class CodeRun
{
    public static void Run(ICodeRunModule code)
    {
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine($"{code.Title}");
        Console.WriteLine("*****************************************************************************");

        code.Run();
    }
}

