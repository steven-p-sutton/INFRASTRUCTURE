using System;

namespace Conductus.EXCEPTION.Example
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
