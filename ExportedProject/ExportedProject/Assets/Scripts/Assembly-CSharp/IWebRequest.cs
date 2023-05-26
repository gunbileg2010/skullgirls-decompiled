using System;
using System.Collections.Generic;
using System.IO;

public interface IWebRequest : IDisposable
{
	string Url { get; set; }

	string Method { get; set; }

	string ContentType { get; set; }

	bool IsDone { get; }

	bool IsError { get; }

	string Error { get; }

	long ResponseCode { get; }

	long ResponseContentLength { get; }

	string ResponseText { get; }

	byte[] ResponseBytes { get; }

	Stream ResponseStream { get; }

	void SetRequestHeader(string name, string value);

	void SetRequestContent(string content);

	void SetRequestContent(byte[] bytes);

	void Send();

	void Abort();

	Dictionary<string, string> GetResponseHeaders();
}
