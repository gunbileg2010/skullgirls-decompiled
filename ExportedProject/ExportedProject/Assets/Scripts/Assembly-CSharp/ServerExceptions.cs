using System.Collections.Generic;

public static class ServerExceptions
{
	private static Dictionary<string, ServerExceptionCode> exceptionLookup;

	public static ServerExceptionCode GetServerExceptionCodeForStringCode(string errorCode)
	{
		return default(ServerExceptionCode);
	}

	public static string GetStringCodeForServerExceptionCode(ServerExceptionCode code)
	{
		return null;
	}

	public static bool IsExpectedServerException(ServerExceptionCode code)
	{
		return false;
	}
}
