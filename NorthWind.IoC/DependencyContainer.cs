namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
	public static IServiceCollection AddNorthWindServices(
		this IServiceCollection services)
	{
		services.AddDebugWriter();
		services.AddConsoleWriter();
		services.AddServices();
		services.AddFileWriter();
		return services;
	}


}
