// Based on https://www.tutorialsteacher.com/csharp/csharp-extension-method

/*
    * The IsGreaterThan() method is not a method of int data type (Int32 struct). It is an 
    * extension method written by the programmer for the int data type. The IsGreaterThan() 
    * extension method will be available throughout the application by including the namespace 
    * in which it has been defined.
    */

public static class IntExtensions
{
    public static bool IsGreaterThan(this int i, int value)
    // notice 1st parameter is the type that this extension method operates on
    {
        return i > value;
    }
}
