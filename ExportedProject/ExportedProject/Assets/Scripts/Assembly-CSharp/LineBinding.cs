using System;

public static class LineBinding
{
	public enum LoginResult
	{
		Success = 0,
		Failure = 1,
		Canceled = 2
	}

	private const int kCanceledResult = 1;

	public static void Init(string channelId)
	{
	}

	public static void Login(Action<LoginResult, string> callback)
	{
	}

	public static void Logout()
	{
	}

	public static bool IsLoggedIn()
	{
		return false;
	}

	public static string GetAccessToken()
	{
		return null;
	}
}
