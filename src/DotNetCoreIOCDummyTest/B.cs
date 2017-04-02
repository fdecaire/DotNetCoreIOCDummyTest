using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreIOCDummyTest
{
    public class B : IB
    {
	    public int DependentMethod()
	    {
		    return 5;
	    }
    }
}
