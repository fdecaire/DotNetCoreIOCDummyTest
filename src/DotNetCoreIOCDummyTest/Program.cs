using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreIOCDummyTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
	        var serviceProvider = new ServiceCollection()
		        .AddSingleton<IB, B>()
		        .AddSingleton<IA, A>()
		        .BuildServiceProvider();

			var a = serviceProvider.GetService<IA>();
			a.MyMethod();
		}
    }
}
