using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve]
	public class JsonSerializationException : JsonException
	{
		public JsonSerializationException()
		{
		}

		public JsonSerializationException(string message)
		{
		}

		public JsonSerializationException(string message, Exception innerException)
		{
		}

		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
