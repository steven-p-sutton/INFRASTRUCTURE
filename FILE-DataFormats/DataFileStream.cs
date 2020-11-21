
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
    public class DataFileStream : DataFile
    {
        public override void Create(string fName)
        {
            // Delete the file if it exists.
            if (File.Exists(fName))
            {
                File.Delete(fName);
            }

            using (FileStream fs = File.Create(fName))
            {
            }
        }
        public override void Write(string fName, WidgetObject widget)
        {
            using (FileStream fs = File.OpenWrite(fName))
            {
                // Write Widget raw bytes to stream file, no formatting etc
                AddText(fs, widget.Date.ToString());
                AddText(fs, widget.TemperatureC.ToString());
                AddText(fs, widget.Summary);
            }
        }
        public override WidgetObject Read(string fName)
        {
            WidgetObject widget = new WidgetObject();
            return widget;
        }
        void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
