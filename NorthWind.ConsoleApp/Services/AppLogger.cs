namespace NorthWind.ConsoleApp.Services
{
	internal class AppLogger(IUserActionWriter writer)
	{
		public void WriteLog(string message)
		{
			UserAction Log = new UserAction("System", message);
			writer.Write(Log);
		}
	}
}
