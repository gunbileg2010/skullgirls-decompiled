using System;
using System.Collections.Generic;
using System.IO;

public class HttpResponse : IDisposable
{
	private HttpRequest responseTo;

	private IWebRequest webRequest;

	private bool didTimeOut;

	private long responseCode;

	private Dictionary<string, string> _responseHeaders;

	private string responseBodyText;

	private Dictionary<string, object> responseDataAsDict;

	private HttpEncoding expectedResponseEncoding;

	private Dictionary<string, string> ResponseHeaders => null;

	public HttpResponse(HttpRequest request, bool timedOut)
	{
	}

	public HttpResponse(HttpRequest request, long responseCode, bool timedOut)
	{
	}

	public HttpResponse(long responseCode, Dictionary<string, string> responseHeaders = null, Dictionary<string, object> responseData = null)
	{
	}

	public void Dispose()
	{
	}

	public bool DidCommunicationSucceed()
	{
		return false;
	}

	public bool TimedOut()
	{
		return false;
	}

	public bool IsError()
	{
		return false;
	}

	public long GetResponseCode()
	{
		return 0L;
	}

	public long GetContentLength()
	{
		return 0L;
	}

	public string TryGetHeader(string key, string defaultValue = null)
	{
		return null;
	}

	public string GetBodyText()
	{
		return null;
	}

	public Stream GetResponseStream()
	{
		return null;
	}

	public void GenerateResponseDataDictionaryOnBackgroundThread(HttpManager.LogLevel logLevel, Action callback)
	{
	}

	public Dictionary<string, object> GetResponseDataDictionary()
	{
		return null;
	}

	public T TryGet<T>(string key, T defaultValue = default(T))
	{
		return default(T);
	}

	public string GetUrl()
	{
		return null;
	}

	public void OutputToLog(HttpManager.LogLevel logLevel = HttpManager.LogLevel.Everything)
	{
	}

	private string DecodeResponseBodyText()
	{
		return null;
	}
}
