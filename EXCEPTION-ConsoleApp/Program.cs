﻿using System;
using Conductus.Widget.Exceptions; // Custom exceptions

namespace EXCEPTION_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EXCEPTION!");

            throw new WidgetAlreadyExistsException(
                String.Format("Widget {0} Already exists", "123")
            );
        }
    }
}