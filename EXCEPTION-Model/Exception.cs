public class BaseException : System.Exception
{
    private string _Name = string.Empty;
    public BaseException()
    {
        this.Name = "Exception";
    }
    public BaseException(string message)
        : base(message)
    {
    }
    public BaseException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
    public string Name { get; set;}

    public virtual string Display()
    {
        string s = string.Empty;
        s += s.CRLF()
        + s.H3() + s.Pad() + "Name:" + this.Name + s.Pad() + s.H3()
        + s.CRLF()
        + s.Pad() + "Message:" + this.Message
        //+ s.CRLF()
        //+ s.Pad() + "InnerExeption:" + e.InnerException.ToString() 
        + s.CRLF();
        //return ExceptionUtility.Display(this, "BaseException");
        return s;
    }
}
