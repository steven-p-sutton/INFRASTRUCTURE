﻿
//=================================================================================================
// STREAM
//=================================================================================================
// https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?view=netcore-3.1
// Streams = processing bytes for file
// StringStream = processing character in a string
// Textstream = processing string data in a file
// OpenWrite
// Create
//
// NewLines 
// https://social.msdn.microsoft.com/forums/vstudio/en-US/9582ab67-7039-4472-a1d2-b6912ddf5fa4/streamreaderreadline-breaks-at-single-carriage-return
//
// FileStreams & StreamReader/StreamWriter
// http://zetcode.com/csharp/filestream/

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
                // Write Widget raw bytes to stream file lines, no formatting
                // apart from Newline between fields
                AddText(fs, widget.Date.ToString());
                AddText(fs, widget.TemperatureC.ToString());
                AddText(fs, widget.Summary);
            }
        }
        public override WidgetObject Read(string fName)
        {
            WidgetObject widget = new WidgetObject();

            using (FileStream fs = File.OpenRead(fName))
            {
                widget.Date = Convert.ToDateTime(GetText(fs));
                widget.TemperatureC = int.Parse(GetText(fs));
                widget.Summary = GetText(fs);
            }
            return widget;
        }
        public override byte[] ReadBytes(string fName)
        {
            return new byte[0];
        }
        void AddText(FileStream fs, string value)
        {
            string s = value + Environment.NewLine;
            byte[] info = new UTF8Encoding(true).GetBytes(s);
            fs.Write(info, 0, info.Length);
        }

        string GetText(FileStream fs)
        {
            string s = string.Empty;
            using (StreamReader reader = new StreamReader(fs))
            {
                s = reader.ReadLine();
            }
            return s;
        }
    }
}
