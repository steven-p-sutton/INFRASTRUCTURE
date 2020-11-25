public class WidgetAlreadyExistsException : System.Exception
{
    public WidgetAlreadyExistsException()
    {
    }
    public WidgetAlreadyExistsException(string message)
        : base(message)
    {
    }
    public WidgetAlreadyExistsException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Display()
    {  
        return ExceptionUtility.Display(this, "WidgetAlreadyExistsException");
    }
}
