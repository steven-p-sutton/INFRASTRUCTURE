//=================================================================================================
// CSV
//=================================================================================================
// using Microsoft.VisualBasic.FileIO; // VB !!!! 
//     TextFieldParser
// https://thecodebuzz.com/read-csv-file-in-net-core/
// https://thecodebuzz.com/read-csv-file-in-net-core-textfieldparser/
// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

using System;
using System.IO;
using System.Text;
using System.Data;
using Microsoft.VisualBasic.FileIO; // VB !!!! 

namespace Conductus.FILE
{
    public class DataFileCsv : DataFile
    {
        public override void Create(string fName)
        {
        }
        public override void Write(string fName, WidgetObject widget)
        {
        }
        public override WidgetObject Read(string fName)
        {
            WidgetObject widget = new WidgetObject();

            DataTable csvData = ReadCSVFile(fName);
            DisplayDataTable(csvData);

            return new WidgetObject();
        }
        public override byte[] ReadBytes(string fName)
        {
            return new byte[0];
        }
        public override string ReadString(string fName)
        {
            return string.Empty;
        }
        private DataTable ReadCSVFile(string csv_file_path)
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
        private void DisplayDataTable(DataTable myData)
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
        private string DataTableField(DataTable myData, string name)
        {
            int i = 0;

            // Column Headings
            for (int x = 0; x < myData.Columns.Count; x++)
            {
                //Console.Write(myData.Columns[x].Caption + " ");
                if (String.Equals(myData.Columns[x].Caption, name))
                {
                    i = x;
                }
            }

            string s = String.Empty;

            // Row Data
            foreach (DataRow row in myData.Rows)
            {
                //    Console.WriteLine();
                //    for (int x = 0; x < myData.Columns.Count; x++)
                //    {
                //        //Console.Write(row[x].ToString() + " ");
                //    }
                s = row[i].ToString();
            }
            //Console.WriteLine();

            return s;
        }
    }
}
