namespace Conductus.FILE.Dataformats
{
    public abstract class DataFile
    {
        public abstract void Create(string fName);
        public abstract void Write(string fName, Widget widget);
        public abstract Widget Read(string fName);
        public abstract byte[] ReadBytes(string fName);
        public abstract string ReadString(string fName);
        //throw new NotImplementedException();
    }
}
