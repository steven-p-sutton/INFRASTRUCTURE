//=================================================================================================
// JSON
//=================================================================================================
//using System.Text.Json; // JSON handling
//    JsonSerializer.Serialize
//    JsonSerializer.Deserialize
// https://dotnetcoretutorials.com/2019/09/11/how-to-parse-json-in-net-core/
// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

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
    public class DataFileJson : DataFile
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
            string jsonWidgetString1 = JsonSerializer.Serialize(widget);
            File.WriteAllText(fName, jsonWidgetString1);
        }
        public override WidgetObject Read(string fName)
        {
            WidgetObject widget;
            string jsonWidgetString2 = File.ReadAllText(fName);

            Console.WriteLine(jsonWidgetString2);
            widget = JsonSerializer.Deserialize<WidgetObject>(jsonWidgetString2);

            string s = JsonSerializer.Serialize(widget);
            Console.WriteLine("{0}", s);

            return widget;
        }
    }
}
