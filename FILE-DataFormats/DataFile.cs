using Conductus.Widget.Object;

namespace Conductus.FILE
{
    public abstract class DataFile
    {
        public abstract void Create(string fName);
        public abstract void Write(string fName, WidgetObject widget);
        public abstract WidgetObject Read(string fName);
    }
}
