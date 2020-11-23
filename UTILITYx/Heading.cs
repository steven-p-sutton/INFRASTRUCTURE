using System;
using System.Collections.Generic;
using System.Text;

namespace Conductus.UTILITY.Heading
{
    static public class Heading
    {
        static public string H1
        {
            get { return new String('*', 6); }
        }
        static public string H2
        {
            get { return new String('=', 6); }
        }
        static public string H3
        {
            get { return new String('-', 6); }
        }
        static public string H4
        {
            get { return new String('.', 6); }
        }
        static public string H5
        {
            get { return new String(' ', 6); }
        }
    }
}
