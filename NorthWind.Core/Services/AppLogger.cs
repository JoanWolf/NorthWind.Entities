namespace NorthWind.ConsoleApp.Services
{
	internal class AppLogger(IEnumerable<IUserActionWriter> writers):IAppLogger
	{
		public void WriteLog(string message)
		{
			UserAction Log = new UserAction("AppLogger", message);
				foreach (var writer in writers) 
					writer.Write(Log);
				
		}

	}
}
