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
            string root = "C:\\Users\\steve\\Documents\\Visual Studio Work\\FILE-DataFormats\\";

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("1. STREAM Files");
            Console.WriteLine("--------------------------------------------------------------------");

            string streamFileName = "Stream.txt";
            StreamDateFile f = new StreamDateFile();
            f.Create(root + streamFileName);
            f.Write(root + streamFileName, m_widget1);
            f.Read(root + streamFileName);

            //fStream_Create(root + streamFileName);
            //fStream_Write(root + streamFileName);
            //fStream_Read(root + streamFileName);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("2. TEXT Files");
            Console.WriteLine("--------------------------------------------------------------------");

            string textFileName = "Text.txt";

            fText_Create(root + textFileName);
            fText_Write(root + textFileName);
            fText_Read(root + textFileName);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("3. CSV Files");
            Console.WriteLine("--------------------------------------------------------------------");

            string csvFileName = "Csv.csv";

            fCsv_Create(root + csvFileName);
            fCsv_Write(root + csvFileName);
            fCsv_Read(root + csvFileName);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("4. JSON Files");
            Console.WriteLine("-------------------------------------------------------------------");

            string jsonFileName = "Json.json";

            fJson_Create(root + jsonFileName);
            fJson_Write(root + jsonFileName);
            fJson_Read(root + jsonFileName);

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


        static void fStream_Create(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fStream_Create-START");
            //-----------------------------------------------------------------------------
            // Delete the file if it exists.
            if (File.Exists(fName))
            {
                File.Delete(fName);
            }
 
            //-----------------------------------------------------------------------------
            Console.WriteLine("Create the file - could use OpenWrite");
            //-----------------------------------------------------------------------------
            using (FileStream fs = File.Create(fName))
            {
            }
            //-----------------------------------------------------------------------------
            Console.WriteLine("fStream_Create-END");
            //-----------------------------------------------------------------------------
        }
        static void fStream_Write(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fStream_Write-START");
            //-----------------------------------------------------------------------------
            using (FileStream fs = File.OpenWrite(fName))
            {
                // Write Widget raw bytes to stream file, no formatting etc
                AddText(fs, m_widget1.Date.ToString());
                AddText(fs, m_widget1.TemperatureC.ToString());
                AddText(fs, m_widget1.Summary);
            }
            //-----------------------------------------------------------------------------
            Console.WriteLine("fStream_Write-END");
            //-----------------------------------------------------------------------------
        }
        static void fStream_Read(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fStream_Read-START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Open the stream and read it back");
            //-----------------------------------------------------------------------------
            using (FileStream fs = File.OpenRead(fName))
            {
                //-------------------------------------------------------------------------
                Console.WriteLine("2. Write the text lines to the screen");
                //-------------------------------------------------------------------------
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
            //-----------------------------------------------------------------------------
            Console.WriteLine("fStream_Read-END");
            //-----------------------------------------------------------------------------
        }
        static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        
        //=================================================================================================
        // TEXT
        //=================================================================================================
        // https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader?view=netcore-3.1
        // https://www.pluralsight.com/guides/declaring-and-initializing-variables-in-c

        static void fText_Create(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fText_Create-START");
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
            Console.WriteLine("fText_Create-END");
            //-----------------------------------------------------------------------------
        }
        static void fText_Write(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fText_Write-START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Write the object to the new text stream");
            //-----------------------------------------------------------------------------
            using (StreamWriter sw = File.AppendText(fName))
            {
                sw.WriteLine(m_widget1.Date.ToString());
                sw.WriteLine(m_widget1.TemperatureC.ToString());
                sw.WriteLine(m_widget1.Summary.ToString());
            }
            //-----------------------------------------------------------------------------
            Console.WriteLine("fText_Write-END");
            //-----------------------------------------------------------------------------
        }
        static void fText_Read(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fText_Read_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Read the text lines from the text stream");
            //-----------------------------------------------------------------------------
            using (StreamReader sr = File.OpenText(fName))
            {
                //-------------------------------------------------------------------------
                Console.WriteLine("2. Write the bytes to the screen");
                //-------------------------------------------------------------------------
                string s = String.Empty;

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            //-----------------------------------------------------------------------------
            Console.WriteLine("fText_Read_END");
            //-----------------------------------------------------------------------------
        }

        //=================================================================================================
        // CSV
        //=================================================================================================
        // using Microsoft.VisualBasic.FileIO; // VB !!!! 
        //     TextFieldParser
        // https://thecodebuzz.com/read-csv-file-in-net-core/
        // https://thecodebuzz.com/read-csv-file-in-net-core-textfieldparser/
        // https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

        static void fCsv_Create(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fCsv_Create_START");
            //-----------------------------------------------------------------------------
            //-----------------------------------------------------------------------------
            Console.WriteLine("fCsv_Create_END");
            //-----------------------------------------------------------------------------
        }
        static void fCsv_Write(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fCsv_Write_START");
            //-----------------------------------------------------------------------------
            //-----------------------------------------------------------------------------
            Console.WriteLine("fCsv_Write_END");
            //-----------------------------------------------------------------------------
        }
        static void fCsv_Read(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fCsv_Read_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Read csv file into DataTable");
            //-----------------------------------------------------------------------------
            DataTable csvData = ReadCSVFile(fName);

            //-----------------------------------------------------------------------------
            Console.WriteLine("2. Display DataTable to screen");
            //-----------------------------------------------------------------------------
            DisplayDataTable(csvData);

            //-----------------------------------------------------------------------------
            Console.WriteLine("fCsv_Read_END");
            //-----------------------------------------------------------------------------
        }
        private static DataTable ReadCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields;

                    bool tableCreated = false;
                    //Console.WriteLine("Columns");

                    while (tableCreated == false)
                    {
                        colFields = csvReader.ReadFields();

                        foreach (string column in colFields)
                        {
                            //Console.Write(column + " ");

                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        //Console.WriteLine();

                        tableCreated = true;
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] colData = csvReader.ReadFields();
                        /*
                        foreach (string value in colData)
                        {
                            Console.Write(value + " ");
                        }
                        Console.WriteLine();
                        */
                        csvData.Rows.Add(colData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return csvData;
        }
        private static void DisplayDataTable(DataTable myData)
        {
            // Column Headings
            for (int x = 0; x < myData.Columns.Count; x++)
            {
                Console.Write(myData.Columns[x].Caption + " ");
            }
            // Row Data
            foreach (DataRow row in myData.Rows)
            {
                Console.WriteLine();
                for (int x = 0; x < myData.Columns.Count; x++)
                {
                    Console.Write(row[x].ToString() + " ");
                }
            }
            Console.WriteLine();
        }

        //=================================================================================================
        // JSON
        //=================================================================================================
        //using System.Text.Json; // JSON handling
        //    JsonSerializer.Serialize
        //    JsonSerializer.Deserialize
        // https://dotnetcoretutorials.com/2019/09/11/how-to-parse-json-in-net-core/
        // https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

        static void fJson_Create(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fJson_Create_START");
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
            //Console.WriteLine("2. Serialize widget1 to JsonWidgetString1 & output on screen ->");
            //-----------------------------------------------------------------------------
            //string jsonWidgetString1 = JsonSerializer.Serialize(m_widget1);
            //Console.WriteLine(jsonWidgetString1);
            //Console.WriteLine(string.Empty);

            //-----------------------------------------------------------------------------
            Console.WriteLine("fJson_Create_END");
            //-----------------------------------------------------------------------------
        }
        static void fJson_Write(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fJson_Write_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("1. Setup widget1 to serialize");
            //-----------------------------------------------------------------------------
            // Declared & initiazed at top of program

            //-----------------------------------------------------------------------------
            Console.WriteLine("2. Write JsonWidgetString1 to a file {0}", fName);
            //-----------------------------------------------------------------------------
            string jsonWidgetString1 = JsonSerializer.Serialize(m_widget1);
            File.WriteAllText(fName, jsonWidgetString1);

            //-----------------------------------------------------------------------------
            Console.WriteLine("fJson_Write_END");
            //-----------------------------------------------------------------------------
        }
        static void fJson_Read(string fName)
        {
            //-----------------------------------------------------------------------------
            Console.WriteLine("fJson_Read_START");
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            Console.WriteLine("4. Read JsonWidgetString2 from file {0}->", fName);
            //-----------------------------------------------------------------------------
            string jsonWidgetString2 = File.ReadAllText(fName);
            Console.WriteLine(jsonWidgetString2);

            //-----------------------------------------------------------------------------
            Console.WriteLine("5. Deserialize JsonWidgetString2 into widget2");
            //-----------------------------------------------------------------------------
            m_widget2 = JsonSerializer.Deserialize<WidgetObject>(jsonWidgetString2);

            //-----------------------------------------------------------------------------
            Console.WriteLine("6. Output widget2 to screen -> ");
            //-----------------------------------------------------------------------------
            string s = JsonSerializer.Serialize(m_widget2);
            Console.WriteLine("{0}", s);

            //-----------------------------------------------------------------------------
            Console.WriteLine("fJson_Read_END");
            //-----------------------------------------------------------------------------
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
