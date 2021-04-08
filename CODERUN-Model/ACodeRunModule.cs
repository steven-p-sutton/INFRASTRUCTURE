using System;

public abstract class ACodeRunModule : ICodeRunModule
{
    public abstract string Title { get; }
    public abstract void Run();
    public void Msg(string txt)
    {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine($"{txt}");
    }
}

