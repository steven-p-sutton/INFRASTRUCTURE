using System;
using System.Collections.Generic;
using System.Text;

namespace Conductus.Widget.Exceptions
{
    static class ExceptionUtility
    {
        static string Display(System.Exception e)
        {
            return "Message: " + e.Message;
        }
    }
}
