using System;
using Conductus.Widget.Exceptions;  // Widget exception

namespace Conductus.FILE.ConsoleApp
{
    class Program
    {
        // Global objects that will be used throughout the various types of files and objects
        // A source object
        static WidgetObject m_widget1 = new WidgetObject()
        {
            Date = DateTimeOffset.Now,
            Name = "Widget1",
            Count = 99,
            Secret = "Widget 1 Secret"
        };

        // An empty destination object
        static WidgetObject m_widget2 = new WidgetObject();
        static void Main(string[] args)
        {
            // Directory.GetCurrentDirectory()
            string root = "C:\\Users\\steve\\Documents\\Visual Studio Work\\INFRASTRUCTURE\\FILE-DataFormats\\";

            // Display the reference widget to play with
            Console.WriteLine(m_widget1.Display(nameof(m_widget1)));

            Console.WriteLine(Heading.Div);
            Console.WriteLine("1. STREAM Files");
            Console.WriteLine(Heading.Div);
            
            try
            {
                string streamFileName = "Stream.txt";
                DataFileStream fs = new DataFileStream();

                // Create file to store widget
                fs.Create(root + streamFileName);

                // Write widget to file
                fs.Write(root + streamFileName, m_widget1);

                // Read the widget back from the file
                m_widget2 = fs.Read(root + streamFileName);

                Console.WriteLine(m_widget2.Display(nameof(m_widget2)));

                // Read back saved widget as bytes
                byte[] buf = new byte[1024];
                buf = fs.ReadBytes(root + streamFileName);

                // Read back saved widget as string
                string s = fs.ReadString(root + streamFileName);
            }
            catch (WidgetNotImplentedException e)
            {
                // Format using custom excdeptions format method
                Console.WriteLine(e.Display());
            }
            catch (System.Exception e)
            {
                // Standard system execption, just format by hand
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(Heading.Div);
            Console.WriteLine("2. TEXT Files");
            Console.WriteLine(Heading.Div);

            try
            {
                string textFileName = "Text.txt";
                DataFileText ft = new DataFileText();

                // Create file to store widget
                ft.Create(root + textFileName);

                // Write widget to file
                ft.Write(root + textFileName, m_widget1);

                // Read the widget back from the file
                m_widget2 = ft.Read(root + textFileName);

                Console.WriteLine(m_widget2.Display(nameof(m_widget2)));

                // Read back saved widget as bytes
                byte[] buf = new byte[1024];
                buf = ft.ReadBytes(root + textFileName);

                // Read back saved widget as string
                string s = ft.ReadString(root + textFileName);
            }
            catch (WidgetNotImplentedException e)
            {
                // Format using custom excdeptions format method
                Console.WriteLine(e.Display());
            }
            catch(System.Exception e)
            {
                 // Standard system execption, just format by hand
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(Heading.Div);
            Console.WriteLine("3. CSV Files");
            Console.WriteLine(Heading.Div);

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

            Console.WriteLine(Heading.Div);
            Console.WriteLine("4. JSON Files");
            Console.WriteLine(Heading.Div);

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

            Console.WriteLine(Heading.Div);
            Console.WriteLine("4. XML Files");
            Console.WriteLine(Heading.Div);

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

            Console.WriteLine(Heading.Div);
            Console.WriteLine("99. ALL DONE");
            Console.WriteLine(Heading.Div);
        }
    }
}
