namespace NorthWind.ConsoleApp.Services
{
	internal class ProductService(IUserActionWriter writer) : IProductService
	{
		public void Add(String user, string productName)
		{
			UserAction Action = new UserAction(user, $"ProductServices: {productName}");
			writer.Write(Action);
		}
	}
}
