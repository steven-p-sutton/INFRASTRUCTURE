// Based on https://www.tutorialsteacher.com/csharp/csharp-extension-method

/*
    * The IsGreaterThan() method is not a method of int data type (Int32 struct). It is an 
    * extension method written by the programmer for the int data type. The IsGreaterThan() 
    * extension method will be available throughout the application by including the namespace 
    * in which it has been defined.
    */

public static class RunTypeExtensions
{
    public static int ToInt(this IMock.RunType runType)
    // notice 1st parameter is the type that this extension method operates on
    {
        return (int)runType;
    }
    public static string ToString(this IMock.RunType runType)
    {
        return runType.ToString();
    }
    public static IMock.RunType Next(this IMock.RunType runType)
    {
        return runType++;
    }
    public static IMock.RunType Previous(this IMock.RunType runType)
    {
        return runType--;
    }
}
