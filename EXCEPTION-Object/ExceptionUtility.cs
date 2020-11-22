using System;
using System.Collections.Generic;
using System.Text;

namespace Conductus.Widget.Exceptions
{
    public class ExceptionUtility
    {
        public string Display(System.Exception e, string Name)
        {
            return "Name:" + Name + " Message:" + e.Message;
        }
    }
}