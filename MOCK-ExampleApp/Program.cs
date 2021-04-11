using System;
using Conductus.EXAMPLE.Model.Core;

namespace MOCK.EXAMPLE.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mockOK = new MExample
                {
                    Run = IMock.RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                var mockERROR = new MExample
                {
                    Run = IMock.RunType.EXCEPTION,
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
