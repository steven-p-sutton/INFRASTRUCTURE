//using Microsoft.Extensions.Logging;

using System;

namespace Conductus.PATTERN.FooBar.FOOSERVICE
{
    class clsFooService : IFooService
    {
        public void DoThing(int number)
        {
            Console.WriteLine("FooService.DoThing");
        }
    }
}
