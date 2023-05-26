using System;

public static class ExceptionExtensions
{
	public static bool IsDiskFullException(this Exception exception)
	{
		return false;
	}

	public static void ShowOutOfSpacePopup(Action callback)
	{
	}

	public static bool HandleDiskFullException(this Exception exception, Action callback = null)
	{
		return false;
	}
}
