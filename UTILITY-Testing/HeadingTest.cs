using System;
using System.Collections.Generic;
using System.Text;

namespace UTILITY_Testing
{
    public class HeadingTest: ExampleBase
    {
        public HeadingTest()
        {
            this.Title = "HeadingTest";
            this.Go("Simple formatted Message");
        }
        protected override void Run()
        {
            HeadingExample h = new HeadingExample();

            MessageLine("Use some Headings in a formated string");

            Message (h.s());
        }
    }
}
