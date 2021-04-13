using System;
using System.Collections.Generic;

public interface  IExample
{
    string Str { get; set; }
    int Int { get; set; }
    List<string> Repository { get; set; }
    int Add(string item);
    string Remove(int idx);
    int Find(string item);
}
