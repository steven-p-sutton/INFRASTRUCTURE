using System;
using Conductus.EXAMPLE.Model;
using Conductus.EXCEPTION.Model.Core;

namespace Conductus.EXAMPLE.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Example");
            Console.WriteLine("===============================================================================");

            try
            {
                var example = new Example();

                example.Str = "APP-Example";
                example.Int = 99;
                example.Ping("Example.Ping()");

                example.Add(example.Str);
                example.Add(example.Int.ToString());

                foreach (var item in example.Repository)
                    Console.WriteLine(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("===============================================================================");
            Console.WriteLine("HExample");
            Console.WriteLine("===============================================================================");

            try
            {
                var host = new HExample();

                var s = host.Str();
                var i = host.Int();
                var p = host.Ping();
                
                host.Add();
                host.Find();
                host.Remove();

                host.Try = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("===============================================================================");
            Console.WriteLine("EExample");
            Console.WriteLine("===============================================================================");

            try
            {
                var notImpementedYet = new EExample();

                notImpementedYet.Add("Item");
                notImpementedYet.Remove(notImpementedYet.Find("Item"));
                notImpementedYet.Ping("EExample.Ping()");
            }
            catch (ExampleNotImplentedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("===============================================================================");
            Console.WriteLine("MExample");
            Console.WriteLine("===============================================================================");

            try
            {
                var mockOK = new MExample
                {
                    Run = RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                var  mockERROR= new MExample
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

            Console.ReadLine();
        }
    }
}
