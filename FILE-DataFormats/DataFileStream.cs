
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

namespace Conductus.FILE.Dataformats
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
            // Create the new file
            using (FileStream fs = File.Create(fName))
            {
            }
            // use fs.Close(); if not using 'using'
        }
        public override void Write(string fName, Widget widget)
        {
            using (FileStream fs = File.OpenWrite(fName))
            {
                // Write Widget raw bytes to stream file lines, no formatting
                // apart from Newline between fields
                AddText(fs, widget.Date.ToString());
                AddText(fs, widget.Name.ToString());
                AddText(fs, widget.Count.ToString());
                AddText(fs, widget.Secret.ToString());
            }
        }
        public override Widget Read(string fName)
        {
            Widget widget = new Widget();
            using (FileStream fs = File.OpenRead(fName))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    widget.Date = Convert.ToDateTime(GetText(sr));
                    widget.Name = GetText(sr);
                    widget.Count = int.Parse(GetText(sr));
                    widget.Secret = GetText(sr);
                }
            }
            return widget;
        }
        public override byte[] ReadBytes(string fName)
        {
            FileStream fs = File.OpenRead(fName);
            byte[] buf = new byte[1024];
            int c = fs.Read(buf, 0, buf.Length);
            return buf;
        }
        public override string ReadString(string fName)
        {
            FileStream fs = File.OpenRead(fName);
            byte[] buf = new byte[1024];
            int c = fs.Read(buf, 0, buf.Length);
            return Encoding.UTF8.GetString(buf, 0, c);
        }
        void AddText(FileStream fs, string value)
        {
            string s = value + Environment.NewLine;
            byte[] info = new UTF8Encoding(true).GetBytes(s);
            fs.Write(info, 0, info.Length);
        }
        string GetText(StreamReader sr)
        {
            return sr.ReadLine();
        }
    }
}
