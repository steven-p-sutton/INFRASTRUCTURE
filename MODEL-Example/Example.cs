using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Example : IExample
{
    public Example()
    {
        Repository = new List<string>();
    }
    [JsonProperty("str")]
    public string Str { get; set; }
    [JsonProperty("int")]
    public int Int { get; set; }
    [JsonProperty("list")]
    public List<string> Repository { get; set; }
    public int Add(string item)
    {
        this.Repository.Add(item);
        return Repository.IndexOf(item);
    }
    public string Remove(int idx)
    {
        string item = this.Repository[idx];
        this.Repository.Remove(item);
        return item;
    }
    public int Find(string item)
    {
        var idx = this.Repository.IndexOf(item);
        if (idx == -1) throw new ExampleNotFoundException();
        return idx;
    }
}