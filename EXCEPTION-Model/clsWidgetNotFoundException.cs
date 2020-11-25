public class WidgetNotFoundException : System.Exception
{
    public WidgetNotFoundException()
    {
    }
    public WidgetNotFoundException(string message)
        : base(message)
    {
    }
    public WidgetNotFoundException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {
        return ExceptionUtility.Display(this, "WidgetNotFoundException");
    }
}
