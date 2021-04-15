﻿using System;
using System.Collections.Generic;
using System.Text;

public class HExample
{
    Example Example { get; set; }
    public HExample()
    {
        this.Example = new Example
        {
            Str = "Hello World",
            Int = 99,
            Repository = new List<string>()
        };
        this.Example.Repository.Add("string1");
        this.Example.Str = "Str";
        this.Example.Int = 11;
    }
    public HExample(Example example)
    {
        this.Example = example;
    }

    /// <summary>
    /// An overall confidence test to try out the class 
    /// </summary>
    public bool Try
    {
        set
        {
            if (value)
            {
                string str = this.Example.Str;
                int Int = this.Example.Int;

                string s = Example.Ping("HExample.Try.Ping()");

                int idx = 0;
                string item = string.Empty;

                idx = Example.Find("Added");
                idx = Example.Add("Added");
                idx = Example.Find("Added");
                item = Example.Remove(idx);
                idx = Example.Find("Added");
                item = Example.Remove(idx);
            }
            else
            {
                this.Example = new Example
                {
                    Str = "",
                    Int = 0,
                    Repository = new List<string>()
                };
            }
        }
    }
    /// <summary>
    /// Each class method / property to has a call to exercise it 
    /// </summary>
        
    public string Str()
    {
        return Example.Str;
    }
    public int Int()
    {
        return Example.Int;
    }
    public string Ping()
    {
        return Example.Ping("HExample.Ping.Ping()");
    }
    public int Add()
    {
        Example.Add("Added");
        return Example.Find("Added");
    }
    public string Remove()
    {
        int idx = Example.Find("Added");
        return Example.Remove(idx);
    }
    public int Find()
    {
        Example.Add("Added");
        return Example.Find("Added");
    }
}
