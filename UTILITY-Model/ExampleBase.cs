using System;
using System.IO;

public abstract class ExampleBase
{
    public string Title { get; set; }
    public TextWriter Output { get; set; }

    public ExampleBase()
    {
        this.Output = Console.Out;
        this.Title = "106-ExampleBase";
    }
    public ExampleBase(string title)
    {
        this.Title = title;
    }
    private string MessageGo(string message)
    {
        string s = "\n     : " + "Go ......";
        this.Output.WriteLine(s);
        return (s);
    }   
    private string MessageBegin(string message)
    {
        string s = "\nBEGIN: " + this.Title + ": " + message;
        this.Output.WriteLine(s);
        return (s);
    }
    private string MessageEnd(string message)
    {
        string s = "\nEND  : " + this.Title + ": " + message; ;
        this.Output.WriteLine(s);
        return (s);
    }
    public string MessageLine(string message)
    {
        string s = "\n     : " + this.Title + ": " + message;
        this.Output.WriteLine(s);
        return (s);
    }
    public string Message(string message)
    {
        string s = " " + message;
        this.Output.Write(s);
        return (s);
    }
    protected abstract void Run();

    public void Go(string message)
    {
        this.MessageBegin(message);
        //this.MessageGo(message);
        this.Run();
        this.MessageEnd(message);
    }
}
