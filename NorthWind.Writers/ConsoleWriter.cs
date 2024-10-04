namespace NorthWind.Writers
{
	internal class ConsoleWriter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
			Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
				action.CreatedDatetime, action.User, action.Description);
		}
	}
}
