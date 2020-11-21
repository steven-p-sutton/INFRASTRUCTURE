namespace Conductus.FILE
{
    abstract class DateFile
    {
        public abstract void Create(string fName);
        public abstract void Write(string fName);
        public abstract void Read(string fName);
    }
}
