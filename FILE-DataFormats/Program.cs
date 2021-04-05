using System;
using Conductus.WIDGET.Exception;  // Widget exception
using Conductus.EXCEPTION.Model.Core;
using Conductus.EXTENSION.Model.Core;

namespace Conductus.FILE.Dataformats
{
    class Program
    {
        private static readonly string s = string.Empty;

        // Global objects that will be used throughout the various types of files and objects
        // A source object
        static Widget m_widget1 = new Widget()
        {
            Date = DateTimeOffset.Now,
            Name = "Widget1",
            Count = 99,
            Secret = "Widget 1 Secret"
        };

        // An empty destination object
        static Widget m_widget2 = new Widget();
        static void Main(string[] args)
        {
            // Directory.GetCurrentDirectory()
            string root = "C:\\Users\\steve\\Documents\\Visual Studio Work\\INFRASTRUCTURE\\FILE-DataFormats\\";

            // Display the reference widget to play with
            Console.WriteLine(m_widget1.Display(nameof(m_widget1)));

            Console.WriteLine(s.Div());
            Console.WriteLine("1. STREAM Files");
            Console.WriteLine(s.Div());
            
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
            Console.WriteLine(s.Div());
            Console.WriteLine("2. TEXT Files");
            Console.WriteLine(s.Div());

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

            Console.WriteLine(s.Div());
            Console.WriteLine("3. CSV Files");
            Console.WriteLine(s.Div());

            try
            {
                string csvFileName = "csv.csv";
                DataFileCsv fc = new DataFileCsv();

                // Create file to store widget
                fc.Create(root + csvFileName);

                // Write widget to file
                fc.Write(root + csvFileName, m_widget1);

                // Read the widget back from the file
                m_widget2 = fc.Read(root + csvFileName);

                Console.WriteLine(m_widget2.Display(nameof(m_widget2)));

                // Read back saved widget as bytes
                byte[] buf = new byte[1024];
                buf = fc.ReadBytes(root + csvFileName);

                // Read back saved widget as string
                string s = fc.ReadString(root + csvFileName);
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

            Console.WriteLine(s.Div());
            Console.WriteLine("4. JSON Files");
            Console.WriteLine(s.Div());

            try
            {

                string jsonFileName = "csv.csv";
                DataFileJson fj = new DataFileJson();

                // Create file to store widget
                fj.Create(root + jsonFileName);

                // Write widget to file
                fj.Write(root + jsonFileName, m_widget1);

                // Read the widget back from the file
                m_widget2 = fj.Read(root + jsonFileName);

                Console.WriteLine(m_widget2.Display(nameof(m_widget2)));

                // Read back saved widget as bytes
                byte[] buf = new byte[1024];
                buf = fj.ReadBytes(root + jsonFileName);

                // Read back saved widget as string
                string s = fj.ReadString(root + jsonFileName);
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

            Console.WriteLine(s.Div());
            Console.WriteLine("4. XML Files");
            Console.WriteLine(s.Div());

            try
            {
                //string xmlFileName = "XML.xml";
                DataFileXml fx = new DataFileXml();

                //fx.Create(root + xmlFileName);
                //fx.Write(root + xmlFileName, m_widget1);
                //m_widget2 = fx.Read(root + xmlFileName);
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

            Console.WriteLine(s.Div());
            Console.WriteLine("99. ALL DONE");
            Console.WriteLine(s.Div());
        }
    }
}
