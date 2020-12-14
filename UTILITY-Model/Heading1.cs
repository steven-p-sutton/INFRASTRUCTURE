
using System;

public class HeadingExample: ExampleBase
{
    public HeadingExample()
    {
        this.Title = "HeadingExample";
    }
    protected override void Run()
    {
        string Name = "Steve";
        string message = "Hello world!";

        MessageLine("Use some Headings in a formated string");

        string s = Environment.NewLine;
        s = s + Heading.H3 + Heading.Pad + "Name:" + Name + Heading.Pad + Heading.H3 + Environment.NewLine;
        s = s + "       Message:" + message + Environment.NewLine;

        MessageLine(s);
    }
}
