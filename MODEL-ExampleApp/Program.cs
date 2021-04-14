﻿using System;
//using Conductus.MODEL.Model.Core;

namespace Conductus.MODEL.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mockOK = new MExample
                {
                    Run = RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                var mockERROR = new MExample
                {
                    Run = RunType.EXCEPTION,
                    ExceptionExpected = new ExampleAlreadyExistsException("Mock ERROR"),
                    Throws = true,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
