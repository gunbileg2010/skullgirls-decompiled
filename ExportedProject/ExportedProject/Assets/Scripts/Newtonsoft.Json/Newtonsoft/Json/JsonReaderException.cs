using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve]
	public class JsonReaderException : JsonException
	{
		private int LineNumber
		{
			[CompilerGenerated]
			set
			{
			}
		}

		private int LinePosition
		{
			[CompilerGenerated]
			set
			{
			}
		}

		private string Path
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonReaderException()
		{
		}

		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
		}

		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
