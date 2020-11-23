// A general class that is used to hold data and strctures for examples.
// Defines so that examples can interchange data & ideas
// 
// Files for CSV, XML, JSON, TEXT, ... and memory DataTables, database tables, 
// spreadsheets etc, Web pages, API, MVC, ADO etc 

using System;
using Conductus.UTILITY.Heading;

namespace Conductus.Widget.Object
{
    // Instance Examples (psate into your code)

    // Tuple assigned values

    // static Widget m_widget1 = new Widget()
    // {
    //    Date = DateTimeOffset.Now,
    //    TemperatureC = 32,
    //    Summary = "Test 1 summary"
    // };

    // Empty values

    // An empty destination object
    // static Widget m_widget2 = new Widget();

    // Constructor assigned values 

    // static Widget m_widget3 = new Widget(DateTimeOffset.Now, 32, "Summary3");

    // https://www.w3schools.com/cs/cs_constructors.asp

    public class WidgetDTO
    {
        // Default (optional) do nothing
        public WidgetDTO()
        {
        }
        // Create a class constructor with multiple parameters
        public WidgetDTO(DateTimeOffset date, int temperatureC, string summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }
        public WidgetDTO(WidgetObject widget)
        {
            Id = widget.Id;
            Date = widget.Date;
            TemperatureC = widget.TemperatureC;
            Summary = widget.Summary;
            // Secret NOT present in DTO
        }
        public string Display(string title)
        {
            string s = Environment.NewLine;
            s = s + Heading.H1 + " " + title + " " + Heading.H1 + Environment.NewLine;
            s = s + "          Id: " + this.Id.ToString() + Environment.NewLine;
            s = s + "        Date: " + this.Date.ToString() + Environment.NewLine;
            s = s + "TemperatureC: " + this.TemperatureC.ToString() + Environment.NewLine;
            s = s + "TemperatureF: " + this.TemperatureF.ToString() + Environment.NewLine;
            s = s + "     Summary: " + this.Summary.ToString() + Environment.NewLine;
            s = s + Environment.NewLine;
            return s;
        }
        public WidgetDTO WidgetToDTO(WidgetObject widget) => new WidgetDTO (widget);
        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556); // calculated
        public string Summary { get; set; }
    }
}
