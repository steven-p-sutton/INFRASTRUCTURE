using System;
using System.IO;

public class Message :IMessage
{
    public string Title { get; set; }
    public TextWriter Output { get; set; }
    public Message()
    {
        this.Output = Console.Out;
        this.Title = "MessageOutput";
    }
    public string MessageGo(string message)
    {
        string s = "\n     : " + "Go ......";
        this.Output.WriteLine(s);
        return (s);
    }
    public string MessageBegin(string message)
    {
        string s = "\nBEGIN: " + this.Title + ": " + message;
        this.Output.WriteLine(s);
        return (s);
    }
    public string MessageEnd(string message)
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
    public string MessageOut(string message)
    {
        string s = " " + message;
        this.Output.Write(s);
        return (s);
    }
}
