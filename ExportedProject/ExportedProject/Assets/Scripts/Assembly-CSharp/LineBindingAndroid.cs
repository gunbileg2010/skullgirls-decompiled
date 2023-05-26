using System;
using UnityEngine;

public static class LineBindingAndroid
{
	public class LineLoginCallback : AndroidJavaProxy
	{
		private Action<int, string> callback;

		public LineLoginCallback(Action<int, string> callback)
			: base((string)null)
		{
		}

		public void onResult(int result, string message)
		{
		}
	}

	private const string kBindingClass = "com.hiddenvariable.linelogin.LineLoginBinding";

	private static AndroidJavaClass unity;

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

	private static AndroidJavaObject GetUnityActivity()
	{
		return null;
	}
}
