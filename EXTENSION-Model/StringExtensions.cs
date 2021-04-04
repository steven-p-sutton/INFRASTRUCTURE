using System;

public static class StringExtensions
{
    public static string H1 (this string s, string value)
    {
        return new String('*', 6);
    }
    public static string H2(this string s, string value)
    {
        string h2 = new String('=', 6);
        return h2;
    }
    public static string H3(this string s, string value)
    {
        string h3 = new String('-', 6);
        return h3;
    }
    public static string H4(this string s, string value)
    {
        return new String('.', 6);
    }
    public static string H5(this string s, string value)
    {
        return new String(' ', 6);
    }
    public static string Pad(this string s, string value)
    {
        return new String(' ', 6);
    }
    public static string Div(this string s, string value)
    {
        return new String('-', 6);
    }
    public static string CRLF(this string s, string value)
    {
        string crlf = Environment.NewLine;
        return crlf;
    }
}
