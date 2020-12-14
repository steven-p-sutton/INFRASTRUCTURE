public class ExampleExample : ExampleBase
{
    public ExampleExample()
    {
        this.Title = "ExampleExample";
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
