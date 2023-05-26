using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

public class HttpWebRequestWrapper : IWebRequest, IDisposable
{
	private bool isDone;

	private bool isError;

	private HttpWebRequest httpWebRequest;

	private byte[] requestBodyBytes;

	private HttpWebResponse httpWebResponse;

	private Dictionary<string, string> responseHeaders;

	private byte[] responseBytes;

	private string responseString;

	private bool originalResponseStreamWasUsed;

	private string webExceptionMessage;

	private Action responseCallback;

	public string Url
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Method
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ContentType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsDone => false;

	public bool IsError => false;

	public string Error => null;

	public long ResponseCode => 0L;

	public long ResponseContentLength => 0L;

	public string ResponseText => null;

	public byte[] ResponseBytes => null;

	public Stream ResponseStream => null;

	public HttpWebRequestWrapper(string url)
	{
	}

	public void Dispose()
	{
	}

	public void SetRequestHeader(string name, string value)
	{
	}

	public void SetRequestContent(string content)
	{
	}

	public void SetRequestContent(byte[] bytes)
	{
	}

	public void Send(Action responseCallback)
	{
	}

	public void Send()
	{
	}

	public void Abort()
	{
	}

	public Dictionary<string, string> GetResponseHeaders()
	{
		return null;
	}

	private void OnGetRequestStreamResult(IAsyncResult result)
	{
	}

	private void OnGetResponseResult(IAsyncResult result)
	{
	}

	private void SendResponseCallback()
	{
	}
}
