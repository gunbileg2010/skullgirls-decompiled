using System;

public static class LineBindingIOS
{
	public class MonoPInvokeCallbackAttribute : Attribute
	{
		public Type type;

		public MonoPInvokeCallbackAttribute(Type t)
		{
		}
	}

	public delegate void LoginResultDelegate(int result, string message);

	private static Action<int, string> loginCallback;

	public static void Init(string channelId)
	{
	}

	public static void Login(Action<int, string> callback)
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

	private static void OnLoginResult(int result, string message)
	{
	}
}
