using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class NetworkRequest
{
	private static DateTime _serverTime;

	private static float lastRealtimeSinceStartup;

	private Action responseCallback;

	private bool succeeded;

	protected HttpResult result;

	protected long responseCode;

	private string errorCode;

	private string errorMessage;

	private ServerExceptionCode serverExceptionCode;

	protected bool raiseResponseDataEvent;

	protected bool skipMaintenanceModeCheck;

	public static DateTime ServerTime
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public static event Action<DateTime> NetworkTimeUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<Dictionary<string, object>> ResponseDataReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	static NetworkRequest()
	{
	}

	public virtual void Send(Action callback)
	{
	}

	public bool Succeeded()
	{
		return false;
	}

	public HttpResult GetResult()
	{
		return default(HttpResult);
	}

	public string GetErrorCode()
	{
		return null;
	}

	public string GetErrorMessage()
	{
		return null;
	}

	public ServerExceptionCode GetServerExceptionCode()
	{
		return default(ServerExceptionCode);
	}

	protected virtual void OnBackendResponse(HttpResponse response)
	{
	}

	protected virtual void OnBackendCommsError(HttpResponse response)
	{
	}

	protected void FinishRequest(bool requestSucceeded = true, HttpResponse response = null, string additionalInfo = null)
	{
	}

	protected void UpdateServerTimeFromResponse(HttpResponse response)
	{
	}

	public static string GetRequestFingerprint(HttpRequest request)
	{
		return null;
	}

	public static string GenerateRequestSignature(string endpoint, List<string> queries = null, string body = null)
	{
		return null;
	}

	protected bool HasValidResponseSignature(HttpResponse response)
	{
		return false;
	}

	private void LogError(HttpResponse response, string additionalInfo)
	{
	}
}
