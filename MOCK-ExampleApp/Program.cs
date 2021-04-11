using System;
using Conductus.MOCK.Model.Core;
using Conductus.MOCK.Example;

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
                    Assert = IMock.RunType.SUCCESS
                };

                var mockERROR = new MExample
                {
                    Run = IMock.RunType.EXCEPTION,
                    ExceptionExpected = new ExampleAlreadyExistsException("Mock ERROR"),
                    Throws = true,
                    Arrange = true,
                    Test = true,
                    Assert = IMock.RunType.EXCEPTION
                };
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
