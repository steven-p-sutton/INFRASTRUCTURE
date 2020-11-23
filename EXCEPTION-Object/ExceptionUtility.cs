using System;
using System.Collections.Generic;
using System.Text;
using Conductus.UTILITY.Heading;

namespace Conductus.Widget.Exceptions
{
    static public class ExceptionUtility
    {
        static public string Display(System.Exception e, string Name)
        {
            string s = Environment.NewLine;
            s = s + Heading.H1 + "Name:" + Name + Heading.H1 + Environment.NewLine;
            s = s + "       Message:" + e.Message + Environment.NewLine;
            //s = s + " InnerExeption:" + e.InnerException.ToString() + Environment.NewLine;
            return (s);      
        }
    }
}