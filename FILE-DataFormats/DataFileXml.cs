//=================================================================================================
// XML
//=================================================================================================
// https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/serialize-object-xml
// https://docs.microsoft.com/en-us/dotnet/standard/serialization/examples-of-xml-serialization
// https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netcore-3.1

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
            XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(widget.GetType());
            xmlSerializer.Serialize(Console.Out, widget);

            using (TextWriter tw = File.AppendText(fName))
            {
                xmlSerializer.Serialize(tw, widget);
            }
        }
        public override WidgetObject Read(string fName)
        {
            WidgetObject widget;

            XmlSerializer xmlSerializer = new XmlSerializer(m_widget2.GetType());
            using (Stream sr = new FileStream(fName, FileMode.Open))
            {
                widget = (WidgetObject)xmlSerializer.Deserialize(sr);
            }
            xmlSerializer.Serialize(Console.Out, widget);

            return widget;
        }
    }
}
