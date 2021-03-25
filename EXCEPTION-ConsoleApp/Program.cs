using System;
using Conductus.WIDGET.Exception;

namespace Conductus.EXCEPTION.ConsoleApp
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
