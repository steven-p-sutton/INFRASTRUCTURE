//using Microsoft.Extensions.Logging;

using System;

namespace FooService
{
    class clsFooService : IFooService
    {
        public void DoThing(int number)
        {
            Console.WriteLine("FooService.DoThing");
        }
    }
}
