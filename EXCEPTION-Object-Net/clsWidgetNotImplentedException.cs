﻿namespace Conductus.Widget.Exceptions.Net
{
    // https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions

    public class WidgetNotImplentedException : System.Exception
    {
        public WidgetNotImplentedException()
        {
        }
        public WidgetNotImplentedException(string message)
            : base(message)
        {
        }
        public WidgetNotImplentedException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
        public string Display()
        {
            return ExceptionUtility.Display(this, "WidgetNotImplentedException");
        }
    }
}