//=================================================================================================
// TEXT
//=================================================================================================
// https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader?view=netcore-3.1
// https://www.pluralsight.com/guides/declaring-and-initializing-variables-in-c

using System;
using System.IO;
using System.Text;
using System.Data;
using Microsoft.VisualBasic.FileIO; // VB !!!! 
// TextFieldParser
using System.Text.Json; // JSON handling
// JsonSerializer.Serialize
// JsonSerializer.Deserialize
using System.Xml.Serialization;
using Conductus.Widget.Object;

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
            using (StreamReader sr = File.OpenText(fName))
            {
                string s = String.Empty;

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            
            return new WidgetObject();
        }
    }
}
