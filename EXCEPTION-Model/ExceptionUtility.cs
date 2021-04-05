static public class ExceptionUtility
{
    static public string Display(System.Exception e, string Name)
    {
        string s = string.Empty;  
        s += s.CRLF()
        + s.H3() + s.Pad() + "Name:" + Name + s.Pad() + s.H3() 
        + s.CRLF()
        + s.Pad() +  "Message:" + e.Message 
        //+ s.CRLF()
        //+ s.Pad() + "InnerExeption:" + e.InnerException.ToString() 
        + s.CRLF();
        return s;
    }
}