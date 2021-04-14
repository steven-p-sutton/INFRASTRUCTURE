/// <summary>
/// RunType - A means to partition the stages of the object semantics. 
/// IMock.IRunType contains SUCCESS = 0 & EXCPTION = 1 properties so we can add some 
/// specific ones applicable to out Mock object
/// </summary>
public class RunType : IRunType
{
    public static int FAIL_GetDateOfJoining { get { return -1; } }
}
