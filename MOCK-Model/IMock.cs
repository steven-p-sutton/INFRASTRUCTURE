using System;
using Newtonsoft.Json;

public abstract class IMock
{
    public enum RunType { SUCCESS = 0, EXCEPTION = 1, EXCEPTION_01 = -1, EXCEPTION_02 = -2, EXCEPTION_03 = -3, EXCEPTION_04 = -4 };
    public enum VerifyTimes { NEVER = 0, ONCE = 1, EXACTLY = 3 };
    [JsonProperty("run")] 
    public RunType Run { set; get; }
    [JsonProperty("input")]
    public virtual bool Input { set; get; }
    [JsonProperty("output")]
    public virtual bool Output { set; get; }
    [JsonProperty("exceptionExpected")]
    public Exception ExceptionExpected { set; get; }
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
