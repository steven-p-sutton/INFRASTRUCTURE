
//=================================================================================================
// STREAM
//=================================================================================================
// https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?view=netcore-3.1
// Streams = processing bytes for file
// StringStream = processing character in a string
// Textstream = processing string data in a file
// OpenWrite
// Create

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
    public class DateFileText
    {
        public void Create(string fName)
        {
        }
        public void Write(string fName, WidgetObject widget)
        {
        }
        public WidgetObject Read(string fName)
        {
            return new WidgetObject();
        }
    }
}
