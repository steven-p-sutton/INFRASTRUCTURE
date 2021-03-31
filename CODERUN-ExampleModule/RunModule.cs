using System;
public class CodeRunModule : ICodeRunModule
{
    public string Title
    {
        get { return "Run Code Module"; }
    }

    public void Run()
    {
        var module = new Module();
        Console.WriteLine(module.Hello("Steve"));
    }
}
