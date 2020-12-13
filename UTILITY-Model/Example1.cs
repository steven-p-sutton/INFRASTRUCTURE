using System.Collections.Generic;
using System.Linq;


public class Example1 : ExampleBase
{
    protected override void Run()
    {
        MessageLine("Pre-loop message");

        MessageLine("Loop message");
        for (int i = 0; i < 10; i++)
        {
            Message((i + " "));
        }

        MessageLine("Post-loop message");
    }
}
