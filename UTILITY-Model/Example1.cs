public class Example1 : ExampleBase
{
    public Example1()
    {
        this.Title = "102";
    }
    
    protected override void Run()
    {
        MessageLine("103");

        MessageLine("104");
        for (int i = 0; i < 10; i++)
        {
            Message((i + " "));
        }

        MessageLine("105");
    }
}
