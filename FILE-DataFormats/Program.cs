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

            string streamFileName = "Stream.txt";
            DataFileStream fs = new DataFileStream();

            fs.Create(root + streamFileName);
            fs.Write(root + streamFileName, m_widget1);
            m_widget2 = fs.Read(root + streamFileName);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("2. TEXT Files");
            Console.WriteLine("--------------------------------------------------------------------");

            string textFileName = "Text.txt";
            DataFileText ft = new DataFileText();

            ft.Create(root + textFileName);
            ft.Write(root + textFileName, m_widget1);
            m_widget2 = ft.Read(root + textFileName);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("3. CSV Files");
            Console.WriteLine("--------------------------------------------------------------------");

            string csvFileName = "Csv.csv";
            DataFileCsv fc = new DataFileCsv();

            fc.Create(root + csvFileName);
            ft.Write(root + csvFileName, m_widget1);
            m_widget2 = fc.Read(root + csvFileName);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("4. JSON Files");
            Console.WriteLine("-------------------------------------------------------------------");

            string jsonFileName = "Json.json";
            DataFileJson fj = new DataFileJson();

            fj.Create(root + jsonFileName);
            fj.Write(root + jsonFileName, m_widget1);
            m_widget2 = fj.Read(root + jsonFileName);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("4. XML Files");
            Console.WriteLine("-------------------------------------------------------------------");

            string XmlFileName = "XML.xml";

            fXml_Create(root + XmlFileName);
            fXml_Write(root + XmlFileName);
            fXml_Read(root + XmlFileName);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("99. ALL DONE");
            Console.WriteLine("-------------------------------------------------------------------");
        }
       

        //=================================================================================================
        // XML
        //=================================================================================================
        // https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/serialize-object-xml
        // https://docs.microsoft.com/en-us/dotnet/standard/serialization/examples-of-xml-serialization
        // https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netcore-3.1

        static void fXml_Create(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fXml_Create_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Delete the file if it exists");
            //-----------------------------------------------------------------------------
            if (File.Exists(fName))
            {
                File.Delete(fName);
            }

            //-----------------------------------------------------------------------------
            Console.WriteLine("2. Create a file to write to");
            //-----------------------------------------------------------------------------
            using (StreamWriter sw = File.CreateText(fName))
            {
            }

            //-----------------------------------------------------------------------------
            Console.WriteLine("fXml_Create_END");
            //-----------------------------------------------------------------------------
        }
        static void fXml_Write(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fXml_Write_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Setup widget1 to serialize");
            //-----------------------------------------------------------------------------
            // Declared & initiazed at top of program

            //-----------------------------------------------------------------------------
            Console.WriteLine("2. Output widget1 to screen ->");
            //----------------------------------------------------------------------------
            XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(m_widget1.GetType());
            xmlSerializer.Serialize(Console.Out, m_widget1);

            //-----------------------------------------------------------------------------
            Console.WriteLine("3. Serialize widget1 to xml file {0}", fName);
            //----------------------------------------------------------------------------
            using (TextWriter tw = File.AppendText(fName))
            {
                xmlSerializer.Serialize(tw, m_widget1);
            }
            
            //-----------------------------------------------------------------------------
            Console.WriteLine("fXml_Write_END");
            //-----------------------------------------------------------------------------
        }
        static void fXml_Read(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fXml_Read_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Serialize widget2 from xml file {0}", fName);
            //----------------------------------------------------------------------------
            XmlSerializer xmlSerializer = new XmlSerializer(m_widget2.GetType());
            using (Stream sr = new FileStream(fName, FileMode.Open))
            {
                m_widget2 = (WidgetObject)xmlSerializer.Deserialize(sr);
            }

            //-----------------------------------------------------------------------------
            Console.WriteLine("2. Output widget2 to screen ->");
            //----------------------------------------------------------------------------
            xmlSerializer.Serialize(Console.Out, m_widget1);

            //-----------------------------------------------------------------------------
            Console.WriteLine("fXml_Read_END");
            //-----------------------------------------------------------------------------
        }
    }
}
