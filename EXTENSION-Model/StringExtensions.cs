using System;

public static class StringExtensions
{
    private const int _nMin = 1;
    private const int _nMax = 6;
    public static string H1 (this string s, int n = _nMax)
    {
        return new String('*', n);
    }
    public static string H2(this string s, int n = _nMax)
    {
        return new String('=', n);
    }
    public static string H3(this string s, int n = _nMax)
    {
        return new String('-', n);
    }
    public static string H4(this string s, int n = _nMax)
    {
        return new String('.', n);
    }
    public static string H5(this string s, int n = _nMax)
    {
        return new String(' ', n);
    }
    public static string Pad(this string s, int n = _nMax)
    {
        return new String(' ', n);
    }
    public static string Div(this string s, int n = _nMax)
    {
        return new String('-', n);
    }
    public static string CRLF(this string s, int n = _nMin)
    {
        string tmp = string.Empty;

        for (int i = 0; i < n; i++)
            tmp += Environment.NewLine;

        return tmp;
    }
}
