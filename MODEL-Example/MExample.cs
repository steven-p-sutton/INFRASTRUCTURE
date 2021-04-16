using Moq;
//using Conductus.MOCK.Model.Core;

public class MExample : IMock
{
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
            if (value)
            {
                if (this.Run == RunType.EXCEPTION)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<string>()))
                    .Returns(string.Empty);

                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                     .Returns(int.MinValue);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Returns(int.MinValue);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Returns(string.Empty);
                }
                else
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<string>()))
                    .Returns("PING:");

                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                     .Returns(0);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Returns(0);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Returns("Mock");
                }
            }
            else
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));
            }
        }
    }
    public override bool ReturnsAsync
    {
        set
        {
            if (value)
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));
            }
            else
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));
            }
        }
    }
    public override bool Verifyable
    {
        set
        {
            if (value)
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()))
                .Verifiable();

                _mMock.Setup(x => x.Add(It.IsAny<string>()))
                .Verifiable();

                _mMock.Setup(x => x.Find(It.IsAny<string>()))
                .Verifiable();

                _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                .Verifiable();
            }
            else
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));
            }
        }
    }
    public override bool Verify
    {
        set
        {
            if (value)
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));

                if (this.Run == RunType.EXCEPTION)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
                }
                else if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
                }
                else if (this.Run == RunType.FAIL_Ping)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
                }
                else if (this.Run == RunType.FAIL_Add)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
                }
                else if (this.Run == RunType.FAIL_Find)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
                }
                else if (this.Run == RunType.FAIL_Remove)
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
                }
                else
                {
                    _mMock.Verify(x => x.Ping(It.IsAny<string>()), Times.AtLeastOnce());
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.AtLeastOnce());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.AtLeastOnce());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.AtLeastOnce());
                }
            }
            else
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));
            }
        }
    }
    public override bool Throws
    {
        set
        {
            if (value)
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));

                if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                    _mMock.Setup(x => x.Add(It.IsAny<string>()));
                    _mMock.Setup(x => x.Find(It.IsAny<string>()));
                    _mMock.Setup(x => x.Remove(It.IsAny<int>()));
                }
                else if (this.Run == RunType.EXCEPTION)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                }
                else if (this.Run == RunType.FAIL_Ping)
                {
                    _mMock.Setup(x => x.Ping(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);
                }
                else if (this.Run == RunType.FAIL_Add)
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);
                }
                else if (this.Run == RunType.FAIL_Find)
                {
                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);
                }
                else if (this.Run == RunType.FAIL_Remove)
                {
                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                }
            }
            else
            {
                _mMock.Setup(x => x.Ping(It.IsAny<string>()));
                _mMock.Setup(x => x.Add(It.IsAny<string>()));
                _mMock.Setup(x => x.Find(It.IsAny<string>()));
                _mMock.Setup(x => x.Remove(It.IsAny<int>()));
            }
        }
    }
    public override bool Arrange
    {
        set
        {
            this.Verifyable = value;
            this.Returns = value;
            this.Throws = value;
        }
    }
    public override bool Test
    {
        set
        {
            if (value)
            {
                this.Mock.Object.Ping("MExample.Test.Ping()");
                this.Mock.Object.Add("Item");
                this.Mock.Object.Remove(this.Mock.Object.Find("Item"));

                //if (this.Run == RunType.SUCCESS)
                //{
                //    this.Mock.Object.Ping("MExample.Test.Ping()");
                //    this.Mock.Object.Add("Item");
                //    this.Mock.Object.Remove(this.Mock.Object.Find("Item"));
                //}
                //else if (this.Run == RunType.EXCEPTION)
                //{
                //    this.Mock.Object.Ping("MExample.Test.Ping()");
                //    this.Mock.Object.Add("Item");
                //    this.Mock.Object.Remove(this.Mock.Object.Find("Item"));
                //}
                //else if (this.Run == RunType.FAIL_Ping)
                //{
                //    this.Mock.Object.Ping("MExample.Test.Ping()");
                //}
                //else if (this.Run == RunType.FAIL_Add)
                //{
                //    this.Mock.Object.Ping("MExample.Test.Ping()");
                //    this.Mock.Object.Add("Item");
                //}
                //else if (this.Run == RunType.FAIL_Find)
                //{
                //    this.Mock.Object.Ping("MExample.Test.Ping()");
                //    this.Mock.Object.Add("Item");
                //    this.Mock.Object.Find("Item");
                //}
                //else if (this.Run == RunType.FAIL_Remove)
                //{
                //    this.Mock.Object.Ping("MExample.Test.Ping()");
                //    this.Mock.Object.Add("Item");
                //    this.Mock.Object.Remove(this.Mock.Object.Find("Item"));
                //}
            }
        }
    }
    public override bool Assert
    {
        set
        {
            this.Verify = value;
        }
    }
}
