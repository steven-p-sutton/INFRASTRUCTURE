static public class ExceptionUtility
{
    static public string Display(System.Exception e, string Name)
    {
        string s = ""; ;  
            s = s + s.CRLF
            + s.H3 
            + s.Pad 
            + "Name:" + Name 
            + s.Pad 
            + s.H3 
            + s.CRLF
            + "       Message:" 
            + e.Message 
            + s.CRLF;
        //s = s + " InnerExeption:" + e.InnerException.ToString() + Environment.NewLine;
        return s;
    }
}