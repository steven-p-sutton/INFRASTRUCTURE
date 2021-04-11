using System;
using Moq;
using Conductus.MOCK.Model.Core;

namespace Conductus.MOCK.Example
{
    public class MExample: IMock
    {
        public Mock<Example> _mMock;
        public MExample()
        {
            _mMock = new Mock<Example>();
        }
        public Mock<Example> Mock
        {
            get => _mMock;
        }
        public override bool Returns
        {
            set
            {
                if (this.Run == RunType.SUCCESS)

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
                if (this.Run == RunType.SUCCESS)

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
                    if (this.Run == RunType.EXCEPTION)
                        _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());

                    else if (this.Run == RunType.SUCCESS)
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
                    if (this.Run == RunType.EXCEPTION)

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
                if (this.Run == RunType.SUCCESS)
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
                else; // TBD
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
                else; // TBD
            }
        }
    }
}
