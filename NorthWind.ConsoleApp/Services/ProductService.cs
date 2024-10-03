using NorthWind.Entities.ValueObjects;

namespace NorthWind.ConsoleApp.Services
{
	internal class ProductService(IUserActionWriter writer)
	{
		public void Add(String user, string productName)
		{
			UserAction Action = new UserAction(user, $"Created: {productName}");
			writer.Write(Action);
		}
	}
}
