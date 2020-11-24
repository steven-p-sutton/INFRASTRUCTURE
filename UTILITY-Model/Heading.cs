using System;
static public class Heading
{
    static public string H1
    {
        get { return new String('*', 6); }
    }
    static public string H2
    {
        get { return new String('=', 6); }
    }
    static public string H3
    {
        get { return new String('-', 6); }
    }
    static public string H4
    {
        get { return new String('.', 6); }
    }
    static public string H5
    {
        get { return new String(' ', 6); }
    }
    static public string Pad
    {
        get { return new String(' ', 1); }
    }
    static public string Div
    {
        get { return new String('-', 80); }
    }
}
