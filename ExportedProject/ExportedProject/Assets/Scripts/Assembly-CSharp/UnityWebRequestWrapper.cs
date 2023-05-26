using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Networking;

public class UnityWebRequestWrapper : IWebRequest, IDisposable
{
	private UnityWebRequest unityWebRequest;

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

	public UnityWebRequestWrapper(string url)
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
}
