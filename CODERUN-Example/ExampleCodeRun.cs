using System;
public class ExampleCodeRun : ICodeRunModule
{
    public string Title
    {
        get { return "Sample Code Run"; }
    }

    public void Run()
    {
        var sample = new ExampleClass();
        Console.WriteLine(sample.Hello("Steve"));
    }
}
