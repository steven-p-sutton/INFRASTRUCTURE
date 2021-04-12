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
                    Run = (int)MExample.RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                var mockERROR = new MExample
                {
                    Run = (int)MExample.RunType.EXCEPTION,
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
