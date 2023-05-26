using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace Open.Nat
{
	internal class SoapClient
	{
		private readonly string _serviceType;

		private readonly Uri _url;

		public SoapClient(Uri url, string serviceType)
		{
		}

		public Task<XmlDocument> InvokeAsync(string operationName, IDictionary<string, object> args)
		{
			return null;
		}

		private static Task<WebResponse> GetWebResponse(WebRequest request)
		{
			return null;
		}

		private HttpWebRequest BuildHttpWebRequest(string operationName, byte[] messageBody)
		{
			return null;
		}

		private byte[] BuildMessageBody(string operationName, IEnumerable<KeyValuePair<string, object>> args)
		{
			return null;
		}

		private XmlDocument GetXmlDocument(string response)
		{
			return null;
		}
	}
}
