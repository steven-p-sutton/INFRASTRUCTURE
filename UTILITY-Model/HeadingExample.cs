
using System;

public class HeadingExample
{
    public string s()
    {
        string Name = "Steve";
        string message = "Hello world!";

        string s = Environment.NewLine;
        s = s + Heading.H3 + Heading.Pad + "Name:" + Name + Heading.Pad + Heading.H3 + Environment.NewLine;
        s = s + "       Message:" + message + Environment.NewLine;
        return s;
    }
}
