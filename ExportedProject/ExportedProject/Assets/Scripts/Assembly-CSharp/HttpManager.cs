using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpManager : MonoBehaviour
{
	public enum LogLevel
	{
		None = 0,
		UrlAndCode = 1,
		UrlCodeAndHeaders = 2,
		Everything = 3
	}

	[SerializeField]
	private bool debug;

	[SerializeField]
	private LogLevel logLevel;

	[SerializeField]
	private LogLevel devLogLevel;

	[SerializeField]
	private LogLevel errorLogLevel;

	[SerializeField]
	private LogLevel editorLogLevel;

	[SerializeField]
	private float defaultTimeoutSeconds;

	[SerializeField]
	private bool forceNoNetwork;

	[SerializeField]
	private float artificialLagSeconds;

	private Dictionary<string, string> globalHeaderFields;

	private Dictionary<string, string> transactionMap;

	private static int transactionCounter;

	public void Send(HttpRequest request, Action<HttpResponse> callback)
	{
	}

	public void Send(HttpRequest request, Action<HttpResponse> successCallback, Action<HttpResponse> errorCallback)
	{
	}

	public void SetGlobalHeader(string key, string value)
	{
	}

	public void RemoveGlobalHeader(string key)
	{
	}

	public bool HasInternetConnection()
	{
		return false;
	}

	public void SetDebug(bool debug)
	{
	}

	public bool IsDebug()
	{
		return false;
	}

	public LogLevel GetLogLevel(bool isError)
	{
		return default(LogLevel);
	}

	public float GetDefaultTimeoutSeconds()
	{
		return 0f;
	}

	private IEnumerator DoSendRequest(HttpRequest httpRequest, Action<HttpResponse> callback, Action<HttpResponse> errorCallback)
	{
		return null;
	}

	private void SendResponseCallback(bool success, HttpResponse response, Action<HttpResponse> callback, Action<HttpResponse> errorCallback)
	{
	}

	private void SuppressWarnings()
	{
	}

	private string GenerateTransactionId()
	{
		return null;
	}
}
