using System.Collections.Generic;

public class HttpRequest
{
	private HttpVerb verb;

	private string url;

	private Dictionary<string, List<string>> queries;

	private Dictionary<string, object> headerFields;

	private HttpContentType contentType;

	private Dictionary<string, object> parameters;

	private byte[] putData;

	private float timeout;

	private int retries;

	private IWebRequest webRequest;

	private bool debug;

	private HttpEncoding expectedResponseEncoding;

	private bool deserializeResponseBodyImmediately;

	public HttpRequest(HttpVerb verb = HttpVerb.Get)
	{
	}

	public HttpRequest(HttpVerb verb, string url)
	{
	}

	public void SetVerb(HttpVerb verb)
	{
	}

	public void SetUrl(string url)
	{
	}

	public string GetUrl()
	{
		return null;
	}

	public void SetHeader(string key, string value)
	{
	}

	public void AddQuery(string key, string value)
	{
	}

	public Dictionary<string, List<string>> GetQueries()
	{
		return null;
	}

	public void SetParameter(string key, object value)
	{
	}

	public void SetContentType(HttpContentType contentType)
	{
	}

	public void SetPutData(byte[] putData)
	{
	}

	public void SetTimeout(float timeout)
	{
	}

	public float GetTimeout()
	{
		return 0f;
	}

	public void SetRetries(int retries)
	{
	}

	public int GetRetries()
	{
		return 0;
	}

	public void SetDebug(bool debug)
	{
	}

	public bool IsDebug()
	{
		return false;
	}

	public void SetExpectedResponseEncoding(HttpEncoding encoding)
	{
	}

	public HttpEncoding GetExpectedResponseEncoding()
	{
		return default(HttpEncoding);
	}

	public void SetDeserializeBodyImmediately(bool doIt)
	{
	}

	public bool GetDeserializeBodyImmediately()
	{
		return false;
	}

	public string GetJsonBody()
	{
		return null;
	}

	public IWebRequest GetWebRequest(bool forceReconstruct = false)
	{
		return null;
	}

	public void OutputToLog(HttpManager.LogLevel logLevel = HttpManager.LogLevel.Everything)
	{
	}

	private void ConstructGetRequest()
	{
	}

	private void ConstructDeleteRequest()
	{
	}

	private void ConstructPostRequest()
	{
	}

	private void ConstructPutRequest()
	{
	}

	private string ConstructUrl()
	{
		return null;
	}

	private IWebRequest CreateWebRequest(string url)
	{
		return null;
	}
}
