﻿using System;

public static class CodeRun
{
    public static void Run(ICodeRunModule code)
    {
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine($"{code.Title}");
        Console.WriteLine("*****************************************************************************");

        code.Run();
    }
}

