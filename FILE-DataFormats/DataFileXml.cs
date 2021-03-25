//=================================================================================================
// XML
//=================================================================================================
// https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/serialize-object-xml
// https://docs.microsoft.com/en-us/dotnet/standard/serialization/examples-of-xml-serialization
// https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netcore-3.1

using System;
using System.IO;
using System.Xml.Serialization;

namespace Conductus.FILE.Dataformats
{
    public class DataFileXml : DataFile
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
        public override void Write(string fName, Widget widget)
        {
            XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(widget.GetType());
            xmlSerializer.Serialize(Console.Out, widget);

            using (TextWriter tw = File.AppendText(fName))
            {
                xmlSerializer.Serialize(tw, widget);
            }
        }
        public override Widget Read(string fName)
        {
            Widget widget = new Widget();

            XmlSerializer xmlSerializer = new XmlSerializer(widget.GetType());
            using (Stream sr = new FileStream(fName, FileMode.Open))
            {
                widget = (Widget)xmlSerializer.Deserialize(sr);
            }
            xmlSerializer.Serialize(Console.Out, widget);

            return widget;
        }
        public override byte[] ReadBytes(string fName)
        {
            return new byte[0];
        }
        public override string ReadString(string fName)
        {
            return string.Empty;
        }
    }
}
