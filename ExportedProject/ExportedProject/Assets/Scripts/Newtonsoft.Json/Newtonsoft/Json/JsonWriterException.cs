using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve]
	public class JsonWriterException : JsonException
	{
		private string Path
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonWriterException()
		{
		}

		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		internal JsonWriterException(string message, Exception innerException, string path)
		{
		}

		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			return null;
		}

		internal static JsonWriterException Create(string path, string message, Exception ex)
		{
			return null;
		}
	}
}
