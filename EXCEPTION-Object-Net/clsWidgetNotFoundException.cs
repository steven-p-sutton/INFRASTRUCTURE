﻿namespace Conductus.Widget.Exceptions.Net
{
    // https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions

    public class WidgetNotFoundException : System.Exception
    {
        public WidgetNotFoundException()
        {
        }
        public WidgetNotFoundException(string message)
            : base(message)
        {
        }
        public WidgetNotFoundException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
        public string Display()
        {
            return ExceptionUtility.Display(this, "WidgetNotFoundException");
        }
    }
}