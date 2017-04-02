using DotNetCoreIOCDummyTest;
using Moq;
using Xunit;

namespace UnitTests
{
    public class TestClassA
    {
		[Fact]
	    public void ClassATest1()
		{
			var mockedB = new Mock<IB>();
			mockedB.Setup(b => b.DependentMethod()).Returns(3);

			var a = new A(mockedB.Object);

			Assert.Equal(3, a.MyMethod());
		}
    }
}
