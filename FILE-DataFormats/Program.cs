//  Files
//      https://www.guru99.com/c-sharp-stream.html
//      https://csharp.hotexamples.com/examples/-/TextStream/-/php-textstream-class-examples.html

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

using Conductus.Widget.Object; // Object used for all examples
using Conductus.FILE;

namespace Conductus.FILE.ConsoleApp
{
    class Program
    {
        // Global objects that will be used throughout the various types of files and objects
        // A source object
        static WidgetObject m_widget1 = new WidgetObject()
        {
            Date = DateTimeOffset.Now,
            TemperatureC = 32,
            Summary = "Test 1 summary"
        };

        // An empty destination object
        static WidgetObject m_widget2 = new WidgetObject();
        static void Main(string[] args)
        {
            // Directory.GetCurrentDirectory()
            string root = "C:\\Users\\steve\\Documents\\Visual Studio Work\\INFRASTRUCTURE\\FILE-DataFormats\\";

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("1. STREAM Files");
            Console.WriteLine("--------------------------------------------------------------------");

            try
            {
                string streamFileName = "Stream.txt";
                DataFileStream fs = new DataFileStream();

                //fs.Create(root + streamFileName);
                //fs.Write(root + streamFileName, m_widget1);
                m_widget2 = fs.Read(root + streamFileName);
                byte[] buf = new byte[1024];
                buf = fs.ReadBytes(root + streamFileName);
                string s = fs.ReadString(root + streamFileName);
            }
            catch (NotImplementedException e)
            {
                // do nothing & continue
            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("2. TEXT Files");
            Console.WriteLine("--------------------------------------------------------------------");

            try
            {
                string textFileName = "Text.txt";
                DataFileText ft = new DataFileText();

                //ft.Create(root + textFileName);
                //ft.Write(root + textFileName, m_widget1);
                //m_widget2 = ft.Read(root + textFileName);
            }
            catch (NotImplementedException e)
            {
                // do nothing & continue
            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("3. CSV Files");
            Console.WriteLine("--------------------------------------------------------------------");

            try
            {
                string csvFileName = "Csv.csv";
                DataFileCsv fc = new DataFileCsv();

                //fc.Create(root + csvFileName);
                //fc.Write(root + csvFileName, m_widget1);
                //m_widget2 = fc.Read(root + csvFileName);
            }
            catch (NotImplementedException e)
            {
                // do nothing & continue
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("4. JSON Files");
            Console.WriteLine("-------------------------------------------------------------------");
            
            try
            {
                string jsonFileName = "Json.json";
                DataFileJson fj = new DataFileJson();


                //fj.Create(root + jsonFileName);
                //fj.Write(root + jsonFileName, m_widget1);
                //m_widget2 = fj.Read(root + jsonFileName);
            }
            catch (NotImplementedException e)
            {
                // do nothing & continue
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("4. XML Files");
            Console.WriteLine("-------------------------------------------------------------------");

            try
            {
                string xmlFileName = "XML.xml";
                DataFileXml fx = new DataFileXml();

                //fx.Create(root + xmlFileName);
                //fx.Write(root + xmlFileName, m_widget1);
                //m_widget2 = fx.Read(root + xmlFileName);
            }
            catch (NotImplementedException e)
            {
                // do nothing & continue
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("99. ALL DONE");
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
