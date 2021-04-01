using System;
using Newtonsoft.Json;

public abstract class IMock
{
    public enum RunType { SUCCESS = 0, EXCEPTION = 1 };
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
    public abstract int Verify { set; }
    [JsonProperty("throws")]
    public abstract RunType Throws { set; }
    [JsonProperty("arrange")]
    public abstract RunType Arrange { set; }
    [JsonProperty("test")]
    public abstract RunType Test { set; }
    [JsonProperty("assert")]
    public abstract RunType Assert { set; }
}
