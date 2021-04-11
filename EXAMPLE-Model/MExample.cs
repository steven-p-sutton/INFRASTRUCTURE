using System;
using Moq;

// IMock.cs has to be source file included in the EXAMPLE-Model shared code project
public class MExample : IMock
{
    /// <summary>
    /// RunType - A means to partition the stages of the object semantics. 
    /// Since used only in the derrived object it can be declared withing the object with object specific names
    /// Used within the overriden properties to set such things as Verify times, return values & exceptions raised
    /// for non-success scenarios
    /// </summary>
    public enum RunType { SUCCESS = 0, EXCEPTION = 1, FAIL_GetDateOfJoining = -1};

    public Mock<IExample> _mMock;
    public MExample()
    {
        _mMock = new Mock<IExample>();
    }
    public Mock<IExample> Mock
    {
        get => _mMock;
    }
    public override bool Returns
    {
        set
        {
            if (this.Run.ToString() == RunType.SUCCESS.ToString())

                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.Now);

            else
                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.MinValue);
        }
    }
    public override bool ReturnsAsync
    {
        set
        {
            if (this.Run.ToString() == RunType.SUCCESS.ToString())

                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));

            else
                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
        }
    }
    public override bool Verifyable
    {
        set
        {
            if (value)
                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                .Verifiable();
            else
                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
        }
    }
    public override bool Verify
    {
        set
        {
            if (value)
            {
                if (this.Run.ToString() == RunType.EXCEPTION.ToString())
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());

                else if (this.Run.ToString() == RunType.SUCCESS.ToString())
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());

                else if (this.Run.ToString() == RunType.FAIL_GetDateOfJoining.ToString())
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());

                else
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.AtLeastOnce); // TBD
            }
            else
                _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never()); // TBD
        }
    }
    public override bool Throws
    {
        set
        {
            if (value)
            {
                if (this.Run.ToString() == RunType.EXCEPTION.ToString())

                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                else
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
            }
        }
    }
    public override bool Arrange
    {
        set
        {
            if (this.Run.ToString() == RunType.SUCCESS.ToString())
            {
                this.Verifyable = true;
                this.Returns = true;
            }
            else
                this.Throws = value;
        }
    }
    public override bool Test
    {
        set
        {
            if (value)
            {
                Console.WriteLine(this.Mock.Object.GetDateOfJoining(1));
            }
        }
    }
    public override bool Assert
    {
        set
        {
            if (value)
            {
                this.Verify = true;
            }
        }
    }
}
