namespace Conductus.EXAMPLE.Model
{
    /// <summary>
    /// RunType - A means to partition the stages of the object semantics. 
    /// IMock.IRunType contains SUCCESS = 0 & EXCPTION = 1 properties so we can add some 
    /// specific ones applicable to out Mock object
    /// </summary>
    public class RunType : IRunType
    {
        public static int FAIL_Add { get { return -1; } }
        public static int FAIL_Find { get { return -2; } }
        public static int FAIL_Remove { get { return -3; } }
    }
}
