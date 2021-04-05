using System;

namespace Conductus.EXCEPTION.ExampleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ExceptionExample();
            }
            catch(ExceptionExample e)
            {
                Console.WriteLine(e.Display());
            }
        }
    }
}
