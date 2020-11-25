using System;
//using Conductus.UTILITY.Net.Heading;

namespace Conductus.Widget.Exceptions.Net
{
    static public class ExceptionUtility
    {
        static public string Display(System.Exception e, string Name)
        {
            string s = Environment.NewLine;
            s = s + Heading.H3 + Heading.Pad + "Name:" + Name + Heading.Pad + Heading.H3 + Environment.NewLine;
            s = s + "       Message:" + e.Message + Environment.NewLine;
            //s = s + " InnerExeption:" + e.InnerException.ToString() + Environment.NewLine;
            return (s);      
        }
    }
}