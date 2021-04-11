using System;
using Newtonsoft.Json;

public abstract class IMock
{
    /// <summary>
    /// RunType - A means to partition the stages of the object semantics. 
    /// Since used only in the derrived object it can be declared withing the object with object specific names
    /// Used within the overriden properties to set such things as Verify times, return values & exceptions raised
    /// for non-success scenarios
    /// </summary>
    public enum RunType { SUCCESS = 0, EXCEPTION = 1, ONE = -1, TWO = -2, THREE = -3, FOUR = -4, FIVE = -5, SIX = -6, SEVEN = -7, EIGHT = -8, NINE = -9};
    /// <summary>
    /// Set to allow the semantics to be chnaged according to the path required within the mock object simiulating the 
    /// real object's behaviour
    /// </summary>
    [JsonProperty("run")] 
    public RunType Run { set; get; }
    /// <summary>
    /// Exception we expect to get when run. Compared with acutal in Assert for test
    /// </summary>
    [JsonProperty("exceptionExpected")]
    public Exception ExceptionExpected { set; get; }
    /// <summary>
    /// Exception we got when run. Compared with expected in Assert for test
    /// </summary>
    [JsonProperty("exceptionRaised")]
    public Exception ExceptionRaised { set; get; }
    [JsonProperty("verifyable")]
    public abstract bool Verifyable { set; }
    public abstract bool Returns { set; }
    [JsonProperty("returnsAsync")]
    public abstract bool ReturnsAsync { set; }
    [JsonProperty("verify")]
    public abstract bool Verify { set; }
    [JsonProperty("throws")]
    public abstract bool Throws { set; }
    [JsonProperty("throws")]
    public abstract bool Arrange { set; }
    [JsonProperty("test")]
    public abstract bool Test { set; }
    [JsonProperty("assert")]
    public abstract bool Assert { set; }
}
