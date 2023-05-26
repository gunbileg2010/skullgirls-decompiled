using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve]
	public class JsonException : Exception
	{
		public JsonException()
		{
		}

		public JsonException(string message)
		{
		}

		public JsonException(string message, Exception innerException)
		{
		}

		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
