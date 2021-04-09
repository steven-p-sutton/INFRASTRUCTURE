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
        public override int Verify
        {
            set
            {
                if (value == 0)
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
                else if (value == 1)
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
                else
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(value));
            }
        }
        public override RunType Throws
        {
            set
            {
                if (value == RunType.EXCEPTION)
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                else
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
            }
        }
        public override RunType Arrange
        {
            set
            {
                if (value == RunType.SUCCESS)
                {
                    this.Verifyable = true;
                    this.Returns = true;
                }
                else
                    this.Throws = value;
            }
        }
        public override RunType Test
        {
            set
            {
                Console.WriteLine(this.Mock.Object.GetDateOfJoining(1));
            }
        }
        public override RunType Assert
        {
            set
            {
                if (value == RunType.SUCCESS)
                    this.Verify = 1;
                else
                    this.Verify = 1;
            }
        }
    }
}
