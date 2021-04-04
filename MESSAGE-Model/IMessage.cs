using System.IO;

public interface IMessage
{
    public string Title { get; set; }
    public TextWriter Output { get; set; }
    public string MessageGo(string message);
    public string MessageBegin(string message);
    public string MessageEnd(string message);
    public string MessageLine(string message);
    public string MessageOut(string message);
}
