using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreIOCDummyTest
{
    public class A : IA
    {
	    private readonly IB _b;

	    public A(IB b)
	    {
		    _b = b;
	    }

	    public int MyMethod()
	    {
			return _b.DependentMethod();
		}
	}
}
