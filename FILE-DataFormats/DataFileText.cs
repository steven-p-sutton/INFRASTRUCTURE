//=================================================================================================
// TEXT
//=================================================================================================
// https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader?view=netcore-3.1
// https://www.pluralsight.com/guides/declaring-and-initializing-variables-in-c
// https://www.guru99.com/c-sharp-stream.html
// https://csharp.hotexamples.com/examples/-/TextStream/-/php-textstream-class-examples.html

using System;
using System.IO;
using Conductus.Widget.Object;      // Widget object
using Conductus.Widget.Exceptions;  // Widget exceptions

namespace Conductus.FILE
{
    public class DataFileText : DataFile
    {
        public override void Create(string fName)
        {
            if (File.Exists(fName))
            {
                File.Delete(fName);
            }
            using (StreamWriter sw = File.CreateText(fName))
            {
            }
        }
        public override void Write(string fName, WidgetObject widget)
        {
            using (StreamWriter sw = File.AppendText(fName))
            {
                sw.WriteLine(widget.Date.ToString());
                sw.WriteLine(widget.TemperatureC.ToString());
                sw.WriteLine(widget.Summary.ToString());
            }
        }
        public override WidgetObject Read(string fName)
        {
            WidgetObject widget = new WidgetObject();
            using (StreamReader sr = File.OpenText(fName))
            {   
                widget.Date = Convert.ToDateTime(sr.ReadLine());
                widget.TemperatureC = int.Parse(sr.ReadLine());
                widget.Summary = sr.ReadLine();
            }
            return widget;
        }
        public override byte[] ReadBytes(string fName)
        {
            throw new WidgetNotImplentedException("Text Streams are not byte streams.");
        }
        public override string ReadString(string fName)
        {
            throw new WidgetNotImplentedException("Text Streams are not byte streams.");
        }
    }
}
