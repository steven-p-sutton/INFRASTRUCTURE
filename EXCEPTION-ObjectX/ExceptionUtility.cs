using System;
using System.Collections.Generic;
using System.Text;

namespace Conductus.Widget.Exceptions
{
    static public class ExceptionUtility
    {
        static public string H1
        {
            get { return new String('-', 6); }
        }
        static public string Display(System.Exception e, string Name)
        {
            string s = Environment.NewLine;
            s = s + ExceptionUtility .H1 + "Name:" + Name + ExceptionUtility.H1 + Environment.NewLine;
            s = s + "       Message:" + e.Message + Environment.NewLine;
            //s = s + " InnerExeption:" + e.InnerException.ToString() + Environment.NewLine;
            return (s);      
        }
    }
}