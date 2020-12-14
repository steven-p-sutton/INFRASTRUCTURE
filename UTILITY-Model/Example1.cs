public class Example1 : ExampleBase
{
    public Example1()
    {
        this.Title = "Example1";
    }
    protected override void Run()
    {
        MessageLine("Preamble before code");

        MessageLine("Code");
        for (int i = 0; i < 10; i++)
        {
            Message((i + " "));
        }

        MessageLine("Post after code");
    }
}
