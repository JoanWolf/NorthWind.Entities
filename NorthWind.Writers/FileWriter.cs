﻿namespace NorthWind.Writers;

	public class FileWriter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
		File.AppendAllText("AppLogs.txt",
			string.Format("FileWriter: {0}, {1}, {2}",
			action.CreatedDatetime, action.User, action.Description));


	}
}

